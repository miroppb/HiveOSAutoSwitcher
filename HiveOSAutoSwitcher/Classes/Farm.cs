using Newtonsoft.Json;

namespace HiveOSAutoSwitcher.Classes
{
	public class Farm
	{
		// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
		public class AsicRedHashrate
		{
			public string? algo { get; set; }
			public int hashrate { get; set; }
		}

		public class CostDetail
		{
			public int type { get; set; }
			public string? type_name { get; set; }
			public double amount { get; set; }
			public int monthly_price { get; set; }
			public double monthly_cost { get; set; }
			public double daily_cost { get; set; }
		}

		public class Datum
		{
			public int id { get; set; }
			public string? name { get; set; }
			public string? timezone { get; set; }
			public int gpu_red_temp { get; set; }
			public int asic_red_temp { get; set; }
			public int asic_red_board_temp { get; set; }
			public int gpu_red_mem_temp { get; set; }
			public int gpu_red_cpu_temp { get; set; }
			public int gpu_red_fan { get; set; }
			public int asic_red_fan { get; set; }
			public int gpu_red_asr { get; set; }
			public int asic_red_asr { get; set; }
			public double gpu_red_la { get; set; }
			public double asic_red_la { get; set; }
			public List<AsicRedHashrate>? asic_red_hashrate { get; set; }
			public List<string>? repo_urls { get; set; }
			public double power_price { get; set; }
			public string? power_price_currency { get; set; }
			public bool charge_on_pool { get; set; }
			public string? worker_name_template { get; set; }
			public string? autocreate_hash { get; set; }
			public bool nonfree { get; set; }
			public bool locked { get; set; }
			public bool twofa_required { get; set; }
			public bool trusted { get; set; }
			public Owner? owner { get; set; }
			public Payer? payer { get; set; }
			public PersonalSettings? personal_settings { get; set; }
			public string? role { get; set; }
			public int workers_count { get; set; }
			public int rigs_count { get; set; }
			public int asics_count { get; set; }
			public int disabled_rigs_count { get; set; }
			public int disabled_asics_count { get; set; }
			public Money? money { get; set; }
			public Stats? stats { get; set; }
			public List<Hashrate>? hashrates { get; set; }
			public List<HashratesByCoin>? hashrates_by_coin { get; set; }
			public List<int>? tag_ids { get; set; }
			public int hardware_power_draw { get; set; }
			public int psu_efficiency { get; set; }
			public bool octofan_correct_power { get; set; }
			public bool auto_tags { get; set; }
			public DefaultFs? default_fs { get; set; }
		}

		public class DefaultFs
		{
			[JsonProperty("1")]
			public int _1 { get; set; }

			[JsonProperty("2")]
			public int _2 { get; set; }
		}

		public class Hashrate
		{
			public string? algo { get; set; }
			public int hashrate { get; set; }
		}

		public class HashratesByCoin
		{
			public string? coin { get; set; }
			public string? algo { get; set; }
			public int hashrate { get; set; }
		}

		public class Money
		{
			public bool is_paid { get; set; }
			public bool is_free { get; set; }
			public double balance { get; set; }
			public int discount { get; set; }
			public int monthly_cost { get; set; }
			public int daily_cost { get; set; }
			public List<CostDetail>? cost_details { get; set; }
			public int days_left { get; set; }
			public bool overdraft { get; set; }
			public int overdraft_days_left { get; set; }
		}

		public class Owner
		{
			public int id { get; set; }
			public string? login { get; set; }
			public string name { get; set; }
			public bool me { get; set; }
		}

		public class Payer
		{
			public int id { get; set; }
			public string? login { get; set; }
			public string name { get; set; }
			public bool me { get; set; }
		}

		public class PersonalSettings
		{
			public bool is_favorite { get; set; }
			public string? note { get; set; }
		}

		public class Root
		{
			public List<Datum> data { get; set; }
			public List<Tag>? tags { get; set; }
		}

		public class Stats
		{
			public int workers_total { get; set; }
			public int workers_online { get; set; }
			public int workers_offline { get; set; }
			public int workers_overheated { get; set; }
			public int workers_no_temp { get; set; }
			public int workers_overloaded { get; set; }
			public int workers_invalid { get; set; }
			public int workers_low_asr { get; set; }
			public int workers_no_hashrate { get; set; }
			public int rigs_total { get; set; }
			public int rigs_online { get; set; }
			public int rigs_offline { get; set; }
			public int rigs_power { get; set; }
			public int gpus_total { get; set; }
			public int gpus_online { get; set; }
			public int gpus_offline { get; set; }
			public int gpus_overheated { get; set; }
			public int gpus_no_temp { get; set; }
			public int asics_total { get; set; }
			public int asics_online { get; set; }
			public int asics_power { get; set; }
			public int asics_offline { get; set; }
			public int boards_total { get; set; }
			public int boards_online { get; set; }
			public int boards_offline { get; set; }
			public int boards_overheated { get; set; }
			public int boards_no_temp { get; set; }
			public int cpus_online { get; set; }
			public int devices_total { get; set; }
			public int devices_online { get; set; }
			public int devices_offline { get; set; }
			public int power_draw { get; set; }
			public double power_cost { get; set; }
			public double asr { get; set; }
		}

		public class Tag
		{
			public int id { get; set; }
			public string? name { get; set; }
			public int color { get; set; }
			public int farms_count { get; set; }
			public int workers_count { get; set; }
			public int type_id { get; set; }
			public int user_id { get; set; }
		}


	}
}
