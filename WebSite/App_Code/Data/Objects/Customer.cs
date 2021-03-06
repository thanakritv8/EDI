﻿using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace MyCompany.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class Customer
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _customerId;
        
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
        
        public Customer()
        {
        }
        
        [System.ComponentModel.DataObjectField(true, true, false)]
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
        
        public static List<MyCompany.Data.Objects.Customer> Select(
                    int? customerId, 
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
                    DateTime? updateDate)
        {
            return new CustomerFactory().Select(customerId, code, name, code2, code3, locationCode, plantCode, addressCode, contact, address, city, state, country, zIPCode, phone, mobile, fax, email, createBy, createDate, updateBy, updateDate);
        }
        
        public static List<MyCompany.Data.Objects.Customer> Select(MyCompany.Data.Objects.Customer qbe)
        {
            return new CustomerFactory().Select(qbe);
        }
        
        public static List<MyCompany.Data.Objects.Customer> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new CustomerFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.Customer> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new CustomerFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<MyCompany.Data.Objects.Customer> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new CustomerFactory().Select(filter, sort, CustomerFactory.SelectView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.Customer> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new CustomerFactory().Select(filter, sort, CustomerFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<MyCompany.Data.Objects.Customer> Select(string filter, BusinessObjectParameters parameters)
        {
            return new CustomerFactory().Select(filter, null, CustomerFactory.SelectView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.Customer> Select(string filter, params FieldValue[] parameters)
        {
            return new CustomerFactory().Select(filter, null, CustomerFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static MyCompany.Data.Objects.Customer SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new CustomerFactory().SelectSingle(filter, parameters);
        }
        
        public static MyCompany.Data.Objects.Customer SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new CustomerFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static MyCompany.Data.Objects.Customer SelectSingle(int? customerId)
        {
            return new CustomerFactory().SelectSingle(customerId);
        }
        
        public int Insert()
        {
            return new CustomerFactory().Insert(this);
        }
        
        public int Update()
        {
            return new CustomerFactory().Update(this);
        }
        
        public int Delete()
        {
            return new CustomerFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("CustomerId: {0}", this.CustomerId);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class CustomerFactory
    {
        
        public CustomerFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("Customer");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("Customer");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("Customer");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("Customer");
            }
        }
        
        public static CustomerFactory Create()
        {
            return new CustomerFactory();
        }
        
        protected virtual PageRequest CreateRequest(
                    int? customerId, 
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
                    string sort, 
                    int maximumRows, 
                    int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (customerId.HasValue)
            	filter.Add(("CustomerId:=" + customerId.Value.ToString()));
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
            return new PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray());
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public List<MyCompany.Data.Objects.Customer> Select(
                    int? customerId, 
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
                    string sort, 
                    int maximumRows, 
                    int startRowIndex, 
                    string dataView)
        {
            PageRequest request = CreateRequest(customerId, code, name, code2, code3, locationCode, plantCode, addressCode, contact, address, city, state, country, zIPCode, phone, mobile, fax, email, createBy, createDate, updateBy, updateDate, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("Customer", dataView, request);
            return page.ToList<MyCompany.Data.Objects.Customer>();
        }
        
        public List<MyCompany.Data.Objects.Customer> Select(MyCompany.Data.Objects.Customer qbe)
        {
            return Select(qbe.CustomerId, qbe.Code, qbe.Name, qbe.Code2, qbe.Code3, qbe.LocationCode, qbe.PlantCode, qbe.AddressCode, qbe.Contact, qbe.Address, qbe.City, qbe.State, qbe.Country, qbe.ZIPCode, qbe.Phone, qbe.Mobile, qbe.Fax, qbe.Email, qbe.CreateBy, qbe.CreateDate, qbe.UpdateBy, qbe.UpdateDate);
        }
        
        public int SelectCount(
                    int? customerId, 
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
                    string sort, 
                    int maximumRows, 
                    int startRowIndex, 
                    string dataView)
        {
            PageRequest request = CreateRequest(customerId, code, name, code2, code3, locationCode, plantCode, addressCode, contact, address, city, state, country, zIPCode, phone, mobile, fax, email, createBy, createDate, updateBy, updateDate, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("Customer", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<MyCompany.Data.Objects.Customer> Select(
                    int? customerId, 
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
                    DateTime? updateDate)
        {
            return Select(customerId, code, name, code2, code3, locationCode, plantCode, addressCode, contact, address, city, state, country, zIPCode, phone, mobile, fax, email, createBy, createDate, updateBy, updateDate, null, Int32.MaxValue, 0, SelectView);
        }
        
        public MyCompany.Data.Objects.Customer SelectSingle(int? customerId)
        {
            List<MyCompany.Data.Objects.Customer> list = Select(customerId, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<MyCompany.Data.Objects.Customer> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("Customer", dataView, request);
            return page.ToList<MyCompany.Data.Objects.Customer>();
        }
        
        public List<MyCompany.Data.Objects.Customer> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<MyCompany.Data.Objects.Customer> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public MyCompany.Data.Objects.Customer SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<MyCompany.Data.Objects.Customer> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(MyCompany.Data.Objects.Customer theCustomer, MyCompany.Data.Objects.Customer original_Customer)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("CustomerId", original_Customer.CustomerId, theCustomer.CustomerId, true));
            values.Add(new FieldValue("Code", original_Customer.Code, theCustomer.Code));
            values.Add(new FieldValue("Name", original_Customer.Name, theCustomer.Name));
            values.Add(new FieldValue("Code2", original_Customer.Code2, theCustomer.Code2));
            values.Add(new FieldValue("Code3", original_Customer.Code3, theCustomer.Code3));
            values.Add(new FieldValue("LocationCode", original_Customer.LocationCode, theCustomer.LocationCode));
            values.Add(new FieldValue("PlantCode", original_Customer.PlantCode, theCustomer.PlantCode));
            values.Add(new FieldValue("AddressCode", original_Customer.AddressCode, theCustomer.AddressCode));
            values.Add(new FieldValue("Contact", original_Customer.Contact, theCustomer.Contact));
            values.Add(new FieldValue("Address", original_Customer.Address, theCustomer.Address));
            values.Add(new FieldValue("City", original_Customer.City, theCustomer.City));
            values.Add(new FieldValue("State", original_Customer.State, theCustomer.State));
            values.Add(new FieldValue("Country", original_Customer.Country, theCustomer.Country));
            values.Add(new FieldValue("ZIPCode", original_Customer.ZIPCode, theCustomer.ZIPCode));
            values.Add(new FieldValue("Phone", original_Customer.Phone, theCustomer.Phone));
            values.Add(new FieldValue("Mobile", original_Customer.Mobile, theCustomer.Mobile));
            values.Add(new FieldValue("Fax", original_Customer.Fax, theCustomer.Fax));
            values.Add(new FieldValue("Email", original_Customer.Email, theCustomer.Email));
            values.Add(new FieldValue("Remark", original_Customer.Remark, theCustomer.Remark));
            values.Add(new FieldValue("CreateBy", original_Customer.CreateBy, theCustomer.CreateBy));
            values.Add(new FieldValue("CreateDate", original_Customer.CreateDate, theCustomer.CreateDate));
            values.Add(new FieldValue("UpdateBy", original_Customer.UpdateBy, theCustomer.UpdateBy));
            values.Add(new FieldValue("UpdateDate", original_Customer.UpdateDate, theCustomer.UpdateDate));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(MyCompany.Data.Objects.Customer theCustomer, MyCompany.Data.Objects.Customer original_Customer, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "Customer";
            args.View = dataView;
            args.Values = CreateFieldValues(theCustomer, original_Customer);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("Customer", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theCustomer);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(MyCompany.Data.Objects.Customer theCustomer, MyCompany.Data.Objects.Customer original_Customer)
        {
            return ExecuteAction(theCustomer, original_Customer, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(MyCompany.Data.Objects.Customer theCustomer)
        {
            return Update(theCustomer, SelectSingle(theCustomer.CustomerId));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(MyCompany.Data.Objects.Customer theCustomer)
        {
            return ExecuteAction(theCustomer, new Customer(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(MyCompany.Data.Objects.Customer theCustomer)
        {
            return ExecuteAction(theCustomer, theCustomer, "Select", "Delete", DeleteView);
        }
    }
}
