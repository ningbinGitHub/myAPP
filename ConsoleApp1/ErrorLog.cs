using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ConsoleApp1
{
    /// <summary>
    /// 错误日志操作类
    /// </summary>
    public class ErrorLog
    {
        /// <summary>
        /// 记录日志
        /// </summary>
        /// <param name="funName">执行方法名</param>
        /// <param name="errMsg">错误信息</param>
        public static void WriteLog(string funName, string errMsg, String ss = null)
        {

            string errorTxt = "";
            string fileDirectory = @"C:/WorkFile/Logs/App_Data/";
            string logName = DateTime.Now.ToString("yyyyMMdd") + ss + ".txt";
            string fileName = fileDirectory + logName;
            try
            {
                if (!Directory.Exists(fileDirectory))
                {
                    Directory.CreateDirectory(fileDirectory);
                }
                if (!File.Exists(fileName))
                {

                    StreamWriter sw;
                    sw = File.CreateText(fileName);
                    sw.Close();

                }
                errorTxt = Convert.ToString(Convert.ToDateTime(DateTime.Now).ToString("yyyy-MM-dd HH:mm:ss")) + "  方法名：" + funName + "， 错误信息：" + errMsg + Environment.NewLine;
                File.AppendAllText(fileName, errorTxt);

            }
            catch
            {
                //
            }

        }// end

        public static void WriteLog_1(string funName, string errMsg, String ss = null)
        {

            string errorTxt = "";
            string fileDirectory = @"C:/WorkFile/Logs/App_Data/";
            string logName = DateTime.Now.ToString("yyyyMMdd") + ss + ".txt";
            string fileName = fileDirectory + logName;
            try
            {
                if (!Directory.Exists(fileDirectory))
                {
                    Directory.CreateDirectory(fileDirectory);
                }
                if (!File.Exists(fileName))
                {

                    StreamWriter sw;
                    sw = File.CreateText(fileName);
                    sw.Close();
                    sw.Dispose();
                }
                errorTxt = Convert.ToString(Convert.ToDateTime(DateTime.Now).ToString("yyyy-MM-dd HH:mm:ss")) + "  方法名：" + funName + "， 错误信息：" + errMsg + Environment.NewLine;
                File.AppendAllText(fileName, errorTxt);

            }
            catch
            {
                //
            }

        }// end
    }
}
