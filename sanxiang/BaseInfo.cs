using System;

namespace model
{
	
	//实时监测数据
	public class SanxiangData{
		private string id="";//id
		private string watchdog_id="";//监控设备id
		private string taiqu_id="";//台区id
		private DateTime time= DateTime.Now;//时间
		private float voltage_a=0;//A相电压
		private float voltage_b=0;//B相电压
		private float voltage_c=0;//C相电压
		private float current_a=0;//A相电流
		private float current_b=0;//B相电流
		private float current_c=0;//C相电流
		private float current_n=0;//N相电流
		private float frequency=0;//频率
		private float active_power=0;//有功功率
		private float reactive_power=0;//无功功率
		private float apparent_power=0;//视在功率
		private float power_factor=0;//功率因数
		private float active_electric_energy=0;//有功电能
		private float reactive_electric_energy=0;//无功电能
		private float apparent_electric_energy=0;//视在电能
		private float voltage_unbalance=0;//电压不平衡度
		private float current_unbalance=0;//电流不平衡度


        public SanxiangData()
        {



        }

        public SanxiangData(string id, string watchdog_id, string taiqu_id, DateTime time, float voltage_a, float voltage_b, float voltage_c, float current_a, float current_b, float current_c, float current_n, float frequency, float active_power, float reactive_power, float apparent_power, float power_factor, float active_electric_energy, float reactive_electric_energy, float apparent_electric_energy, float voltage_unbalance, float current_unbalance)
		{
			this.id = id;
			this.watchdog_id = watchdog_id;
            this.taiqu_id = taiqu_id;
			this.time = time;
			this.voltage_a = voltage_a;
			this.voltage_b = voltage_b;
			this.voltage_c = voltage_c;
			this.current_a = current_a;
			this.current_b = current_b;
			this.current_c = current_c;
			this.current_n = current_n;
			this.frequency = frequency;
			this.active_power = active_power;
			this.reactive_power = reactive_power;
			this.apparent_power = apparent_power;
			this.power_factor = power_factor;
			this.active_electric_energy = active_electric_energy;
			this.reactive_electric_energy = reactive_electric_energy;
			this.apparent_electric_energy = apparent_electric_energy;
			this.voltage_unbalance = voltage_unbalance;
			this.current_unbalance = current_unbalance;
		}
		public string Id {
			get {
				return this.id;
			}
			set {
				id = value;
			}
		}

		public string Watchdog_id {
			get {
				return this.watchdog_id;
			}
			set {
				watchdog_id = value;
			}
		}

		public string Taiqu_id {
			get {
                return this.taiqu_id;
			}
			set {
                taiqu_id = value;
			}
		}

		public DateTime Time {
			get {
				return this.time;
			}
			set {
				time = value;
			}
		}

		public float Voltage_a {
			get {
				return this.voltage_a;
			}
			set {
				voltage_a = value;
			}
		}

		public float Voltage_b {
			get {
				return this.voltage_b;
			}
			set {
				voltage_b = value;
			}
		}

		public float Voltage_c {
			get {
				return this.voltage_c;
			}
			set {
				voltage_c = value;
			}
		}

		public float Current_a {
			get {
				return this.current_a;
			}
			set {
				current_a = value;
			}
		}

		public float Current_b {
			get {
				return this.current_b;
			}
			set {
				current_b = value;
			}
		}

		public float Current_c {
			get {
				return this.current_c;
			}
			set {
				current_c = value;
			}
		}

		public float Current_n {
			get {
				return this.current_n;
			}
			set {
				current_n = value;
			}
		}

		public float Frequency {
			get {
				return this.frequency;
			}
			set {
				frequency = value;
			}
		}

		public float Active_power {
			get {
				return this.active_power;
			}
			set {
				active_power = value;
			}
		}

		public float Reactive_power {
			get {
				return this.reactive_power;
			}
			set {
				reactive_power = value;
			}
		}

		public float Apparent_power {
			get {
				return this.apparent_power;
			}
			set {
				apparent_power = value;
			}
		}

		public float Power_factor {
			get {
				return this.power_factor;
			}
			set {
				power_factor = value;
			}
		}

		public float Active_electric_energy {
			get {
				return this.active_electric_energy;
			}
			set {
				active_electric_energy = value;
			}
		}

		public float Reactive_electric_energy {
			get {
				return this.reactive_electric_energy;
			}
			set {
				reactive_electric_energy = value;
			}
		}

		public float Apparent_electric_energy {
			get {
				return this.apparent_electric_energy;
			}
			set {
				apparent_electric_energy = value;
			}
		}

