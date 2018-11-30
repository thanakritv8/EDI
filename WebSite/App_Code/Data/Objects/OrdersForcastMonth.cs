using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace MyCompany.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class OrdersForcastMonth
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
        private int? _customerId;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _createBy;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _createDate;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _updateBy;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _updateDate;
        
        public OrdersForcastMonth()
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
        
        public static List<MyCompany.Data.Objects.OrdersForcastMonth> Select(
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
                    int? customerId, 
                    string createBy, 
                    DateTime? createDate, 
                    string updateBy, 
                    DateTime? updateDate)
        {
            return new OrdersForcastMonthFactory().Select(autoId, orderBy, deliveryDestination, customerMatCode, partsDevision, customerPO, key1, key2, key3, reliabilityDevision, deliveryDate, quantity, unit, plngPeriod, sAPCode, customerId, createBy, createDate, updateBy, updateDate);
        }
        
        public static List<MyCompany.Data.Objects.OrdersForcastMonth> Select(MyCompany.Data.Objects.OrdersForcastMonth qbe)
        {
            return new OrdersForcastMonthFactory().Select(qbe);
        }
        
        public static List<MyCompany.Data.Objects.OrdersForcastMonth> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new OrdersForcastMonthFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.OrdersForcastMonth> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new OrdersForcastMonthFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<MyCompany.Data.Objects.OrdersForcastMonth> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new OrdersForcastMonthFactory().Select(filter, sort, OrdersForcastMonthFactory.SelectView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.OrdersForcastMonth> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new OrdersForcastMonthFactory().Select(filter, sort, OrdersForcastMonthFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<MyCompany.Data.Objects.OrdersForcastMonth> Select(string filter, BusinessObjectParameters parameters)
        {
            return new OrdersForcastMonthFactory().Select(filter, null, OrdersForcastMonthFactory.SelectView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.OrdersForcastMonth> Select(string filter, params FieldValue[] parameters)
        {
            return new OrdersForcastMonthFactory().Select(filter, null, OrdersForcastMonthFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static MyCompany.Data.Objects.OrdersForcastMonth SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new OrdersForcastMonthFactory().SelectSingle(filter, parameters);
        }
        
        public static MyCompany.Data.Objects.OrdersForcastMonth SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new OrdersForcastMonthFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static MyCompany.Data.Objects.OrdersForcastMonth SelectSingle(decimal? autoId)
        {
            return new OrdersForcastMonthFactory().SelectSingle(autoId);
        }
        
        public int Insert()
        {
            return new OrdersForcastMonthFactory().Insert(this);
        }
        
        public int Update()
        {
            return new OrdersForcastMonthFactory().Update(this);
        }
        
        public int Delete()
        {
            return new OrdersForcastMonthFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("AutoId: {0}", this.AutoId);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class OrdersForcastMonthFactory
    {
        
        public OrdersForcastMonthFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("OrdersForcastMonth");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("OrdersForcastMonth");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("OrdersForcastMonth");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("OrdersForcastMonth");
            }
        }
        
        public static OrdersForcastMonthFactory Create()
        {
            return new OrdersForcastMonthFactory();
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
        public List<MyCompany.Data.Objects.OrdersForcastMonth> Select(
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
            PageRequest request = CreateRequest(autoId, orderBy, deliveryDestination, customerMatCode, partsDevision, customerPO, key1, key2, key3, reliabilityDevision, deliveryDate, quantity, unit, plngPeriod, sAPCode, customerId, createBy, createDate, updateBy, updateDate, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("OrdersForcastMonth", dataView, request);
            return page.ToList<MyCompany.Data.Objects.OrdersForcastMonth>();
        }
        
        public List<MyCompany.Data.Objects.OrdersForcastMonth> Select(MyCompany.Data.Objects.OrdersForcastMonth qbe)
        {
            return Select(qbe.AutoId, qbe.OrderBy, qbe.DeliveryDestination, qbe.CustomerMatCode, qbe.PartsDevision, qbe.CustomerPO, qbe.Key1, qbe.Key2, qbe.Key3, qbe.ReliabilityDevision, qbe.DeliveryDate, qbe.Quantity, qbe.Unit, qbe.PlngPeriod, qbe.SAPCode, qbe.CustomerId, qbe.CreateBy, qbe.CreateDate, qbe.UpdateBy, qbe.UpdateDate);
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
            PageRequest request = CreateRequest(autoId, orderBy, deliveryDestination, customerMatCode, partsDevision, customerPO, key1, key2, key3, reliabilityDevision, deliveryDate, quantity, unit, plngPeriod, sAPCode, customerId, createBy, createDate, updateBy, updateDate, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("OrdersForcastMonth", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<MyCompany.Data.Objects.OrdersForcastMonth> Select(
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
                    int? customerId, 
                    string createBy, 
                    DateTime? createDate, 
                    string updateBy, 
                    DateTime? updateDate)
        {
            return Select(autoId, orderBy, deliveryDestination, customerMatCode, partsDevision, customerPO, key1, key2, key3, reliabilityDevision, deliveryDate, quantity, unit, plngPeriod, sAPCode, customerId, createBy, createDate, updateBy, updateDate, null, Int32.MaxValue, 0, SelectView);
        }
        
        public MyCompany.Data.Objects.OrdersForcastMonth SelectSingle(decimal? autoId)
        {
            List<MyCompany.Data.Objects.OrdersForcastMonth> list = Select(autoId, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<MyCompany.Data.Objects.OrdersForcastMonth> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("OrdersForcastMonth", dataView, request);
            return page.ToList<MyCompany.Data.Objects.OrdersForcastMonth>();
        }
        
        public List<MyCompany.Data.Objects.OrdersForcastMonth> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<MyCompany.Data.Objects.OrdersForcastMonth> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public MyCompany.Data.Objects.OrdersForcastMonth SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<MyCompany.Data.Objects.OrdersForcastMonth> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(MyCompany.Data.Objects.OrdersForcastMonth theOrdersForcastMonth, MyCompany.Data.Objects.OrdersForcastMonth original_OrdersForcastMonth)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("AutoId", original_OrdersForcastMonth.AutoId, theOrdersForcastMonth.AutoId, true));
            values.Add(new FieldValue("OrderBy", original_OrdersForcastMonth.OrderBy, theOrdersForcastMonth.OrderBy));
            values.Add(new FieldValue("DeliveryDestination", original_OrdersForcastMonth.DeliveryDestination, theOrdersForcastMonth.DeliveryDestination));
            values.Add(new FieldValue("CustomerMatCode", original_OrdersForcastMonth.CustomerMatCode, theOrdersForcastMonth.CustomerMatCode));
            values.Add(new FieldValue("PartsDevision", original_OrdersForcastMonth.PartsDevision, theOrdersForcastMonth.PartsDevision));
            values.Add(new FieldValue("CustomerPO", original_OrdersForcastMonth.CustomerPO, theOrdersForcastMonth.CustomerPO));
            values.Add(new FieldValue("Key1", original_OrdersForcastMonth.Key1, theOrdersForcastMonth.Key1));
            values.Add(new FieldValue("Key2", original_OrdersForcastMonth.Key2, theOrdersForcastMonth.Key2));
            values.Add(new FieldValue("Key3", original_OrdersForcastMonth.Key3, theOrdersForcastMonth.Key3));
            values.Add(new FieldValue("ReliabilityDevision", original_OrdersForcastMonth.ReliabilityDevision, theOrdersForcastMonth.ReliabilityDevision));
            values.Add(new FieldValue("DeliveryDate", original_OrdersForcastMonth.DeliveryDate, theOrdersForcastMonth.DeliveryDate));
            values.Add(new FieldValue("Quantity", original_OrdersForcastMonth.Quantity, theOrdersForcastMonth.Quantity));
            values.Add(new FieldValue("Unit", original_OrdersForcastMonth.Unit, theOrdersForcastMonth.Unit));
            values.Add(new FieldValue("PlngPeriod", original_OrdersForcastMonth.PlngPeriod, theOrdersForcastMonth.PlngPeriod));
            values.Add(new FieldValue("SAPCode", original_OrdersForcastMonth.SAPCode, theOrdersForcastMonth.SAPCode));
            values.Add(new FieldValue("CustomerId", original_OrdersForcastMonth.CustomerId, theOrdersForcastMonth.CustomerId));
            values.Add(new FieldValue("CreateBy", original_OrdersForcastMonth.CreateBy, theOrdersForcastMonth.CreateBy));
            values.Add(new FieldValue("CreateDate", original_OrdersForcastMonth.CreateDate, theOrdersForcastMonth.CreateDate));
            values.Add(new FieldValue("UpdateBy", original_OrdersForcastMonth.UpdateBy, theOrdersForcastMonth.UpdateBy));
            values.Add(new FieldValue("UpdateDate", original_OrdersForcastMonth.UpdateDate, theOrdersForcastMonth.UpdateDate));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(MyCompany.Data.Objects.OrdersForcastMonth theOrdersForcastMonth, MyCompany.Data.Objects.OrdersForcastMonth original_OrdersForcastMonth, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "OrdersForcastMonth";
            args.View = dataView;
            args.Values = CreateFieldValues(theOrdersForcastMonth, original_OrdersForcastMonth);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("OrdersForcastMonth", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theOrdersForcastMonth);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(MyCompany.Data.Objects.OrdersForcastMonth theOrdersForcastMonth, MyCompany.Data.Objects.OrdersForcastMonth original_OrdersForcastMonth)
        {
            return ExecuteAction(theOrdersForcastMonth, original_OrdersForcastMonth, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(MyCompany.Data.Objects.OrdersForcastMonth theOrdersForcastMonth)
        {
            return Update(theOrdersForcastMonth, SelectSingle(theOrdersForcastMonth.AutoId));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(MyCompany.Data.Objects.OrdersForcastMonth theOrdersForcastMonth)
        {
            return ExecuteAction(theOrdersForcastMonth, new OrdersForcastMonth(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(MyCompany.Data.Objects.OrdersForcastMonth theOrdersForcastMonth)
        {
            return ExecuteAction(theOrdersForcastMonth, theOrdersForcastMonth, "Select", "Delete", DeleteView);
        }
    }
}
