


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
 * Form ID:627141da-ef10-4e03-bcf1-89cc49210bef 
 * Form Name:test1111111
 * UIFactory Auto Generator
 ***********************************************************************************************/
namespace LogViewerUI
{
	[FormRegister("UFIDA.U9.Cust.LogViewer","LogViewerUI.test1111111WebPart", "UFIDA.U9.Cust.LogViewer.WebPart", "627141da-ef10-4e03-bcf1-89cc49210bef","WebPart", "False", 640, 384)] 
	///insert into aspnet_Parts (SysVersion, Path, ClassName, [Assembly], FormId) values (0, 'UFIDA.U9.Cust.LogViewer', 'LogViewerUI.test1111111WebPart', 'UFIDA.U9.Cust.LogViewer.WebPart', '627141da-ef10-4e03-bcf1-89cc49210bef')
	///<siteMapNode url="~/erp/simple.aspx?lnk=627141da-ef10-4e03-bcf1-89cc49210bef" title="test1111111"/>
    public partial class test1111111WebPart : UFSoft.UBF.UI.FormProcess.BaseWebForm
    {
		#region Page Controller/Code Behind
        private static readonly ILogger logger = LoggerManager.GetLogger(typeof(test1111111WebPart));
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
        IUFToolbar Toolbar2;
        IUFTreeControl TreeControl2;
        IUFCard Card2;
		UpdatePanel updatePanel;
		HiddenField wpFindID;
		IUFContainer topLevelPanel;     
        IUFSeparator SeparatorInFavorites;
        IUFButton BtnDefaultValues;
        #endregion
        
        #region constructor
        public test1111111WebPart()
        {
            FormID = "627141da-ef10-4e03-bcf1-89cc49210bef";
            IsAutoSize = bool.Parse("False");
        }
        #endregion


	
            
	//获取档案版型结果: 

        #region eventBind and databind
        private void EventBind()
        {
			//事件绑定模板

	
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
            IUFContainer _panel = UIControlBuilder.BuildTopLevelContainer(this,"test1111111",true,640,384);
            CommonBuilder.ContainerGridLayoutPropBuilder(_panel, 3, 10, 0, 8, 10, 10, 10, 10);
			InitViewBindingContainer(this, _panel,  null, "", "", null, 1, "");
			UIControlBuilder.BuildContainerGridLayout(_panel, 8,new GridColumnDef[]{new GridColumnDef(204,bool.Parse("False")),new GridColumnDef(203,bool.Parse("False")),new GridColumnDef(201,bool.Parse("False")),},new GridRowDef[]{new GridRowDef(29,bool.Parse("False")),new GridRowDef(29,bool.Parse("False")),new GridRowDef(29,bool.Parse("False")),new GridRowDef(29,bool.Parse("False")),new GridRowDef(29,bool.Parse("False")),new GridRowDef(29,bool.Parse("False")),new GridRowDef(29,bool.Parse("False")),new GridRowDef(29,bool.Parse("False")),new GridRowDef(29,bool.Parse("False")),new GridRowDef(28,bool.Parse("False")),});
            //???还有用么?
            topLevelPanel = _panel;    
            
            UIControlBuilder.BuildCommonControls(this,ref updatePanel,ref wpFindID);
            





	
			_BuilderControl_Toolbar2(_panel);

		
			UIControlBuilder.BuilderUFControl(this.Toolbar2, "0");		


	
			_BuilderControl_TreeControl2(_panel);

		
			UIControlBuilder.BuilderUFControl(this.TreeControl2, "1");		


	
			_BuilderControl_Card2(_panel);

		
			UIControlBuilder.BuilderUFControl(this.Card2, "2");		



			
     
			
			
            EventBind();
            AfterCreateChildControls();
            
        }        







				        
        private void _BuilderControl_Toolbar2(IUFContainer container)
        {
            IUFToolbar _Toolbar = UIControlBuilder.BuilderToolBarControl(container,"Toolbar2",true, true, "0",621, 30, 0, 0, 3, 1,"100");
            this.Toolbar2 = _Toolbar;
            
            ///foreach Toolbar下的所有控件，增加到此容器

            
            ((UFWebToolbarAdapter)_Toolbar).RemoveControls();
        }



	        private void _BuilderControl_TreeControl2(IUFContainer container)
        {
            IUFTreeControl _RadTreeView = new UFWebTreeControlAdapter();
            _RadTreeView.ID = "TreeControl2";
			UIControlBuilder.BuilderUFControl(_RadTreeView, "True", "True", "1");
            _RadTreeView.AutoPostBack = bool.Parse("True");
            _RadTreeView.LoadOnDemand = bool.Parse("False");
            _RadTreeView.CheckBoxes = bool.Parse("False");
            _RadTreeView.MultipleSelect = bool.Parse("False");
			CommonBuilder.GridLayoutPropBuilder(container, _RadTreeView, 205, 325, 0, 1, 1, 9, "100");
			InitViewBindingContainer(this, _RadTreeView,  null, "", "", null, -1, "");
            this.TreeControl2 = _RadTreeView;
            container.Controls.Add(_RadTreeView);

			ITreeViewBinding treeViewBinding;
        }

	                   
        private IUFCard _BuilderControl_Card2(IUFContainer container)
        {
            IUFCard _UFCard = UIControlBuilder.BuildCard(container,"Card2",true,"none", true, true, "2","","5b78762d-1c15-4139-b8b3-fdc8c9dcf2c3");
			CommonBuilder.GridLayoutPropBuilder(container, _UFCard, 411, 325, 1, 1, 2, 9, "100");
            CommonBuilder.ContainerGridLayoutPropBuilder(_UFCard, 3, 9, 0, 7, 10, 10, 10, 10);
			InitViewBindingContainer(this, _UFCard,  null, "", "", null, 1, "");
			UIControlBuilder.BuildContainerGridLayout(_UFCard, 7,new GridColumnDef[]{new GridColumnDef(125,bool.Parse("False")),new GridColumnDef(124,bool.Parse("False")),new GridColumnDef(118,bool.Parse("False")),},new GridRowDef[]{new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),});
            this.Card2 = _UFCard;

            ///foreach UFCard下的所有控件，增加到此容器








            
            container.Controls.Add(_UFCard);
            return _UFCard;
        }





		#endregion
		

	}
}
