using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace MyCompany.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class CalDateType
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _calDateTypeId;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _code;
        
        public CalDateType()
        {
        }
        
        [System.ComponentModel.DataObjectField(true, false, false)]
        public int? CalDateTypeId
        {
            get
            {
                return _calDateTypeId;
            }
            set
            {
                _calDateTypeId = value;
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
        
        public static List<MyCompany.Data.Objects.CalDateType> Select(int? calDateTypeId, string code)
        {
            return new CalDateTypeFactory().Select(calDateTypeId, code);
        }
        
        public static List<MyCompany.Data.Objects.CalDateType> Select(MyCompany.Data.Objects.CalDateType qbe)
        {
            return new CalDateTypeFactory().Select(qbe);
        }
        
        public static List<MyCompany.Data.Objects.CalDateType> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new CalDateTypeFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.CalDateType> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new CalDateTypeFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<MyCompany.Data.Objects.CalDateType> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new CalDateTypeFactory().Select(filter, sort, CalDateTypeFactory.SelectView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.CalDateType> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new CalDateTypeFactory().Select(filter, sort, CalDateTypeFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<MyCompany.Data.Objects.CalDateType> Select(string filter, BusinessObjectParameters parameters)
        {
            return new CalDateTypeFactory().Select(filter, null, CalDateTypeFactory.SelectView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.CalDateType> Select(string filter, params FieldValue[] parameters)
        {
            return new CalDateTypeFactory().Select(filter, null, CalDateTypeFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static MyCompany.Data.Objects.CalDateType SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new CalDateTypeFactory().SelectSingle(filter, parameters);
        }
        
        public static MyCompany.Data.Objects.CalDateType SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new CalDateTypeFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static MyCompany.Data.Objects.CalDateType SelectSingle(int? calDateTypeId)
        {
            return new CalDateTypeFactory().SelectSingle(calDateTypeId);
        }
        
        public int Insert()
        {
            return new CalDateTypeFactory().Insert(this);
        }
        
        public int Update()
        {
            return new CalDateTypeFactory().Update(this);
        }
        
        public int Delete()
        {
            return new CalDateTypeFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("CalDateTypeId: {0}", this.CalDateTypeId);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class CalDateTypeFactory
    {
        
        public CalDateTypeFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("CalDateType");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("CalDateType");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("CalDateType");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("CalDateType");
            }
        }
        
        public static CalDateTypeFactory Create()
        {
            return new CalDateTypeFactory();
        }
        
        protected virtual PageRequest CreateRequest(int? calDateTypeId, string code, string sort, int maximumRows, int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (calDateTypeId.HasValue)
            	filter.Add(("CalDateTypeId:=" + calDateTypeId.Value.ToString()));
            if (!(String.IsNullOrEmpty(code)))
            	filter.Add(("Code:*" + code));
            return new PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray());
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public List<MyCompany.Data.Objects.CalDateType> Select(int? calDateTypeId, string code, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(calDateTypeId, code, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("CalDateType", dataView, request);
            return page.ToList<MyCompany.Data.Objects.CalDateType>();
        }
        
        public List<MyCompany.Data.Objects.CalDateType> Select(MyCompany.Data.Objects.CalDateType qbe)
        {
            return Select(qbe.CalDateTypeId, qbe.Code);
        }
        
        public int SelectCount(int? calDateTypeId, string code, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(calDateTypeId, code, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("CalDateType", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<MyCompany.Data.Objects.CalDateType> Select(int? calDateTypeId, string code)
        {
            return Select(calDateTypeId, code, null, Int32.MaxValue, 0, SelectView);
        }
        
        public MyCompany.Data.Objects.CalDateType SelectSingle(int? calDateTypeId)
        {
            string emptyCode = null;
            List<MyCompany.Data.Objects.CalDateType> list = Select(calDateTypeId, emptyCode);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<MyCompany.Data.Objects.CalDateType> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("CalDateType", dataView, request);
            return page.ToList<MyCompany.Data.Objects.CalDateType>();
        }
        
        public List<MyCompany.Data.Objects.CalDateType> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<MyCompany.Data.Objects.CalDateType> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public MyCompany.Data.Objects.CalDateType SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<MyCompany.Data.Objects.CalDateType> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(MyCompany.Data.Objects.CalDateType theCalDateType, MyCompany.Data.Objects.CalDateType original_CalDateType)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("CalDateTypeId", original_CalDateType.CalDateTypeId, theCalDateType.CalDateTypeId));
            values.Add(new FieldValue("Code", original_CalDateType.Code, theCalDateType.Code));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(MyCompany.Data.Objects.CalDateType theCalDateType, MyCompany.Data.Objects.CalDateType original_CalDateType, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "CalDateType";
            args.View = dataView;
            args.Values = CreateFieldValues(theCalDateType, original_CalDateType);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("CalDateType", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theCalDateType);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(MyCompany.Data.Objects.CalDateType theCalDateType, MyCompany.Data.Objects.CalDateType original_CalDateType)
        {
            return ExecuteAction(theCalDateType, original_CalDateType, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(MyCompany.Data.Objects.CalDateType theCalDateType)
        {
            return Update(theCalDateType, SelectSingle(theCalDateType.CalDateTypeId));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(MyCompany.Data.Objects.CalDateType theCalDateType)
        {
            return ExecuteAction(theCalDateType, new CalDateType(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(MyCompany.Data.Objects.CalDateType theCalDateType)
        {
            return ExecuteAction(theCalDateType, theCalDateType, "Select", "Delete", DeleteView);
        }
    }
}
