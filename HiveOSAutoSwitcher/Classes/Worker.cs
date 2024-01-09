using Newtonsoft.Json;

namespace HiveOSAutoSwitcher.Classes
{
	public class Worker
	{
		// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
		public class Amd
		{
			public string core_clock { get; set; }
			public string core_state { get; set; }
			public string core_vddc { get; set; }
			public string mem_clock { get; set; }
			public string mem_state { get; set; }
			public string mem_mvdd { get; set; }
			public string mem_vddci { get; set; }
			public string fan_speed { get; set; }
			public string power_limit { get; set; }
			public string tref_timing { get; set; }
			public string soc_clock { get; set; }
			public string soc_vddmax { get; set; }
			public bool aggressive { get; set; }
		}

		public class Amdmemtweak
		{
			public List<int> gpus { get; set; }
			public Params @params { get; set; }
		}

		public class AsicConfig
		{
			public string additionalProp1 { get; set; }
			public string additionalProp2 { get; set; }
			public string additionalProp3 { get; set; }
		}

		public class AsicInfo
		{
			public string model { get; set; }
			public string short_name { get; set; }
			public string logic_version { get; set; }
			public string firmware { get; set; }
			public bool hiveon { get; set; }
			public string install_type { get; set; }
			public string upgrade_type { get; set; }
			public string control_board { get; set; }
		}

		public class AsicStats
		{
			public List<Fan> fans { get; set; }
			public int fans_count { get; set; }
			public List<Board> boards { get; set; }
			public bool asicboost { get; set; }
		}

		public class Autofan
		{
			public bool enabled { get; set; }
			public List<Item> items { get; set; }
			public int critical_temp { get; set; }
			public string critical_temp_action { get; set; }
			public bool no_amd { get; set; }
			public bool reboot_on_errors { get; set; }
			public bool smart_mode { get; set; }
		}

		public class AvgHashrates
		{
			public Ethash ethash { get; set; }
		}

		public class Board
		{
			public int chain { get; set; }
			public int acn { get; set; }
			public double freq { get; set; }
			public List<int> status { get; set; }
			public int temp { get; set; }
			public int board_temp { get; set; }
			public int hw_errors { get; set; }
			public double power { get; set; }
			public double chain_voltage { get; set; }
		}

		public class ByAlgo
		{
			public string algo { get; set; }
			public Amd amd { get; set; }
			public Nvidia nvidia { get; set; }
			public Tweakers tweakers { get; set; }
		}

		public class Channel
		{
			public int index { get; set; }
			public int worker_id { get; set; }
			public int state { get; set; }
			public int current { get; set; }
		}

		public class Command
		{
			public string command { get; set; }
			public int id { get; set; }
			public Data data { get; set; }
		}

		public class CommandResult
		{
		}

		public class Config
		{
		}

		public class Coolbox
		{
			public int fan { get; set; }
			public bool auto { get; set; }
			public int target_temp { get; set; }
			public int target_mem_temp { get; set; }
			public bool wd_enabled { get; set; }
			public int wd_interval { get; set; }
		}

		public class CoolboxInfo
		{
			public string version { get; set; }
			public string revision { get; set; }
			public string model { get; set; }
		}

		public class CoolboxStats
		{
			public List<int> casefan { get; set; }
			public List<int> thermosensors { get; set; }
		}

		public class Cpu
		{
			public string id { get; set; }
			public string model { get; set; }
			public int cores { get; set; }
			public bool aes { get; set; }
		}

		public class Data
		{
		}

		public class Default
		{
			public Amd amd { get; set; }
			public Nvidia nvidia { get; set; }
			public Tweakers tweakers { get; set; }
		}

		public class Details
		{
			public string mem { get; set; }
			public int mem_gb { get; set; }
			public string mem_type { get; set; }
			public string mem_oem { get; set; }
			public string vbios { get; set; }
			public string subvendor { get; set; }
			public string oem { get; set; }
		}

		public class Disk
		{
			public string model { get; set; }
		}

		public class DonnagerRelay
		{
			public List<Channel> channels { get; set; }
		}

		public class DonnagerRelayInfo
		{
			public string firmware { get; set; }
		}

		public class DonnagerRelayStats
		{
			public List<Channel> channels { get; set; }
		}

		public class Ethash
		{
			[JsonProperty("15m")]
			public int _15m { get; set; }

			[JsonProperty("1h")]
			public int _1h { get; set; }
		}

		public class Fan
		{
			public int index { get; set; }
			public int fan { get; set; }
			public int fan_rpm { get; set; }
		}

