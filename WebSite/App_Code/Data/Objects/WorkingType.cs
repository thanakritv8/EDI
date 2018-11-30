using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace MyCompany.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class WorkingType
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _workTypeId;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _code;
        
        public WorkingType()
        {
        }
        
        [System.ComponentModel.DataObjectField(true, false, false)]
        public int? WorkTypeId
        {
            get
            {
                return _workTypeId;
            }
            set
            {
                _workTypeId = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public string Code
        {
            get
            {
                return _code;
            }
            set
            {
                _code = value;
            }
        }
        
        public static List<MyCompany.Data.Objects.WorkingType> Select(int? workTypeId, string code)
        {
            return new WorkingTypeFactory().Select(workTypeId, code);
        }
        
        public static List<MyCompany.Data.Objects.WorkingType> Select(MyCompany.Data.Objects.WorkingType qbe)
        {
            return new WorkingTypeFactory().Select(qbe);
        }
        
        public static List<MyCompany.Data.Objects.WorkingType> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new WorkingTypeFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.WorkingType> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new WorkingTypeFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<MyCompany.Data.Objects.WorkingType> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new WorkingTypeFactory().Select(filter, sort, WorkingTypeFactory.SelectView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.WorkingType> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new WorkingTypeFactory().Select(filter, sort, WorkingTypeFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<MyCompany.Data.Objects.WorkingType> Select(string filter, BusinessObjectParameters parameters)
        {
            return new WorkingTypeFactory().Select(filter, null, WorkingTypeFactory.SelectView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.WorkingType> Select(string filter, params FieldValue[] parameters)
        {
            return new WorkingTypeFactory().Select(filter, null, WorkingTypeFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static MyCompany.Data.Objects.WorkingType SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new WorkingTypeFactory().SelectSingle(filter, parameters);
        }
        
        public static MyCompany.Data.Objects.WorkingType SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new WorkingTypeFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static MyCompany.Data.Objects.WorkingType SelectSingle(int? workTypeId)
        {
            return new WorkingTypeFactory().SelectSingle(workTypeId);
        }
        
        public int Insert()
        {
            return new WorkingTypeFactory().Insert(this);
        }
        
        public int Update()
        {
            return new WorkingTypeFactory().Update(this);
        }
        
        public int Delete()
        {
            return new WorkingTypeFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("WorkTypeId: {0}", this.WorkTypeId);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class WorkingTypeFactory
    {
        
        public WorkingTypeFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("WorkingType");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("WorkingType");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("WorkingType");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("WorkingType");
            }
        }
        
        public static WorkingTypeFactory Create()
        {
            return new WorkingTypeFactory();
        }
        
        protected virtual PageRequest CreateRequest(int? workTypeId, string code, string sort, int maximumRows, int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (workTypeId.HasValue)
            	filter.Add(("WorkTypeId:=" + workTypeId.Value.ToString()));
            if (!(String.IsNullOrEmpty(code)))
            	filter.Add(("Code:*" + code));
            return new PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray());
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public List<MyCompany.Data.Objects.WorkingType> Select(int? workTypeId, string code, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(workTypeId, code, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("WorkingType", dataView, request);
            return page.ToList<MyCompany.Data.Objects.WorkingType>();
        }
        
        public List<MyCompany.Data.Objects.WorkingType> Select(MyCompany.Data.Objects.WorkingType qbe)
        {
            return Select(qbe.WorkTypeId, qbe.Code);
        }
        
        public int SelectCount(int? workTypeId, string code, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(workTypeId, code, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("WorkingType", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<MyCompany.Data.Objects.WorkingType> Select(int? workTypeId, string code)
        {
            return Select(workTypeId, code, null, Int32.MaxValue, 0, SelectView);
        }
        
        public MyCompany.Data.Objects.WorkingType SelectSingle(int? workTypeId)
        {
            string emptyCode = null;
            List<MyCompany.Data.Objects.WorkingType> list = Select(workTypeId, emptyCode);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<MyCompany.Data.Objects.WorkingType> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("WorkingType", dataView, request);
            return page.ToList<MyCompany.Data.Objects.WorkingType>();
        }
        
        public List<MyCompany.Data.Objects.WorkingType> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<MyCompany.Data.Objects.WorkingType> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public MyCompany.Data.Objects.WorkingType SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<MyCompany.Data.Objects.WorkingType> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(MyCompany.Data.Objects.WorkingType theWorkingType, MyCompany.Data.Objects.WorkingType original_WorkingType)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("WorkTypeId", original_WorkingType.WorkTypeId, theWorkingType.WorkTypeId));
            values.Add(new FieldValue("Code", original_WorkingType.Code, theWorkingType.Code));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(MyCompany.Data.Objects.WorkingType theWorkingType, MyCompany.Data.Objects.WorkingType original_WorkingType, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "WorkingType";
            args.View = dataView;
            args.Values = CreateFieldValues(theWorkingType, original_WorkingType);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("WorkingType", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theWorkingType);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(MyCompany.Data.Objects.WorkingType theWorkingType, MyCompany.Data.Objects.WorkingType original_WorkingType)
        {
            return ExecuteAction(theWorkingType, original_WorkingType, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(MyCompany.Data.Objects.WorkingType theWorkingType)
        {
            return Update(theWorkingType, SelectSingle(theWorkingType.WorkTypeId));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(MyCompany.Data.Objects.WorkingType theWorkingType)
        {
            return ExecuteAction(theWorkingType, new WorkingType(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(MyCompany.Data.Objects.WorkingType theWorkingType)
        {
            return ExecuteAction(theWorkingType, theWorkingType, "Select", "Delete", DeleteView);
        }
    }
}
