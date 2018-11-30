using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace MyCompany.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class MaterialNumber
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
        private DateTime? _varidityDateTo;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _validitydateFrom;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _pLANT;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _materialNumber;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _unitCode;
        
        public MaterialNumber()
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
        public DateTime? VaridityDateTo
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
        public DateTime? ValiditydateFrom
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
        public string MaterialNumber_
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
        
        public static List<MyCompany.Data.Objects.MaterialNumber> Select(int? autoId, string soldtoParty, string shiptoParty, string customerItemNumber, string massPartsIDFlag, string expansionKey1, string expansionKey2, string expansionKey3, DateTime? varidityDateTo, DateTime? validitydateFrom, string pLANT, string materialNumber, string unitCode)
        {
            return new MaterialNumberFactory().Select(autoId, soldtoParty, shiptoParty, customerItemNumber, massPartsIDFlag, expansionKey1, expansionKey2, expansionKey3, varidityDateTo, validitydateFrom, pLANT, materialNumber, unitCode);
        }
        
        public static List<MyCompany.Data.Objects.MaterialNumber> Select(MyCompany.Data.Objects.MaterialNumber qbe)
        {
            return new MaterialNumberFactory().Select(qbe);
        }
        
        public static List<MyCompany.Data.Objects.MaterialNumber> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new MaterialNumberFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.MaterialNumber> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new MaterialNumberFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<MyCompany.Data.Objects.MaterialNumber> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new MaterialNumberFactory().Select(filter, sort, MaterialNumberFactory.SelectView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.MaterialNumber> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new MaterialNumberFactory().Select(filter, sort, MaterialNumberFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<MyCompany.Data.Objects.MaterialNumber> Select(string filter, BusinessObjectParameters parameters)
        {
            return new MaterialNumberFactory().Select(filter, null, MaterialNumberFactory.SelectView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.MaterialNumber> Select(string filter, params FieldValue[] parameters)
        {
            return new MaterialNumberFactory().Select(filter, null, MaterialNumberFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static MyCompany.Data.Objects.MaterialNumber SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new MaterialNumberFactory().SelectSingle(filter, parameters);
        }
        
        public static MyCompany.Data.Objects.MaterialNumber SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new MaterialNumberFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static MyCompany.Data.Objects.MaterialNumber SelectSingle(int? autoId)
        {
            return new MaterialNumberFactory().SelectSingle(autoId);
        }
        
        public int Insert()
        {
            return new MaterialNumberFactory().Insert(this);
        }
        
        public int Update()
        {
            return new MaterialNumberFactory().Update(this);
        }
        
        public int Delete()
        {
            return new MaterialNumberFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("AutoId: {0}", this.AutoId);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class MaterialNumberFactory
    {
        
        public MaterialNumberFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("MaterialNumber");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("MaterialNumber");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("MaterialNumber");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("MaterialNumber");
            }
        }
        
        public static MaterialNumberFactory Create()
        {
            return new MaterialNumberFactory();
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
                    DateTime? varidityDateTo, 
                    DateTime? validitydateFrom, 
                    string pLANT, 
                    string materialNumber, 
                    string unitCode, 
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
            if (varidityDateTo.HasValue)
            	filter.Add(("VaridityDateTo:=" + varidityDateTo.Value.ToString()));
            if (validitydateFrom.HasValue)
            	filter.Add(("ValiditydateFrom:=" + validitydateFrom.Value.ToString()));
            if (!(String.IsNullOrEmpty(pLANT)))
            	filter.Add(("PLANT:*" + pLANT));
            if (!(String.IsNullOrEmpty(materialNumber)))
            	filter.Add(("MaterialNumber:*" + materialNumber));
            if (!(String.IsNullOrEmpty(unitCode)))
            	filter.Add(("UnitCode:*" + unitCode));
            return new PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray());
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public List<MyCompany.Data.Objects.MaterialNumber> Select(
                    int? autoId, 
                    string soldtoParty, 
                    string shiptoParty, 
                    string customerItemNumber, 
                    string massPartsIDFlag, 
                    string expansionKey1, 
                    string expansionKey2, 
                    string expansionKey3, 
                    DateTime? varidityDateTo, 
                    DateTime? validitydateFrom, 
                    string pLANT, 
                    string materialNumber, 
                    string unitCode, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex, 
                    string dataView)
        {
            PageRequest request = CreateRequest(autoId, soldtoParty, shiptoParty, customerItemNumber, massPartsIDFlag, expansionKey1, expansionKey2, expansionKey3, varidityDateTo, validitydateFrom, pLANT, materialNumber, unitCode, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("MaterialNumber", dataView, request);
            return page.ToList<MyCompany.Data.Objects.MaterialNumber>();
        }
        
        public List<MyCompany.Data.Objects.MaterialNumber> Select(MyCompany.Data.Objects.MaterialNumber qbe)
        {
            return Select(qbe.AutoId, qbe.SoldtoParty, qbe.ShiptoParty, qbe.CustomerItemNumber, qbe.MassPartsIDFlag, qbe.ExpansionKey1, qbe.ExpansionKey2, qbe.ExpansionKey3, qbe.VaridityDateTo, qbe.ValiditydateFrom, qbe.PLANT, qbe.MaterialNumber_, qbe.UnitCode);
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
                    DateTime? varidityDateTo, 
                    DateTime? validitydateFrom, 
                    string pLANT, 
                    string materialNumber, 
                    string unitCode, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex, 
                    string dataView)
        {
            PageRequest request = CreateRequest(autoId, soldtoParty, shiptoParty, customerItemNumber, massPartsIDFlag, expansionKey1, expansionKey2, expansionKey3, varidityDateTo, validitydateFrom, pLANT, materialNumber, unitCode, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("MaterialNumber", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<MyCompany.Data.Objects.MaterialNumber> Select(int? autoId, string soldtoParty, string shiptoParty, string customerItemNumber, string massPartsIDFlag, string expansionKey1, string expansionKey2, string expansionKey3, DateTime? varidityDateTo, DateTime? validitydateFrom, string pLANT, string materialNumber, string unitCode)
        {
            return Select(autoId, soldtoParty, shiptoParty, customerItemNumber, massPartsIDFlag, expansionKey1, expansionKey2, expansionKey3, varidityDateTo, validitydateFrom, pLANT, materialNumber, unitCode, null, Int32.MaxValue, 0, SelectView);
        }
        
        public MyCompany.Data.Objects.MaterialNumber SelectSingle(int? autoId)
        {
            List<MyCompany.Data.Objects.MaterialNumber> list = Select(autoId, null, null, null, null, null, null, null, null, null, null, null, null);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<MyCompany.Data.Objects.MaterialNumber> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("MaterialNumber", dataView, request);
            return page.ToList<MyCompany.Data.Objects.MaterialNumber>();
        }
        
        public List<MyCompany.Data.Objects.MaterialNumber> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<MyCompany.Data.Objects.MaterialNumber> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public MyCompany.Data.Objects.MaterialNumber SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<MyCompany.Data.Objects.MaterialNumber> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(MyCompany.Data.Objects.MaterialNumber theMaterialNumber, MyCompany.Data.Objects.MaterialNumber original_MaterialNumber)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("AutoId", original_MaterialNumber.AutoId, theMaterialNumber.AutoId, true));
            values.Add(new FieldValue("SoldtoParty", original_MaterialNumber.SoldtoParty, theMaterialNumber.SoldtoParty));
            values.Add(new FieldValue("ShiptoParty", original_MaterialNumber.ShiptoParty, theMaterialNumber.ShiptoParty));
            values.Add(new FieldValue("CustomerItemNumber", original_MaterialNumber.CustomerItemNumber, theMaterialNumber.CustomerItemNumber));
            values.Add(new FieldValue("MassPartsIDFlag", original_MaterialNumber.MassPartsIDFlag, theMaterialNumber.MassPartsIDFlag));
            values.Add(new FieldValue("ExpansionKey1", original_MaterialNumber.ExpansionKey1, theMaterialNumber.ExpansionKey1));
            values.Add(new FieldValue("ExpansionKey2", original_MaterialNumber.ExpansionKey2, theMaterialNumber.ExpansionKey2));
            values.Add(new FieldValue("ExpansionKey3", original_MaterialNumber.ExpansionKey3, theMaterialNumber.ExpansionKey3));
            values.Add(new FieldValue("VaridityDateTo", original_MaterialNumber.VaridityDateTo, theMaterialNumber.VaridityDateTo));
            values.Add(new FieldValue("ValiditydateFrom", original_MaterialNumber.ValiditydateFrom, theMaterialNumber.ValiditydateFrom));
            values.Add(new FieldValue("PLANT", original_MaterialNumber.PLANT, theMaterialNumber.PLANT));
            values.Add(new FieldValue("MaterialNumber", original_MaterialNumber.MaterialNumber_, theMaterialNumber.MaterialNumber_));
            values.Add(new FieldValue("UnitCode", original_MaterialNumber.UnitCode, theMaterialNumber.UnitCode));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(MyCompany.Data.Objects.MaterialNumber theMaterialNumber, MyCompany.Data.Objects.MaterialNumber original_MaterialNumber, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "MaterialNumber";
            args.View = dataView;
            args.Values = CreateFieldValues(theMaterialNumber, original_MaterialNumber);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("MaterialNumber", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theMaterialNumber);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(MyCompany.Data.Objects.MaterialNumber theMaterialNumber, MyCompany.Data.Objects.MaterialNumber original_MaterialNumber)
        {
            return ExecuteAction(theMaterialNumber, original_MaterialNumber, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(MyCompany.Data.Objects.MaterialNumber theMaterialNumber)
        {
            return Update(theMaterialNumber, SelectSingle(theMaterialNumber.AutoId));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(MyCompany.Data.Objects.MaterialNumber theMaterialNumber)
        {
            return ExecuteAction(theMaterialNumber, new MaterialNumber(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(MyCompany.Data.Objects.MaterialNumber theMaterialNumber)
        {
            return ExecuteAction(theMaterialNumber, theMaterialNumber, "Select", "Delete", DeleteView);
        }
    }
}
