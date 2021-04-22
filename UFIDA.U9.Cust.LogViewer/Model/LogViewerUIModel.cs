#region Using directives

using System;
using System.Collections;
using System.Data;
using UFSoft.UBF.UI.MD.Runtime;
using UFSoft.UBF.UI.MD.Runtime.Implement;

#endregion

namespace LogViewerUI
{
	[Serializable]
	public partial class LogViewerUIModel : UIModel
	{
		#region Constructor
		public LogViewerUIModel() : base("LogViewerUI")
		{
			InitClass();
			this.SetResourceInfo("50fc507b-11b9-49a0-becf-8af5f58d7665");
            try{
			    AfterInitModel();
            }catch(Exception exception){
              IUIModel model = this;
		      this.ErrorMessage.SetErrorMessage(ref model,exception);
			}
		}

		//just for Clone 
		private LogViewerUIModel(bool isInit) : base("LogViewerUI")
		{}
		protected override IUIModel CreateCloneInstance()
		{
			return new LogViewerUIModel(false);
		}
		#endregion
		#region member
		#region views
		private ViewLogViewerView viewViewLogViewer;			
		private ViewSearchView viewViewSearch;			
		#endregion
		
		#region links
		#endregion
		
		#region properties
		#endregion
		#endregion

		#region property
		public ViewLogViewerView ViewLogViewer
		{
			get { return (ViewLogViewerView)this["ViewLogViewer"]; }
		}
		public ViewSearchView ViewSearch
		{
			get { return (ViewSearchView)this["ViewSearch"]; }
		}
		
		#region RealViews
		#endregion
		
	
		#endregion

		#region function
		private void InitClass()
		{
			this.viewViewLogViewer = new ViewLogViewerView(this);
			this.viewViewLogViewer.SetResourceInfo("7aa25d35-afe4-48f7-942a-d0cd804be9fd");
			this.Views.Add(this.viewViewLogViewer);			
			this.viewViewSearch = new ViewSearchView(this);
			this.viewViewSearch.SetResourceInfo("5599a39e-5503-49b3-8365-89772dd8e302");
			this.Views.Add(this.viewViewSearch);			

			
		}

		public override string AssemblyName
		{
			get { return "UFIDA.U9.Cust.LogViewer"; }
		}
		
		#endregion
		private void OnValidate_DefualtImpl()
    {
    }

	}


	[Serializable]
	public partial class ViewLogViewerView : UIView
	{
		#region Constructor
		public ViewLogViewerView(IUIModel model) : base(model,"ViewLogViewer","", true)
		{
			InitClass();
		}
		//构造空实例,不进行初始化.目前为Clone使用.
		private ViewLogViewerView():base(null,"ViewLogViewer","", true)
		{
		}
		protected override IUIView CreateCloneInstance()
		{
			return new ViewLogViewerView();
		}
		#endregion

		#region fiels property filter
		public IUIField FieldID
		{
			get { return this.Fields["ID"]; }
		}
		public IUIField FieldCreatedOn
		{
			get { return this.Fields["CreatedOn"]; }
		}
		public IUIField FieldCreatedBy
		{
			get { return this.Fields["CreatedBy"]; }
		}
		public IUIField FieldModifiedOn
		{
			get { return this.Fields["ModifiedOn"]; }
		}
		public IUIField FieldModifiedBy
		{
			get { return this.Fields["ModifiedBy"]; }
		}
		public IUIField FieldSysVersion
		{
			get { return this.Fields["SysVersion"]; }
		}
		public IUIField FieldFileName
		{
			get { return this.Fields["FileName"]; }
		}
		public IUIField FieldModified
		{
			get { return this.Fields["Modified"]; }
		}
		public IUIField FieldFileSize
		{
			get { return this.Fields["FileSize"]; }
		}
		public IUIField FieldIsHave
		{
			get { return this.Fields["IsHave"]; }
		}


		[Obsolete("请使用CurrentFilter属性，这个方法有可能会导致强弱类型转换出错")]
		public ViewLogViewerDefaultFilterFilter DefaultFilter
		{
			get { return (ViewLogViewerDefaultFilterFilter)this.CurrentFilter; }
		}
		#endregion

