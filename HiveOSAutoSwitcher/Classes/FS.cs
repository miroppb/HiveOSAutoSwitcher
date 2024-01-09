namespace HiveOSAutoSwitcher.Classes
{
	internal class FS
	{
		// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
		public class Datum
		{
			public int id { get; set; }
			public string? name { get; set; }
			public bool is_favorite { get; set; }
			public List<Item>? items { get; set; }
			public int workers_count { get; set; }
			public int applied_at { get; set; }
			public int farm_id { get; set; }
			public int user_id { get; set; }
		}

		public class Item
		{
			public string? coin { get; set; }
			public string? pool { get; set; }
			public List<string>? pool_geo { get; set; }
			public bool pool_ssl { get; set; }
			public List<string>? pool_urls { get; set; }
			public int wal_id { get; set; }
			public string? email { get; set; }
			public string? dcoin { get; set; }
			public string? dpool { get; set; }
			public List<string>? dpool_geo { get; set; }
			public bool dpool_ssl { get; set; }
			public List<string>? dpool_urls { get; set; }
			public int dwal_id { get; set; }
			public string? demail { get; set; }
			public string? miner { get; set; }
			public MinerConfig? miner_config { get; set; }
			public string? miner_alt { get; set; }
		}

		public class MinerConfig
		{
		}

		public class Root
		{
			public List<Datum>? data { get; set; }
		}


	}
}
