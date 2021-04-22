using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UFIDA.U9.Cust.LogViewer.BLL
{
    public class LogFiles
    {
        public static FileInfo[] LoadLog()
        {
            string path = System.Web.HttpContext.Current.Server.MapPath("~/log/");
            DirectoryInfo root = new DirectoryInfo(path);
            return root.GetFiles();
        }


        public static string ReadFile(string FullName)
        {
            string path = System.Web.HttpContext.Current.Server.MapPath("~/log/");
            return ReadTextFromFileWithReadOnlyMode(path + FullName);
        }


        public static string ReadTextFromFileWithReadOnlyMode(string filename)
        {
            string content;
            using (FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                using (StreamReader sr = new StreamReader(fs, System.Text.Encoding.Default))
                {
                    StringBuilder sb = new StringBuilder();
                    while (!sr.EndOfStream)
                    {
                        sb.AppendLine(sr.ReadLine() + "<br>");
                    }

                    content = sb.ToString();
                }
            }

            return content;
        }


        public static string CopyFile(string filename)
        {
            string CopyFile = System.Web.HttpContext.Current.Server.MapPath("~/log/" + filename);
            string copytopath = System.Web.HttpContext.Current.Server.MapPath("~/temp/");

            if (!Directory.Exists(copytopath)) Directory.CreateDirectory(copytopath);
            File.Delete(copytopath + filename + ".txt");
            File.Copy(CopyFile, copytopath+ filename+".txt");

            return filename + ".txt";
        }


    }
}