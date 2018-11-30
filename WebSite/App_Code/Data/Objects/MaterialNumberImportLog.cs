using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace MyCompany.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class MaterialNumberImportLog
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _logId;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _autoId;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _soldtoParty;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _shiptoParty;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _customerItemNumber;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _massPartsIDFlag;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _expansionKey1;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _expansionKey2;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _expansionKey3;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _varidityDateTo;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _validitydateFrom;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _pLANT;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _materialNumber;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _unitCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _status;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _executeDate;
        
        public MaterialNumberImportLog()
        {
        }
        
        [System.ComponentModel.DataObjectField(true, true, false)]
        public decimal? LogId
        {
            get
            {
                return _logId;
            }
            set
            {
                _logId = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
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
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string SoldtoParty
        {
            get
            {
                return _soldtoParty;
            }
            set
            {
                _soldtoParty = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string ShiptoParty
        {
            get
            {
                return _shiptoParty;
            }
            set
            {
                _shiptoParty = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CustomerItemNumber
        {
            get
            {
                return _customerItemNumber;
            }
            set
            {
                _customerItemNumber = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string MassPartsIDFlag
        {
            get
            {
                return _massPartsIDFlag;
            }
            set
            {
                _massPartsIDFlag = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string ExpansionKey1
        {
            get
            {
                return _expansionKey1;
            }
            set
            {
                _expansionKey1 = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string ExpansionKey2
        {
            get
            {
                return _expansionKey2;
            }
            set
            {
                _expansionKey2 = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string ExpansionKey3
        {
            get
            {
                return _expansionKey3;
            }
            set
            {
                _expansionKey3 = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string VaridityDateTo
        {
            get
            {
                return _varidityDateTo;
            }
            set
            {
                _varidityDateTo = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string ValiditydateFrom
        {
            get
            {
                return _validitydateFrom;
            }
            set
            {
                _validitydateFrom = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string PLANT
        {
            get
            {
                return _pLANT;
            }
            set
            {
                _pLANT = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string MaterialNumber
        {
            get
            {
                return _materialNumber;
            }
            set
            {
                _materialNumber = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string UnitCode
        {
            get
            {
                return _unitCode;
            }
            set
            {
                _unitCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Status
        {
            get
            {
                return _status;
            }
            set
            {
                _status = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
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
        
        public static List<MyCompany.Data.Objects.MaterialNumberImportLog> Select(
                    decimal? logId, 
                    int? autoId, 
                    string soldtoParty, 
                    string shiptoParty, 
                    string customerItemNumber, 
                    string massPartsIDFlag, 
                    string expansionKey1, 
                    string expansionKey2, 
                    string expansionKey3, 
                    string varidityDateTo, 
                    string validitydateFrom, 
                    string pLANT, 
                    string materialNumber, 
                    string unitCode, 
                    string status, 
                    DateTime? executeDate)
        {
            return new MaterialNumberImportLogFactory().Select(logId, autoId, soldtoParty, shiptoParty, customerItemNumber, massPartsIDFlag, expansionKey1, expansionKey2, expansionKey3, varidityDateTo, validitydateFrom, pLANT, materialNumber, unitCode, status, executeDate);
        }
        
        public static List<MyCompany.Data.Objects.MaterialNumberImportLog> Select(MyCompany.Data.Objects.MaterialNumberImportLog qbe)
        {
            return new MaterialNumberImportLogFactory().Select(qbe);
        }
        
        public static List<MyCompany.Data.Objects.MaterialNumberImportLog> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new MaterialNumberImportLogFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.MaterialNumberImportLog> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new MaterialNumberImportLogFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<MyCompany.Data.Objects.MaterialNumberImportLog> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new MaterialNumberImportLogFactory().Select(filter, sort, MaterialNumberImportLogFactory.SelectView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.MaterialNumberImportLog> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new MaterialNumberImportLogFactory().Select(filter, sort, MaterialNumberImportLogFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<MyCompany.Data.Objects.MaterialNumberImportLog> Select(string filter, BusinessObjectParameters parameters)
        {
            return new MaterialNumberImportLogFactory().Select(filter, null, MaterialNumberImportLogFactory.SelectView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.MaterialNumberImportLog> Select(string filter, params FieldValue[] parameters)
        {
            return new MaterialNumberImportLogFactory().Select(filter, null, MaterialNumberImportLogFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static MyCompany.Data.Objects.MaterialNumberImportLog SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new MaterialNumberImportLogFactory().SelectSingle(filter, parameters);
        }
        
        public static MyCompany.Data.Objects.MaterialNumberImportLog SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new MaterialNumberImportLogFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static MyCompany.Data.Objects.MaterialNumberImportLog SelectSingle(decimal? logId)
        {
            return new MaterialNumberImportLogFactory().SelectSingle(logId);
        }
        
        public int Insert()
        {
            return new MaterialNumberImportLogFactory().Insert(this);
        }
        
        public int Update()
        {
            return new MaterialNumberImportLogFactory().Update(this);
        }
        
        public int Delete()
        {
            return new MaterialNumberImportLogFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("LogId: {0}", this.LogId);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class MaterialNumberImportLogFactory
    {
        
        public MaterialNumberImportLogFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("MaterialNumberImportLog");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("MaterialNumberImportLog");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("MaterialNumberImportLog");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("MaterialNumberImportLog");
            }
        }
        
        public static MaterialNumberImportLogFactory Create()
        {
            return new MaterialNumberImportLogFactory();
        }
        
        protected virtual PageRequest CreateRequest(
                    decimal? logId, 
                    int? autoId, 
                    string soldtoParty, 
                    string shiptoParty, 
                    string customerItemNumber, 
                    string massPartsIDFlag, 
                    string expansionKey1, 
                    string expansionKey2, 
                    string expansionKey3, 
                    string varidityDateTo, 
                    string validitydateFrom, 
                    string pLANT, 
                    string materialNumber, 
                    string unitCode, 
                    string status, 
                    DateTime? executeDate, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (logId.HasValue)
            	filter.Add(("LogId:=" + logId.Value.ToString()));
            if (autoId.HasValue)
            	filter.Add(("AutoId:=" + autoId.Value.ToString()));
            if (!(String.IsNullOrEmpty(soldtoParty)))
            	filter.Add(("SoldtoParty:*" + soldtoParty));
            if (!(String.IsNullOrEmpty(shiptoParty)))
            	filter.Add(("ShiptoParty:*" + shiptoParty));
            if (!(String.IsNullOrEmpty(customerItemNumber)))
            	filter.Add(("CustomerItemNumber:*" + customerItemNumber));
            if (!(String.IsNullOrEmpty(massPartsIDFlag)))
            	filter.Add(("MassPartsIDFlag:*" + massPartsIDFlag));
            if (!(String.IsNullOrEmpty(expansionKey1)))
            	filter.Add(("ExpansionKey1:*" + expansionKey1));
            if (!(String.IsNullOrEmpty(expansionKey2)))
            	filter.Add(("ExpansionKey2:*" + expansionKey2));
            if (!(String.IsNullOrEmpty(expansionKey3)))
            	filter.Add(("ExpansionKey3:*" + expansionKey3));
            if (!(String.IsNullOrEmpty(varidityDateTo)))
            	filter.Add(("VaridityDateTo:*" + varidityDateTo));
            if (!(String.IsNullOrEmpty(validitydateFrom)))
            	filter.Add(("ValiditydateFrom:*" + validitydateFrom));
            if (!(String.IsNullOrEmpty(pLANT)))
            	filter.Add(("PLANT:*" + pLANT));
            if (!(String.IsNullOrEmpty(materialNumber)))
            	filter.Add(("MaterialNumber:*" + materialNumber));
            if (!(String.IsNullOrEmpty(unitCode)))
            	filter.Add(("UnitCode:*" + unitCode));
            if (!(String.IsNullOrEmpty(status)))
            	filter.Add(("Status:*" + status));
            if (executeDate.HasValue)
            	filter.Add(("ExecuteDate:=" + executeDate.Value.ToString()));
            return new PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray());
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public List<MyCompany.Data.Objects.MaterialNumberImportLog> Select(
                    decimal? logId, 
                    int? autoId, 
                    string soldtoParty, 
                    string shiptoParty, 
                    string customerItemNumber, 
                    string massPartsIDFlag, 
                    string expansionKey1, 
                    string expansionKey2, 
                    string expansionKey3, 
                    string varidityDateTo, 
                    string validitydateFrom, 
                    string pLANT, 
                    string materialNumber, 
                    string unitCode, 
                    string status, 
                    DateTime? executeDate, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex, 
                    string dataView)
        {
            PageRequest request = CreateRequest(logId, autoId, soldtoParty, shiptoParty, customerItemNumber, massPartsIDFlag, expansionKey1, expansionKey2, expansionKey3, varidityDateTo, validitydateFrom, pLANT, materialNumber, unitCode, status, executeDate, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("MaterialNumberImportLog", dataView, request);
            return page.ToList<MyCompany.Data.Objects.MaterialNumberImportLog>();
        }
        
        public List<MyCompany.Data.Objects.MaterialNumberImportLog> Select(MyCompany.Data.Objects.MaterialNumberImportLog qbe)
        {
            return Select(qbe.LogId, qbe.AutoId, qbe.SoldtoParty, qbe.ShiptoParty, qbe.CustomerItemNumber, qbe.MassPartsIDFlag, qbe.ExpansionKey1, qbe.ExpansionKey2, qbe.ExpansionKey3, qbe.VaridityDateTo, qbe.ValiditydateFrom, qbe.PLANT, qbe.MaterialNumber, qbe.UnitCode, qbe.Status, qbe.ExecuteDate);
        }
        
        public int SelectCount(
                    decimal? logId, 
                    int? autoId, 
                    string soldtoParty, 
                    string shiptoParty, 
                    string customerItemNumber, 
                    string massPartsIDFlag, 
                    string expansionKey1, 
                    string expansionKey2, 
                    string expansionKey3, 
                    string varidityDateTo, 
                    string validitydateFrom, 
                    string pLANT, 
                    string materialNumber, 
                    string unitCode, 
                    string status, 
                    DateTime? executeDate, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex, 
                    string dataView)
        {
            PageRequest request = CreateRequest(logId, autoId, soldtoParty, shiptoParty, customerItemNumber, massPartsIDFlag, expansionKey1, expansionKey2, expansionKey3, varidityDateTo, validitydateFrom, pLANT, materialNumber, unitCode, status, executeDate, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("MaterialNumberImportLog", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<MyCompany.Data.Objects.MaterialNumberImportLog> Select(
                    decimal? logId, 
                    int? autoId, 
                    string soldtoParty, 
                    string shiptoParty, 
                    string customerItemNumber, 
                    string massPartsIDFlag, 
                    string expansionKey1, 
                    string expansionKey2, 
                    string expansionKey3, 
                    string varidityDateTo, 
                    string validitydateFrom, 
                    string pLANT, 
                    string materialNumber, 
                    string unitCode, 
                    string status, 
                    DateTime? executeDate)
        {
            return Select(logId, autoId, soldtoParty, shiptoParty, customerItemNumber, massPartsIDFlag, expansionKey1, expansionKey2, expansionKey3, varidityDateTo, validitydateFrom, pLANT, materialNumber, unitCode, status, executeDate, null, Int32.MaxValue, 0, SelectView);
        }
        
        public MyCompany.Data.Objects.MaterialNumberImportLog SelectSingle(decimal? logId)
        {
            List<MyCompany.Data.Objects.MaterialNumberImportLog> list = Select(logId, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<MyCompany.Data.Objects.MaterialNumberImportLog> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("MaterialNumberImportLog", dataView, request);
            return page.ToList<MyCompany.Data.Objects.MaterialNumberImportLog>();
        }
        
        public List<MyCompany.Data.Objects.MaterialNumberImportLog> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<MyCompany.Data.Objects.MaterialNumberImportLog> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public MyCompany.Data.Objects.MaterialNumberImportLog SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<MyCompany.Data.Objects.MaterialNumberImportLog> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(MyCompany.Data.Objects.MaterialNumberImportLog theMaterialNumberImportLog, MyCompany.Data.Objects.MaterialNumberImportLog original_MaterialNumberImportLog)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("LogId", original_MaterialNumberImportLog.LogId, theMaterialNumberImportLog.LogId, true));
            values.Add(new FieldValue("AutoId", original_MaterialNumberImportLog.AutoId, theMaterialNumberImportLog.AutoId));
            values.Add(new FieldValue("SoldtoParty", original_MaterialNumberImportLog.SoldtoParty, theMaterialNumberImportLog.SoldtoParty));
            values.Add(new FieldValue("ShiptoParty", original_MaterialNumberImportLog.ShiptoParty, theMaterialNumberImportLog.ShiptoParty));
            values.Add(new FieldValue("CustomerItemNumber", original_MaterialNumberImportLog.CustomerItemNumber, theMaterialNumberImportLog.CustomerItemNumber));
            values.Add(new FieldValue("MassPartsIDFlag", original_MaterialNumberImportLog.MassPartsIDFlag, theMaterialNumberImportLog.MassPartsIDFlag));
            values.Add(new FieldValue("ExpansionKey1", original_MaterialNumberImportLog.ExpansionKey1, theMaterialNumberImportLog.ExpansionKey1));
            values.Add(new FieldValue("ExpansionKey2", original_MaterialNumberImportLog.ExpansionKey2, theMaterialNumberImportLog.ExpansionKey2));
            values.Add(new FieldValue("ExpansionKey3", original_MaterialNumberImportLog.ExpansionKey3, theMaterialNumberImportLog.ExpansionKey3));
            values.Add(new FieldValue("VaridityDateTo", original_MaterialNumberImportLog.VaridityDateTo, theMaterialNumberImportLog.VaridityDateTo));
            values.Add(new FieldValue("ValiditydateFrom", original_MaterialNumberImportLog.ValiditydateFrom, theMaterialNumberImportLog.ValiditydateFrom));
            values.Add(new FieldValue("PLANT", original_MaterialNumberImportLog.PLANT, theMaterialNumberImportLog.PLANT));
            values.Add(new FieldValue("MaterialNumber", original_MaterialNumberImportLog.MaterialNumber, theMaterialNumberImportLog.MaterialNumber));
            values.Add(new FieldValue("UnitCode", original_MaterialNumberImportLog.UnitCode, theMaterialNumberImportLog.UnitCode));
            values.Add(new FieldValue("Status", original_MaterialNumberImportLog.Status, theMaterialNumberImportLog.Status));
            values.Add(new FieldValue("ExecuteDate", original_MaterialNumberImportLog.ExecuteDate, theMaterialNumberImportLog.ExecuteDate));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(MyCompany.Data.Objects.MaterialNumberImportLog theMaterialNumberImportLog, MyCompany.Data.Objects.MaterialNumberImportLog original_MaterialNumberImportLog, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "MaterialNumberImportLog";
            args.View = dataView;
            args.Values = CreateFieldValues(theMaterialNumberImportLog, original_MaterialNumberImportLog);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("MaterialNumberImportLog", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theMaterialNumberImportLog);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(MyCompany.Data.Objects.MaterialNumberImportLog theMaterialNumberImportLog, MyCompany.Data.Objects.MaterialNumberImportLog original_MaterialNumberImportLog)
        {
            return ExecuteAction(theMaterialNumberImportLog, original_MaterialNumberImportLog, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(MyCompany.Data.Objects.MaterialNumberImportLog theMaterialNumberImportLog)
        {
            return Update(theMaterialNumberImportLog, SelectSingle(theMaterialNumberImportLog.LogId));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(MyCompany.Data.Objects.MaterialNumberImportLog theMaterialNumberImportLog)
        {
            return ExecuteAction(theMaterialNumberImportLog, new MaterialNumberImportLog(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(MyCompany.Data.Objects.MaterialNumberImportLog theMaterialNumberImportLog)
        {
            return ExecuteAction(theMaterialNumberImportLog, theMaterialNumberImportLog, "Select", "Delete", DeleteView);
        }
    }
}
