using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace MyCompany.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class CalDate
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _autoId;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _calDate;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _calDateTypeId;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _calDateTypeCode;
        
        public CalDate()
        {
        }
        
        [System.ComponentModel.DataObjectField(true, true, false)]
        public int? AutoId
        {
            get
            {
                return _autoId;
            }
            set
            {
                _autoId = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public DateTime? CalDate_
        {
            get
            {
                return _calDate;
            }
            set
            {
                _calDate = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
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
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CalDateTypeCode
        {
            get
            {
                return _calDateTypeCode;
            }
            set
            {
                _calDateTypeCode = value;
            }
        }
        
        public static List<MyCompany.Data.Objects.CalDate> Select(int? autoId, DateTime? calDate, int? calDateTypeId, string calDateTypeCode)
        {
            return new CalDateFactory().Select(autoId, calDate, calDateTypeId, calDateTypeCode);
        }
        
        public static List<MyCompany.Data.Objects.CalDate> Select(MyCompany.Data.Objects.CalDate qbe)
        {
            return new CalDateFactory().Select(qbe);
        }
        
        public static List<MyCompany.Data.Objects.CalDate> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new CalDateFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.CalDate> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new CalDateFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<MyCompany.Data.Objects.CalDate> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new CalDateFactory().Select(filter, sort, CalDateFactory.SelectView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.CalDate> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new CalDateFactory().Select(filter, sort, CalDateFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<MyCompany.Data.Objects.CalDate> Select(string filter, BusinessObjectParameters parameters)
        {
            return new CalDateFactory().Select(filter, null, CalDateFactory.SelectView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.CalDate> Select(string filter, params FieldValue[] parameters)
        {
            return new CalDateFactory().Select(filter, null, CalDateFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static MyCompany.Data.Objects.CalDate SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new CalDateFactory().SelectSingle(filter, parameters);
        }
        
        public static MyCompany.Data.Objects.CalDate SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new CalDateFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static MyCompany.Data.Objects.CalDate SelectSingle(int? autoId)
        {
            return new CalDateFactory().SelectSingle(autoId);
        }
        
        public int Insert()
        {
            return new CalDateFactory().Insert(this);
        }
        
        public int Update()
        {
            return new CalDateFactory().Update(this);
        }
        
        public int Delete()
        {
            return new CalDateFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("AutoId: {0}", this.AutoId);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class CalDateFactory
    {
        
        public CalDateFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("CalDate");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("CalDate");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("CalDate");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("CalDate");
            }
        }
        
        public static CalDateFactory Create()
        {
            return new CalDateFactory();
        }
        
        protected virtual PageRequest CreateRequest(int? autoId, DateTime? calDate, int? calDateTypeId, string calDateTypeCode, string sort, int maximumRows, int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (autoId.HasValue)
            	filter.Add(("AutoId:=" + autoId.Value.ToString()));
            if (calDate.HasValue)
            	filter.Add(("CalDate:=" + calDate.Value.ToString()));
            if (calDateTypeId.HasValue)
            	filter.Add(("CalDateTypeId:=" + calDateTypeId.Value.ToString()));
            if (!(String.IsNullOrEmpty(calDateTypeCode)))
            	filter.Add(("CalDateTypeCode:*" + calDateTypeCode));
            return new PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray());
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public List<MyCompany.Data.Objects.CalDate> Select(int? autoId, DateTime? calDate, int? calDateTypeId, string calDateTypeCode, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(autoId, calDate, calDateTypeId, calDateTypeCode, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("CalDate", dataView, request);
            return page.ToList<MyCompany.Data.Objects.CalDate>();
        }
        
        public List<MyCompany.Data.Objects.CalDate> Select(MyCompany.Data.Objects.CalDate qbe)
        {
            return Select(qbe.AutoId, qbe.CalDate_, qbe.CalDateTypeId, qbe.CalDateTypeCode);
        }
        
        public int SelectCount(int? autoId, DateTime? calDate, int? calDateTypeId, string calDateTypeCode, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(autoId, calDate, calDateTypeId, calDateTypeCode, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("CalDate", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<MyCompany.Data.Objects.CalDate> Select(int? autoId, DateTime? calDate, int? calDateTypeId, string calDateTypeCode)
        {
            return Select(autoId, calDate, calDateTypeId, calDateTypeCode, null, Int32.MaxValue, 0, SelectView);
        }
        
        public MyCompany.Data.Objects.CalDate SelectSingle(int? autoId)
        {
            DateTime? emptyCalDate = null;
            int? emptyCalDateTypeId = null;
            string emptyCalDateTypeCode = null;
            List<MyCompany.Data.Objects.CalDate> list = Select(autoId, emptyCalDate, emptyCalDateTypeId, emptyCalDateTypeCode);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<MyCompany.Data.Objects.CalDate> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("CalDate", dataView, request);
            return page.ToList<MyCompany.Data.Objects.CalDate>();
        }
        
        public List<MyCompany.Data.Objects.CalDate> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<MyCompany.Data.Objects.CalDate> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public MyCompany.Data.Objects.CalDate SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<MyCompany.Data.Objects.CalDate> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(MyCompany.Data.Objects.CalDate theCalDate, MyCompany.Data.Objects.CalDate original_CalDate)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("AutoId", original_CalDate.AutoId, theCalDate.AutoId, true));
            values.Add(new FieldValue("CalDate", original_CalDate.CalDate_, theCalDate.CalDate_));
            values.Add(new FieldValue("CalDateTypeId", original_CalDate.CalDateTypeId, theCalDate.CalDateTypeId));
            values.Add(new FieldValue("CalDateTypeCode", original_CalDate.CalDateTypeCode, theCalDate.CalDateTypeCode, true));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(MyCompany.Data.Objects.CalDate theCalDate, MyCompany.Data.Objects.CalDate original_CalDate, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "CalDate";
            args.View = dataView;
            args.Values = CreateFieldValues(theCalDate, original_CalDate);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("CalDate", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theCalDate);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(MyCompany.Data.Objects.CalDate theCalDate, MyCompany.Data.Objects.CalDate original_CalDate)
        {
            return ExecuteAction(theCalDate, original_CalDate, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(MyCompany.Data.Objects.CalDate theCalDate)
        {
            return Update(theCalDate, SelectSingle(theCalDate.AutoId));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(MyCompany.Data.Objects.CalDate theCalDate)
        {
            return ExecuteAction(theCalDate, new CalDate(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(MyCompany.Data.Objects.CalDate theCalDate)
        {
            return ExecuteAction(theCalDate, theCalDate, "Select", "Delete", DeleteView);
        }
    }
}
