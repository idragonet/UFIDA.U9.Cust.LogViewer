


using System;
using System.Text;
using System.Collections;
using System.Xml;
using System.Data;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Resources;
using System.Reflection;
using System.Globalization;
using System.Threading;

using Telerik.WebControls;
using UFSoft.UBF.UI.WebControls;
using UFSoft.UBF.UI.WebControls.InterActionComponenet;
using UFSoft.UBF.Util.Log;
using UFSoft.UBF.Util.Context;

//using MagicAjax.UI.Controls;
using UFSoft.UBF.Report.UI.ReportView.Web;
using UFSoft.UBF.UI.WebControlAdapter;
using UFSoft.UBF.UI.FormProcess;
using UFSoft.UBF.UI.IView;
using UFSoft.UBF.UI.Engine;
using UFSoft.UBF.UI.Engine.Builder;
using UFSoft.UBF.UI.Engine.Authorization;
using UFSoft.UBF.UI.MD.Runtime;
using UFSoft.UBF.UI.ActionProcess;
using UFSoft.UBF.UI.ControlModel;
using UFSoft.UBF.UI.Controls;
using UFSoft.UBF.UI.WebControls.Association;
using UFSoft.UBF.UI.WebControls.ClientCallBack;
using System.Web.UI;
using UFSoft.UBF.UI.UIFormPersonalization;
using System.Collections.Specialized;


/***********************************************************************************************
 * Form ID:83dd816f-aec5-469e-b46f-3f94517f0c77 
 * Form Name:LogViewerForm
 * UIFactory Auto Generator
 ***********************************************************************************************/
namespace LogViewerUI
{
	[FormRegister("UFIDA.U9.Cust.LogViewer","LogViewerUI.LogViewerFormWebPart", "UFIDA.U9.Cust.LogViewer.WebPart", "83dd816f-aec5-469e-b46f-3f94517f0c77","WebPart", "True", 1000, 528)] 
	///insert into aspnet_Parts (SysVersion, Path, ClassName, [Assembly], FormId) values (0, 'UFIDA.U9.Cust.LogViewer', 'LogViewerUI.LogViewerFormWebPart', 'UFIDA.U9.Cust.LogViewer.WebPart', '83dd816f-aec5-469e-b46f-3f94517f0c77')
	///<siteMapNode url="~/erp/simple.aspx?lnk=83dd816f-aec5-469e-b46f-3f94517f0c77" title="LogViewerForm"/>
    public partial class LogViewerFormWebPart : UFSoft.UBF.UI.FormProcess.BaseWebForm
    {
		#region Page Controller/Code Behind
        private static readonly ILogger logger = LoggerManager.GetLogger(typeof(LogViewerFormWebPart));
        private string assemblyName = System.Reflection.Assembly.GetExecutingAssembly().FullName;
        //private string displayNamePostfix = "displayName";

		#region 强类型化基类属性.
		public new LogViewerUIAction Action
		{
			get { return (LogViewerUIAction)base.Action; }
			set { base.Action = value; }
		}
		LogViewerUIModel _uimodel=null;
		public new LogViewerUIModel Model
		{
			get 
			{
			     if(_uimodel == null){
			          _uimodel = new LogViewerUIModel();
			     }
			     return _uimodel; 
			}
			set { _uimodel = value; }
		}
        protected override IUIModel UIModel{
            get{
                return this.Model;
            }
            set{
                this.Model = value as LogViewerUIModel;
            }
        }
		#endregion 
		public FormAdjust adjust;
        #region variable declaration
        IUFCard Card3;
        IUFTabControl TabControl0;
        IUFTabPage TabPage0;
        IUFDataGrid DataGrid3;
        IUFCard Card4;
        IUFButton Button_serach;
        IUFButton Button_Down;
        IUFLabel lblSearchKey261;
        IUFFldTextBox SearchKey261;
        IUFLabel lblID95;
        IUFFldNumberControl ID95;
        IUFLabel lblSysVersion48;
        IUFFldNumberControl SysVersion48;
		UpdatePanel updatePanel;
		HiddenField wpFindID;
		IUFContainer topLevelPanel;     
        IUFSeparator SeparatorInFavorites;
        IUFButton BtnDefaultValues;
        #endregion
        
        #region constructor
        public LogViewerFormWebPart()
        {
            FormID = "83dd816f-aec5-469e-b46f-3f94517f0c77";
            IsAutoSize = bool.Parse("True");
        }
        #endregion


	
            
