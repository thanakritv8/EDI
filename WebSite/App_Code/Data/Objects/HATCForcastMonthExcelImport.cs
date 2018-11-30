using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace MyCompany.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class HATCForcastMonthExcelImport
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _autoId;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _orderBy;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _deliveryDestination;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _customerMatCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _partsDevision;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _customerPO;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _key1;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _key2;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _key3;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _reliabilityDevision;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _deliveryDate;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _quantity;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _unit;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _plngPeriod;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _sAPCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _fileId;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _statusCode;
        
        public HATCForcastMonthExcelImport()
        {
        }
        
        [System.ComponentModel.DataObjectField(true, true, false)]
        public decimal? AutoId
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
        public string OrderBy
        {
            get
            {
                return _orderBy;
            }
            set
            {
                _orderBy = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string DeliveryDestination
        {
            get
            {
                return _deliveryDestination;
            }
            set
            {
                _deliveryDestination = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CustomerMatCode
        {
            get
            {
                return _customerMatCode;
            }
            set
            {
                _customerMatCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string PartsDevision
        {
            get
            {
                return _partsDevision;
            }
            set
            {
                _partsDevision = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CustomerPO
        {
            get
            {
                return _customerPO;
            }
            set
            {
                _customerPO = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Key1
        {
            get
            {
                return _key1;
            }
            set
            {
                _key1 = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Key2
        {
            get
            {
                return _key2;
            }
            set
            {
                _key2 = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Key3
        {
            get
            {
                return _key3;
            }
            set
            {
                _key3 = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string ReliabilityDevision
        {
            get
            {
                return _reliabilityDevision;
            }
            set
            {
                _reliabilityDevision = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public DateTime? DeliveryDate
        {
            get
            {
                return _deliveryDate;
            }
            set
            {
                _deliveryDate = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Quantity
        {
            get
            {
                return _quantity;
            }
            set
            {
                _quantity = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Unit
        {
            get
            {
                return _unit;
            }
            set
            {
                _unit = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string PlngPeriod
        {
            get
            {
                return _plngPeriod;
            }
            set
            {
                _plngPeriod = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string SAPCode
        {
            get
            {
                return _sAPCode;
            }
            set
            {
                _sAPCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
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
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string StatusCode
        {
            get
            {
                return _statusCode;
            }
            set
            {
                _statusCode = value;
            }
        }
        
        public static List<MyCompany.Data.Objects.HATCForcastMonthExcelImport> Select(
                    decimal? autoId, 
                    string orderBy, 
                    string deliveryDestination, 
                    string customerMatCode, 
                    string partsDevision, 
                    string customerPO, 
                    string key1, 
                    string key2, 
                    string key3, 
                    string reliabilityDevision, 
                    DateTime? deliveryDate, 
                    string quantity, 
                    string unit, 
                    string plngPeriod, 
                    string sAPCode, 
                    decimal? fileId, 
                    string statusCode)
        {
            return new HATCForcastMonthExcelImportFactory().Select(autoId, orderBy, deliveryDestination, customerMatCode, partsDevision, customerPO, key1, key2, key3, reliabilityDevision, deliveryDate, quantity, unit, plngPeriod, sAPCode, fileId, statusCode);
        }
        
        public static List<MyCompany.Data.Objects.HATCForcastMonthExcelImport> Select(MyCompany.Data.Objects.HATCForcastMonthExcelImport qbe)
        {
            return new HATCForcastMonthExcelImportFactory().Select(qbe);
        }
        
        public static List<MyCompany.Data.Objects.HATCForcastMonthExcelImport> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new HATCForcastMonthExcelImportFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.HATCForcastMonthExcelImport> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new HATCForcastMonthExcelImportFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<MyCompany.Data.Objects.HATCForcastMonthExcelImport> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new HATCForcastMonthExcelImportFactory().Select(filter, sort, HATCForcastMonthExcelImportFactory.SelectView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.HATCForcastMonthExcelImport> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new HATCForcastMonthExcelImportFactory().Select(filter, sort, HATCForcastMonthExcelImportFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<MyCompany.Data.Objects.HATCForcastMonthExcelImport> Select(string filter, BusinessObjectParameters parameters)
        {
            return new HATCForcastMonthExcelImportFactory().Select(filter, null, HATCForcastMonthExcelImportFactory.SelectView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.HATCForcastMonthExcelImport> Select(string filter, params FieldValue[] parameters)
        {
            return new HATCForcastMonthExcelImportFactory().Select(filter, null, HATCForcastMonthExcelImportFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static MyCompany.Data.Objects.HATCForcastMonthExcelImport SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new HATCForcastMonthExcelImportFactory().SelectSingle(filter, parameters);
        }
        
        public static MyCompany.Data.Objects.HATCForcastMonthExcelImport SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new HATCForcastMonthExcelImportFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static MyCompany.Data.Objects.HATCForcastMonthExcelImport SelectSingle(decimal? autoId)
        {
            return new HATCForcastMonthExcelImportFactory().SelectSingle(autoId);
        }
        
        public int Insert()
        {
            return new HATCForcastMonthExcelImportFactory().Insert(this);
        }
        
        public int Update()
        {
            return new HATCForcastMonthExcelImportFactory().Update(this);
        }
        
        public int Delete()
        {
            return new HATCForcastMonthExcelImportFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("AutoId: {0}", this.AutoId);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class HATCForcastMonthExcelImportFactory
    {
        
        public HATCForcastMonthExcelImportFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("HATCForcastMonthExcelImport");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("HATCForcastMonthExcelImport");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("HATCForcastMonthExcelImport");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("HATCForcastMonthExcelImport");
            }
        }
        
        public static HATCForcastMonthExcelImportFactory Create()
        {
            return new HATCForcastMonthExcelImportFactory();
        }
        
        protected virtual PageRequest CreateRequest(
                    decimal? autoId, 
                    string orderBy, 
                    string deliveryDestination, 
                    string customerMatCode, 
                    string partsDevision, 
                    string customerPO, 
                    string key1, 
                    string key2, 
                    string key3, 
                    string reliabilityDevision, 
                    DateTime? deliveryDate, 
                    string quantity, 
                    string unit, 
                    string plngPeriod, 
                    string sAPCode, 
                    decimal? fileId, 
                    string statusCode, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (autoId.HasValue)
            	filter.Add(("AutoId:=" + autoId.Value.ToString()));
            if (!(String.IsNullOrEmpty(orderBy)))
            	filter.Add(("OrderBy:*" + orderBy));
            if (!(String.IsNullOrEmpty(deliveryDestination)))
            	filter.Add(("DeliveryDestination:*" + deliveryDestination));
            if (!(String.IsNullOrEmpty(customerMatCode)))
            	filter.Add(("CustomerMatCode:*" + customerMatCode));
            if (!(String.IsNullOrEmpty(partsDevision)))
            	filter.Add(("PartsDevision:*" + partsDevision));
            if (!(String.IsNullOrEmpty(customerPO)))
            	filter.Add(("CustomerPO:*" + customerPO));
            if (!(String.IsNullOrEmpty(key1)))
            	filter.Add(("Key1:*" + key1));
            if (!(String.IsNullOrEmpty(key2)))
            	filter.Add(("Key2:*" + key2));
            if (!(String.IsNullOrEmpty(key3)))
            	filter.Add(("Key3:*" + key3));
            if (!(String.IsNullOrEmpty(reliabilityDevision)))
            	filter.Add(("ReliabilityDevision:*" + reliabilityDevision));
            if (deliveryDate.HasValue)
            	filter.Add(("DeliveryDate:=" + deliveryDate.Value.ToString()));
            if (!(String.IsNullOrEmpty(quantity)))
            	filter.Add(("Quantity:*" + quantity));
            if (!(String.IsNullOrEmpty(unit)))
            	filter.Add(("Unit:*" + unit));
            if (!(String.IsNullOrEmpty(plngPeriod)))
            	filter.Add(("PlngPeriod:*" + plngPeriod));
            if (!(String.IsNullOrEmpty(sAPCode)))
            	filter.Add(("SAPCode:*" + sAPCode));
            if (fileId.HasValue)
            	filter.Add(("FileId:=" + fileId.Value.ToString()));
            if (!(String.IsNullOrEmpty(statusCode)))
            	filter.Add(("StatusCode:*" + statusCode));
            return new PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray());
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public List<MyCompany.Data.Objects.HATCForcastMonthExcelImport> Select(
                    decimal? autoId, 
                    string orderBy, 
                    string deliveryDestination, 
                    string customerMatCode, 
                    string partsDevision, 
                    string customerPO, 
                    string key1, 
                    string key2, 
                    string key3, 
                    string reliabilityDevision, 
                    DateTime? deliveryDate, 
                    string quantity, 
                    string unit, 
                    string plngPeriod, 
                    string sAPCode, 
                    decimal? fileId, 
                    string statusCode, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex, 
                    string dataView)
        {
            PageRequest request = CreateRequest(autoId, orderBy, deliveryDestination, customerMatCode, partsDevision, customerPO, key1, key2, key3, reliabilityDevision, deliveryDate, quantity, unit, plngPeriod, sAPCode, fileId, statusCode, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("HATCForcastMonthExcelImport", dataView, request);
            return page.ToList<MyCompany.Data.Objects.HATCForcastMonthExcelImport>();
        }
        
        public List<MyCompany.Data.Objects.HATCForcastMonthExcelImport> Select(MyCompany.Data.Objects.HATCForcastMonthExcelImport qbe)
        {
            return Select(qbe.AutoId, qbe.OrderBy, qbe.DeliveryDestination, qbe.CustomerMatCode, qbe.PartsDevision, qbe.CustomerPO, qbe.Key1, qbe.Key2, qbe.Key3, qbe.ReliabilityDevision, qbe.DeliveryDate, qbe.Quantity, qbe.Unit, qbe.PlngPeriod, qbe.SAPCode, qbe.FileId, qbe.StatusCode);
        }
        
        public int SelectCount(
                    decimal? autoId, 
                    string orderBy, 
                    string deliveryDestination, 
                    string customerMatCode, 
                    string partsDevision, 
                    string customerPO, 
                    string key1, 
                    string key2, 
                    string key3, 
                    string reliabilityDevision, 
                    DateTime? deliveryDate, 
                    string quantity, 
                    string unit, 
                    string plngPeriod, 
                    string sAPCode, 
                    decimal? fileId, 
                    string statusCode, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex, 
                    string dataView)
        {
            PageRequest request = CreateRequest(autoId, orderBy, deliveryDestination, customerMatCode, partsDevision, customerPO, key1, key2, key3, reliabilityDevision, deliveryDate, quantity, unit, plngPeriod, sAPCode, fileId, statusCode, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("HATCForcastMonthExcelImport", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<MyCompany.Data.Objects.HATCForcastMonthExcelImport> Select(
                    decimal? autoId, 
                    string orderBy, 
                    string deliveryDestination, 
                    string customerMatCode, 
                    string partsDevision, 
                    string customerPO, 
                    string key1, 
                    string key2, 
                    string key3, 
                    string reliabilityDevision, 
                    DateTime? deliveryDate, 
                    string quantity, 
                    string unit, 
                    string plngPeriod, 
                    string sAPCode, 
                    decimal? fileId, 
                    string statusCode)
        {
            return Select(autoId, orderBy, deliveryDestination, customerMatCode, partsDevision, customerPO, key1, key2, key3, reliabilityDevision, deliveryDate, quantity, unit, plngPeriod, sAPCode, fileId, statusCode, null, Int32.MaxValue, 0, SelectView);
        }
        
        public MyCompany.Data.Objects.HATCForcastMonthExcelImport SelectSingle(decimal? autoId)
        {
            List<MyCompany.Data.Objects.HATCForcastMonthExcelImport> list = Select(autoId, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<MyCompany.Data.Objects.HATCForcastMonthExcelImport> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("HATCForcastMonthExcelImport", dataView, request);
            return page.ToList<MyCompany.Data.Objects.HATCForcastMonthExcelImport>();
        }
        
        public List<MyCompany.Data.Objects.HATCForcastMonthExcelImport> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<MyCompany.Data.Objects.HATCForcastMonthExcelImport> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public MyCompany.Data.Objects.HATCForcastMonthExcelImport SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<MyCompany.Data.Objects.HATCForcastMonthExcelImport> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(MyCompany.Data.Objects.HATCForcastMonthExcelImport theHATCForcastMonthExcelImport, MyCompany.Data.Objects.HATCForcastMonthExcelImport original_HATCForcastMonthExcelImport)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("AutoId", original_HATCForcastMonthExcelImport.AutoId, theHATCForcastMonthExcelImport.AutoId, true));
            values.Add(new FieldValue("OrderBy", original_HATCForcastMonthExcelImport.OrderBy, theHATCForcastMonthExcelImport.OrderBy));
            values.Add(new FieldValue("DeliveryDestination", original_HATCForcastMonthExcelImport.DeliveryDestination, theHATCForcastMonthExcelImport.DeliveryDestination));
            values.Add(new FieldValue("CustomerMatCode", original_HATCForcastMonthExcelImport.CustomerMatCode, theHATCForcastMonthExcelImport.CustomerMatCode));
            values.Add(new FieldValue("PartsDevision", original_HATCForcastMonthExcelImport.PartsDevision, theHATCForcastMonthExcelImport.PartsDevision));
            values.Add(new FieldValue("CustomerPO", original_HATCForcastMonthExcelImport.CustomerPO, theHATCForcastMonthExcelImport.CustomerPO));
            values.Add(new FieldValue("Key1", original_HATCForcastMonthExcelImport.Key1, theHATCForcastMonthExcelImport.Key1));
            values.Add(new FieldValue("Key2", original_HATCForcastMonthExcelImport.Key2, theHATCForcastMonthExcelImport.Key2));
            values.Add(new FieldValue("Key3", original_HATCForcastMonthExcelImport.Key3, theHATCForcastMonthExcelImport.Key3));
            values.Add(new FieldValue("ReliabilityDevision", original_HATCForcastMonthExcelImport.ReliabilityDevision, theHATCForcastMonthExcelImport.ReliabilityDevision));
            values.Add(new FieldValue("DeliveryDate", original_HATCForcastMonthExcelImport.DeliveryDate, theHATCForcastMonthExcelImport.DeliveryDate));
            values.Add(new FieldValue("Quantity", original_HATCForcastMonthExcelImport.Quantity, theHATCForcastMonthExcelImport.Quantity));
            values.Add(new FieldValue("Unit", original_HATCForcastMonthExcelImport.Unit, theHATCForcastMonthExcelImport.Unit));
            values.Add(new FieldValue("PlngPeriod", original_HATCForcastMonthExcelImport.PlngPeriod, theHATCForcastMonthExcelImport.PlngPeriod));
            values.Add(new FieldValue("SAPCode", original_HATCForcastMonthExcelImport.SAPCode, theHATCForcastMonthExcelImport.SAPCode));
            values.Add(new FieldValue("FileId", original_HATCForcastMonthExcelImport.FileId, theHATCForcastMonthExcelImport.FileId));
            values.Add(new FieldValue("StatusCode", original_HATCForcastMonthExcelImport.StatusCode, theHATCForcastMonthExcelImport.StatusCode));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(MyCompany.Data.Objects.HATCForcastMonthExcelImport theHATCForcastMonthExcelImport, MyCompany.Data.Objects.HATCForcastMonthExcelImport original_HATCForcastMonthExcelImport, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "HATCForcastMonthExcelImport";
            args.View = dataView;
            args.Values = CreateFieldValues(theHATCForcastMonthExcelImport, original_HATCForcastMonthExcelImport);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("HATCForcastMonthExcelImport", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theHATCForcastMonthExcelImport);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(MyCompany.Data.Objects.HATCForcastMonthExcelImport theHATCForcastMonthExcelImport, MyCompany.Data.Objects.HATCForcastMonthExcelImport original_HATCForcastMonthExcelImport)
        {
            return ExecuteAction(theHATCForcastMonthExcelImport, original_HATCForcastMonthExcelImport, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(MyCompany.Data.Objects.HATCForcastMonthExcelImport theHATCForcastMonthExcelImport)
        {
            return Update(theHATCForcastMonthExcelImport, SelectSingle(theHATCForcastMonthExcelImport.AutoId));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(MyCompany.Data.Objects.HATCForcastMonthExcelImport theHATCForcastMonthExcelImport)
        {
            return ExecuteAction(theHATCForcastMonthExcelImport, new HATCForcastMonthExcelImport(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(MyCompany.Data.Objects.HATCForcastMonthExcelImport theHATCForcastMonthExcelImport)
        {
            return ExecuteAction(theHATCForcastMonthExcelImport, theHATCForcastMonthExcelImport, "Select", "Delete", DeleteView);
        }
    }
}
