using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace MyCompany.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class CustomerImportLog
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _logId;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _autoId;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _code;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _name;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _code2;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _code3;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _locationCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _plantCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _addressCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _contact;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _address;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _city;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _state;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _country;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _zIPCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _phone;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _mobile;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _fax;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _email;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _remark;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _createBy;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _createDate;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _updateBy;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _updateDate;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _executeDate;
        
        public CustomerImportLog()
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
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public string Code
        {
            get
            {
                return _code;
            }
            set
            {
                _code = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Code2
        {
            get
            {
                return _code2;
            }
            set
            {
                _code2 = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Code3
        {
            get
            {
                return _code3;
            }
            set
            {
                _code3 = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string LocationCode
        {
            get
            {
                return _locationCode;
            }
            set
            {
                _locationCode = value;
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
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AddressCode
        {
            get
            {
                return _addressCode;
            }
            set
            {
                _addressCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Contact
        {
            get
            {
                return _contact;
            }
            set
            {
                _contact = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Address
        {
            get
            {
                return _address;
            }
            set
            {
                _address = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string City
        {
            get
            {
                return _city;
            }
            set
            {
                _city = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string State
        {
            get
            {
                return _state;
            }
            set
            {
                _state = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Country
        {
            get
            {
                return _country;
            }
            set
            {
                _country = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string ZIPCode
        {
            get
            {
                return _zIPCode;
            }
            set
            {
                _zIPCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Phone
        {
            get
            {
                return _phone;
            }
            set
            {
                _phone = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Mobile
        {
            get
            {
                return _mobile;
            }
            set
            {
                _mobile = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Fax
        {
            get
            {
                return _fax;
            }
            set
            {
                _fax = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                _email = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Remark
        {
            get
            {
                return _remark;
            }
            set
            {
                _remark = value;
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
        
        public static List<MyCompany.Data.Objects.CustomerImportLog> Select(
                    decimal? logId, 
                    int? autoId, 
                    string code, 
                    string name, 
                    string code2, 
                    string code3, 
                    string locationCode, 
                    string plantCode, 
                    string addressCode, 
                    string contact, 
                    string address, 
                    string city, 
                    string state, 
                    string country, 
                    string zIPCode, 
                    string phone, 
                    string mobile, 
                    string fax, 
                    string email, 
                    string createBy, 
                    DateTime? createDate, 
                    string updateBy, 
                    DateTime? updateDate, 
                    DateTime? executeDate)
        {
            return new CustomerImportLogFactory().Select(logId, autoId, code, name, code2, code3, locationCode, plantCode, addressCode, contact, address, city, state, country, zIPCode, phone, mobile, fax, email, createBy, createDate, updateBy, updateDate, executeDate);
        }
        
        public static List<MyCompany.Data.Objects.CustomerImportLog> Select(MyCompany.Data.Objects.CustomerImportLog qbe)
        {
            return new CustomerImportLogFactory().Select(qbe);
        }
        
        public static List<MyCompany.Data.Objects.CustomerImportLog> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new CustomerImportLogFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.CustomerImportLog> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new CustomerImportLogFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<MyCompany.Data.Objects.CustomerImportLog> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new CustomerImportLogFactory().Select(filter, sort, CustomerImportLogFactory.SelectView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.CustomerImportLog> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new CustomerImportLogFactory().Select(filter, sort, CustomerImportLogFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<MyCompany.Data.Objects.CustomerImportLog> Select(string filter, BusinessObjectParameters parameters)
        {
            return new CustomerImportLogFactory().Select(filter, null, CustomerImportLogFactory.SelectView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.CustomerImportLog> Select(string filter, params FieldValue[] parameters)
        {
            return new CustomerImportLogFactory().Select(filter, null, CustomerImportLogFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static MyCompany.Data.Objects.CustomerImportLog SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new CustomerImportLogFactory().SelectSingle(filter, parameters);
        }
        
        public static MyCompany.Data.Objects.CustomerImportLog SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new CustomerImportLogFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static MyCompany.Data.Objects.CustomerImportLog SelectSingle(decimal? logId)
        {
            return new CustomerImportLogFactory().SelectSingle(logId);
        }
        
        public int Insert()
        {
            return new CustomerImportLogFactory().Insert(this);
        }
        
        public int Update()
        {
            return new CustomerImportLogFactory().Update(this);
        }
        
        public int Delete()
        {
            return new CustomerImportLogFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("LogId: {0}", this.LogId);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class CustomerImportLogFactory
    {
        
        public CustomerImportLogFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("CustomerImportLog");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("CustomerImportLog");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("CustomerImportLog");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("CustomerImportLog");
            }
        }
        
        public static CustomerImportLogFactory Create()
        {
            return new CustomerImportLogFactory();
        }
        
        protected virtual PageRequest CreateRequest(
                    decimal? logId, 
                    int? autoId, 
                    string code, 
                    string name, 
                    string code2, 
                    string code3, 
                    string locationCode, 
                    string plantCode, 
                    string addressCode, 
                    string contact, 
                    string address, 
                    string city, 
                    string state, 
                    string country, 
                    string zIPCode, 
                    string phone, 
                    string mobile, 
                    string fax, 
                    string email, 
                    string createBy, 
                    DateTime? createDate, 
                    string updateBy, 
                    DateTime? updateDate, 
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
            if (!(String.IsNullOrEmpty(code)))
            	filter.Add(("Code:*" + code));
            if (!(String.IsNullOrEmpty(name)))
            	filter.Add(("Name:*" + name));
            if (!(String.IsNullOrEmpty(code2)))
            	filter.Add(("Code2:*" + code2));
            if (!(String.IsNullOrEmpty(code3)))
            	filter.Add(("Code3:*" + code3));
            if (!(String.IsNullOrEmpty(locationCode)))
            	filter.Add(("LocationCode:*" + locationCode));
            if (!(String.IsNullOrEmpty(plantCode)))
            	filter.Add(("PlantCode:*" + plantCode));
            if (!(String.IsNullOrEmpty(addressCode)))
            	filter.Add(("AddressCode:*" + addressCode));
            if (!(String.IsNullOrEmpty(contact)))
            	filter.Add(("Contact:*" + contact));
            if (!(String.IsNullOrEmpty(address)))
            	filter.Add(("Address:*" + address));
            if (!(String.IsNullOrEmpty(city)))
            	filter.Add(("City:*" + city));
            if (!(String.IsNullOrEmpty(state)))
            	filter.Add(("State:*" + state));
            if (!(String.IsNullOrEmpty(country)))
            	filter.Add(("Country:*" + country));
            if (!(String.IsNullOrEmpty(zIPCode)))
            	filter.Add(("ZIPCode:*" + zIPCode));
            if (!(String.IsNullOrEmpty(phone)))
            	filter.Add(("Phone:*" + phone));
            if (!(String.IsNullOrEmpty(mobile)))
            	filter.Add(("Mobile:*" + mobile));
            if (!(String.IsNullOrEmpty(fax)))
            	filter.Add(("Fax:*" + fax));
            if (!(String.IsNullOrEmpty(email)))
            	filter.Add(("Email:*" + email));
            if (!(String.IsNullOrEmpty(createBy)))
            	filter.Add(("CreateBy:*" + createBy));
            if (createDate.HasValue)
            	filter.Add(("CreateDate:=" + createDate.Value.ToString()));
            if (!(String.IsNullOrEmpty(updateBy)))
            	filter.Add(("UpdateBy:*" + updateBy));
            if (updateDate.HasValue)
            	filter.Add(("UpdateDate:=" + updateDate.Value.ToString()));
            if (executeDate.HasValue)
            	filter.Add(("ExecuteDate:=" + executeDate.Value.ToString()));
            return new PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray());
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public List<MyCompany.Data.Objects.CustomerImportLog> Select(
                    decimal? logId, 
                    int? autoId, 
                    string code, 
                    string name, 
                    string code2, 
                    string code3, 
                    string locationCode, 
                    string plantCode, 
                    string addressCode, 
                    string contact, 
                    string address, 
                    string city, 
                    string state, 
                    string country, 
                    string zIPCode, 
                    string phone, 
                    string mobile, 
                    string fax, 
                    string email, 
                    string createBy, 
                    DateTime? createDate, 
                    string updateBy, 
                    DateTime? updateDate, 
                    DateTime? executeDate, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex, 
                    string dataView)
        {
            PageRequest request = CreateRequest(logId, autoId, code, name, code2, code3, locationCode, plantCode, addressCode, contact, address, city, state, country, zIPCode, phone, mobile, fax, email, createBy, createDate, updateBy, updateDate, executeDate, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("CustomerImportLog", dataView, request);
            return page.ToList<MyCompany.Data.Objects.CustomerImportLog>();
        }
        
        public List<MyCompany.Data.Objects.CustomerImportLog> Select(MyCompany.Data.Objects.CustomerImportLog qbe)
        {
            return Select(qbe.LogId, qbe.AutoId, qbe.Code, qbe.Name, qbe.Code2, qbe.Code3, qbe.LocationCode, qbe.PlantCode, qbe.AddressCode, qbe.Contact, qbe.Address, qbe.City, qbe.State, qbe.Country, qbe.ZIPCode, qbe.Phone, qbe.Mobile, qbe.Fax, qbe.Email, qbe.CreateBy, qbe.CreateDate, qbe.UpdateBy, qbe.UpdateDate, qbe.ExecuteDate);
        }
        
        public int SelectCount(
                    decimal? logId, 
                    int? autoId, 
                    string code, 
                    string name, 
                    string code2, 
                    string code3, 
                    string locationCode, 
                    string plantCode, 
                    string addressCode, 
                    string contact, 
                    string address, 
                    string city, 
                    string state, 
                    string country, 
                    string zIPCode, 
                    string phone, 
                    string mobile, 
                    string fax, 
                    string email, 
                    string createBy, 
                    DateTime? createDate, 
                    string updateBy, 
                    DateTime? updateDate, 
                    DateTime? executeDate, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex, 
                    string dataView)
        {
            PageRequest request = CreateRequest(logId, autoId, code, name, code2, code3, locationCode, plantCode, addressCode, contact, address, city, state, country, zIPCode, phone, mobile, fax, email, createBy, createDate, updateBy, updateDate, executeDate, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("CustomerImportLog", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<MyCompany.Data.Objects.CustomerImportLog> Select(
                    decimal? logId, 
                    int? autoId, 
                    string code, 
                    string name, 
                    string code2, 
                    string code3, 
                    string locationCode, 
                    string plantCode, 
                    string addressCode, 
                    string contact, 
                    string address, 
                    string city, 
                    string state, 
                    string country, 
                    string zIPCode, 
                    string phone, 
                    string mobile, 
                    string fax, 
                    string email, 
                    string createBy, 
                    DateTime? createDate, 
                    string updateBy, 
                    DateTime? updateDate, 
                    DateTime? executeDate)
        {
            return Select(logId, autoId, code, name, code2, code3, locationCode, plantCode, addressCode, contact, address, city, state, country, zIPCode, phone, mobile, fax, email, createBy, createDate, updateBy, updateDate, executeDate, null, Int32.MaxValue, 0, SelectView);
        }
        
        public MyCompany.Data.Objects.CustomerImportLog SelectSingle(decimal? logId)
        {
            List<MyCompany.Data.Objects.CustomerImportLog> list = Select(logId, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<MyCompany.Data.Objects.CustomerImportLog> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("CustomerImportLog", dataView, request);
            return page.ToList<MyCompany.Data.Objects.CustomerImportLog>();
        }
        
        public List<MyCompany.Data.Objects.CustomerImportLog> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<MyCompany.Data.Objects.CustomerImportLog> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public MyCompany.Data.Objects.CustomerImportLog SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<MyCompany.Data.Objects.CustomerImportLog> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(MyCompany.Data.Objects.CustomerImportLog theCustomerImportLog, MyCompany.Data.Objects.CustomerImportLog original_CustomerImportLog)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("LogId", original_CustomerImportLog.LogId, theCustomerImportLog.LogId, true));
            values.Add(new FieldValue("AutoId", original_CustomerImportLog.AutoId, theCustomerImportLog.AutoId));
            values.Add(new FieldValue("Code", original_CustomerImportLog.Code, theCustomerImportLog.Code));
            values.Add(new FieldValue("Name", original_CustomerImportLog.Name, theCustomerImportLog.Name));
            values.Add(new FieldValue("Code2", original_CustomerImportLog.Code2, theCustomerImportLog.Code2));
            values.Add(new FieldValue("Code3", original_CustomerImportLog.Code3, theCustomerImportLog.Code3));
            values.Add(new FieldValue("LocationCode", original_CustomerImportLog.LocationCode, theCustomerImportLog.LocationCode));
            values.Add(new FieldValue("PlantCode", original_CustomerImportLog.PlantCode, theCustomerImportLog.PlantCode));
            values.Add(new FieldValue("AddressCode", original_CustomerImportLog.AddressCode, theCustomerImportLog.AddressCode));
            values.Add(new FieldValue("Contact", original_CustomerImportLog.Contact, theCustomerImportLog.Contact));
            values.Add(new FieldValue("Address", original_CustomerImportLog.Address, theCustomerImportLog.Address));
            values.Add(new FieldValue("City", original_CustomerImportLog.City, theCustomerImportLog.City));
            values.Add(new FieldValue("State", original_CustomerImportLog.State, theCustomerImportLog.State));
            values.Add(new FieldValue("Country", original_CustomerImportLog.Country, theCustomerImportLog.Country));
            values.Add(new FieldValue("ZIPCode", original_CustomerImportLog.ZIPCode, theCustomerImportLog.ZIPCode));
            values.Add(new FieldValue("Phone", original_CustomerImportLog.Phone, theCustomerImportLog.Phone));
            values.Add(new FieldValue("Mobile", original_CustomerImportLog.Mobile, theCustomerImportLog.Mobile));
            values.Add(new FieldValue("Fax", original_CustomerImportLog.Fax, theCustomerImportLog.Fax));
            values.Add(new FieldValue("Email", original_CustomerImportLog.Email, theCustomerImportLog.Email));
            values.Add(new FieldValue("Remark", original_CustomerImportLog.Remark, theCustomerImportLog.Remark));
            values.Add(new FieldValue("CreateBy", original_CustomerImportLog.CreateBy, theCustomerImportLog.CreateBy));
            values.Add(new FieldValue("CreateDate", original_CustomerImportLog.CreateDate, theCustomerImportLog.CreateDate));
            values.Add(new FieldValue("UpdateBy", original_CustomerImportLog.UpdateBy, theCustomerImportLog.UpdateBy));
            values.Add(new FieldValue("UpdateDate", original_CustomerImportLog.UpdateDate, theCustomerImportLog.UpdateDate));
            values.Add(new FieldValue("ExecuteDate", original_CustomerImportLog.ExecuteDate, theCustomerImportLog.ExecuteDate));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(MyCompany.Data.Objects.CustomerImportLog theCustomerImportLog, MyCompany.Data.Objects.CustomerImportLog original_CustomerImportLog, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "CustomerImportLog";
            args.View = dataView;
            args.Values = CreateFieldValues(theCustomerImportLog, original_CustomerImportLog);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("CustomerImportLog", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theCustomerImportLog);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(MyCompany.Data.Objects.CustomerImportLog theCustomerImportLog, MyCompany.Data.Objects.CustomerImportLog original_CustomerImportLog)
        {
            return ExecuteAction(theCustomerImportLog, original_CustomerImportLog, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(MyCompany.Data.Objects.CustomerImportLog theCustomerImportLog)
        {
            return Update(theCustomerImportLog, SelectSingle(theCustomerImportLog.LogId));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(MyCompany.Data.Objects.CustomerImportLog theCustomerImportLog)
        {
            return ExecuteAction(theCustomerImportLog, new CustomerImportLog(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(MyCompany.Data.Objects.CustomerImportLog theCustomerImportLog)
        {
            return ExecuteAction(theCustomerImportLog, theCustomerImportLog, "Select", "Delete", DeleteView);
        }
    }
}
