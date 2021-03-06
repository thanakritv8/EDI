﻿using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using MyCompany.Data;

namespace MyCompany.Models
{
	public partial class MMTHForcastImportModel : BusinessRulesObjectModel
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
        private int? _quantity;
        
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
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _deliveryDestinationCode;
        
        public MMTHForcastImportModel()
        {
        }
        
        public MMTHForcastImportModel(BusinessRules r) : 
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
        public int? Quantity
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
        public decimal? FileId
        {
            get
            {
                return _fileId;
            }
            set
            {
                _fileId = value;
                UpdateFieldValue("FileId", value);
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
    public partial class MMTHForcastImport : MMTHForcastImportModel
    {
        
        public static List<MyCompany.Models.MMTHForcastImport> Select(
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
                    int? quantity, 
                    string unit, 
                    string plngPeriod, 
                    string sAPCode, 
                    decimal? fileId, 
                    string statusCode, 
                    string deliveryDestinationCode)
        {
            return new MMTHForcastImportFactory().Select(autoId, orderBy, deliveryDestination, customerMatCode, partsDevision, customerPO, key1, key2, key3, reliabilityDevision, deliveryDate, quantity, unit, plngPeriod, sAPCode, fileId, statusCode, deliveryDestinationCode);
        }
        
        public static List<MyCompany.Models.MMTHForcastImport> Select(string filter, string sort, string dataView, params System.Object[] parameters)
        {
            return new MMTHForcastImportFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<MyCompany.Models.MMTHForcastImport> Select(string filter, string sort, params System.Object[] parameters)
        {
            return new MMTHForcastImportFactory().Select(filter, sort, MMTHForcastImportFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<MyCompany.Models.MMTHForcastImport> Select(string filter, params System.Object[] parameters)
        {
            return new MMTHForcastImportFactory().Select(filter, null, MMTHForcastImportFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static MyCompany.Models.MMTHForcastImport SelectSingle(string filter, params System.Object[] parameters)
        {
            return new MMTHForcastImportFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static MyCompany.Models.MMTHForcastImport SelectSingle(decimal? autoId)
        {
            return new MMTHForcastImportFactory().SelectSingle(autoId);
        }
        
        public int Insert()
        {
            return new MMTHForcastImportFactory().Insert(this);
        }
        
        public int Update()
        {
            return new MMTHForcastImportFactory().Update(this);
        }
        
        public int Delete()
        {
            return new MMTHForcastImportFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("AutoId: {0}", this.AutoId);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class MMTHForcastImportFactory
    {
        
        public MMTHForcastImportFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("MMTHForcastImport");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("MMTHForcastImport");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("MMTHForcastImport");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("MMTHForcastImport");
            }
        }
        
        public static MMTHForcastImportFactory Create()
        {
            return new MMTHForcastImportFactory();
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
                    int? quantity, 
                    string unit, 
                    string plngPeriod, 
                    string sAPCode, 
                    decimal? fileId, 
                    string statusCode, 
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
            if (quantity.HasValue)
            	filter.Add(("Quantity:=" + quantity.Value.ToString()));
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
            if (!(String.IsNullOrEmpty(deliveryDestinationCode)))
            	filter.Add(("DeliveryDestinationCode:*" + deliveryDestinationCode));
            PageRequest request = new PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray());
            request.MetadataFilter = new string[] {
                    "fields"};
            return request;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public List<MyCompany.Models.MMTHForcastImport> Select(
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
                    int? quantity, 
                    string unit, 
                    string plngPeriod, 
                    string sAPCode, 
                    decimal? fileId, 
                    string statusCode, 
                    string deliveryDestinationCode, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex, 
                    string dataView)
        {
            PageRequest request = CreateRequest(autoId, orderBy, deliveryDestination, customerMatCode, partsDevision, customerPO, key1, key2, key3, reliabilityDevision, deliveryDate, quantity, unit, plngPeriod, sAPCode, fileId, statusCode, deliveryDestinationCode, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            request.MetadataFilter = new string[] {
                    "fields"};
            ViewPage page = ControllerFactory.CreateDataController().GetPage("MMTHForcastImport", dataView, request);
            return page.ToList<MyCompany.Models.MMTHForcastImport>();
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
                    int? quantity, 
                    string unit, 
                    string plngPeriod, 
                    string sAPCode, 
                    decimal? fileId, 
                    string statusCode, 
                    string deliveryDestinationCode, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex, 
                    string dataView)
        {
            PageRequest request = CreateRequest(autoId, orderBy, deliveryDestination, customerMatCode, partsDevision, customerPO, key1, key2, key3, reliabilityDevision, deliveryDate, quantity, unit, plngPeriod, sAPCode, fileId, statusCode, deliveryDestinationCode, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.MetadataFilter = new string[] {
                    "fields"};
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("MMTHForcastImport", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<MyCompany.Models.MMTHForcastImport> Select(
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
                    int? quantity, 
                    string unit, 
                    string plngPeriod, 
                    string sAPCode, 
                    decimal? fileId, 
                    string statusCode, 
                    string deliveryDestinationCode)
        {
            return Select(autoId, orderBy, deliveryDestination, customerMatCode, partsDevision, customerPO, key1, key2, key3, reliabilityDevision, deliveryDate, quantity, unit, plngPeriod, sAPCode, fileId, statusCode, deliveryDestinationCode, null, Int32.MaxValue, 0, SelectView);
        }
        
        public List<MyCompany.Models.MMTHForcastImport> Select(MyCompany.Models.MMTHForcastImport qbe)
        {
            return Select(qbe.AutoId, qbe.OrderBy, qbe.DeliveryDestination, qbe.CustomerMatCode, qbe.PartsDevision, qbe.CustomerPO, qbe.Key1, qbe.Key2, qbe.Key3, qbe.ReliabilityDevision, qbe.DeliveryDate, qbe.Quantity, qbe.Unit, qbe.PlngPeriod, qbe.SAPCode, qbe.FileId, qbe.StatusCode, qbe.DeliveryDestinationCode);
        }
        
        public List<MyCompany.Models.MMTHForcastImport> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public List<MyCompany.Models.MMTHForcastImport> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<MyCompany.Models.MMTHForcastImport> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            request.MetadataFilter = new string[] {
                    "fields"};
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("MMTHForcastImport", dataView, request);
            return page.ToList<MyCompany.Models.MMTHForcastImport>();
        }
        
        public MyCompany.Models.MMTHForcastImport SelectSingle(decimal? autoId)
        {
            List<MyCompany.Models.MMTHForcastImport> list = Select(autoId, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public MyCompany.Models.MMTHForcastImport SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<MyCompany.Models.MMTHForcastImport> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(MyCompany.Models.MMTHForcastImport theMMTHForcastImport, MyCompany.Models.MMTHForcastImport original_MMTHForcastImport)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("AutoId", original_MMTHForcastImport.AutoId, theMMTHForcastImport.AutoId, true));
            values.Add(new FieldValue("OrderBy", original_MMTHForcastImport.OrderBy, theMMTHForcastImport.OrderBy));
            values.Add(new FieldValue("DeliveryDestination", original_MMTHForcastImport.DeliveryDestination, theMMTHForcastImport.DeliveryDestination));
            values.Add(new FieldValue("CustomerMatCode", original_MMTHForcastImport.CustomerMatCode, theMMTHForcastImport.CustomerMatCode));
            values.Add(new FieldValue("PartsDevision", original_MMTHForcastImport.PartsDevision, theMMTHForcastImport.PartsDevision));
            values.Add(new FieldValue("CustomerPO", original_MMTHForcastImport.CustomerPO, theMMTHForcastImport.CustomerPO));
            values.Add(new FieldValue("Key1", original_MMTHForcastImport.Key1, theMMTHForcastImport.Key1));
            values.Add(new FieldValue("Key2", original_MMTHForcastImport.Key2, theMMTHForcastImport.Key2));
            values.Add(new FieldValue("Key3", original_MMTHForcastImport.Key3, theMMTHForcastImport.Key3));
            values.Add(new FieldValue("ReliabilityDevision", original_MMTHForcastImport.ReliabilityDevision, theMMTHForcastImport.ReliabilityDevision));
            values.Add(new FieldValue("DeliveryDate", original_MMTHForcastImport.DeliveryDate, theMMTHForcastImport.DeliveryDate));
            values.Add(new FieldValue("Quantity", original_MMTHForcastImport.Quantity, theMMTHForcastImport.Quantity));
            values.Add(new FieldValue("Unit", original_MMTHForcastImport.Unit, theMMTHForcastImport.Unit));
            values.Add(new FieldValue("PlngPeriod", original_MMTHForcastImport.PlngPeriod, theMMTHForcastImport.PlngPeriod));
            values.Add(new FieldValue("SAPCode", original_MMTHForcastImport.SAPCode, theMMTHForcastImport.SAPCode));
            values.Add(new FieldValue("FileId", original_MMTHForcastImport.FileId, theMMTHForcastImport.FileId));
            values.Add(new FieldValue("StatusCode", original_MMTHForcastImport.StatusCode, theMMTHForcastImport.StatusCode));
            values.Add(new FieldValue("DeliveryDestinationCode", original_MMTHForcastImport.DeliveryDestinationCode, theMMTHForcastImport.DeliveryDestinationCode));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(MyCompany.Models.MMTHForcastImport theMMTHForcastImport, MyCompany.Models.MMTHForcastImport original_MMTHForcastImport, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "MMTHForcastImport";
            args.View = dataView;
            args.Values = CreateFieldValues(theMMTHForcastImport, original_MMTHForcastImport);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("MMTHForcastImport", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theMMTHForcastImport);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(MyCompany.Models.MMTHForcastImport theMMTHForcastImport, MyCompany.Models.MMTHForcastImport original_MMTHForcastImport)
        {
            return ExecuteAction(theMMTHForcastImport, original_MMTHForcastImport, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(MyCompany.Models.MMTHForcastImport theMMTHForcastImport)
        {
            return Update(theMMTHForcastImport, SelectSingle(theMMTHForcastImport.AutoId));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(MyCompany.Models.MMTHForcastImport theMMTHForcastImport)
        {
            return ExecuteAction(theMMTHForcastImport, new MMTHForcastImport(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(MyCompany.Models.MMTHForcastImport theMMTHForcastImport)
        {
            return ExecuteAction(theMMTHForcastImport, theMMTHForcastImport, "Select", "Delete", DeleteView);
        }
    }
}