	//获取档案版型结果: 

        #region eventBind and databind
        private void EventBind()
        {
			//事件绑定模板
				//Button控件事件
			this.Button_serach.Click += new EventHandler(Button_serach_Click);		
						
				//Button控件事件
			this.Button_Down.Click += new EventHandler(Button_Down_Click);		
						

	
             //Grid控件的客户化筛选，定位事件
            ((UFWebDataGridAdapter)this.DataGrid3).GridCustomFilterHandler += new GridCustomFilterDelegate(UFGridDataGrid3_GridCustomFilterHandler);
	
            AfterEventBind();
        }
        #endregion            
        
		#region override method
		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad2(e);
		}
		protected override void OnLoadDataDo(EventArgs e)
		{
		    adjust.ProcessAdjustBeforeOnLoad(this);
			if (UIEngineHelper.IsDataBind(PageStatus, this))
			{
				if(this.Model==null){				        
					this.Model = new LogViewerUIModel();
				}
				OnLoadConsumer(new InParameterModel[]{},new InParameterModel[]{});
				OnLoadData(this);
				this.IsDataBinding = true ; //加载完数据要绑定一次.目前加这.
			}
			else
			{
				//去除.已经移入到OnInit()中.
				//this.Model = (LogViewerUIModel)this.CurrentState[this.TaskId.ToString()];
			}
			adjust.ProcessAdjustAfterOnLoadData(this);
		            AfterOnLoad();
            
            adjust.ProcessAdjustAfterOnLoad(this);
		}
		protected override void OnPreRender(EventArgs e)
		{
			base.OnPreRender2(e);
		}
        protected override void OnPreRenderDo(EventArgs e)
        {
            adjust.ProcessAdjustBeforeOnPreRender(this);
			base.OnPreRender(e);
			this.CurrentState[this.TaskId.ToString()] = this.Model;
			RegisterClearWebPartPadding();
            UFIDA.U9.UI.PDHelper.FormAuthorityHelper.SetWebPartAuthorization(this);
            
			if (IsDataBinding) //2006-9-7 可由开发人员控制
			{
				BeforeUIModelBinding();
								if(!Page.IsPostBack)
				{
					EnumTypeBinding.BindEnumControls(this);
				}
				UFIDA.U9.UI.Commands.CommandHelper.BindFlexData(this);
				adjust.ProcessAdjustBeforeDataBinding(this);
				if (this.IsOnlyDataBinding)
				{
					this.DataBinding();
				}
				adjust.ProcessAdjustAfterDataBinding(this);

				AfterUIModelBinding();
			}
			adjust.ProcessAdjustAfterOnPreRender(this);
        }
		protected override void OnInit(EventArgs e)
		{
			base.OnInit2(e);
		}
		protected override void OnInitDo(EventArgs e)
		{			 
			this.Page.InitComplete += new EventHandler(Page_InitComplete);
			WebPartBuilder.InitWebPart(this);
            this.Action = new LogViewerUIAction(this);
            adjust = new FormAdjust();
		    CreateFormChildControls();
		}
        void Page_InitComplete(object sender, EventArgs e)
        {

            adjust.ProcessInit(this);
        }
        #endregion

      
        
