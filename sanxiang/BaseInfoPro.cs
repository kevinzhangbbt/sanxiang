using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using PAL;
using System.Collections;
using utils;

namespace model
{
    /// <summary>
    /// 三相数据接口
    /// </summary>
    public class SanxiangDataPro
    {
        //添加三相数据
        public static int Add(SanxiangData data)
        {
            string sql = "insert into sanxiang_data values (@id,@watchdog_id,@taiqu_id,@time,@voltage_a,@voltage_b,@voltage_c,@current_a,@current_b,@current_c,@current_n,@frequency,@active_power,@reactive_power,@apparent_power,@power_factor,@active_electric_energy,@reactive_electric_energy,@apparent_electric_energy,@voltage_unbalance,@currnet_unbalance)";
            SqlParameter[] para = new SqlParameter[21];
            para[0] = new SqlParameter("@id", data.Id);
            para[1] = new SqlParameter("@watchdog_id", data.Watchdog_id);
            para[2] = new SqlParameter("@taiqu_id", data.Taiqu_id);
            para[3] = new SqlParameter("@time", data.Time);
            para[4] = new SqlParameter("@voltage_a", data.Voltage_a);
            para[5] = new SqlParameter("@voltage_b", data.Voltage_b);
            para[6] = new SqlParameter("@voltage_c", data.Voltage_c);
            para[7] = new SqlParameter("@current_a", data.Current_a);
            para[8] = new SqlParameter("@current_b", data.Current_b);
            para[9] = new SqlParameter("@current_c", data.Current_c);
            para[10] = new SqlParameter("@current_n", data.Current_n);
            para[11] = new SqlParameter("@frequency", data.Frequency);
            para[12] = new SqlParameter("@active_power", data.Active_power);
            para[13] = new SqlParameter("@reactive_power", data.Reactive_power);
            para[14] = new SqlParameter("@apparent_power", data.Apparent_power);
            para[15] = new SqlParameter("@power_factor", data.Power_factor);
            para[16] = new SqlParameter("@active_electric_energy", data.Active_electric_energy);
            para[17] = new SqlParameter("@reactive_electric_energy", data.Reactive_electric_energy);
            para[18] = new SqlParameter("@apparent_electric_energy", data.Apparent_electric_energy);
            para[19] = new SqlParameter("@voltage_unbalance", data.Voltage_unbalance);
            para[20] = new SqlParameter("@currnet_ubbalance", data.Current_unbalance);


            try
            {
                return Factory.Execute().ExecuteNonQuery(sql, CommandType.Text, para);
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        //编辑三相数据
        public static int Edit(SanxiangData data)
        {
            string sql = "update sanxiang_data set watchdog_id=@watchdog_id, taiqu_id=@taiqu_id,time=@time,voltage_a=@voltage_a,voltage_b=@voltage_b,voltage_c=@voltage_c,current_a=@current_a,current_b=@current_b,current_c=@current_c,current_n=@current_n,frequency=@frequency,active_power=@active_power,reactive_power=@reactive_power,apparent_power=apparent_power,power_factor=@power_factor,active_electric_energy=@active_electric_energy,reactive_electric_energy=@reactive_electric_energy,apparent_electric_energy=@apparent_electric_energy,voltage_unbalance=@voltage_unbalance,currnet_unbalance=@currnet_unbalance where id=@id)";
            SqlParameter[] para = new SqlParameter[21];
            para[0] = new SqlParameter("@id", data.Id);
            para[1] = new SqlParameter("@watchdog_id", data.Watchdog_id);
            para[2] = new SqlParameter("@taiqu_id", data.Taiqu_id);
            para[3] = new SqlParameter("@time", data.Time);
            para[4] = new SqlParameter("@voltage_a", data.Voltage_a);
            para[5] = new SqlParameter("@voltage_b", data.Voltage_b);
            para[6] = new SqlParameter("@voltage_c", data.Voltage_c);
            para[7] = new SqlParameter("@current_a", data.Current_a);
            para[8] = new SqlParameter("@current_b", data.Current_b);
            para[9] = new SqlParameter("@current_c", data.Current_c);
            para[10] = new SqlParameter("@current_n", data.Current_n);
            para[11] = new SqlParameter("@frequency", data.Frequency);
            para[12] = new SqlParameter("@active_power", data.Active_power);
            para[13] = new SqlParameter("@reactive_power", data.Reactive_power);
            para[14] = new SqlParameter("@apparent_power", data.Apparent_power);
            para[15] = new SqlParameter("@power_factor", data.Power_factor);
            para[16] = new SqlParameter("@active_electric_energy", data.Active_electric_energy);
            para[17] = new SqlParameter("@reactive_electric_energy", data.Reactive_electric_energy);
            para[18] = new SqlParameter("@apparent_electric_energy", data.Apparent_electric_energy);
            para[19] = new SqlParameter("@voltage_unbalance", data.Voltage_unbalance);
            para[20] = new SqlParameter("@currnet_unbalance", data.Current_unbalance);

            try
            {
                return Factory.Execute().ExecuteNonQuery(sql, CommandType.Text, para);
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        //删除三相数据
        public static int Delete(string dataID)
        {
            string sql = "delete from sanxiang_data where id=@id";
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@id", dataID);
            try
            {
                return Factory.Execute().ExecuteNonQuery(sql, CommandType.StoredProcedure, para);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        //分页获取三相数据
        public static List<SanxiangData> GetDataList(int pageSize, int pageIndex)
        {
            string sql = "select * from sanxiang_data order by time desc";
            try
            {
                DataTable dt = Factory.Execute().ExecuteTableByPage(pageSize, pageIndex, sql, CommandType.Text, null);
                List<SanxiangData> datas = new List<SanxiangData>();
                int count = dt.Rows.Count;
                for (int i = 0; i < count; i++)
                {
                    SanxiangData data = new SanxiangData();
                    data.Id = dt.Rows[0]["id"].ToString();
                    data.Watchdog_id = dt.Rows[0]["watchdog_id"].ToString();
                    data.Taiqu_id = dt.Rows[0]["taiqu_id"].ToString();
                    data.Time = DateTime.Parse(dt.Rows[0]["time"].ToString());
                    data.Voltage_a = float.Parse(dt.Rows[0]["voltage_a"].ToString());
                    data.Voltage_b = float.Parse(dt.Rows[0]["voltage_b"].ToString());
                    data.Voltage_c = float.Parse(dt.Rows[0]["voltage_c"].ToString());
                    data.Current_a = float.Parse(dt.Rows[0]["current_a"].ToString());
                    data.Current_b = float.Parse(dt.Rows[0]["current_b"].ToString());
                    data.Current_c = float.Parse(dt.Rows[0]["current_c"].ToString());
                    data.Current_n = float.Parse(dt.Rows[0]["current_n"].ToString());
                    data.Frequency = float.Parse(dt.Rows[0]["frequency"].ToString());
                    data.Active_power = float.Parse(dt.Rows[0]["active_power"].ToString());
                    data.Reactive_power = float.Parse(dt.Rows[0]["reactive_power"].ToString());
                    data.Apparent_power = float.Parse(dt.Rows[0]["apparent_power"].ToString());
                    data.Power_factor = float.Parse(dt.Rows[0]["power_factor"].ToString());
                    data.Active_electric_energy = float.Parse(dt.Rows[0]["active_electric_energy"].ToString());
                    data.Reactive_electric_energy = float.Parse(dt.Rows[0]["rective_electric_energy"].ToString());
                    data.Apparent_electric_energy = float.Parse(dt.Rows[0]["apparent_electric_energy"].ToString());
                    data.Voltage_unbalance = float.Parse(dt.Rows[0]["voltage_unbalance"].ToString());
                    data.Current_unbalance = float.Parse(dt.Rows[0]["current_unbalance"].ToString());
                    datas.Add(data);

                }
                return datas;

            }
            catch (Exception e)
            {
                throw e;
            }
        }
        //获取某三相数据
        public static SanxiangData GetSanxiangDataByID(string dataID)
        {

            SanxiangData data = new SanxiangData();
            string sql = "select * from sanxiang_data where id = @id";
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@id", dataID);
            try
            {
                DataTable dt = Factory.Execute().ExecuteTable(sql, CommandType.Text, para);
                data.Id = dt.Rows[0]["id"].ToString();
                data.Watchdog_id = dt.Rows[0]["watchdog_id"].ToString();
                data.Taiqu_id = dt.Rows[0]["taiqu_id"].ToString();
                data.Time = DateTime.Parse(dt.Rows[0]["time"].ToString());
                data.Voltage_a = float.Parse(dt.Rows[0]["voltage_a"].ToString());
                data.Voltage_b = float.Parse(dt.Rows[0]["voltage_b"].ToString());
                data.Voltage_c = float.Parse(dt.Rows[0]["voltage_c"].ToString());
                data.Current_a = float.Parse(dt.Rows[0]["current_a"].ToString());
                data.Current_b = float.Parse(dt.Rows[0]["current_b"].ToString());
                data.Current_c = float.Parse(dt.Rows[0]["current_c"].ToString());
                data.Current_n = float.Parse(dt.Rows[0]["current_n"].ToString());
                data.Frequency = float.Parse(dt.Rows[0]["frequency"].ToString());
                data.Active_power = float.Parse(dt.Rows[0]["active_power"].ToString());
                data.Reactive_power = float.Parse(dt.Rows[0]["reactive_power"].ToString());
                data.Apparent_power = float.Parse(dt.Rows[0]["apparent_power"].ToString());
                data.Power_factor = float.Parse(dt.Rows[0]["power_factor"].ToString());
                data.Active_electric_energy = float.Parse(dt.Rows[0]["active_electric_energy"].ToString());
                data.Reactive_electric_energy = float.Parse(dt.Rows[0]["rective_electric_energy"].ToString());
                data.Apparent_electric_energy = float.Parse(dt.Rows[0]["apparent_electric_energy"].ToString());
                data.Voltage_unbalance = float.Parse(dt.Rows[0]["voltage_unbalance"].ToString());
                data.Current_unbalance = float.Parse(dt.Rows[0]["current_unbalance"].ToString());
                return data;
            }
            catch (Exception e)
            {
                throw e;
            }
        }




    }
    
    
    /// <summary>
    /// 报警事件接口
    /// </summary>
    public class AlarmPro
    {
        //添加报警事件
        public static int Add(Alarm alarm)
        {
            string sql = "insert into alarm values (@id,@watchdog_id,@taiqu_id,@time,@alarm_type,@alarm_rank,@process_user,@status,@remark)";
            SqlParameter[] para = new SqlParameter[9];
            para[0] = new SqlParameter("@id", alarm.Id);
            para[1] = new SqlParameter("@watchdog_id",alarm.Watchdog_id);
            para[2] = new SqlParameter("@taiqu_id", alarm.Taiqu_id);
            para[3] = new SqlParameter("@time", alarm.Time);
            para[4] = new SqlParameter("@alarm_type", alarm.Alarm_type);
            para[5] = new SqlParameter("@alarm_rank", alarm.Alarm_rank);
            para[6] = new SqlParameter("@process_user", alarm.Process_user);
            para[7] = new SqlParameter("@status", alarm.Status);
            para[8] = new SqlParameter("@remark", alarm.Remark);

            try
            {
                return Factory.Execute().ExecuteNonQuery(sql, CommandType.Text, para);
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        //编辑报警事件
        public static int Edit(Alarm alarm)
        {
            string sql = "update alarm set watchdog_id=@watchdog_id, taiqu_id=@taiqu_id,time=@time,alarm_type=@alarm_type,alarm_rank=@alarm_rank,process_user=@process_user,status=@status,remark=@remark where alarm_id=@id)";
            SqlParameter[] para = new SqlParameter[9];
            para[0] = new SqlParameter("@id", alarm.Id);
            para[1] = new SqlParameter("@watchdog_id", alarm.Watchdog_id);
            para[2] = new SqlParameter("@taiqu_id", alarm.Taiqu_id);
            para[3] = new SqlParameter("@time", alarm.Time);
            para[4] = new SqlParameter("@alarm_type", alarm.Alarm_type);
            para[5] = new SqlParameter("@alarm_rank", alarm.Alarm_rank);
            para[6] = new SqlParameter("@process_user", alarm.Process_user);
            para[7] = new SqlParameter("@status", alarm.Status);
            para[8] = new SqlParameter("@remark", alarm.Remark);

            try
            {
                return Factory.Execute().ExecuteNonQuery(sql, CommandType.Text, para);
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        //删除报警事件
        public static int Delete(string alarmID)
        {
            string sql = "delete from alarm where alarm_id=@id";
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@id", alarmID);
            try
            {
                return Factory.Execute().ExecuteNonQuery(sql, CommandType.StoredProcedure, para);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        //分页获取报警事件
        public static List<Alarm> GetAlarmList(int pageSize, int pageIndex)
        {
            string sql = "select * from alarm order by time desc";
            try
            {
                DataTable dt = Factory.Execute().ExecuteTableByPage(pageSize, pageIndex,sql, CommandType.Text, null);
                List<Alarm> alarms = new List<Alarm>();
                int count = dt.Rows.Count;
                for (int i = 0; i < count; i++)
                {
                    Alarm alarm = new Alarm();
                    alarm.Id = dt.Rows[0]["alarm_id"].ToString();
                    alarm.Watchdog_id = dt.Rows[0]["watchdog_id"].ToString();
                    alarm.Taiqu_id = dt.Rows[0]["taiqu_id"].ToString();
                    alarm.Time = DateTime.Parse(dt.Rows[0]["time"].ToString());
                    alarm.Alarm_type = dt.Rows[0]["alarm_type"].ToString();
                    alarm.Alarm_rank = dt.Rows[0]["alarm_rank"].ToString();
                    alarm.Process_user = dt.Rows[0]["proces_user"].ToString();
                    alarm.Status = dt.Rows[0]["status"].ToString();
                    alarm.Remark = dt.Rows[0]["remark"].ToString();
                    alarms.Add(alarm);

                }
                return alarms;

            }
            catch (Exception e)
            {
                throw e;
            }
        }
        //获取某报警信息
        public static Alarm GetAlarmByID(string alarmID)
        {

            Alarm alarm = new Alarm();
            string sql = "select * from alarm where alarm_id = @alarmID";
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@alarmID", alarmID);
            try
            {
                DataTable dt = Factory.Execute().ExecuteTable(sql, CommandType.Text, para);
                alarm.Id = dt.Rows[0]["alarm_id"].ToString();
                alarm.Watchdog_id = dt.Rows[0]["watchdog_id"].ToString();
                alarm.Taiqu_id = dt.Rows[0]["taiqu_id"].ToString();
                alarm.Time = DateTime.Parse(dt.Rows[0]["time"].ToString());
                alarm.Alarm_type = dt.Rows[0]["alarm_type"].ToString();
                alarm.Alarm_rank = dt.Rows[0]["alarm_rank"].ToString();
                alarm.Process_user = dt.Rows[0]["proces_user"].ToString();
                alarm.Status = dt.Rows[0]["status"].ToString();
                alarm.Remark = dt.Rows[0]["remark"].ToString();
                return alarm;
            }
            catch (Exception e)
            {
                throw e;
            }
        }




    }
    
    
   /// <summary>
   /// 用户接口
   /// </summary>
    public class UserPro
    {
       //添加用户
        public static int Add(User user)
        {
            string sql = "insert into users values (@id,@username,@password,@role,@nickname,@created_time,@last_login,@admin_level)";
            SqlParameter[] para = new SqlParameter[8];
            para[0] = new SqlParameter("@id", user.Id);
            para[1] =new SqlParameter("@username", user.Username);
            para[2] =new SqlParameter("@password", user.Password);
            para[3] = new SqlParameter("@role", user.Role);
            para[4] = new SqlParameter("@nickname", user.Nickname);
            para[5] = new SqlParameter("@created_time", user.Created_time);
            para[6] = new SqlParameter("@last_login", user.Last_login);
            para[7] = new SqlParameter("@admin_level", user.Admin_level);

            try
            {
                return Factory.Execute().ExecuteNonQuery(sql, CommandType.Text, para);
            }
            catch (Exception e)
            {
                throw e;
            }
          
        }

        //编辑用户
        public static int Edit(User user)
        {
            string sql = "update users set username=@username, password=@password,role=@role,nickname=@nickname,created_time=@created_time,last_login=@last_login,admin_level=@admin_level where user_id=@id)";
            SqlParameter[] para = new SqlParameter[8];
            para[0] = new SqlParameter("@id", user.Id);
            para[1] = new SqlParameter("@username", user.Username);
            para[2] = new SqlParameter("@password", user.Password);
            para[3] = new SqlParameter("@role", user.Role);
            para[4] = new SqlParameter("@nickname", user.Nickname);
            para[5] = new SqlParameter("@created_time", user.Created_time);
            para[6] = new SqlParameter("@last_login", user.Last_login);
            para[7] = new SqlParameter("@admin_level", user.Admin_level);

            try
            {
                return Factory.Execute().ExecuteNonQuery(sql, CommandType.Text, para);
            }
            catch (Exception e)
            {
                throw e;
            }

        }
        
        //删除用户
        public static int Delete(string userID)
        {
            string sql = "delete from users where user_id=@id";
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@id", userID);
            try
            {
                return Factory.Execute().ExecuteNonQuery(sql, CommandType.StoredProcedure, para);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
       
        //获取全部用户
        public static List<User> GetAll()
        {
            string sql = "select * from users";
            try
            {
                DataTable dt = Factory.Execute().ExecuteTable(sql, CommandType.Text, null);
                List<User> users = new List<User>();
                int count = dt.Rows.Count;
                for (int i = 0; i < count; i++)
                {
                    User user = new User();
                    user.Id = dt.Rows[i]["user_id"].ToString();
                    user.Username = dt.Rows[i]["username"].ToString();
                    user.Password = dt.Rows[i]["password"].ToString();
                    user.Role = dt.Rows[i]["role"].ToString();
                    user.Nickname = dt.Rows[i]["nickname"].ToString();
                    user.Admin_level = int.Parse(dt.Rows[i]["admin_level"].ToString());
                    user.Created_time = DateTime.Parse(dt.Rows[i]["created_time"].ToString());
                    user.Last_login = DateTime.Parse(dt.Rows[i]["last_login"].ToString());
                    users.Add(user);

                }
                return users;
                
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        //获取某用户信息
        public static User GetUserByID(string userID)
        {

            User user = new User();
            string sql = "select * from user where user_id = @userID";
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@userID", userID);
            try
            {
                DataTable dt = Factory.Execute().ExecuteTable(sql, CommandType.Text, para);
                user.Id = dt.Rows[0]["user_id"].ToString();
                user.Username = dt.Rows[0]["username"].ToString();
                user.Password = dt.Rows[0]["password"].ToString();
                user.Role = dt.Rows[0]["role"].ToString();
                user.Nickname = dt.Rows[0]["nickname"].ToString();
                user.Admin_level = int.Parse(dt.Rows[0]["admin_level"].ToString());
                user.Created_time = DateTime.Parse(dt.Rows[0]["created_time"].ToString());
                user.Last_login = DateTime.Parse(dt.Rows[0]["last_login"].ToString());
                return user;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        //登录认证，password为原始密码,登陆成功返回user_id,失败返回空字符串
        public static string Login(string username, string password)
        {
          
            string pass = Utils.GetMd5Pass(password);
            string sql = "select * from users where username=@username and password=@password";
            SqlParameter[] para = new SqlParameter[2];
            para[0] = new SqlParameter("@username", username);
            para[1] = new SqlParameter("@password", pass);
            try
            {
                DataTable dt=Factory.Execute().ExecuteTable(sql, CommandType.Text, para);
                if (dt.Rows.Count==1){
                    return dt.Rows[0]["user_id"].ToString();
                }
                return "";
                
            }
            catch (Exception)
            {
                return  "";
            }

        }

    }

    /// <summary>
    /// 监控设备接口
    /// </summary>
    public class WatchDogPro
    {
        //添加监控设备
        public static int Add(WatchDog watchdog)
        {
            string sql = "insert into watchdog values (@id,@taiqu_id,@ip)";
            SqlParameter[] para = new SqlParameter[3];
            para[0] = new SqlParameter("@id", watchdog.Id);
            para[1] = new SqlParameter("@taiqu_id", watchdog.Taiqu_id);
            para[2] = new SqlParameter("@ip",watchdog.Ip_address);
         

            try
            {
                return Factory.Execute().ExecuteNonQuery(sql, CommandType.Text, para);
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        //编辑监控设备
        public static int Edit(WatchDog watchdog)
        {
            string sql = "update watchdog set taiqu_id=@taiqu_id,ip_address=@ip_address where watchdog_id=@id)";
            SqlParameter[] para = new SqlParameter[3];
            para[0] = new SqlParameter("@id", watchdog.Id);
            para[1] = new SqlParameter("@taiqu_id", watchdog.Taiqu_id);
            para[2] = new SqlParameter("@ip_address", watchdog.Ip_address);
          

            try
            {
                return Factory.Execute().ExecuteNonQuery(sql, CommandType.Text, para);
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        //删除监控设备
        public static int Delete(string dogID)
        {
            string sql = "delete from watchdog where watchdog_id=@id";
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@id", dogID);
            try
            {
                return Factory.Execute().ExecuteNonQuery(sql, CommandType.StoredProcedure, para);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

    }

    /// <summary>
    /// 节点接口
    /// </summary>
    public class NodeStructPro
    {
        static String root_id = "bcea06c3937a45c0b715e122a4c91e23";
        static String sheng_id = "22d291f6bdc041db99fbd2d0a28f3b21";
        static String shi_id = "039b34cfea96414585f7ae8cfece81dc";
        static String qu_id = "6ed81bdcffe44a2eab322f3d1248e51f";

        public static String getQuId()
        {

            return qu_id;
        }


        public static int init()
        {

           
            if (NodeStructPro.isExistById(root_id) != 1)
            {
                NodeStruct node = new NodeStruct(root_id,"","root","root","");
                NodeStructPro.Add(node);
            }
            if (NodeStructPro.isExistById(sheng_id) != 1)
            {
                NodeStruct node = new NodeStruct(sheng_id, root_id, "河南省", "sheng", "");
                NodeStructPro.Add(node);
            }
            if (NodeStructPro.isExistById(shi_id) != 1)
            {
                NodeStruct node = new NodeStruct(shi_id, sheng_id, "洛阳市", "shi", "");
                NodeStructPro.Add(node);
            }
            if (NodeStructPro.isExistById(qu_id) != 1)
            {
                NodeStruct node = new NodeStruct(qu_id, shi_id, "鄢陵县", "qu", "");
                NodeStructPro.Add(node);
            }
            return 1;
            

        }
        //根据id判断node是否存在
        public static int isExistById(String id)
        {

            string sql = "select * from structure where exists struct_id=@id";
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@id", id);
           
            try
            {
                return Factory.Execute().ExecuteNonQuery(sql, CommandType.Text, para);
            }
            catch (Exception e)
            {
                throw e;
            }


        }


        //根据name type parent_id判断node是否存在
        public static int isExist(String name,String type,String parent_id)
        {

            string sql = "select * from structure where exists name=@name and type=@type and parent_id=@parent_id";
            SqlParameter[] para = new SqlParameter[3];
            para[0] = new SqlParameter("@name", name);
            para[1] = new SqlParameter("@type", type);
            para[2] = new SqlParameter("@parent_id", parent_id);

            try
            {
                return Factory.Execute().ExecuteNonQuery(sql, CommandType.Text, para);
            }
            catch (Exception e)
            {
                throw e;
            }


        }


        //根据name type parent_id获取
        public static NodeStruct getNodeStruct(String name, String type, String parent_id)
        {

            string sql = "select * from structure where name=@name and type=@type and parent_id=@parent_id";
            SqlParameter[] para = new SqlParameter[3];
            para[0] = new SqlParameter("@name", name);
            para[1] = new SqlParameter("@type", type);
            para[2] = new SqlParameter("@parent_id", parent_id);
            NodeStruct node = new NodeStruct();
            try
            {
                DataTable dt = Factory.Execute().ExecuteTable(sql, CommandType.Text, para);
                node.Id = dt.Rows[0]["struct_id"].ToString();
                node.Name = dt.Rows[0]["name"].ToString();
                node.Parent_id = dt.Rows[0]["parent_id"].ToString();
                node.Type = dt.Rows[0]["type"].ToString();
                node.Admin_user = dt.Rows[0]["admin_user"].ToString();
                return node;
            }
            catch (Exception e)
            {
                throw e;
            }


        }

        //添加节点
        public static int Add(NodeStruct s)
        {
            string sql = "insert into structure values (@id,@parent_id,@name,@type,@admin_user)";
            SqlParameter[] para = new SqlParameter[5];
            para[0] = new SqlParameter("@id", s.Id);
            para[1] = new SqlParameter("@parent_id",s.Parent_id);
            para[2] = new SqlParameter("@name", s.Name);
            para[3] = new SqlParameter("@type", s.Type);
            para[4] = new SqlParameter("@admin_user", s.Admin_user);



            try
            {
                return Factory.Execute().ExecuteNonQuery(sql, CommandType.Text, para);
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        //编辑节点
        public static int Edit(NodeStruct s)
        {
            string sql = "update structure set parent_id=@parent_id,name=@name,type=@type,admin_user=@admin_user where struct_id=@id)";
            SqlParameter[] para = new SqlParameter[5];
            para[0] = new SqlParameter("@id", s.Id);
            para[1] = new SqlParameter("@parent_id", s.Parent_id);
            para[2] = new SqlParameter("@name", s.Name);
            para[3] = new SqlParameter("@type", s.Type);
            para[4] = new SqlParameter("@admin_user", s.Admin_user);


            try
            {
                return Factory.Execute().ExecuteNonQuery(sql, CommandType.Text, para);
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        //删除节点
        public static int Delete(string sID)
        {
            string sql = "delete from structure where struct_id=@id";
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@id", sID);
            try
            {
                return Factory.Execute().ExecuteNonQuery(sql, CommandType.StoredProcedure, para);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        



    }

}
