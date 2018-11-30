using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace MyCompany.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class WorkingDate
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _autoId;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _workDate;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _statusId;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _workTypeId;
        
        public WorkingDate()
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
        public DateTime? WorkDate
        {
            get
            {
                return _workDate;
            }
            set
            {
                _workDate = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public bool? StatusId
        {
            get
            {
                return _statusId;
            }
            set
            {
                _statusId = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
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
        
        public static List<MyCompany.Data.Objects.WorkingDate> Select(int? autoId, DateTime? workDate, bool? statusId, int? workTypeId)
        {
            return new WorkingDateFactory().Select(autoId, workDate, statusId, workTypeId);
        }
        
        public static List<MyCompany.Data.Objects.WorkingDate> Select(MyCompany.Data.Objects.WorkingDate qbe)
        {
            return new WorkingDateFactory().Select(qbe);
        }
        
        public static List<MyCompany.Data.Objects.WorkingDate> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new WorkingDateFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.WorkingDate> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new WorkingDateFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<MyCompany.Data.Objects.WorkingDate> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new WorkingDateFactory().Select(filter, sort, WorkingDateFactory.SelectView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.WorkingDate> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new WorkingDateFactory().Select(filter, sort, WorkingDateFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<MyCompany.Data.Objects.WorkingDate> Select(string filter, BusinessObjectParameters parameters)
        {
            return new WorkingDateFactory().Select(filter, null, WorkingDateFactory.SelectView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.WorkingDate> Select(string filter, params FieldValue[] parameters)
        {
            return new WorkingDateFactory().Select(filter, null, WorkingDateFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static MyCompany.Data.Objects.WorkingDate SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new WorkingDateFactory().SelectSingle(filter, parameters);
        }
        
        public static MyCompany.Data.Objects.WorkingDate SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new WorkingDateFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static MyCompany.Data.Objects.WorkingDate SelectSingle(int? autoId)
        {
            return new WorkingDateFactory().SelectSingle(autoId);
        }
        
        public int Insert()
        {
            return new WorkingDateFactory().Insert(this);
        }
        
        public int Update()
        {
            return new WorkingDateFactory().Update(this);
        }
        
        public int Delete()
        {
            return new WorkingDateFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("AutoId: {0}", this.AutoId);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class WorkingDateFactory
    {
        
        public WorkingDateFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("WorkingDate");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("WorkingDate");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("WorkingDate");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("WorkingDate");
            }
        }
        
        public static WorkingDateFactory Create()
        {
            return new WorkingDateFactory();
        }
        
        protected virtual PageRequest CreateRequest(int? autoId, DateTime? workDate, bool? statusId, int? workTypeId, string sort, int maximumRows, int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (autoId.HasValue)
            	filter.Add(("AutoId:=" + autoId.Value.ToString()));
            if (workDate.HasValue)
            	filter.Add(("WorkDate:=" + workDate.Value.ToString()));
            if (statusId.HasValue)
            	filter.Add(("StatusId:=" + statusId.Value.ToString()));
            if (workTypeId.HasValue)
            	filter.Add(("WorkTypeId:=" + workTypeId.Value.ToString()));
            return new PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray());
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public List<MyCompany.Data.Objects.WorkingDate> Select(int? autoId, DateTime? workDate, bool? statusId, int? workTypeId, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(autoId, workDate, statusId, workTypeId, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("WorkingDate", dataView, request);
            return page.ToList<MyCompany.Data.Objects.WorkingDate>();
        }
        
        public List<MyCompany.Data.Objects.WorkingDate> Select(MyCompany.Data.Objects.WorkingDate qbe)
        {
            return Select(qbe.AutoId, qbe.WorkDate, qbe.StatusId, qbe.WorkTypeId);
        }
        
        public int SelectCount(int? autoId, DateTime? workDate, bool? statusId, int? workTypeId, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(autoId, workDate, statusId, workTypeId, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("WorkingDate", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<MyCompany.Data.Objects.WorkingDate> Select(int? autoId, DateTime? workDate, bool? statusId, int? workTypeId)
        {
            return Select(autoId, workDate, statusId, workTypeId, null, Int32.MaxValue, 0, SelectView);
        }
        
        public MyCompany.Data.Objects.WorkingDate SelectSingle(int? autoId)
        {
            DateTime? emptyWorkDate = null;
            bool? emptyStatusId = null;
            int? emptyWorkTypeId = null;
            List<MyCompany.Data.Objects.WorkingDate> list = Select(autoId, emptyWorkDate, emptyStatusId, emptyWorkTypeId);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<MyCompany.Data.Objects.WorkingDate> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("WorkingDate", dataView, request);
            return page.ToList<MyCompany.Data.Objects.WorkingDate>();
        }
        
        public List<MyCompany.Data.Objects.WorkingDate> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<MyCompany.Data.Objects.WorkingDate> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public MyCompany.Data.Objects.WorkingDate SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<MyCompany.Data.Objects.WorkingDate> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(MyCompany.Data.Objects.WorkingDate theWorkingDate, MyCompany.Data.Objects.WorkingDate original_WorkingDate)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("AutoId", original_WorkingDate.AutoId, theWorkingDate.AutoId, true));
            values.Add(new FieldValue("WorkDate", original_WorkingDate.WorkDate, theWorkingDate.WorkDate));
            values.Add(new FieldValue("StatusId", original_WorkingDate.StatusId, theWorkingDate.StatusId));
            values.Add(new FieldValue("WorkTypeId", original_WorkingDate.WorkTypeId, theWorkingDate.WorkTypeId));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(MyCompany.Data.Objects.WorkingDate theWorkingDate, MyCompany.Data.Objects.WorkingDate original_WorkingDate, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "WorkingDate";
            args.View = dataView;
            args.Values = CreateFieldValues(theWorkingDate, original_WorkingDate);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("WorkingDate", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theWorkingDate);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(MyCompany.Data.Objects.WorkingDate theWorkingDate, MyCompany.Data.Objects.WorkingDate original_WorkingDate)
        {
            return ExecuteAction(theWorkingDate, original_WorkingDate, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(MyCompany.Data.Objects.WorkingDate theWorkingDate)
        {
            return Update(theWorkingDate, SelectSingle(theWorkingDate.AutoId));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(MyCompany.Data.Objects.WorkingDate theWorkingDate)
        {
            return ExecuteAction(theWorkingDate, new WorkingDate(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(MyCompany.Data.Objects.WorkingDate theWorkingDate)
        {
            return ExecuteAction(theWorkingDate, theWorkingDate, "Select", "Delete", DeleteView);
        }
    }
}