		#region Init
		private void InitClass()
		{
			UIModelRuntimeFactory.AddNewUIField(this,"ID", typeof(Int64), false,"","System.Int64", "", false,false, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","bc226b54-44e4-4265-8bd7-21fc88490da1");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedOn", typeof(DateTime), false,"","System.DateTime", "", false,false, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","b01d7d62-6a9a-46e7-83bc-ec4198b94eb1");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedBy", typeof(String), false,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","944aaebd-d4a7-4984-b719-37efecb98c65");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedOn", typeof(DateTime), false,"","System.DateTime", "", false,false, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","998e254d-d090-4270-92e1-5bfc5c16527e");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedBy", typeof(String), false,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","143d972c-fe02-45ef-a5fa-6cbcb569129a");
			UIModelRuntimeFactory.AddNewUIField(this,"SysVersion", typeof(Int64), false,"","System.Int64", "", false,false, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","effe9c94-95d7-483a-be7c-844857178557");
			UIModelRuntimeFactory.AddNewUIField(this,"FileName", typeof(String), true,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","037797a1-e033-4b0d-8c0c-42733ce362da");
			UIModelRuntimeFactory.AddNewUIField(this,"Modified", typeof(DateTime), true,"2005-1-1 00:00:00","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","e8fa5a04-0f81-4ec2-a6fa-7a8f09e79347");
			UIModelRuntimeFactory.AddNewUIField(this,"FileSize", typeof(String), true,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","c75b1eb8-f2f0-4bdb-9a80-f986e7a7de4d");
			UIModelRuntimeFactory.AddNewUIField(this,"IsHave", typeof(Boolean), true,"","System.Boolean", "", false,false, false, "",false,(UIFieldType)1,"5efeea06-cae7-4cc0-82e9-20a789e4e582","a19ebb2a-080a-45c0-b8b1-cdc81eec7c34");


			this.CurrentFilter = new ViewLogViewerDefaultFilterFilter(this);
		}
		#endregion
		
		#region override method
		protected override IUIRecord BuildNewRecord(IUIRecordBuilder builder)
		{
			return new ViewLogViewerRecord(builder);
		}
		#endregion

		#region new method
		public new ViewLogViewerRecord FocusedRecord
		{
			get { return (ViewLogViewerRecord)base.FocusedRecord ; }
			set { base.FocusedRecord = value ; }
		}
		public new ViewLogViewerRecord AddNewUIRecord()
		{	
			return (ViewLogViewerRecord)base.AddNewUIRecord();
		}
		public new ViewLogViewerRecord NewUIRecord()
		{	
			return (ViewLogViewerRecord)base.NewUIRecord();
		}
		#endregion 

	}

	[Serializable]
	public class ViewLogViewerRecord : UIRecord
	{
		#region Constructor
		public ViewLogViewerRecord(IUIRecordBuilder builder):base(builder)
		{
		}
		private ViewLogViewerView uiviewViewLogViewer
		{
			get { return (ViewLogViewerView)this.ContainerView; }
		}
		protected override IUIRecord CreateCloneInstance(IUIRecordBuilder builder)
		{
			return new ViewLogViewerRecord(builder);
		}
		#endregion

		#region property
		
		
		public  Int64 ID
		{
			get{
				//object value = this[this.uiviewViewLogViewer.FieldID] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewViewLogViewer.FieldID);
			}
			set{
				this[this.uiviewViewLogViewer.FieldID] = value;
			}
		}
		
		
		public  DateTime CreatedOn
		{
			get{
				//object value = this[this.uiviewViewLogViewer.FieldCreatedOn] ;
				//return (DateTime)value;
				return GetValue<DateTime>(this.uiviewViewLogViewer.FieldCreatedOn);
			}
			set{
				this[this.uiviewViewLogViewer.FieldCreatedOn] = value;
			}
		}
		
		
		public  String CreatedBy
		{
			get{
				//object value = this[this.uiviewViewLogViewer.FieldCreatedBy] ;
				//return (String)value;
				return GetValue<String>(this.uiviewViewLogViewer.FieldCreatedBy);
			}
			set{
				this[this.uiviewViewLogViewer.FieldCreatedBy] = value;
			}
		}
		
		
		public  DateTime ModifiedOn
		{
			get{
				//object value = this[this.uiviewViewLogViewer.FieldModifiedOn] ;
				//return (DateTime)value;
				return GetValue<DateTime>(this.uiviewViewLogViewer.FieldModifiedOn);
			}
			set{
				this[this.uiviewViewLogViewer.FieldModifiedOn] = value;
			}
		}
		
		
		public  String ModifiedBy
		{
			get{
				//object value = this[this.uiviewViewLogViewer.FieldModifiedBy] ;
				//return (String)value;
				return GetValue<String>(this.uiviewViewLogViewer.FieldModifiedBy);
			}
			set{
				this[this.uiviewViewLogViewer.FieldModifiedBy] = value;
			}
		}
		
		
		public new Int64 SysVersion
		{
			get{
				//object value = this[this.uiviewViewLogViewer.FieldSysVersion] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewViewLogViewer.FieldSysVersion);
			}
			set{
				this[this.uiviewViewLogViewer.FieldSysVersion] = value;
			}
		}
		
		
		public  String FileName
		{
			get{
				//object value = this[this.uiviewViewLogViewer.FieldFileName] ;
				//return (String)value;
				return GetValue<String>(this.uiviewViewLogViewer.FieldFileName);
			}
			set{
				this[this.uiviewViewLogViewer.FieldFileName] = value;
			}
		}
		
		
		public  DateTime? Modified
		{
			get{
				//object value = this[this.uiviewViewLogViewer.FieldModified] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewViewLogViewer.FieldModified);
			}
			set{
				this[this.uiviewViewLogViewer.FieldModified] = value;
			}
		}
		
		
		public  String FileSize
		{
			get{
				//object value = this[this.uiviewViewLogViewer.FieldFileSize] ;
				//return (String)value;
				return GetValue<String>(this.uiviewViewLogViewer.FieldFileSize);
			}
			set{
				this[this.uiviewViewLogViewer.FieldFileSize] = value;
			}
		}
		
		
		public  Boolean? IsHave
		{
			get{
				//object value = this[this.uiviewViewLogViewer.FieldIsHave] ;
				//return (Boolean?)value;
				return GetValue<Boolean?>(this.uiviewViewLogViewer.FieldIsHave);
			}
			set{
				this[this.uiviewViewLogViewer.FieldIsHave] = value;
			}
		}
		#endregion
	}
	
	[Serializable]
	public class ViewLogViewerDefaultFilterFilter : UIFilter
	{
		#region Constructor
		public ViewLogViewerDefaultFilterFilter(IUIView view) 
			: base("DefaultFilter",view,@"",@"")
		{
			InitClass();
		}
		//for Clone Constructor
		private ViewLogViewerDefaultFilterFilter()
			: base("DefaultFilter",null,"","")
		{}
		protected override IUIFilter CreateCloneInstance()
		{
			return new ViewLogViewerDefaultFilterFilter();
		}
		#endregion

		#region property
		#endregion
		
		#region function
		private void InitClass()
		{
		}
		#endregion

	}



	[Serializable]
	public partial class ViewSearchView : UIView
	{
		#region Constructor
		public ViewSearchView(IUIModel model) : base(model,"ViewSearch","", true)
		{
			InitClass();
		}
		//构造空实例,不进行初始化.目前为Clone使用.
		private ViewSearchView():base(null,"ViewSearch","", true)
		{
		}
		protected override IUIView CreateCloneInstance()
		{
			return new ViewSearchView();
		}
		#endregion

		#region fiels property filter
		public IUIField FieldID
		{
			get { return this.Fields["ID"]; }
		}
		public IUIField FieldCreatedOn
		{
			get { return this.Fields["CreatedOn"]; }
		}
		public IUIField FieldCreatedBy
		{
			get { return this.Fields["CreatedBy"]; }
		}
		public IUIField FieldModifiedOn
		{
			get { return this.Fields["ModifiedOn"]; }
		}
		public IUIField FieldModifiedBy
		{
			get { return this.Fields["ModifiedBy"]; }
		}
		public IUIField FieldSysVersion
		{
			get { return this.Fields["SysVersion"]; }
		}
		public IUIField FieldSearchKey
		{
			get { return this.Fields["SearchKey"]; }
		}
		public IUIField FieldFileText
		{
			get { return this.Fields["FileText"]; }
		}


		[Obsolete("请使用CurrentFilter属性，这个方法有可能会导致强弱类型转换出错")]
		public ViewSearchDefaultFilterFilter DefaultFilter
		{
			get { return (ViewSearchDefaultFilterFilter)this.CurrentFilter; }
		}
		#endregion

		#region Init
		private void InitClass()
		{
			UIModelRuntimeFactory.AddNewUIField(this,"ID", typeof(Int64), false,"","System.Int64", "", false,false, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","e300cb85-b583-42c8-9718-be4d412f7c70");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedOn", typeof(DateTime), false,"","System.DateTime", "", false,false, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","b4d28b02-f640-415f-9792-39273e711415");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedBy", typeof(String), false,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","d2734ed2-e0c9-415b-aae5-f3e762d08bb0");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedOn", typeof(DateTime), false,"","System.DateTime", "", false,false, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","f6605a73-9400-4202-8b48-bb2f51086bfb");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedBy", typeof(String), false,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","bc1d2344-a86d-4c09-971f-45eef61d6570");
			UIModelRuntimeFactory.AddNewUIField(this,"SysVersion", typeof(Int64), false,"","System.Int64", "", false,false, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","aec5bd44-5eb0-488a-929b-128a784b84cb");
			UIModelRuntimeFactory.AddNewUIField(this,"SearchKey", typeof(String), true,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","c4f47877-b18a-4f36-88cc-621b7d3bd6f5");
			UIModelRuntimeFactory.AddNewUIField(this,"FileText", typeof(String), true,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","b2cd6c4a-99ed-4249-847f-ce6f40400407");


			this.CurrentFilter = new ViewSearchDefaultFilterFilter(this);
		}
		#endregion
		
		#region override method
		protected override IUIRecord BuildNewRecord(IUIRecordBuilder builder)
		{
			return new ViewSearchRecord(builder);
		}
		#endregion

		#region new method
		public new ViewSearchRecord FocusedRecord
		{
			get { return (ViewSearchRecord)base.FocusedRecord ; }
			set { base.FocusedRecord = value ; }
		}
		public new ViewSearchRecord AddNewUIRecord()
		{	
			return (ViewSearchRecord)base.AddNewUIRecord();
		}
		public new ViewSearchRecord NewUIRecord()
		{	
			return (ViewSearchRecord)base.NewUIRecord();
		}
		#endregion 

	}

	[Serializable]
	public class ViewSearchRecord : UIRecord
	{
		#region Constructor
		public ViewSearchRecord(IUIRecordBuilder builder):base(builder)
		{
		}
		private ViewSearchView uiviewViewSearch
		{
			get { return (ViewSearchView)this.ContainerView; }
		}
		protected override IUIRecord CreateCloneInstance(IUIRecordBuilder builder)
		{
			return new ViewSearchRecord(builder);
		}
		#endregion

		#region property
		
		
		public  Int64 ID
		{
			get{
				//object value = this[this.uiviewViewSearch.FieldID] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewViewSearch.FieldID);
			}
			set{
				this[this.uiviewViewSearch.FieldID] = value;
			}
		}
		
		
		public  DateTime CreatedOn
		{
			get{
				//object value = this[this.uiviewViewSearch.FieldCreatedOn] ;
				//return (DateTime)value;
				return GetValue<DateTime>(this.uiviewViewSearch.FieldCreatedOn);
			}
			set{
				this[this.uiviewViewSearch.FieldCreatedOn] = value;
			}
		}
		
		
		public  String CreatedBy
		{
			get{
				//object value = this[this.uiviewViewSearch.FieldCreatedBy] ;
				//return (String)value;
				return GetValue<String>(this.uiviewViewSearch.FieldCreatedBy);
			}
			set{
				this[this.uiviewViewSearch.FieldCreatedBy] = value;
			}
		}
		
		
		public  DateTime ModifiedOn
		{
			get{
				//object value = this[this.uiviewViewSearch.FieldModifiedOn] ;
				//return (DateTime)value;
				return GetValue<DateTime>(this.uiviewViewSearch.FieldModifiedOn);
			}
			set{
				this[this.uiviewViewSearch.FieldModifiedOn] = value;
			}
		}
		
		
		public  String ModifiedBy
		{
			get{
				//object value = this[this.uiviewViewSearch.FieldModifiedBy] ;
				//return (String)value;
				return GetValue<String>(this.uiviewViewSearch.FieldModifiedBy);
			}
			set{
				this[this.uiviewViewSearch.FieldModifiedBy] = value;
			}
		}
		
		
		public new Int64 SysVersion
		{
			get{
				//object value = this[this.uiviewViewSearch.FieldSysVersion] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewViewSearch.FieldSysVersion);
			}
			set{
				this[this.uiviewViewSearch.FieldSysVersion] = value;
			}
		}
		
		
		public  String SearchKey
		{
			get{
				//object value = this[this.uiviewViewSearch.FieldSearchKey] ;
				//return (String)value;
				return GetValue<String>(this.uiviewViewSearch.FieldSearchKey);
			}
			set{
				this[this.uiviewViewSearch.FieldSearchKey] = value;
			}
		}
		
		
		public  String FileText
		{
			get{
				//object value = this[this.uiviewViewSearch.FieldFileText] ;
				//return (String)value;
				return GetValue<String>(this.uiviewViewSearch.FieldFileText);
			}
			set{
				this[this.uiviewViewSearch.FieldFileText] = value;
			}
		}
		#endregion
	}
	
	[Serializable]
	public class ViewSearchDefaultFilterFilter : UIFilter
	{
		#region Constructor
		public ViewSearchDefaultFilterFilter(IUIView view) 
			: base("DefaultFilter",view,@"",@"")
		{
			InitClass();
		}
		//for Clone Constructor
		private ViewSearchDefaultFilterFilter()
			: base("DefaultFilter",null,"","")
		{}
		protected override IUIFilter CreateCloneInstance()
		{
			return new ViewSearchDefaultFilterFilter();
		}
		#endregion

		#region property
		#endregion
		
		#region function
		private void InitClass()
		{
		}
		#endregion

	}



}