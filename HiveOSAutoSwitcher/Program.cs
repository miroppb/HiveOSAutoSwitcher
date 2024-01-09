// See https://aka.ms/new-console-template for more information
using HiveOSAutoSwitcher;
using HiveOSAutoSwitcher.Classes;
using Newtonsoft.Json;
using RestSharp;

Console.WriteLine("Hello, HiveOS!");

const string API = @"https://api2.hiveos.farm/api/v2/";

//string GetAccessToken()
//{
//	var client = new RestClient(API);
//	var request = new RestRequest("auth/login");
//	request.AddJsonBody(new
//	{
//		Secrets.login,
//		Secrets.password,
//		remember = true
//	});
//	var response = client.Post(request);

//	var options = new JsonSerializerOptions
//	{
//		PropertyNameCaseInsensitive = true
//	};
//	var result = System.Text.Json.JsonSerializer.Deserialize<Login>(response.Content!, options);
//	return result!.access_token;
//}

int GetFarm(string AToken)
{
	var client = new RestClient(API);
	var request = new RestRequest("farms");
	request.AddHeader("Authorization", $"Bearer {AToken}");
	var response = client.Get(request);

	Farm.Root result = JsonConvert.DeserializeObject<Farm.Root>(response.Content!)!;
	return result.data.First().id;
}

List<Farm.Datum> GetWorkers(string AToken, int FarmID)
{
	var client = new RestClient(API);
	var request = new RestRequest($"farms/{FarmID}/workers");
	request.AddHeader("Authorization", $"Bearer {AToken}");
	var response = client.Get(request);

	Workers.Root result = JsonConvert.DeserializeObject<Workers.Root>(response.Content!)!;
	return result.data!;
}

Worker.FlightSheet GetWorkerFS(string AToken, int FarmID, int WorkerID)
{
	var client = new RestClient(API);
	var request = new RestRequest($"farms/{FarmID}/workers/{WorkerID}");
	request.AddHeader("Authorization", $"Bearer {AToken}");
	var response = client.Get(request);

	Worker.Root result = JsonConvert.DeserializeObject<Worker.Root>(response.Content!)!;
	return result.flight_sheet;
}

Dictionary<int, string> GetFS(string AToken, int FarmID)
{
	var client = new RestClient(API);
	var request = new RestRequest($"farms/{FarmID}/fs");
	request.AddHeader("Authorization", $"Bearer {AToken}");
	var response = client.Get(request);

	FS.Root result = JsonConvert.DeserializeObject<FS.Root>(response.Content!)!;
	Dictionary<int, string> ret = new();
	foreach (var temp in result.data!)
	{
		ret.Add(temp.id, temp.name!);
	}
	return ret;
}

string GetBestNicehash(List<string> ListOfAvailableFS)
{
	StreamReader reader = new StreamReader(AppContext.BaseDirectory + "\\wtm.txt");
	string url = reader.ReadToEnd();
	reader.Close();

	var client = new RestClient(url);
	var request = new RestRequest();
	var response = client.Get(request);

	WTM_site.Root wtm = JsonConvert.DeserializeObject<WTM_site.Root>(response.Content!)!;

	client = new RestClient(@"https://miroppb.com/BTC.php");
	request = new RestRequest();
	response = client.Get(request);
	decimal btc = Convert.ToDecimal(response.Content);

	List<WTM_NH> Comp = new()
	{
		new WTM_NH() { Name = "Nicehash-KawPow", Revenue = Convert.ToDecimal(wtm.coins.NicehashKawPow.btc_revenue24) * btc},
		new WTM_NH() { Name = "Nicehash-Zhash", Revenue = Convert.ToDecimal(wtm.coins.NicehashZhash.btc_revenue24) * btc},
		new WTM_NH() { Name = "Nicehash-ZelHash", Revenue = Convert.ToDecimal(wtm.coins.NicehashZelHash.btc_revenue24) * btc},
		new WTM_NH() { Name = "Nicehash-CuckooCycle", Revenue = Convert.ToDecimal(wtm.coins.NicehashCuckooCycle.btc_revenue24) * btc},
		new WTM_NH() { Name = "Nicehash-BeamV3", Revenue = Convert.ToDecimal(wtm.coins.NicehashBeamV3.btc_revenue24) * btc},
		new WTM_NH() { Name = "Nicehash-IronFish", Revenue = Convert.ToDecimal(wtm.coins.NicehashBeamV3.btc_revenue24) * btc},
		new WTM_NH() { Name = "Nicehash-Cuckatoo32", Revenue = Convert.ToDecimal(wtm.coins.NicehashIronFish.btc_revenue24) * btc},
		new WTM_NH() { Name = "Nicehash-Octopus", Revenue = Convert.ToDecimal(wtm.coins.NicehashOctopus.btc_revenue24) * btc},
		new WTM_NH() { Name = "Nicehash-NexaPow", Revenue = Convert.ToDecimal(wtm.coins.NicehashNexaPow.btc_revenue24) * btc},
		new WTM_NH() { Name = "Nicehash-Autolykos", Revenue = Convert.ToDecimal(wtm.coins.NicehashAutolykos.btc_revenue24) * btc},
		new WTM_NH() { Name = "Nicehash-Ethash", Revenue = Convert.ToDecimal(wtm.coins.NicehashEthash.btc_revenue24) * btc},
		new WTM_NH() { Name = "Nicehash-Etchash", Revenue = Convert.ToDecimal(wtm.coins.NicehashEtchash.btc_revenue24) * btc}
	};
	Comp = Comp.OrderByDescending(o => o.Revenue).ToList();
	Comp = Comp.Where(p => ListOfAvailableFS.Any(x => x == p.Name)).ToList();
	return Comp.First().Name;
}

void ApplyFSToWorker(string AToken, int FarmID, int WorkerID, int FSID)
{
	var client = new RestClient(API);
	var request = new RestRequest($"farms/{FarmID}/workers/{WorkerID}");
	request.AddHeader("Authorization", $"Bearer {AToken}");
	request.AddJsonBody(new
	{
		fs_id = FSID
	});
	var response = client.Patch(request);
}

//string ACCESSTOKEN = GetAccessToken();
int FarmID = GetFarm(Secrets.APIKey);
List<Farm.Datum> ListOfWorkers = GetWorkers(Secrets.APIKey, FarmID);
Dictionary<string, string> WorkerFS = new();
foreach (var worker in ListOfWorkers)
{
	Worker.FlightSheet fs = GetWorkerFS(Secrets.APIKey, FarmID, worker.id);
	WorkerFS.Add(worker.name!, fs.name);
}
Dictionary<int, string> ListOfFS = GetFS(Secrets.APIKey, FarmID);
string BestNH = GetBestNicehash(ListOfFS.Select(x => x.Value).ToList());

foreach (var worker in ListOfWorkers)
{
	if (WorkerFS[worker.name!] != BestNH)
	{
		ApplyFSToWorker(Secrets.APIKey, FarmID, worker.id, ListOfFS.First(x => x.Value == BestNH).Key);
		Console.WriteLine($"FS set to: {BestNH}");
	}
}
Console.WriteLine("Good bye");
