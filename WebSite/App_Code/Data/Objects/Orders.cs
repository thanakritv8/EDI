using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace MyCompany.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class Orders
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
        
        public Orders()
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
        
        public static List<MyCompany.Data.Objects.Orders> Select(
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
            return new OrdersFactory().Select(autoId, orderBy, deliveryDestination, deliveryDestnationCode, customerMatCode, partsDevision, customerPO, key1, key2, key3, reliabilityDevision, deliveryDate, quantity, unit, plngPeriod, sAPCode, customerId, createBy, createDate, updateBy, updateDate);
        }
        
        public static List<MyCompany.Data.Objects.Orders> Select(MyCompany.Data.Objects.Orders qbe)
        {
            return new OrdersFactory().Select(qbe);
        }
        
        public static List<MyCompany.Data.Objects.Orders> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new OrdersFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.Orders> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new OrdersFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<MyCompany.Data.Objects.Orders> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new OrdersFactory().Select(filter, sort, OrdersFactory.SelectView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.Orders> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new OrdersFactory().Select(filter, sort, OrdersFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<MyCompany.Data.Objects.Orders> Select(string filter, BusinessObjectParameters parameters)
        {
            return new OrdersFactory().Select(filter, null, OrdersFactory.SelectView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.Orders> Select(string filter, params FieldValue[] parameters)
        {
            return new OrdersFactory().Select(filter, null, OrdersFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static MyCompany.Data.Objects.Orders SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new OrdersFactory().SelectSingle(filter, parameters);
        }
        
        public static MyCompany.Data.Objects.Orders SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new OrdersFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static MyCompany.Data.Objects.Orders SelectSingle(decimal? autoId)
        {
            return new OrdersFactory().SelectSingle(autoId);
        }
        
        public int Insert()
        {
            return new OrdersFactory().Insert(this);
        }
        
        public int Update()
        {
            return new OrdersFactory().Update(this);
        }
        
        public int Delete()
        {
            return new OrdersFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("AutoId: {0}", this.AutoId);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class OrdersFactory
    {
        
        public OrdersFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("Orders");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("Orders");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("Orders");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("Orders");
            }
        }
        
        public static OrdersFactory Create()
        {
            return new OrdersFactory();
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
        public List<MyCompany.Data.Objects.Orders> Select(
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
            ViewPage page = ControllerFactory.CreateDataController().GetPage("Orders", dataView, request);
            return page.ToList<MyCompany.Data.Objects.Orders>();
        }
        
        public List<MyCompany.Data.Objects.Orders> Select(MyCompany.Data.Objects.Orders qbe)
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
            ViewPage page = ControllerFactory.CreateDataController().GetPage("Orders", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<MyCompany.Data.Objects.Orders> Select(
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
        
        public MyCompany.Data.Objects.Orders SelectSingle(decimal? autoId)
        {
            List<MyCompany.Data.Objects.Orders> list = Select(autoId, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<MyCompany.Data.Objects.Orders> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("Orders", dataView, request);
            return page.ToList<MyCompany.Data.Objects.Orders>();
        }
        
        public List<MyCompany.Data.Objects.Orders> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<MyCompany.Data.Objects.Orders> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public MyCompany.Data.Objects.Orders SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<MyCompany.Data.Objects.Orders> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(MyCompany.Data.Objects.Orders theOrders, MyCompany.Data.Objects.Orders original_Orders)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("AutoId", original_Orders.AutoId, theOrders.AutoId, true));
            values.Add(new FieldValue("OrderBy", original_Orders.OrderBy, theOrders.OrderBy));
            values.Add(new FieldValue("DeliveryDestination", original_Orders.DeliveryDestination, theOrders.DeliveryDestination));
            values.Add(new FieldValue("DeliveryDestnationCode", original_Orders.DeliveryDestnationCode, theOrders.DeliveryDestnationCode));
            values.Add(new FieldValue("CustomerMatCode", original_Orders.CustomerMatCode, theOrders.CustomerMatCode));
            values.Add(new FieldValue("PartsDevision", original_Orders.PartsDevision, theOrders.PartsDevision));
            values.Add(new FieldValue("CustomerPO", original_Orders.CustomerPO, theOrders.CustomerPO));
            values.Add(new FieldValue("Key1", original_Orders.Key1, theOrders.Key1));
            values.Add(new FieldValue("Key2", original_Orders.Key2, theOrders.Key2));
            values.Add(new FieldValue("Key3", original_Orders.Key3, theOrders.Key3));
            values.Add(new FieldValue("ReliabilityDevision", original_Orders.ReliabilityDevision, theOrders.ReliabilityDevision));
            values.Add(new FieldValue("DeliveryDate", original_Orders.DeliveryDate, theOrders.DeliveryDate));
            values.Add(new FieldValue("Quantity", original_Orders.Quantity, theOrders.Quantity));
            values.Add(new FieldValue("Unit", original_Orders.Unit, theOrders.Unit));
            values.Add(new FieldValue("PlngPeriod", original_Orders.PlngPeriod, theOrders.PlngPeriod));
            values.Add(new FieldValue("SAPCode", original_Orders.SAPCode, theOrders.SAPCode));
            values.Add(new FieldValue("CustomerId", original_Orders.CustomerId, theOrders.CustomerId));
            values.Add(new FieldValue("CreateBy", original_Orders.CreateBy, theOrders.CreateBy));
            values.Add(new FieldValue("CreateDate", original_Orders.CreateDate, theOrders.CreateDate));
            values.Add(new FieldValue("UpdateBy", original_Orders.UpdateBy, theOrders.UpdateBy));
            values.Add(new FieldValue("UpdateDate", original_Orders.UpdateDate, theOrders.UpdateDate));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(MyCompany.Data.Objects.Orders theOrders, MyCompany.Data.Objects.Orders original_Orders, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "Orders";
            args.View = dataView;
            args.Values = CreateFieldValues(theOrders, original_Orders);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("Orders", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theOrders);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(MyCompany.Data.Objects.Orders theOrders, MyCompany.Data.Objects.Orders original_Orders)
        {
            return ExecuteAction(theOrders, original_Orders, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(MyCompany.Data.Objects.Orders theOrders)
        {
            return Update(theOrders, SelectSingle(theOrders.AutoId));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(MyCompany.Data.Objects.Orders theOrders)
        {
            return ExecuteAction(theOrders, new Orders(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(MyCompany.Data.Objects.Orders theOrders)
        {
            return ExecuteAction(theOrders, theOrders, "Select", "Delete", DeleteView);
        }
    }
}
