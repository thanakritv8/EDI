using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace MyCompany.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class FilesImport
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _fileId;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _fileName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _customerCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _executeDate;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _executeBy;
        
        public FilesImport()
        {
        }
        
        [System.ComponentModel.DataObjectField(true, true, false)]
        public decimal? FileId
        {
            get
            {
                return _fileId;
            }
            set
            {
                _fileId = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public string FileName
        {
            get
            {
                return _fileName;
            }
            set
            {
                _fileName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public string CustomerCode
        {
            get
            {
                return _customerCode;
            }
            set
            {
                _customerCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public DateTime? ExecuteDate
        {
            get
            {
                return _executeDate;
            }
            set
            {
                _executeDate = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public string ExecuteBy
        {
            get
            {
                return _executeBy;
            }
            set
            {
                _executeBy = value;
            }
        }
        
        public static List<MyCompany.Data.Objects.FilesImport> Select(decimal? fileId, string fileName, string customerCode, DateTime? executeDate, string executeBy)
        {
            return new FilesImportFactory().Select(fileId, fileName, customerCode, executeDate, executeBy);
        }
        
        public static List<MyCompany.Data.Objects.FilesImport> Select(MyCompany.Data.Objects.FilesImport qbe)
        {
            return new FilesImportFactory().Select(qbe);
        }
        
        public static List<MyCompany.Data.Objects.FilesImport> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new FilesImportFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.FilesImport> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new FilesImportFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<MyCompany.Data.Objects.FilesImport> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new FilesImportFactory().Select(filter, sort, FilesImportFactory.SelectView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.FilesImport> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new FilesImportFactory().Select(filter, sort, FilesImportFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<MyCompany.Data.Objects.FilesImport> Select(string filter, BusinessObjectParameters parameters)
        {
            return new FilesImportFactory().Select(filter, null, FilesImportFactory.SelectView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.FilesImport> Select(string filter, params FieldValue[] parameters)
        {
            return new FilesImportFactory().Select(filter, null, FilesImportFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static MyCompany.Data.Objects.FilesImport SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new FilesImportFactory().SelectSingle(filter, parameters);
        }
        
        public static MyCompany.Data.Objects.FilesImport SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new FilesImportFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static MyCompany.Data.Objects.FilesImport SelectSingle(decimal? fileId)
        {
            return new FilesImportFactory().SelectSingle(fileId);
        }
        
        public int Insert()
        {
            return new FilesImportFactory().Insert(this);
        }
        
        public int Update()
        {
            return new FilesImportFactory().Update(this);
        }
        
        public int Delete()
        {
            return new FilesImportFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("FileId: {0}", this.FileId);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class FilesImportFactory
    {
        
        public FilesImportFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("FilesImport");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("FilesImport");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("FilesImport");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("FilesImport");
            }
        }
        
        public static FilesImportFactory Create()
        {
            return new FilesImportFactory();
        }
        
        protected virtual PageRequest CreateRequest(decimal? fileId, string fileName, string customerCode, DateTime? executeDate, string executeBy, string sort, int maximumRows, int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (fileId.HasValue)
            	filter.Add(("FileId:=" + fileId.Value.ToString()));
            if (!(String.IsNullOrEmpty(fileName)))
            	filter.Add(("FileName:*" + fileName));
            if (!(String.IsNullOrEmpty(customerCode)))
            	filter.Add(("CustomerCode:*" + customerCode));
            if (executeDate.HasValue)
            	filter.Add(("ExecuteDate:=" + executeDate.Value.ToString()));
            if (!(String.IsNullOrEmpty(executeBy)))
            	filter.Add(("ExecuteBy:*" + executeBy));
            return new PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray());
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public List<MyCompany.Data.Objects.FilesImport> Select(decimal? fileId, string fileName, string customerCode, DateTime? executeDate, string executeBy, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(fileId, fileName, customerCode, executeDate, executeBy, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("FilesImport", dataView, request);
            return page.ToList<MyCompany.Data.Objects.FilesImport>();
        }
        
        public List<MyCompany.Data.Objects.FilesImport> Select(MyCompany.Data.Objects.FilesImport qbe)
        {
            return Select(qbe.FileId, qbe.FileName, qbe.CustomerCode, qbe.ExecuteDate, qbe.ExecuteBy);
        }
        
        public int SelectCount(decimal? fileId, string fileName, string customerCode, DateTime? executeDate, string executeBy, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(fileId, fileName, customerCode, executeDate, executeBy, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("FilesImport", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<MyCompany.Data.Objects.FilesImport> Select(decimal? fileId, string fileName, string customerCode, DateTime? executeDate, string executeBy)
        {
            return Select(fileId, fileName, customerCode, executeDate, executeBy, null, Int32.MaxValue, 0, SelectView);
        }
        
        public MyCompany.Data.Objects.FilesImport SelectSingle(decimal? fileId)
        {
            List<MyCompany.Data.Objects.FilesImport> list = Select(fileId, null, null, null, null);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<MyCompany.Data.Objects.FilesImport> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("FilesImport", dataView, request);
            return page.ToList<MyCompany.Data.Objects.FilesImport>();
        }
        
        public List<MyCompany.Data.Objects.FilesImport> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<MyCompany.Data.Objects.FilesImport> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public MyCompany.Data.Objects.FilesImport SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<MyCompany.Data.Objects.FilesImport> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(MyCompany.Data.Objects.FilesImport theFilesImport, MyCompany.Data.Objects.FilesImport original_FilesImport)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("FileId", original_FilesImport.FileId, theFilesImport.FileId, true));
            values.Add(new FieldValue("FileName", original_FilesImport.FileName, theFilesImport.FileName));
            values.Add(new FieldValue("CustomerCode", original_FilesImport.CustomerCode, theFilesImport.CustomerCode));
            values.Add(new FieldValue("ExecuteDate", original_FilesImport.ExecuteDate, theFilesImport.ExecuteDate));
            values.Add(new FieldValue("ExecuteBy", original_FilesImport.ExecuteBy, theFilesImport.ExecuteBy));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(MyCompany.Data.Objects.FilesImport theFilesImport, MyCompany.Data.Objects.FilesImport original_FilesImport, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "FilesImport";
            args.View = dataView;
            args.Values = CreateFieldValues(theFilesImport, original_FilesImport);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("FilesImport", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theFilesImport);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(MyCompany.Data.Objects.FilesImport theFilesImport, MyCompany.Data.Objects.FilesImport original_FilesImport)
        {
            return ExecuteAction(theFilesImport, original_FilesImport, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(MyCompany.Data.Objects.FilesImport theFilesImport)
        {
            return Update(theFilesImport, SelectSingle(theFilesImport.FileId));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(MyCompany.Data.Objects.FilesImport theFilesImport)
        {
            return ExecuteAction(theFilesImport, new FilesImport(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(MyCompany.Data.Objects.FilesImport theFilesImport)
        {
            return ExecuteAction(theFilesImport, theFilesImport, "Select", "Delete", DeleteView);
        }
    }
}
