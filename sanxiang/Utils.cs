using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Xml;

namespace utils
{
    public class Utils
    {
        //生成MD5密码
        public static string GetMd5Pass(string str)
        {
            string cl = str;
            string pwd = "";
            MD5 md5 = MD5.Create();//实例化一个md5对像
            // 加密后是一个字节类型的数组，这里要注意编码UTF8/Unicode等的选择　
            byte[] s = md5.ComputeHash(Encoding.UTF8.GetBytes(cl));
            // 通过使用循环，将字节类型的数组转换为字符串，此字符串是常规字符格式化所得
            for (int i = 0; i < s.Length; i++)
            {
                // 将得到的字符串使用十六进制类型格式。格式后的字符是小写的字母，如果使用大写（X）则格式后的字符是大写字符
                pwd = pwd + s[i].ToString("X");

            }
            return pwd;
        }

        //生成guid
        public static string GetId()
        {
            return System.Guid.NewGuid().ToString().Replace("-", "");

        }

        /// <summary>
        /// 加密
        /// </summary>
        /// <param name="key">钥匙</param>
        /// <param name="password">原密码</param>
        /// <returns></returns>
        public static string GetJiaMi(string key,string password)
        {
            CspParameters param = new CspParameters();
            param.KeyContainerName = key;
            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(param))
            {
                byte[] plaindata = Encoding.Default.GetBytes(password);//将要加密的字符串转换为字节数组
                byte[] encryptdata = rsa.Encrypt(plaindata, false);//将加密后的字节数据转换为新的加密字节数组
                return Convert.ToBase64String(encryptdata);//将加密后的字节数组转换为字符串
            }

        }

        /// <summary>
        /// 解密
        /// </summary>
        /// <param name="key">钥匙</param>
        /// <param name="password">加密密码</param>
        /// <returns></returns>
        public static string GetJiemi(string key,string password)
        {
            CspParameters param = new CspParameters();
            param.KeyContainerName = key;
            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(param))
            {
                byte[] encryptdata = Convert.FromBase64String(password);
                byte[] decryptdata = rsa.Decrypt(encryptdata, false);
                return Encoding.Default.GetString(decryptdata);
            }


        }

        /// <summary>
        /// 获取配置文档
        /// </summary>
        /// <returns></returns>
        public static  XmlDocument GetConfigDoc()
        {
            string config_file = "config.xml";
            XmlDocument MyXML = new XmlDocument();
            try
            {
                MyXML.Load(config_file);
            }
            catch (Exception)
            {
                XmlDocument doc = new XmlDocument();
                XmlElement Root = doc.CreateElement("config");
                doc.AppendChild(Root);
                doc.Save("config.xml");
                MyXML.Load("config.xml");

            }
            return MyXML;


        }
        /// <summary>
        /// 获取配置文件
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string GetConfig(string key,string default_value)
        {
            try
            {
                XmlDocument doc = GetConfigDoc();
                XmlNodeList nodes = doc.GetElementsByTagName(key);
                if (nodes.Count>0){

                    return nodes[0].InnerText;
                }
                return default_value;
               
            }
            catch (Exception)
            {
                return default_value;

            }

        }
        /// <summary>
        /// 设置配置信息
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool SetConfig(string key,string value)
        {
            try
            {
                XmlDocument doc = GetConfigDoc();
                XmlNode Node = doc.DocumentElement;
                XmlNodeList elements = doc.GetElementsByTagName(key);

            
                XmlElement element_new = doc.CreateElement(key);
                element_new.InnerText = value;
                if (elements.Count>0)
                {
                    Node.ReplaceChild(element_new, elements[0]);
                      
                }
                else
                {
                    
                    Node.AppendChild(element_new);
                    
                }
                doc.Save("config.xml");
                return true;

            }
            catch (Exception)
            {
                return false;

            }

        }

    }
}