		public float Voltage_unbalance {
			get {
				return this.voltage_unbalance;
			}
			set {
				voltage_unbalance = value;
			}
		}

		public float Current_unbalance {
			get {
				return this.current_unbalance;
			}
			set {
				current_unbalance = value;
			}
		}
		

	}
	
    //报警事件
	public class Alarm{
		private string id="";//id
		private string watchdog_id="";//监控设备id
        private string taiqu_id = "";//台区id
		private DateTime time= DateTime.Now;//时间
		private string alarm_type="";//事件类型
		private string alarm_rank="";//事件等级
		private string process_user="";//事件处理人
		private string status="";//事件处理状态
		private string remark="";//备注

        public Alarm()
        {


        }

        public Alarm(string id, string watchdog_id, string taiqu_id, DateTime time, string alarm_type, string alarm_rank, string process_user, string status, string remark)
		{
			this.id = id;
			this.watchdog_id = watchdog_id;
            this.taiqu_id = taiqu_id;
			this.time = time;
			this.alarm_type = alarm_type;
			this.alarm_rank = alarm_rank;
			this.process_user = process_user;
			this.status = status;
			this.remark = remark;
		}
			
		public string Id {
			get {
				return this.id;
			}
			set {
				id = value;
			}
		}

		public string Watchdog_id {
			get {
				return this.watchdog_id;
			}
			set {
				watchdog_id = value;
			}
		}

		public string Taiqu_id {
			get {
				return this.taiqu_id;
			}
			set {
				taiqu_id = value;
			}
		}

		public DateTime Time {
			get {
				return this.time;
			}
			set {
				time = value;
			}
		}

		public string Alarm_type {
			get {
				return this.alarm_type;
			}
			set {
				alarm_type = value;
			}
		}

		public string Alarm_rank {
			get {
				return this.alarm_rank;
			}
			set {
				alarm_rank = value;
			}
		}

		public string Process_user {
			get {
				return this.process_user;
			}
			set {
				process_user = value;
			}
		}

		public string Status {
			get {
				return this.status;
			}
			set {
				status = value;
			}
		}

		public string Remark {
			get {
				return this.remark;
			}
			set {
				remark = value;
			}
		}
	}
	
	//监控设备
	public class WatchDog{
		private string id="";//id
        private string taiqu_id = "";//台区id
		private string ip_address="";//ip

        public WatchDog(string id, string taiqu_id, string ip_address)
		{
			this.id = id;
            this.taiqu_id = taiqu_id;
			this.ip_address = ip_address;
		}
			
		public string Id {
			get {
				return this.id;
			}
			set {
				id = value;
			}
		}

		public string Taiqu_id {
			get {
                return this.taiqu_id;
			}
			set {
                taiqu_id = value;
			}
		}

		public string Ip_address {
			get {
				return this.ip_address;
			}
			set {
				ip_address = value;
			}
		}

	}
		
	//层级结构	
	public class NodeStruct{
		private string id="";//id
		private string parent_id="";//父节点id
		private string name="";//节点名称
		private string type="";//节点类型
		private string admin_user="";//管理人员

        public NodeStruct()
        {



        }

        
			
		public NodeStruct (string id, string parent_id, string name, string type, string admin_user)
		{
			this.id = id;
			this.parent_id = parent_id;
			this.name = name;
			this.type = type;
			this.admin_user = admin_user;
		}
		
		public string Id {
			get {
				return this.id;
			}
			set {
				id = value;
			}
		}

		public string Parent_id {
			get {
				return this.parent_id;
			}
			set {
				parent_id = value;
			}
		}

		public string Name {
			get {
				return this.name;
			}
			set {
				name = value;
			}
		}

		public string Type {
			get {
				return this.type;
			}
			set {
				type = value;
			}
		}

		public string Admin_user {
			get {
				return this.admin_user;
			}
			set {
				admin_user = value;
			}
		}
			
	}
		
	//优化方案
	public class PrioritizationScheme{
			
		private string id="";//id
        private string forecast_id = "";//预测方案编号
		private string scheme_model="";//优化模型
		private DateTime time=DateTime.Now;//时间
		private DateTime? start_time=null;//开始执行的时间
		private DateTime? end_time=null;//执行完成时间
		private string detail="";//详细方案

