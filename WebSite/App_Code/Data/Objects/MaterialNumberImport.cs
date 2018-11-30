using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace MyCompany.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class MaterialNumberImport
    {
        
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
        
        public MaterialNumberImport()
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
        
        public static List<MyCompany.Data.Objects.MaterialNumberImport> Select(int? autoId, string soldtoParty, string shiptoParty, string customerItemNumber, string massPartsIDFlag, string expansionKey1, string expansionKey2, string expansionKey3, string varidityDateTo, string validitydateFrom, string pLANT, string materialNumber, string unitCode, string status)
        {
            return new MaterialNumberImportFactory().Select(autoId, soldtoParty, shiptoParty, customerItemNumber, massPartsIDFlag, expansionKey1, expansionKey2, expansionKey3, varidityDateTo, validitydateFrom, pLANT, materialNumber, unitCode, status);
        }
        
        public static List<MyCompany.Data.Objects.MaterialNumberImport> Select(MyCompany.Data.Objects.MaterialNumberImport qbe)
        {
            return new MaterialNumberImportFactory().Select(qbe);
        }
        
        public static List<MyCompany.Data.Objects.MaterialNumberImport> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new MaterialNumberImportFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.MaterialNumberImport> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new MaterialNumberImportFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<MyCompany.Data.Objects.MaterialNumberImport> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new MaterialNumberImportFactory().Select(filter, sort, MaterialNumberImportFactory.SelectView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.MaterialNumberImport> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new MaterialNumberImportFactory().Select(filter, sort, MaterialNumberImportFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<MyCompany.Data.Objects.MaterialNumberImport> Select(string filter, BusinessObjectParameters parameters)
        {
            return new MaterialNumberImportFactory().Select(filter, null, MaterialNumberImportFactory.SelectView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.MaterialNumberImport> Select(string filter, params FieldValue[] parameters)
        {
            return new MaterialNumberImportFactory().Select(filter, null, MaterialNumberImportFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static MyCompany.Data.Objects.MaterialNumberImport SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new MaterialNumberImportFactory().SelectSingle(filter, parameters);
        }
        
        public static MyCompany.Data.Objects.MaterialNumberImport SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new MaterialNumberImportFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static MyCompany.Data.Objects.MaterialNumberImport SelectSingle(int? autoId)
        {
            return new MaterialNumberImportFactory().SelectSingle(autoId);
        }
        
        public int Insert()
        {
            return new MaterialNumberImportFactory().Insert(this);
        }
        
        public int Update()
        {
            return new MaterialNumberImportFactory().Update(this);
        }
        
        public int Delete()
        {
            return new MaterialNumberImportFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("AutoId: {0}", this.AutoId);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class MaterialNumberImportFactory
    {
        
        public MaterialNumberImportFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("MaterialNumberImport");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("MaterialNumberImport");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("MaterialNumberImport");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("MaterialNumberImport");
            }
        }
        
        public static MaterialNumberImportFactory Create()
        {
            return new MaterialNumberImportFactory();
        }
        
        protected virtual PageRequest CreateRequest(
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
                    string sort, 
                    int maximumRows, 
                    int startRowIndex)
        {
            List<string> filter = new List<string>();
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
            return new PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray());
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public List<MyCompany.Data.Objects.MaterialNumberImport> Select(
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
                    string sort, 
                    int maximumRows, 
                    int startRowIndex, 
                    string dataView)
        {
            PageRequest request = CreateRequest(autoId, soldtoParty, shiptoParty, customerItemNumber, massPartsIDFlag, expansionKey1, expansionKey2, expansionKey3, varidityDateTo, validitydateFrom, pLANT, materialNumber, unitCode, status, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("MaterialNumberImport", dataView, request);
            return page.ToList<MyCompany.Data.Objects.MaterialNumberImport>();
        }
        
        public List<MyCompany.Data.Objects.MaterialNumberImport> Select(MyCompany.Data.Objects.MaterialNumberImport qbe)
        {
            return Select(qbe.AutoId, qbe.SoldtoParty, qbe.ShiptoParty, qbe.CustomerItemNumber, qbe.MassPartsIDFlag, qbe.ExpansionKey1, qbe.ExpansionKey2, qbe.ExpansionKey3, qbe.VaridityDateTo, qbe.ValiditydateFrom, qbe.PLANT, qbe.MaterialNumber, qbe.UnitCode, qbe.Status);
        }
        
        public int SelectCount(
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
                    string sort, 
                    int maximumRows, 
                    int startRowIndex, 
                    string dataView)
        {
            PageRequest request = CreateRequest(autoId, soldtoParty, shiptoParty, customerItemNumber, massPartsIDFlag, expansionKey1, expansionKey2, expansionKey3, varidityDateTo, validitydateFrom, pLANT, materialNumber, unitCode, status, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("MaterialNumberImport", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<MyCompany.Data.Objects.MaterialNumberImport> Select(int? autoId, string soldtoParty, string shiptoParty, string customerItemNumber, string massPartsIDFlag, string expansionKey1, string expansionKey2, string expansionKey3, string varidityDateTo, string validitydateFrom, string pLANT, string materialNumber, string unitCode, string status)
        {
            return Select(autoId, soldtoParty, shiptoParty, customerItemNumber, massPartsIDFlag, expansionKey1, expansionKey2, expansionKey3, varidityDateTo, validitydateFrom, pLANT, materialNumber, unitCode, status, null, Int32.MaxValue, 0, SelectView);
        }
        
        public MyCompany.Data.Objects.MaterialNumberImport SelectSingle(int? autoId)
        {
            List<MyCompany.Data.Objects.MaterialNumberImport> list = Select(autoId, null, null, null, null, null, null, null, null, null, null, null, null, null);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<MyCompany.Data.Objects.MaterialNumberImport> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("MaterialNumberImport", dataView, request);
            return page.ToList<MyCompany.Data.Objects.MaterialNumberImport>();
        }
        
        public List<MyCompany.Data.Objects.MaterialNumberImport> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<MyCompany.Data.Objects.MaterialNumberImport> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public MyCompany.Data.Objects.MaterialNumberImport SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<MyCompany.Data.Objects.MaterialNumberImport> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(MyCompany.Data.Objects.MaterialNumberImport theMaterialNumberImport, MyCompany.Data.Objects.MaterialNumberImport original_MaterialNumberImport)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("AutoId", original_MaterialNumberImport.AutoId, theMaterialNumberImport.AutoId, true));
            values.Add(new FieldValue("SoldtoParty", original_MaterialNumberImport.SoldtoParty, theMaterialNumberImport.SoldtoParty));
            values.Add(new FieldValue("ShiptoParty", original_MaterialNumberImport.ShiptoParty, theMaterialNumberImport.ShiptoParty));
            values.Add(new FieldValue("CustomerItemNumber", original_MaterialNumberImport.CustomerItemNumber, theMaterialNumberImport.CustomerItemNumber));
            values.Add(new FieldValue("MassPartsIDFlag", original_MaterialNumberImport.MassPartsIDFlag, theMaterialNumberImport.MassPartsIDFlag));
            values.Add(new FieldValue("ExpansionKey1", original_MaterialNumberImport.ExpansionKey1, theMaterialNumberImport.ExpansionKey1));
            values.Add(new FieldValue("ExpansionKey2", original_MaterialNumberImport.ExpansionKey2, theMaterialNumberImport.ExpansionKey2));
            values.Add(new FieldValue("ExpansionKey3", original_MaterialNumberImport.ExpansionKey3, theMaterialNumberImport.ExpansionKey3));
            values.Add(new FieldValue("VaridityDateTo", original_MaterialNumberImport.VaridityDateTo, theMaterialNumberImport.VaridityDateTo));
            values.Add(new FieldValue("ValiditydateFrom", original_MaterialNumberImport.ValiditydateFrom, theMaterialNumberImport.ValiditydateFrom));
            values.Add(new FieldValue("PLANT", original_MaterialNumberImport.PLANT, theMaterialNumberImport.PLANT));
            values.Add(new FieldValue("MaterialNumber", original_MaterialNumberImport.MaterialNumber, theMaterialNumberImport.MaterialNumber));
            values.Add(new FieldValue("UnitCode", original_MaterialNumberImport.UnitCode, theMaterialNumberImport.UnitCode));
            values.Add(new FieldValue("Status", original_MaterialNumberImport.Status, theMaterialNumberImport.Status));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(MyCompany.Data.Objects.MaterialNumberImport theMaterialNumberImport, MyCompany.Data.Objects.MaterialNumberImport original_MaterialNumberImport, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "MaterialNumberImport";
            args.View = dataView;
            args.Values = CreateFieldValues(theMaterialNumberImport, original_MaterialNumberImport);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("MaterialNumberImport", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theMaterialNumberImport);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(MyCompany.Data.Objects.MaterialNumberImport theMaterialNumberImport, MyCompany.Data.Objects.MaterialNumberImport original_MaterialNumberImport)
        {
            return ExecuteAction(theMaterialNumberImport, original_MaterialNumberImport, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(MyCompany.Data.Objects.MaterialNumberImport theMaterialNumberImport)
        {
            return Update(theMaterialNumberImport, SelectSingle(theMaterialNumberImport.AutoId));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(MyCompany.Data.Objects.MaterialNumberImport theMaterialNumberImport)
        {
            return ExecuteAction(theMaterialNumberImport, new MaterialNumberImport(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(MyCompany.Data.Objects.MaterialNumberImport theMaterialNumberImport)
        {
            return ExecuteAction(theMaterialNumberImport, theMaterialNumberImport, "Select", "Delete", DeleteView);
        }
    }
}