        #endregion

	
		/// <summary>
        /// WebPart View
        /// </summary>
        #region view Create Contorls
        private void CreateFormChildControls()
        {
            IUFContainer _panel = UIControlBuilder.BuildTopLevelContainer(this,"LogViewerForm",true,1000,528);
            CommonBuilder.ContainerGridLayoutPropBuilder(_panel, 2, 2, 0, 10, 0, 0, 0, 5);
			InitViewBindingContainer(this, _panel,  null, "", "", null, 1, "");
			UIControlBuilder.BuildContainerGridLayout(_panel, 10,new GridColumnDef[]{new GridColumnDef(992,bool.Parse("False")),new GridColumnDef(1,bool.Parse("True")),},new GridRowDef[]{new GridRowDef(40,bool.Parse("True")),new GridRowDef(470,bool.Parse("False")),});
            //???还有用么?
            topLevelPanel = _panel;    
            
            UIControlBuilder.BuildCommonControls(this,ref updatePanel,ref wpFindID);
            





	
			_BuilderControl_Card3(_panel);

		
			UIControlBuilder.BuilderUFControl(this.Card3, "2");		


	
			_BuilderControl_Card4(_panel);

		
			UIControlBuilder.BuilderUFControl(this.Card4, "0");		



		
     
			
			
            EventBind();
            AfterCreateChildControls();
            
        }        







	                   
        private IUFCard _BuilderControl_Card3(IUFContainer container)
        {
            IUFCard _UFCard = UIControlBuilder.BuildCard(container,"Card3",false,"none", true, true, "2","","efa537af-6300-46a9-bd87-536b3c0323a0");
			CommonBuilder.GridLayoutPropBuilder(container, _UFCard, 992, 470, 0, 1, 1, 1, "100");
            CommonBuilder.ContainerGridLayoutPropBuilder(_UFCard, 2, 2, 0, 5, 10, 0, 10, 0);
			InitViewBindingContainer(this, _UFCard,  null, "", "", null, 1, "");
			UIControlBuilder.BuildContainerGridLayout(_UFCard, 5,new GridColumnDef[]{new GridColumnDef(650,bool.Parse("False")),new GridColumnDef(9,bool.Parse("True")),},new GridRowDef[]{new GridRowDef(460,bool.Parse("True")),new GridRowDef(1,bool.Parse("False")),});
            this.Card3 = _UFCard;

            ///foreach UFCard下的所有控件，增加到此容器





	
			_BuilderControl_TabControl0(_UFCard);

		
			UIControlBuilder.BuilderUFControl(this.TabControl0, "0");		



	

            
            container.Controls.Add(_UFCard);
            return _UFCard;
        }

	         private void _BuilderControl_TabControl0(IUFContainer container)
        {
            IUFTabControl _UFTabControl = UIControlBuilder.BuildTabControl(container,"TabControl0",true, true, "0",EventResponseType.Client,650, 466, 0, 0, 1, 2, "100");
            ///foreach UFTabbedPane下的所有控件，增加到此容器
            _UFTabControl.TabPages.Add(_BuilderControl_TabPage0(_UFTabControl));
            this.TabControl0 = _UFTabControl;
        }