        public PrioritizationScheme(string id, string forecast_id, string scheme_model, DateTime time, DateTime start_time, DateTime end_time, string detail)
		{
			this.id = id;
            this.forecast_id = forecast_id;
			this.scheme_model = scheme_model;
			this.time = time;
			this.start_time = start_time;
			this.end_time = end_time;
			this.detail = detail;
		}

			public string Id {
				get {
					return this.id;
				}
				set {
					id = value;
				}
			}

			public string Forecast_id {
				get {
                    return this.forecast_id;
				}
				set {
                    forecast_id = value;
				}
			}

			public string Scheme_model {
				get {
					return this.scheme_model;
				}
				set {
					scheme_model = value;
				}
			}

			public DateTime Time {
				get {
					return this.time;
				}
				set {
					time = value;
				}
			}

			public DateTime? Start_time {
				get {
                  
                        return this.start_time;
				}
				set {
					start_time = value;
				}
			}

			public DateTime? End_time {
				get {
					return this.end_time;
				}
				set {
					end_time = value;
				}
			}

			public string Detail {
				get {
					return this.detail;
				}
				set {
					detail = value;
				}
			}
		
	}
	
	//台区用户
	public class TaiquUser{
		private string id="";//id
		private string uid="";//用户编号（不是本系统的编号）
		private string uname="";//用户名称
			
		public TaiquUser (string id, string uid, string uname)
		{
			this.id = id;
			this.uid = uid;
			this.uname = uname;
		}

		public string Id {
			get {
				return this.id;
			}
			set {
				id = value;
			}
		}

		public string Uid {
			get {
				return this.uid;
			}
			set {
				uid = value;
			}
		}

		public string Uname {
			get {
				return this.uname;
			}
			set {
				uname = value;
			}
		}
			
	}
	
		
	//台区结构
	public class TaiquStruct{
			
		private string id="";//id
		private string taiqu_id="";//台区id
		private int version=0;//版本
        private string version_status = "";//版本状态

        public TaiquStruct(string id, string taiqu_id, int version, string version_status)
		{
			this.id = id;
			this.taiqu_id = taiqu_id;
			this.version = version;
            this.version_status = version_status;
		}
		
		public string Id {
			get {
				return this.id;
			}
			set {
				id = value;
			}
		}

		public string Taiqu_id {
			get {
				return this.taiqu_id;
			}
			set {
				taiqu_id = value;
			}
		}

		public int Version {
			get {
				return this.version;
			}
			set {
				version = value;
			}
		}

        public string Version_status{
			get {
                return this.version_status;
			}
			set {
                version_status = value;
			}
		}
		
		
	}
		
	//台区结构-用户分布；台区结构可变，这里存储所有的结构信息
	public class TaiquUserDistribute{
			
		private string id="";//id
		private string taiqu_user_id="";//台区用户id
		private string taiqu_struct_id="";//台区结构id
		
		public TaiquUserDistribute (string id, string taiqu_user_id, string taiqu_struct_id)
		{
			this.id = id;
			this.taiqu_user_id = taiqu_user_id;
			this.taiqu_struct_id = taiqu_struct_id;
		}
		
		public string Id {
			get {
				return this.id;
			}
			set {
				id = value;
			}
		}

		public string Taiqu_user_id {
			get {
				return this.taiqu_user_id;
			}
			set {
				taiqu_user_id = value;
			}
		}

		public string Taiqu_struct_id {
			get {
				return this.taiqu_struct_id;
			}
			set {
				taiqu_struct_id = value;
			}
		}
		
	}
		
	//台帐
	public class Ledger {
			
		private string id="";//id
	}



	//用户负荷	
	public class UserLoad{
		private string id="";//id
		private string taiqu_user_id="";//台区用户id
		private string uid="";//用户编号
		private string uname="";// 用户名称
		private DateTime time=DateTime.Now;//时间
		private float load_total=0;//累计电能 
		private float load_current=0;//本段时间电能
			
		public UserLoad (string id, string taiqu_user_id, string uid, string uname, DateTime time, float load_total, float load_current)
		{
			this.id = id;
			this.taiqu_user_id = taiqu_user_id;
			this.uid = uid;
			this.uname = uname;
			this.time = time;
			this.load_total = load_total;
			this.load_current = load_current;
		}
			
		public string Id {
			get {
				return this.id;
			}
			set {
				id = value;
			}
		}

		public string Taiqu_user_id {
			get {
				return this.taiqu_user_id;
			}
			set {
				taiqu_user_id = value;
			}
		}

		public string Uid {
			get {
				return this.uid;
			}
			set {
				uid = value;
			}
		}

		public string Uname {
			get {
				return this.uname;
			}
			set {
				uname = value;
			}
		}

