using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using MyCompany.Data;

namespace MyCompany.Models
{
	public partial class MMTHOrderImportModel : BusinessRulesObjectModel
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
        private string _filename;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _plantCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _addCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _statusCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _arrivaltime;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _fromTo;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _deliveryDestinationCode;
        
        public MMTHOrderImportModel()
        {
        }
        
        public MMTHOrderImportModel(BusinessRules r) : 
                base(r)
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
                UpdateFieldValue("AutoId", value);
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
                UpdateFieldValue("OrderBy", value);
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
                UpdateFieldValue("DeliveryDestination", value);
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
                UpdateFieldValue("CustomerMatCode", value);
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
                UpdateFieldValue("PartsDevision", value);
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
                UpdateFieldValue("CustomerPO", value);
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
                UpdateFieldValue("Key1", value);
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
                UpdateFieldValue("Key2", value);
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
                UpdateFieldValue("Key3", value);
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
                UpdateFieldValue("ReliabilityDevision", value);
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
                UpdateFieldValue("DeliveryDate", value);
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
                UpdateFieldValue("Quantity", value);
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
                UpdateFieldValue("Unit", value);
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
                UpdateFieldValue("PlngPeriod", value);
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
                UpdateFieldValue("SAPCode", value);
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Filename
        {
            get
            {
                return _filename;
            }
            set
            {
                _filename = value;
                UpdateFieldValue("Filename", value);
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string PlantCode
        {
            get
            {
                return _plantCode;
            }
            set
            {
                _plantCode = value;
                UpdateFieldValue("PlantCode", value);
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AddCode
        {
            get
            {
                return _addCode;
            }
            set
            {
                _addCode = value;
                UpdateFieldValue("AddCode", value);
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
                UpdateFieldValue("StatusCode", value);
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Arrivaltime
        {
            get
            {
                return _arrivaltime;
            }
            set
            {
                _arrivaltime = value;
                UpdateFieldValue("Arrivaltime", value);
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string FromTo
        {
            get
            {
                return _fromTo;
            }
            set
            {
                _fromTo = value;
                UpdateFieldValue("FromTo", value);
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string DeliveryDestinationCode
        {
            get
            {
                return _deliveryDestinationCode;
            }
            set
            {
                _deliveryDestinationCode = value;
                UpdateFieldValue("DeliveryDestinationCode", value);
            }
        }
    }
    
    [System.ComponentModel.DataObject(false)]
    public partial class MMTHOrderImport : MMTHOrderImportModel
    {
        
        public static List<MyCompany.Models.MMTHOrderImport> Select(
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
                    string filename, 
                    string plantCode, 
                    string addCode, 
                    string statusCode, 
                    string arrivaltime, 
                    string fromTo, 
                    string deliveryDestinationCode)
        {
            return new MMTHOrderImportFactory().Select(autoId, orderBy, deliveryDestination, customerMatCode, partsDevision, customerPO, key1, key2, key3, reliabilityDevision, deliveryDate, quantity, unit, plngPeriod, sAPCode, filename, plantCode, addCode, statusCode, arrivaltime, fromTo, deliveryDestinationCode);
        }
        
        public static List<MyCompany.Models.MMTHOrderImport> Select(string filter, string sort, string dataView, params System.Object[] parameters)
        {
            return new MMTHOrderImportFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<MyCompany.Models.MMTHOrderImport> Select(string filter, string sort, params System.Object[] parameters)
        {
            return new MMTHOrderImportFactory().Select(filter, sort, MMTHOrderImportFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<MyCompany.Models.MMTHOrderImport> Select(string filter, params System.Object[] parameters)
        {
            return new MMTHOrderImportFactory().Select(filter, null, MMTHOrderImportFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static MyCompany.Models.MMTHOrderImport SelectSingle(string filter, params System.Object[] parameters)
        {
            return new MMTHOrderImportFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static MyCompany.Models.MMTHOrderImport SelectSingle(decimal? autoId)
        {
            return new MMTHOrderImportFactory().SelectSingle(autoId);
        }
        
        public int Insert()
        {
            return new MMTHOrderImportFactory().Insert(this);
        }
        
        public int Update()
        {
            return new MMTHOrderImportFactory().Update(this);
        }
        
        public int Delete()
        {
            return new MMTHOrderImportFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("AutoId: {0}", this.AutoId);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class MMTHOrderImportFactory
    {
        
        public MMTHOrderImportFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("MMTHOrderImport");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("MMTHOrderImport");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("MMTHOrderImport");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("MMTHOrderImport");
            }
        }
        
        public static MMTHOrderImportFactory Create()
        {
            return new MMTHOrderImportFactory();
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
                    string filename, 
                    string plantCode, 
                    string addCode, 
                    string statusCode, 
                    string arrivaltime, 
                    string fromTo, 
                    string deliveryDestinationCode, 
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
            if (!(String.IsNullOrEmpty(filename)))
            	filter.Add(("Filename:*" + filename));
            if (!(String.IsNullOrEmpty(plantCode)))
            	filter.Add(("PlantCode:*" + plantCode));
            if (!(String.IsNullOrEmpty(addCode)))
            	filter.Add(("AddCode:*" + addCode));
            if (!(String.IsNullOrEmpty(statusCode)))
            	filter.Add(("StatusCode:*" + statusCode));
            if (!(String.IsNullOrEmpty(arrivaltime)))
            	filter.Add(("Arrivaltime:*" + arrivaltime));
            if (!(String.IsNullOrEmpty(fromTo)))
            	filter.Add(("FromTo:*" + fromTo));
            if (!(String.IsNullOrEmpty(deliveryDestinationCode)))
            	filter.Add(("DeliveryDestinationCode:*" + deliveryDestinationCode));
            PageRequest request = new PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray());
            request.MetadataFilter = new string[] {
                    "fields"};
            return request;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public List<MyCompany.Models.MMTHOrderImport> Select(
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
                    string filename, 
                    string plantCode, 
                    string addCode, 
                    string statusCode, 
                    string arrivaltime, 
                    string fromTo, 
                    string deliveryDestinationCode, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex, 
                    string dataView)
        {
            PageRequest request = CreateRequest(autoId, orderBy, deliveryDestination, customerMatCode, partsDevision, customerPO, key1, key2, key3, reliabilityDevision, deliveryDate, quantity, unit, plngPeriod, sAPCode, filename, plantCode, addCode, statusCode, arrivaltime, fromTo, deliveryDestinationCode, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            request.MetadataFilter = new string[] {
                    "fields"};
            ViewPage page = ControllerFactory.CreateDataController().GetPage("MMTHOrderImport", dataView, request);
            return page.ToList<MyCompany.Models.MMTHOrderImport>();
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
                    string filename, 
                    string plantCode, 
                    string addCode, 
                    string statusCode, 
                    string arrivaltime, 
                    string fromTo, 
                    string deliveryDestinationCode, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex, 
                    string dataView)
        {
            PageRequest request = CreateRequest(autoId, orderBy, deliveryDestination, customerMatCode, partsDevision, customerPO, key1, key2, key3, reliabilityDevision, deliveryDate, quantity, unit, plngPeriod, sAPCode, filename, plantCode, addCode, statusCode, arrivaltime, fromTo, deliveryDestinationCode, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.MetadataFilter = new string[] {
                    "fields"};
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("MMTHOrderImport", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<MyCompany.Models.MMTHOrderImport> Select(
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
                    string filename, 
                    string plantCode, 
                    string addCode, 
                    string statusCode, 
                    string arrivaltime, 
                    string fromTo, 
                    string deliveryDestinationCode)
        {
            return Select(autoId, orderBy, deliveryDestination, customerMatCode, partsDevision, customerPO, key1, key2, key3, reliabilityDevision, deliveryDate, quantity, unit, plngPeriod, sAPCode, filename, plantCode, addCode, statusCode, arrivaltime, fromTo, deliveryDestinationCode, null, Int32.MaxValue, 0, SelectView);
        }
        
        public List<MyCompany.Models.MMTHOrderImport> Select(MyCompany.Models.MMTHOrderImport qbe)
        {
            return Select(qbe.AutoId, qbe.OrderBy, qbe.DeliveryDestination, qbe.CustomerMatCode, qbe.PartsDevision, qbe.CustomerPO, qbe.Key1, qbe.Key2, qbe.Key3, qbe.ReliabilityDevision, qbe.DeliveryDate, qbe.Quantity, qbe.Unit, qbe.PlngPeriod, qbe.SAPCode, qbe.Filename, qbe.PlantCode, qbe.AddCode, qbe.StatusCode, qbe.Arrivaltime, qbe.FromTo, qbe.DeliveryDestinationCode);
        }
        
        public List<MyCompany.Models.MMTHOrderImport> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public List<MyCompany.Models.MMTHOrderImport> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<MyCompany.Models.MMTHOrderImport> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            request.MetadataFilter = new string[] {
                    "fields"};
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("MMTHOrderImport", dataView, request);
            return page.ToList<MyCompany.Models.MMTHOrderImport>();
        }
        
        public MyCompany.Models.MMTHOrderImport SelectSingle(decimal? autoId)
        {
            List<MyCompany.Models.MMTHOrderImport> list = Select(autoId, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public MyCompany.Models.MMTHOrderImport SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<MyCompany.Models.MMTHOrderImport> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(MyCompany.Models.MMTHOrderImport theMMTHOrderImport, MyCompany.Models.MMTHOrderImport original_MMTHOrderImport)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("AutoId", original_MMTHOrderImport.AutoId, theMMTHOrderImport.AutoId, true));
            values.Add(new FieldValue("OrderBy", original_MMTHOrderImport.OrderBy, theMMTHOrderImport.OrderBy));
            values.Add(new FieldValue("DeliveryDestination", original_MMTHOrderImport.DeliveryDestination, theMMTHOrderImport.DeliveryDestination));
            values.Add(new FieldValue("CustomerMatCode", original_MMTHOrderImport.CustomerMatCode, theMMTHOrderImport.CustomerMatCode));
            values.Add(new FieldValue("PartsDevision", original_MMTHOrderImport.PartsDevision, theMMTHOrderImport.PartsDevision));
            values.Add(new FieldValue("CustomerPO", original_MMTHOrderImport.CustomerPO, theMMTHOrderImport.CustomerPO));
            values.Add(new FieldValue("Key1", original_MMTHOrderImport.Key1, theMMTHOrderImport.Key1));
            values.Add(new FieldValue("Key2", original_MMTHOrderImport.Key2, theMMTHOrderImport.Key2));
            values.Add(new FieldValue("Key3", original_MMTHOrderImport.Key3, theMMTHOrderImport.Key3));
            values.Add(new FieldValue("ReliabilityDevision", original_MMTHOrderImport.ReliabilityDevision, theMMTHOrderImport.ReliabilityDevision));
            values.Add(new FieldValue("DeliveryDate", original_MMTHOrderImport.DeliveryDate, theMMTHOrderImport.DeliveryDate));
            values.Add(new FieldValue("Quantity", original_MMTHOrderImport.Quantity, theMMTHOrderImport.Quantity));
            values.Add(new FieldValue("Unit", original_MMTHOrderImport.Unit, theMMTHOrderImport.Unit));
            values.Add(new FieldValue("PlngPeriod", original_MMTHOrderImport.PlngPeriod, theMMTHOrderImport.PlngPeriod));
            values.Add(new FieldValue("SAPCode", original_MMTHOrderImport.SAPCode, theMMTHOrderImport.SAPCode));
            values.Add(new FieldValue("Filename", original_MMTHOrderImport.Filename, theMMTHOrderImport.Filename));
            values.Add(new FieldValue("PlantCode", original_MMTHOrderImport.PlantCode, theMMTHOrderImport.PlantCode));
            values.Add(new FieldValue("AddCode", original_MMTHOrderImport.AddCode, theMMTHOrderImport.AddCode));
            values.Add(new FieldValue("StatusCode", original_MMTHOrderImport.StatusCode, theMMTHOrderImport.StatusCode));
            values.Add(new FieldValue("Arrivaltime", original_MMTHOrderImport.Arrivaltime, theMMTHOrderImport.Arrivaltime));
            values.Add(new FieldValue("FromTo", original_MMTHOrderImport.FromTo, theMMTHOrderImport.FromTo));
            values.Add(new FieldValue("DeliveryDestinationCode", original_MMTHOrderImport.DeliveryDestinationCode, theMMTHOrderImport.DeliveryDestinationCode));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(MyCompany.Models.MMTHOrderImport theMMTHOrderImport, MyCompany.Models.MMTHOrderImport original_MMTHOrderImport, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "MMTHOrderImport";
            args.View = dataView;
            args.Values = CreateFieldValues(theMMTHOrderImport, original_MMTHOrderImport);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("MMTHOrderImport", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theMMTHOrderImport);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(MyCompany.Models.MMTHOrderImport theMMTHOrderImport, MyCompany.Models.MMTHOrderImport original_MMTHOrderImport)
        {
            return ExecuteAction(theMMTHOrderImport, original_MMTHOrderImport, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(MyCompany.Models.MMTHOrderImport theMMTHOrderImport)
        {
            return Update(theMMTHOrderImport, SelectSingle(theMMTHOrderImport.AutoId));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(MyCompany.Models.MMTHOrderImport theMMTHOrderImport)
        {
            return ExecuteAction(theMMTHOrderImport, new MMTHOrderImport(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(MyCompany.Models.MMTHOrderImport theMMTHOrderImport)
        {
            return ExecuteAction(theMMTHOrderImport, theMMTHOrderImport, "Select", "Delete", DeleteView);
        }
    }
}