	        private IUFTabPage _BuilderControl_TabPage0(IUFTabControl container)
        {
            IUFTabPage _UFTabPage = UIControlBuilder.BuildTabPageControl(container,"TabPage0",true, true, "0","8d246116-8447-404e-b0ea-771f661eddc7","8d246116-8447-404e-b0ea-771f661eddc7");
            CommonBuilder.ContainerGridLayoutPropBuilder(_UFTabPage, 2, 1, 0, 5, 10, 10, 10, 10);
			InitViewBindingContainer(this, _UFTabPage,  null, "", "", null, 1, "");
			UIControlBuilder.BuildContainerGridLayout(_UFTabPage, 5,new GridColumnDef[]{new GridColumnDef(600,bool.Parse("True")),new GridColumnDef(10,bool.Parse("False")),},new GridRowDef[]{new GridRowDef(416,bool.Parse("False")),});
            ///foreach UFTab下的所有控件，增加到此容器





	
			_BuilderControl_DataGrid3(_UFTabPage);

		
			UIControlBuilder.BuilderUFControl(this.DataGrid3, "0");		



	

            this.TabPage0 = _UFTabPage;
            return _UFTabPage;
        }

				





       
        private void _BuilderControl_DataGrid3(IUFContainer container)
        {
            IUFDataGrid _UFGrid = UIControlBuilder.BuildGridControl("DataGrid3", UFSoft.UBF.UI.ControlModel.EditStatus.Browse, false, false,false,false,false,false,-1,false, false) ;
  			UIControlBuilder.BuilderUFControl(_UFGrid, "True", "True", "0");
			CommonBuilder.GridLayoutPropBuilder(container, _UFGrid, 600, 416, 0, 0, 1, 1, "100");
			InitViewBindingContainer(this, _UFGrid,  this.Model.ViewLogViewer, "ViewLogViewer", "", null, -1, "");
			((UFSoft.UBF.UI.WebControlAdapter.UFWebDataGridAdapter)_UFGrid).PagingStrategy=UFSoft.UBF.UI.ControlModel.GridPagingStrategy.Auto;
			_UFGrid.AllowSelectAllPage=false;
			((UFSoft.UBF.UI.WebControls.UFGrid)_UFGrid).IsSumAllData=false;
		        ((UFSoft.UBF.UI.WebControls.UFGrid)_UFGrid).IsSumSelectedData=false;
            this.DataGrid3 = _UFGrid;
            container.Controls.Add(_UFGrid);



			IUFDataGridColumn column ;
			GridColumn gridColumn ;
	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"ID1","NumberColumnModel", "", 0,this.Model.ViewLogViewer.Fields["ID"]/*ID*/,"ID", true, false, true, false, false, false, 7, 100, "",true, false,"","bc226b54-44e4-4265-8bd7-21fc88490da1","bc226b54-44e4-4265-8bd7-21fc88490da1","686903d0-e928-4929-aa29-5c61200cd0b7");
			GridControlBuilder.GridNumberColumnBuilder((IUFNumberColumn)column, NumbericType.Numberic, 79228162514264337593543950335m, -79228162514264337593543950335m, null, null, null, null
			,true,"",false,"1","1");
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"SysVersion1","NumberColumnModel", "", 0,this.Model.ViewLogViewer.Fields["SysVersion"]/*SysVersion*/,"SysVersion", false, false, true, false, false, false, 7, 100, "",true, false,"","effe9c94-95d7-483a-be7c-844857178557","effe9c94-95d7-483a-be7c-844857178557","558a9e88-2d81-4b3a-b115-d40926650a7d");
			GridControlBuilder.GridNumberColumnBuilder((IUFNumberColumn)column, NumbericType.Numberic, 79228162514264337593543950335m, -79228162514264337593543950335m, null, null, null, null
			,true,"",false,"1","1");
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"FileName1","TextBoxColumnModel", "", 0,this.Model.ViewLogViewer.Fields["FileName"]/*FileName*/,"FileName", false, true, false, false, false, true, 0, 135, "50",true, false,"","037797a1-e033-4b0d-8c0c-42733ce362da","037797a1-e033-4b0d-8c0c-42733ce362da","a907b24d-80e6-4cb6-b5a0-27ce590d0c94");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","50") ;          
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"Modified1","DatePickerColumnModel", "", 0,this.Model.ViewLogViewer.Fields["Modified"]/*Modified*/,"Modified", false, true, false, false, false, true, 5, 150, "17",true, false,"2005-1-1 00:00:00","e8fa5a04-0f81-4ec2-a6fa-7a8f09e79347","e8fa5a04-0f81-4ec2-a6fa-7a8f09e79347","7d3203b5-91a2-4f53-a7c2-460ba031c6c1");
                   
			((IUFDatePickerColumn)column).DateTimeType = DateTimeType.DateTime;
            ((IUFDatePickerColumn)column).DateTimeFormat = CurrentState._I18N._DateTimeFormatInfo;
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"FileSize0","TextBoxColumnModel", "", 0,this.Model.ViewLogViewer.Fields["FileSize"]/*FileSize*/,"FileSize", false, true, true, false, false, true, 0, 100, "50",true, false,"","c75b1eb8-f2f0-4bdb-9a80-f986e7a7de4d","c75b1eb8-f2f0-4bdb-9a80-f986e7a7de4d","13c3af3d-0c81-4222-91ba-f0783d281a0a");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","50") ;          
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"IsHave0","CheckBoxColumnModel", "", 0,this.Model.ViewLogViewer.Fields["IsHave"]/*IsHave*/,"IsHave", false, true, true, false, false, true, 22, 85, "1",true, false,"","a19ebb2a-080a-45c0-b8b1-cdc81eec7c34","a19ebb2a-080a-45c0-b8b1-cdc81eec7c34","74566742-76fb-41d6-b52c-9f2a77d6d337");
	  
		 
        }

	                   
        private IUFCard _BuilderControl_Card4(IUFContainer container)
        {
            IUFCard _UFCard = UIControlBuilder.BuildCard(container,"Card4",false,"none", true, true, "0","c4f47877-b18a-4f36-88cc-621b7d3bd6f5","33aaf56a-705c-4c98-b373-47c86d383002");
			CommonBuilder.GridLayoutPropBuilder(container, _UFCard, 992, 40, 0, 0, 1, 1, "100");
            CommonBuilder.ContainerGridLayoutPropBuilder(_UFCard, 17, 1, 0, 5, 10, 10, 10, 10);
			InitViewBindingContainer(this, _UFCard,  this.Model.ViewSearch, "ViewSearch", "", null, 1, "");
			UIControlBuilder.BuildContainerGridLayout(_UFCard, 5,new GridColumnDef[]{new GridColumnDef(100,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(100,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(100,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(1,bool.Parse("False")),new GridColumnDef(100,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(100,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(100,bool.Parse("True")),},new GridRowDef[]{new GridRowDef(20,bool.Parse("False")),});
            this.Card4 = _UFCard;

            ///foreach UFCard下的所有控件，增加到此容器





				this.Button_serach = UIControlBuilder.BuilderUFButton(_UFCard, true, "Button_serach", true, true, 80, 20, 8, 0, 1, 1, "100","", this.Model.ElementID,"",false,"b2a157d3-67e6-40f6-bd93-9725d86e07cf","","b2a157d3-67e6-40f6-bd93-9725d86e07cf");
	

		
			UIControlBuilder.BuilderUFControl(this.Button_serach, "2");		


				this.Button_Down = UIControlBuilder.BuilderUFButton(_UFCard, true, "Button_Down", true, true, 80, 20, 10, 0, 1, 1, "100","", this.Model.ElementID,"",false,"6890ccab-9cdb-4431-ba10-b89918a325d4","","6890ccab-9cdb-4431-ba10-b89918a325d4");
	

		
			UIControlBuilder.BuilderUFControl(this.Button_Down, "3");		


				this.lblSearchKey261 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblSearchKey261", "", "True", "True", "Right", 100, 20, 0, 0, 1, 1, "100","c4f47877-b18a-4f36-88cc-621b7d3bd6f5","5c9e1332-26e1-483d-860e-c573ef206000");


								

		
			UIControlBuilder.BuilderUFControl(this.lblSearchKey261, "4");		


				this.SearchKey261 = UIControlBuilder.BuilderTextBox(_UFCard, "SearchKey261", "True", "True", "True", "False", "Left", 0, 60, 0, 300, 20, 2, 0, 5, 1, "False", "100"
			,"",TextBoxMode.SingleLine,TextAlign.Left, true,false,"lblSearchKey261","","50","c4f47877-b18a-4f36-88cc-621b7d3bd6f5","77ceafd0-7f06-4f4d-b8dd-e7b0a904ee48");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.SearchKey261, "False", "SearchKey", this.Model.ViewSearch, this.Model.ViewSearch.FieldSearchKey, "ViewSearch");


		
			UIControlBuilder.BuilderUFControl(this.SearchKey261, "5");		
		 

				this.lblID95 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblID95", "", "False", "True", "Right", 100, 20, 0, 0, 1, 1, "100","e300cb85-b583-42c8-9718-be4d412f7c70","e74ffb49-e9c4-4a9a-a8a0-9cbe8685b5d0");


								

		
			UIControlBuilder.BuilderUFControl(this.lblID95, "6");		


				this.ID95 = UIControlBuilder.BuilderNumberControl(_UFCard, "ID95", "False", "False", "True", "Left", 7, 60, 0, 100, 20, 0, 0, 1, 1, NumbericType.Numberic, "100",79228162514264337593543950335m, -79228162514264337593543950335m
			,TextAlign.Right,0,true,false,true,"lblID95","","e300cb85-b583-42c8-9718-be4d412f7c70","22c20090-f65f-4ee2-ba3b-1e086a623642",null,null,null, null);
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.ID95, "False", "ID", this.Model.ViewSearch, this.Model.ViewSearch.FieldID, "ViewSearch");
	
		
			UIControlBuilder.BuilderUFControl(this.ID95, "7");		
		 

				this.lblSysVersion48 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblSysVersion48", "", "False", "True", "Right", 100, 20, 0, 0, 1, 1, "100","aec5bd44-5eb0-488a-929b-128a784b84cb","20c3a108-1725-4ebf-86c9-6249c9b6c840");


								

		
			UIControlBuilder.BuilderUFControl(this.lblSysVersion48, "8");		


				this.SysVersion48 = UIControlBuilder.BuilderNumberControl(_UFCard, "SysVersion48", "False", "False", "True", "Left", 7, 60, 0, 100, 20, 0, 0, 1, 1, NumbericType.Numberic, "100",79228162514264337593543950335m, -79228162514264337593543950335m
			,TextAlign.Right,0,true,false,true,"lblSysVersion48","","aec5bd44-5eb0-488a-929b-128a784b84cb","2bb1354b-fcce-4b41-b4a9-02a3f4bc6d5b",null,null,null, null);
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.SysVersion48, "False", "SysVersion", this.Model.ViewSearch, this.Model.ViewSearch.FieldSysVersion, "ViewSearch");
	
		
			UIControlBuilder.BuilderUFControl(this.SysVersion48, "9");		
		 


								

            
            container.Controls.Add(_UFCard);
            return _UFCard;
        }





		#endregion
		

	}
}
