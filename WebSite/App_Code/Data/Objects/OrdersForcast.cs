using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace MyCompany.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class OrdersForcast
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _autoId;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _orderBy;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _deliveryDestination;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _deliveryDestnationCode;
        
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
        private int? _customerId;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _createBy;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _createDate;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _updateBy;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _updateDate;
        
        public OrdersForcast()
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
        public string DeliveryDestnationCode
        {
            get
            {
                return _deliveryDestnationCode;
            }
            set
            {
                _deliveryDestnationCode = value;
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
        public int? CustomerId
        {
            get
            {
                return _customerId;
            }
            set
            {
                _customerId = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CreateBy
        {
            get
            {
                return _createBy;
            }
            set
            {
                _createBy = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public DateTime? CreateDate
        {
            get
            {
                return _createDate;
            }
            set
            {
                _createDate = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string UpdateBy
        {
            get
            {
                return _updateBy;
            }
            set
            {
                _updateBy = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public DateTime? UpdateDate
        {
            get
            {
                return _updateDate;
            }
            set
            {
                _updateDate = value;
            }
        }
        
        public static List<MyCompany.Data.Objects.OrdersForcast> Select(
                    decimal? autoId, 
                    string orderBy, 
                    string deliveryDestination, 
                    string deliveryDestnationCode, 
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
                    int? customerId, 
                    string createBy, 
                    DateTime? createDate, 
                    string updateBy, 
                    DateTime? updateDate)
        {
            return new OrdersForcastFactory().Select(autoId, orderBy, deliveryDestination, deliveryDestnationCode, customerMatCode, partsDevision, customerPO, key1, key2, key3, reliabilityDevision, deliveryDate, quantity, unit, plngPeriod, sAPCode, customerId, createBy, createDate, updateBy, updateDate);
        }
        
        public static List<MyCompany.Data.Objects.OrdersForcast> Select(MyCompany.Data.Objects.OrdersForcast qbe)
        {
            return new OrdersForcastFactory().Select(qbe);
        }
        
        public static List<MyCompany.Data.Objects.OrdersForcast> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new OrdersForcastFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.OrdersForcast> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new OrdersForcastFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<MyCompany.Data.Objects.OrdersForcast> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new OrdersForcastFactory().Select(filter, sort, OrdersForcastFactory.SelectView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.OrdersForcast> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new OrdersForcastFactory().Select(filter, sort, OrdersForcastFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<MyCompany.Data.Objects.OrdersForcast> Select(string filter, BusinessObjectParameters parameters)
        {
            return new OrdersForcastFactory().Select(filter, null, OrdersForcastFactory.SelectView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.OrdersForcast> Select(string filter, params FieldValue[] parameters)
        {
            return new OrdersForcastFactory().Select(filter, null, OrdersForcastFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static MyCompany.Data.Objects.OrdersForcast SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new OrdersForcastFactory().SelectSingle(filter, parameters);
        }
        
        public static MyCompany.Data.Objects.OrdersForcast SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new OrdersForcastFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static MyCompany.Data.Objects.OrdersForcast SelectSingle(decimal? autoId)
        {
            return new OrdersForcastFactory().SelectSingle(autoId);
        }
        
        public int Insert()
        {
            return new OrdersForcastFactory().Insert(this);
        }
        
        public int Update()
        {
            return new OrdersForcastFactory().Update(this);
        }
        
        public int Delete()
        {
            return new OrdersForcastFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("AutoId: {0}", this.AutoId);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class OrdersForcastFactory
    {
        
        public OrdersForcastFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("OrdersForcast");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("OrdersForcast");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("OrdersForcast");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("OrdersForcast");
            }
        }
        
        public static OrdersForcastFactory Create()
        {
            return new OrdersForcastFactory();
        }
        
        protected virtual PageRequest CreateRequest(
                    decimal? autoId, 
                    string orderBy, 
                    string deliveryDestination, 
                    string deliveryDestnationCode, 
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
                    int? customerId, 
                    string createBy, 
                    DateTime? createDate, 
                    string updateBy, 
                    DateTime? updateDate, 
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
            if (!(String.IsNullOrEmpty(deliveryDestnationCode)))
            	filter.Add(("DeliveryDestnationCode:*" + deliveryDestnationCode));
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
            if (customerId.HasValue)
            	filter.Add(("CustomerId:=" + customerId.Value.ToString()));
            if (!(String.IsNullOrEmpty(createBy)))
            	filter.Add(("CreateBy:*" + createBy));
            if (createDate.HasValue)
            	filter.Add(("CreateDate:=" + createDate.Value.ToString()));
            if (!(String.IsNullOrEmpty(updateBy)))
            	filter.Add(("UpdateBy:*" + updateBy));
            if (updateDate.HasValue)
            	filter.Add(("UpdateDate:=" + updateDate.Value.ToString()));
            return new PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray());
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public List<MyCompany.Data.Objects.OrdersForcast> Select(
                    decimal? autoId, 
                    string orderBy, 
                    string deliveryDestination, 
                    string deliveryDestnationCode, 
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
                    int? customerId, 
                    string createBy, 
                    DateTime? createDate, 
                    string updateBy, 
                    DateTime? updateDate, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex, 
                    string dataView)
        {
            PageRequest request = CreateRequest(autoId, orderBy, deliveryDestination, deliveryDestnationCode, customerMatCode, partsDevision, customerPO, key1, key2, key3, reliabilityDevision, deliveryDate, quantity, unit, plngPeriod, sAPCode, customerId, createBy, createDate, updateBy, updateDate, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("OrdersForcast", dataView, request);
            return page.ToList<MyCompany.Data.Objects.OrdersForcast>();
        }
        
        public List<MyCompany.Data.Objects.OrdersForcast> Select(MyCompany.Data.Objects.OrdersForcast qbe)
        {
            return Select(qbe.AutoId, qbe.OrderBy, qbe.DeliveryDestination, qbe.DeliveryDestnationCode, qbe.CustomerMatCode, qbe.PartsDevision, qbe.CustomerPO, qbe.Key1, qbe.Key2, qbe.Key3, qbe.ReliabilityDevision, qbe.DeliveryDate, qbe.Quantity, qbe.Unit, qbe.PlngPeriod, qbe.SAPCode, qbe.CustomerId, qbe.CreateBy, qbe.CreateDate, qbe.UpdateBy, qbe.UpdateDate);
        }
        
        public int SelectCount(
                    decimal? autoId, 
                    string orderBy, 
                    string deliveryDestination, 
                    string deliveryDestnationCode, 
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
                    int? customerId, 
                    string createBy, 
                    DateTime? createDate, 
                    string updateBy, 
                    DateTime? updateDate, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex, 
                    string dataView)
        {
            PageRequest request = CreateRequest(autoId, orderBy, deliveryDestination, deliveryDestnationCode, customerMatCode, partsDevision, customerPO, key1, key2, key3, reliabilityDevision, deliveryDate, quantity, unit, plngPeriod, sAPCode, customerId, createBy, createDate, updateBy, updateDate, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("OrdersForcast", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<MyCompany.Data.Objects.OrdersForcast> Select(
                    decimal? autoId, 
                    string orderBy, 
                    string deliveryDestination, 
                    string deliveryDestnationCode, 
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
                    int? customerId, 
                    string createBy, 
                    DateTime? createDate, 
                    string updateBy, 
                    DateTime? updateDate)
        {
            return Select(autoId, orderBy, deliveryDestination, deliveryDestnationCode, customerMatCode, partsDevision, customerPO, key1, key2, key3, reliabilityDevision, deliveryDate, quantity, unit, plngPeriod, sAPCode, customerId, createBy, createDate, updateBy, updateDate, null, Int32.MaxValue, 0, SelectView);
        }
        
        public MyCompany.Data.Objects.OrdersForcast SelectSingle(decimal? autoId)
        {
            List<MyCompany.Data.Objects.OrdersForcast> list = Select(autoId, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<MyCompany.Data.Objects.OrdersForcast> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("OrdersForcast", dataView, request);
            return page.ToList<MyCompany.Data.Objects.OrdersForcast>();
        }
        
        public List<MyCompany.Data.Objects.OrdersForcast> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<MyCompany.Data.Objects.OrdersForcast> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public MyCompany.Data.Objects.OrdersForcast SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<MyCompany.Data.Objects.OrdersForcast> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(MyCompany.Data.Objects.OrdersForcast theOrdersForcast, MyCompany.Data.Objects.OrdersForcast original_OrdersForcast)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("AutoId", original_OrdersForcast.AutoId, theOrdersForcast.AutoId, true));
            values.Add(new FieldValue("OrderBy", original_OrdersForcast.OrderBy, theOrdersForcast.OrderBy));
            values.Add(new FieldValue("DeliveryDestination", original_OrdersForcast.DeliveryDestination, theOrdersForcast.DeliveryDestination));
            values.Add(new FieldValue("DeliveryDestnationCode", original_OrdersForcast.DeliveryDestnationCode, theOrdersForcast.DeliveryDestnationCode));
            values.Add(new FieldValue("CustomerMatCode", original_OrdersForcast.CustomerMatCode, theOrdersForcast.CustomerMatCode));
            values.Add(new FieldValue("PartsDevision", original_OrdersForcast.PartsDevision, theOrdersForcast.PartsDevision));
            values.Add(new FieldValue("CustomerPO", original_OrdersForcast.CustomerPO, theOrdersForcast.CustomerPO));
            values.Add(new FieldValue("Key1", original_OrdersForcast.Key1, theOrdersForcast.Key1));
            values.Add(new FieldValue("Key2", original_OrdersForcast.Key2, theOrdersForcast.Key2));
            values.Add(new FieldValue("Key3", original_OrdersForcast.Key3, theOrdersForcast.Key3));
            values.Add(new FieldValue("ReliabilityDevision", original_OrdersForcast.ReliabilityDevision, theOrdersForcast.ReliabilityDevision));
            values.Add(new FieldValue("DeliveryDate", original_OrdersForcast.DeliveryDate, theOrdersForcast.DeliveryDate));
            values.Add(new FieldValue("Quantity", original_OrdersForcast.Quantity, theOrdersForcast.Quantity));
            values.Add(new FieldValue("Unit", original_OrdersForcast.Unit, theOrdersForcast.Unit));
            values.Add(new FieldValue("PlngPeriod", original_OrdersForcast.PlngPeriod, theOrdersForcast.PlngPeriod));
            values.Add(new FieldValue("SAPCode", original_OrdersForcast.SAPCode, theOrdersForcast.SAPCode));
            values.Add(new FieldValue("CustomerId", original_OrdersForcast.CustomerId, theOrdersForcast.CustomerId));
            values.Add(new FieldValue("CreateBy", original_OrdersForcast.CreateBy, theOrdersForcast.CreateBy));
            values.Add(new FieldValue("CreateDate", original_OrdersForcast.CreateDate, theOrdersForcast.CreateDate));
            values.Add(new FieldValue("UpdateBy", original_OrdersForcast.UpdateBy, theOrdersForcast.UpdateBy));
            values.Add(new FieldValue("UpdateDate", original_OrdersForcast.UpdateDate, theOrdersForcast.UpdateDate));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(MyCompany.Data.Objects.OrdersForcast theOrdersForcast, MyCompany.Data.Objects.OrdersForcast original_OrdersForcast, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "OrdersForcast";
            args.View = dataView;
            args.Values = CreateFieldValues(theOrdersForcast, original_OrdersForcast);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("OrdersForcast", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theOrdersForcast);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(MyCompany.Data.Objects.OrdersForcast theOrdersForcast, MyCompany.Data.Objects.OrdersForcast original_OrdersForcast)
        {
            return ExecuteAction(theOrdersForcast, original_OrdersForcast, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(MyCompany.Data.Objects.OrdersForcast theOrdersForcast)
        {
            return Update(theOrdersForcast, SelectSingle(theOrdersForcast.AutoId));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(MyCompany.Data.Objects.OrdersForcast theOrdersForcast)
        {
            return ExecuteAction(theOrdersForcast, new OrdersForcast(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(MyCompany.Data.Objects.OrdersForcast theOrdersForcast)
        {
            return ExecuteAction(theOrdersForcast, theOrdersForcast, "Select", "Delete", DeleteView);
        }
    }
}