		public class Fanflap
		{
			public int fan { get; set; }
			public bool auto { get; set; }
			public int target_temp { get; set; }
			public int min_fan { get; set; }
			public int max_fan { get; set; }
		}

		public class FanflapStats
		{
			public List<int> fan { get; set; }
		}

		public class FlightSheet
		{
			public int id { get; set; }
			public int farm_id { get; set; }
			public int user_id { get; set; }
			public string name { get; set; }
			public List<Item> items { get; set; }
		}

		public class Gpu
		{
			public string name { get; set; }
			public int amount { get; set; }
		}

		public class GpuInfo
		{
			public string bus_id { get; set; }
			public int bus_number { get; set; }
			public string brand { get; set; }
			public string model { get; set; }
			public string short_name { get; set; }
			public Details details { get; set; }
			public PowerLimit power_limit { get; set; }
			public int index { get; set; }
		}

		public class GpuStat
		{
			public int bus_number { get; set; }
			public int temp { get; set; }
			public int fan { get; set; }
			public int power { get; set; }
			public int coreclk { get; set; }
			public int memclk { get; set; }
			public int memtemp { get; set; }
		}

		public class GpuSummary
		{
			public List<Gpu> gpus { get; set; }
			public int max_temp { get; set; }
			public int max_fan { get; set; }
		}

		public class HardwareInfo
		{
			public Motherboard motherboard { get; set; }
			public Cpu cpu { get; set; }
			public Disk disk { get; set; }
			public List<NetInterface> net_interfaces { get; set; }
		}

		public class HardwareStats
		{
			public string df { get; set; }
			public List<double> cpuavg { get; set; }
			public List<int> cputemp { get; set; }
			public int cpu_cores { get; set; }
			public Memory memory { get; set; }
		}

		public class Hashrate
		{
			public string miner { get; set; }
			public string ver { get; set; }
			public string algo { get; set; }
			public string coin { get; set; }
			public int hash { get; set; }
			public string dalgo { get; set; }
			public string dcoin { get; set; }
			public int dhash { get; set; }
			public Shares shares { get; set; }
			public List<int> hashes { get; set; }
			public List<int> dhashes { get; set; }
			public List<int> temps { get; set; }
			public List<int> fans { get; set; }
			public List<int> invalid_shares { get; set; }
			public List<int> bus_numbers { get; set; }
			public List<int> dbus_numbers { get; set; }
		}

		public class Item
		{
			public string coin { get; set; }
			public string pool { get; set; }
			public int wal_id { get; set; }
			public string dcoin { get; set; }
			public string dpool { get; set; }
			public int dwal_id { get; set; }
			public string miner { get; set; }
			public string miner_alt { get; set; }
			public string mode { get; set; }
			public int target_temp { get; set; }
			public int target_mem_temp { get; set; }
			public int min_fan { get; set; }
			public int max_fan { get; set; }
			public int static_fan { get; set; }
			public int critical_temp { get; set; }
		}

		public class LanConfig
		{
			public bool dhcp { get; set; }
			public string address { get; set; }
			public string gateway { get; set; }
			public string dns { get; set; }
		}

		public class Memory
		{
			public int total { get; set; }
			public int free { get; set; }
		}

		public class Message
		{
			public long id { get; set; }
			public string title { get; set; }
			public string type { get; set; }
			public int time { get; set; }
			public int cmd_id { get; set; }
			public string command { get; set; }
			public CommandResult command_result { get; set; }
			public bool has_payload { get; set; }
		}

		public class Meter
		{
			public string url { get; set; }
			public string user { get; set; }
			public string pass { get; set; }
		}

		public class MinersConfig
		{
			public string miner { get; set; }
			public Config config { get; set; }
		}

		public class MinersStats
		{
			public List<Hashrate> hashrates { get; set; }
		}

		public class MinersSummary
		{
			public List<Hashrate> hashrates { get; set; }
		}

		public class Motherboard
		{
			public string manufacturer { get; set; }
			public string model { get; set; }
			public string bios { get; set; }
		}

		public class NetInterface
		{
			public string iface { get; set; }
			public string mac { get; set; }
		}

		public class Nvidia
		{
			public string core_clock { get; set; }
			public string mem_clock { get; set; }
			public string fan_speed { get; set; }
			public string power_limit { get; set; }
			public bool logo_off { get; set; }
			public bool ohgodapill { get; set; }
			public int ohgodapill_start_timeout { get; set; }
			public string ohgodapill_args { get; set; }
			public int running_delay { get; set; }
			public bool reduce_power { get; set; }
			public bool force_p0 { get; set; }
		}

