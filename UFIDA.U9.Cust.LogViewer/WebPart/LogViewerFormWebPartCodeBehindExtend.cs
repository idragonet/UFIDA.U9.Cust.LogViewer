using System;
using System.Text;
using System.Collections;
using System.Xml;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Resources;
using System.Reflection;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading;
using Telerik.WebControls;
using UFIDA.U9.Cust.LogViewer.BLL;
using UFSoft.UBF.UI;
using UFSoft.UBF.UI.WebControls;
using UFSoft.UBF.UI.Controls;
using UFSoft.UBF.Util.Log;
using UFSoft.UBF.Util.Globalization;
using UFSoft.UBF.UI.IView;
using UFSoft.UBF.UI.Engine;
using UFSoft.UBF.UI.MD.Runtime;
using UFSoft.UBF.UI.ActionProcess;
using UFSoft.UBF.UI.WebControls.ClientCallBack;


/***********************************************************************************************
 * Form ID: 
 * UIFactory Auto Generator 
 ***********************************************************************************************/
namespace LogViewerUI
{
    public partial class LogViewerFormWebPart
    {
        #region Custome eventBind

        //Button_serach_Click...
        private void Button_serach_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.

            this.DataCollect();


            if (this.Model.ViewSearch.FocusedRecord != null)
            {
                string keyword = this.Model.ViewSearch.FocusedRecord.SearchKey.Trim();
                if (!string.IsNullOrEmpty(keyword)) LoadFindData(keyword);
            }


            Button_serach_Click_DefaultImpl(sender, e);
        }

        //Button_Down_Click...
        private void Button_Down_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.
            if (this.Model.ViewLogViewer.FocusedRecord != null)
            {
                string fileName = this.Model.ViewLogViewer.FocusedRecord.FileName;
                string file= LogFiles.CopyFile(fileName);

                string script = $"window.open('../temp/{file}');";
                AtlasHelper.RegisterAtlasStartupScript(this.Page, this.Page.GetType(), Guid.NewGuid().ToString(), script, true);
            }

            Button_Down_Click_DefaultImpl(sender, e);
        }


        /*private void DataGrid3_GridRowClicked_Extend(object sender, GridCallBackEventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.


            if (this.Model.ViewLogViewer.FocusedRecord != null)
            {
                string fileName = this.Model.ViewLogViewer.FocusedRecord.FileName;
                //TextBox946.Text = LogFiles.ReadFile(fileName);
            }
        }*/

        #region 自定义数据初始化加载和数据收集

        private void OnLoadData_Extend(object sender)
        {
            OnLoadData_DefaultImpl(sender);
        }

        private void OnDataCollect_Extend(object sender)
        {
            OnDataCollect_DefaultImpl(sender);
        }

        #endregion

        #region 自己扩展 Extended Event handler

        public void AfterOnLoad()
        {
            LoadSearchData();
            LoadFindData();
        }

        private void LoadFindData(string keyword = "")
        {
            if (this.Model.ViewLogViewer.RecordCount > 1 && string.IsNullOrEmpty(keyword)) return;


            Model.ViewLogViewer.Clear();
            Model.ViewLogViewer.Locked = false;
            Model.ViewLogViewer.ClearCache();

            var log = LogFiles.LoadLog();

            var log2 = log.OrderByDescending(i => i.LastWriteTime).ToList();

            foreach (FileInfo fileInfo in log2)
            {
                if (fileInfo.Name.Contains("All.log"))
                {
                    if (fileInfo.LastWriteTime.Date < DateTime.Now.AddDays(-7)) continue; //只显示最近7天文件


                    var viewLog = Model.ViewLogViewer.AddNewUIRecord();
                    viewLog.FileName = fileInfo.Name;
                    viewLog.Modified = fileInfo.LastWriteTime;
                    viewLog.FileSize = GetFileSize(fileInfo.Length);


                    if (!string.IsNullOrEmpty(keyword))
                    {
                        if (LogFiles.ReadFile(fileInfo.Name).IndexOf(keyword, StringComparison.Ordinal) != -1)
                        {
                            viewLog.IsHave = true;
                        }
                    }
                }
            }
        }


        private void LoadSearchData()
        {
            if (this.Model.ViewSearch.FocusedRecord == null)
            {
                var viewsearch = Model.ViewSearch.AddNewUIRecord();
                viewsearch.SearchKey = "";
            }
        }

        /// <summary>
        /// 计算文件大小函数(保留两位小数),Size为字节大小
        /// </summary>
        /// <param name="size">初始文件大小</param>
        /// <returns></returns>
        public static string GetFileSize(long size)
        {
            var num = 1024.00; //byte


            if (size < num)
                return size + "B";
            if (size < Math.Pow(num, 2))
                return (size / num).ToString("f2") + "KB"; //kb
            if (size < Math.Pow(num, 3))
                return (size / Math.Pow(num, 2)).ToString("f2") + "MB"; //M
            if (size < Math.Pow(num, 4))
                return (size / Math.Pow(num, 3)).ToString("f2") + "G"; //G


            return (size / Math.Pow(num, 4)).ToString("f2") + "T"; //T
        }


        public void AfterCreateChildControls()
        {
        }

        public void AfterEventBind()
        {
        }

        public void BeforeUIModelBinding()
        {
            
        }

        public void AfterUIModelBinding()
        {
        }

        #endregion

        #endregion
    }
}