		public DateTime Time {
			get {
				return this.time;
			}
			set {
				time = value;
			}
		}

		public float Load_total {
			get {
				return this.load_total;
			}
			set {
				load_total = value;
			}
		}

		public float Load_current {
			get {
				return this.load_current;
			}
			set {
				load_current = value;
			}
		}		
	}
		
		
	//用户负荷预测
	public class UserLoadForecast{
		private string id="";//id
		private string taiqu_user_id="";//台区用户id
		private string uid="";//用户编号
		private string uname="";// 用户名称
		private DateTime time=DateTime.Now;//时间
		private string forecast_method="";//预测方法
        private DateTime start_time = DateTime.Now;//预测开始时间
        private DateTime end_time = DateTime.Now;//预测截止时间
		private float load_forecast_total=0;//预测总电能 
		private float load_forecast_current=0;//预测本段时间电能

        public UserLoadForecast(string id, string taiqu_user_id, string uid, string uname, DateTime time, string forecast_method, DateTime start_time, DateTime end_time, float load_forecast_total, float load_forecast_current)
		{
			this.id = id;
			this.taiqu_user_id = taiqu_user_id;
			this.uid = uid;
			this.uname = uname;
			this.time = time;
			this.forecast_method = forecast_method;
            this.start_time = start_time;
            this.end_time = end_time;
			this.load_forecast_total = load_forecast_total;
			this.load_forecast_current = load_forecast_current;
		}
		
		public string Id {
			get {
				return this.id;
			}
			set {
				id = value;
			}
		}

		public string Taiqu_user_id {
			get {
				return this.taiqu_user_id;
			}
			set {
				taiqu_user_id = value;
			}
		}

		public string Uid {
			get {
				return this.uid;
			}
			set {
				uid = value;
			}
		}

		public string Uname {
			get {
				return this.uname;
			}
			set {
				uname = value;
			}
		}

		public DateTime Time {
			get {
				return this.time;
			}
			set {
				time = value;
			}
		}

		public DateTime Start_time {
			get {
				return this.start_time;
			}
			set {
                start_time = value;
			}
		}

        public DateTime End_time
        {
            get
            {
                return this.end_time;
            }
            set
            {
                end_time = value;
            }
        }

		public string Forecast_method {
			get {
				return this.forecast_method;
			}
			set {
				forecast_method = value;
			}
		}

		public float Load_forecast_total {
			get {
				return this.load_forecast_total;
			}
			set {
				load_forecast_total = value;
			}
		}

		public float Load_forecast_current {
			get {
				return this.load_forecast_current;
			}
			set {
				load_forecast_current = value;
			}
		}

	}
	
	//系统用户
    /// <summary>
    /// admin_level=10  台区;admin_level=20  线路;admin_level=30  变电站
    /// admin_level=40  供电所;admin_level=50  区;admin_level=60  市
    /// admin_level=70 省 admin_level=80  国家
    /// </summary>
	public class User{
			
		private string id="";//id
		private string username="";//帐号
		private string password="";//密码
		private string role="";// 用户角色
		private string nickname="";//昵称
		private DateTime created_time=DateTime.Now;//帐号创建时间
		private DateTime? last_login=null;//上次登录时间
		private int admin_level=50;//权限等级

        public User()
        {


        }

		public User (string id, string username, string password, string role, string nickname, DateTime created_time, DateTime last_login, int admin_level)
		{
			this.id = id;
			this.username = username;
			this.password = password;
			this.role = role;
			this.nickname = nickname;
			this.created_time = created_time;
			this.last_login = last_login;
            this.admin_level = admin_level;
		}

       
		
		public string Id {
			get {
				return this.id;
			}
			set {
				id = value;
			}
		}

		public string Username {
			get {
				return this.username;
			}
			set {
				username = value;
			}
		}

		public string Password {
			get {
				return this.password;
			}
			set {
				password = value;
			}
		}

		public string Role {
			get {
				return this.role;
			}
			set {
				role = value;
			}
		}

		public string Nickname {
			get {
				return this.nickname;
			}
			set {
				nickname = value;
			}
		}

		public DateTime Created_time {
			get {
				return this.created_time;
			}
			set {
				created_time = value;
			}
		}

		public DateTime? Last_login {
			get {
				return this.last_login;
			}
			set {
				last_login = value;
			}
		}

		public int Admin_level {
			get {
				return this.admin_level;
			}
			set {
				admin_level = value;
			}
		}
		
			
	}
		
	
}