		public class OcConfig
		{
			public Default @default { get; set; }
			public List<ByAlgo> by_algo { get; set; }
		}

		public class Octofan
		{
			public int fan { get; set; }
			public bool auto { get; set; }
			public int target_temp { get; set; }
			public int target_mem_temp { get; set; }
			public int min_fan { get; set; }
			public int max_fan { get; set; }
			public bool blink_on_errors { get; set; }
			public bool blink_to_find { get; set; }
			public int fan1_max_rpm { get; set; }
			public int fan2_max_rpm { get; set; }
			public int fan3_max_rpm { get; set; }
			public int fan1_port { get; set; }
			public int fan2_port { get; set; }
			public int fan3_port { get; set; }
		}

		public class OctofanStats
		{
			public List<int> casefan { get; set; }
			public List<int> thermosensors { get; set; }
		}

		public class Option
		{
			public string miner { get; set; }
			public int minhash { get; set; }
			public string units { get; set; }
			public bool disable_gui { get; set; }
			public int maintenance_mode { get; set; }
			public int push_interval { get; set; }
			public int miner_delay { get; set; }
			public int doh { get; set; }
			public bool power_cycle { get; set; }
			public bool shellinabox_enable { get; set; }
			public bool ssh_enable { get; set; }
			public bool ssh_password_enable { get; set; }
			public string ssh_authorized_keys { get; set; }
			public bool vnc_enable { get; set; }
			public string vnc_password { get; set; }
		}

		public class Overclock
		{
			public string algo { get; set; }
			public Amd amd { get; set; }
			public Nvidia nvidia { get; set; }
			public Tweakers tweakers { get; set; }
		}

		public class Params
		{
			public int cl { get; set; }
			public int ras { get; set; }
		}

		public class PerfProfile
		{
			public string active { get; set; }
			public List<Tuned> tuned { get; set; }
		}

		public class PersonalSettings
		{
			public bool is_favorite { get; set; }
			public string note { get; set; }
		}

		public class PowerLimit
		{
			public string min { get; set; }
			public string def { get; set; }
			public string max { get; set; }
		}

		public class Powermeter
		{
			public List<Meter> meters { get; set; }
		}

		public class PowermeterStats
		{
			public List<List<double>> power { get; set; }
			public List<double> power_total { get; set; }
			public List<double> energy_total { get; set; }
		}

		public class RemoteAddress
		{
			public string ip { get; set; }
			public string hostname { get; set; }
		}

		public class Root
		{
			public int id { get; set; }
			public int farm_id { get; set; }
			public int platform { get; set; }
			public string name { get; set; }
			public string description { get; set; }
			public int units_count { get; set; }
			public int fans_count { get; set; }
			public bool active { get; set; }
			public string password { get; set; }
			public List<int> tag_ids { get; set; }
			public string mirror_url { get; set; }
			public List<string> repo_urls { get; set; }
			public List<string> ip_addresses { get; set; }
			public RemoteAddress remote_address { get; set; }
			public bool vpn { get; set; }
			public bool has_amd { get; set; }
			public bool has_nvidia { get; set; }
			public bool needs_upgrade { get; set; }
			public string packages_hash { get; set; }
			public LanConfig lan_config { get; set; }
			public string system_type { get; set; }
			public string os_name { get; set; }
			public bool has_octofan { get; set; }
			public bool has_coolbox { get; set; }
			public bool has_fanflap { get; set; }
			public bool has_powermeter { get; set; }
			public bool has_asichub { get; set; }
			public bool has_donnager_relay { get; set; }
			public bool has_ykeda_autofan { get; set; }
			public bool has_windtank_autofan { get; set; }
			public bool has_mknet_autofan { get; set; }
			public PersonalSettings personal_settings { get; set; }
			public Versions versions { get; set; }
			public FlightSheet flight_sheet { get; set; }
			public Overclock overclock { get; set; }
			public int oc_id { get; set; }
			public OcConfig oc_config { get; set; }
			public string oc_algo { get; set; }
			public string oc_algo_actual { get; set; }
			public string oc_algo_resolved { get; set; }
			public List<MinersConfig> miners_config { get; set; }
			public List<string> tuned_miners { get; set; }
			public Watchdog watchdog { get; set; }
			public Option options { get; set; }
			public int hardware_power_draw { get; set; }
			public int psu_efficiency { get; set; }
			public bool octofan_correct_power { get; set; }
			public Autofan autofan { get; set; }
			public Stats stats { get; set; }
			public MinersSummary miners_summary { get; set; }
			public MinersStats miners_stats { get; set; }
			public GpuSummary gpu_summary { get; set; }
			public List<GpuInfo> gpu_info { get; set; }
			public List<GpuStat> gpu_stats { get; set; }
			public HardwareInfo hardware_info { get; set; }
			public HardwareStats hardware_stats { get; set; }
			public AsicInfo asic_info { get; set; }
			public int asichub_id { get; set; }
			public AsicStats asic_stats { get; set; }
			public Octofan octofan { get; set; }
			public OctofanStats octofan_stats { get; set; }
			public Coolbox coolbox { get; set; }
			public CoolboxInfo coolbox_info { get; set; }
			public CoolboxStats coolbox_stats { get; set; }
			public Fanflap fanflap { get; set; }
			public FanflapStats fanflap_stats { get; set; }
			public Powermeter powermeter { get; set; }
			public PowermeterStats powermeter_stats { get; set; }
			public DonnagerRelay donnager_relay { get; set; }
			public DonnagerRelayInfo donnager_relay_info { get; set; }
			public DonnagerRelayStats donnager_relay_stats { get; set; }
			public YkedaAutofan ykeda_autofan { get; set; }
			public YkedaAutofanStats ykeda_autofan_stats { get; set; }
			public WindtankAutofan windtank_autofan { get; set; }
			public WindtankAutofanInfo windtank_autofan_info { get; set; }
			public WindtankAutofanStats windtank_autofan_stats { get; set; }
			public List<Message> messages { get; set; }
			public List<Command> commands { get; set; }
			public int benchmark_id { get; set; }
			public AsicConfig asic_config { get; set; }
			public PerfProfile perf_profile { get; set; }
		}

		public class Shares
		{
			public int accepted { get; set; }
			public int rejected { get; set; }
			public int invalid { get; set; }
			public double ratio { get; set; }
		}

		public class Stats
		{
			public bool online { get; set; }
			public int boot_time { get; set; }
			public int stats_time { get; set; }
			public int miner_start_time { get; set; }
			public int gpus_online { get; set; }
			public int gpus_offline { get; set; }
			public int gpus_overheated { get; set; }
			public int cpus_offline { get; set; }
			public int boards_online { get; set; }
			public int boards_offline { get; set; }
			public int boards_overheated { get; set; }
			public int power_draw { get; set; }
			public bool overheated { get; set; }
			public bool overloaded { get; set; }
			public bool invalid { get; set; }
			public bool low_asr { get; set; }
			public List<string> problems { get; set; }
			public AvgHashrates avg_hashrates { get; set; }
		}

		public class Tuned
		{
			public string profile { get; set; }
		}

		public class Tweakers
		{
			public List<Amdmemtweak> amdmemtweak { get; set; }
		}

		public class Versions
		{
			public string hive { get; set; }
			public string kernel { get; set; }
			public string amd_driver { get; set; }
			public string nvidia_driver { get; set; }
		}

		public class Watchdog
		{
			public bool enabled { get; set; }
			public int restart_timeout { get; set; }
			public int reboot_timeout { get; set; }
			public bool check_power { get; set; }
			public bool check_connection { get; set; }
			public int min_power { get; set; }
			public int max_power { get; set; }
			public string power_action { get; set; }
			public bool check_gpu { get; set; }
			public int max_la { get; set; }
			public double min_asr { get; set; }
			public int share_time { get; set; }
			public List<Option> options { get; set; }
		}

		public class WindtankAutofan
		{
			public int fan { get; set; }
			public bool auto { get; set; }
			public int target_temp { get; set; }
			public int target_mem_temp { get; set; }
			public int min_fan { get; set; }
		}

		public class WindtankAutofanInfo
		{
			public string model { get; set; }
		}

		public class WindtankAutofanStats
		{
			public List<int> casefan { get; set; }
			public List<int> thermosensors { get; set; }
		}

		public class YkedaAutofan
		{
			public int fan { get; set; }
			public bool auto { get; set; }
			public int target_temp { get; set; }
			public int target_mem_temp { get; set; }
			public int min_fan { get; set; }
			public int max_fan { get; set; }
		}

		public class YkedaAutofanStats
		{
			public List<int> casefan { get; set; }
			public List<int> thermosensors { get; set; }
		}


	}
}
