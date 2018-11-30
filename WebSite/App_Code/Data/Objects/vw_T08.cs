using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace MyCompany.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class vw_T08
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _salesDocumentType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _salesOrganization;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _distributionChannel;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _division;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _soldTo;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _shipTo;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _purchaseOrderNumber;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _salesDocument;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _invoiceNumber;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _salesDocumentItemCat;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _materialCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _keyField1;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _keyField2;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _keyField3;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _rokiDeliveryPlant;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _rokiDelStorageLoc;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _goodsMovementDate;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _lastDeliveryPlant;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _lastDelStorageLoc;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _netValueInDocCurrency;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _sdDocumentCurrency;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _incotermPart1;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _incotermPart2;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _scheduleLineCat;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _scheduleLineDate;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _arrivalTime;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _expr1;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _salesUnit;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _fromTo;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _plantCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _addCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _vatRate;
        
        public vw_T08()
        {
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public string SalesDocumentType
        {
            get
            {
                return _salesDocumentType;
            }
            set
            {
                _salesDocumentType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public string SalesOrganization
        {
            get
            {
                return _salesOrganization;
            }
            set
            {
                _salesOrganization = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public string DistributionChannel
        {
            get
            {
                return _distributionChannel;
            }
            set
            {
                _distributionChannel = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public string Division
        {
            get
            {
                return _division;
            }
            set
            {
                _division = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public string SoldTo
        {
            get
            {
                return _soldTo;
            }
            set
            {
                _soldTo = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public string ShipTo
        {
            get
            {
                return _shipTo;
            }
            set
            {
                _shipTo = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public string PurchaseOrderNumber
        {
            get
            {
                return _purchaseOrderNumber;
            }
            set
            {
                _purchaseOrderNumber = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public string SalesDocument
        {
            get
            {
                return _salesDocument;
            }
            set
            {
                _salesDocument = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public string InvoiceNumber
        {
            get
            {
                return _invoiceNumber;
            }
            set
            {
                _invoiceNumber = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public string SalesDocumentItemCat
        {
            get
            {
                return _salesDocumentItemCat;
            }
            set
            {
                _salesDocumentItemCat = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public string MaterialCode
        {
            get
            {
                return _materialCode;
            }
            set
            {
                _materialCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public string KeyField1
        {
            get
            {
                return _keyField1;
            }
            set
            {
                _keyField1 = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public string KeyField2
        {
            get
            {
                return _keyField2;
            }
            set
            {
                _keyField2 = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public string KeyField3
        {
            get
            {
                return _keyField3;
            }
            set
            {
                _keyField3 = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public string RokiDeliveryPlant
        {
            get
            {
                return _rokiDeliveryPlant;
            }
            set
            {
                _rokiDeliveryPlant = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public string RokiDelStorageLoc
        {
            get
            {
                return _rokiDelStorageLoc;
            }
            set
            {
                _rokiDelStorageLoc = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public string GoodsMovementDate
        {
            get
            {
                return _goodsMovementDate;
            }
            set
            {
                _goodsMovementDate = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public string LastDeliveryPlant
        {
            get
            {
                return _lastDeliveryPlant;
            }
            set
            {
                _lastDeliveryPlant = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public string LastDelStorageLoc
        {
            get
            {
                return _lastDelStorageLoc;
            }
            set
            {
                _lastDelStorageLoc = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public string NetValueInDocCurrency
        {
            get
            {
                return _netValueInDocCurrency;
            }
            set
            {
                _netValueInDocCurrency = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public string SdDocumentCurrency
        {
            get
            {
                return _sdDocumentCurrency;
            }
            set
            {
                _sdDocumentCurrency = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public string IncotermPart1
        {
            get
            {
                return _incotermPart1;
            }
            set
            {
                _incotermPart1 = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public string IncotermPart2
        {
            get
            {
                return _incotermPart2;
            }
            set
            {
                _incotermPart2 = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public string ScheduleLineCat
        {
            get
            {
                return _scheduleLineCat;
            }
            set
            {
                _scheduleLineCat = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public string ScheduleLineDate
        {
            get
            {
                return _scheduleLineDate;
            }
            set
            {
                _scheduleLineDate = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public string ArrivalTime
        {
            get
            {
                return _arrivalTime;
            }
            set
            {
                _arrivalTime = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public string Expr1
        {
            get
            {
                return _expr1;
            }
            set
            {
                _expr1 = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public string SalesUnit
        {
            get
            {
                return _salesUnit;
            }
            set
            {
                _salesUnit = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public string FromTo
        {
            get
            {
                return _fromTo;
            }
            set
            {
                _fromTo = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
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
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public string AddCode
        {
            get
            {
                return _addCode;
            }
            set
            {
                _addCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public string VatRate
        {
            get
            {
                return _vatRate;
            }
            set
            {
                _vatRate = value;
            }
        }
        
        public static List<MyCompany.Data.Objects.vw_T08> Select(
                    string salesDocumentType, 
                    string salesOrganization, 
                    string distributionChannel, 
                    string division, 
                    string soldTo, 
                    string shipTo, 
                    string purchaseOrderNumber, 
                    string salesDocument, 
                    string invoiceNumber, 
                    string salesDocumentItemCat, 
                    string materialCode, 
                    string keyField1, 
                    string keyField2, 
                    string keyField3, 
                    string rokiDeliveryPlant, 
                    string rokiDelStorageLoc, 
                    string goodsMovementDate, 
                    string lastDeliveryPlant, 
                    string lastDelStorageLoc, 
                    string netValueInDocCurrency, 
                    string sdDocumentCurrency, 
                    string incotermPart1, 
                    string incotermPart2, 
                    string scheduleLineCat, 
                    string scheduleLineDate, 
                    string arrivalTime, 
                    string expr1, 
                    string salesUnit, 
                    string fromTo, 
                    string plantCode, 
                    string addCode, 
                    string vatRate)
        {
            return new vw_T08Factory().Select(salesDocumentType, salesOrganization, distributionChannel, division, soldTo, shipTo, purchaseOrderNumber, salesDocument, invoiceNumber, salesDocumentItemCat, materialCode, keyField1, keyField2, keyField3, rokiDeliveryPlant, rokiDelStorageLoc, goodsMovementDate, lastDeliveryPlant, lastDelStorageLoc, netValueInDocCurrency, sdDocumentCurrency, incotermPart1, incotermPart2, scheduleLineCat, scheduleLineDate, arrivalTime, expr1, salesUnit, fromTo, plantCode, addCode, vatRate);
        }
        
        public static List<MyCompany.Data.Objects.vw_T08> Select(MyCompany.Data.Objects.vw_T08 qbe)
        {
            return new vw_T08Factory().Select(qbe);
        }
        
        public static List<MyCompany.Data.Objects.vw_T08> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new vw_T08Factory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.vw_T08> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new vw_T08Factory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<MyCompany.Data.Objects.vw_T08> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new vw_T08Factory().Select(filter, sort, vw_T08Factory.SelectView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.vw_T08> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new vw_T08Factory().Select(filter, sort, vw_T08Factory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<MyCompany.Data.Objects.vw_T08> Select(string filter, BusinessObjectParameters parameters)
        {
            return new vw_T08Factory().Select(filter, null, vw_T08Factory.SelectView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.vw_T08> Select(string filter, params FieldValue[] parameters)
        {
            return new vw_T08Factory().Select(filter, null, vw_T08Factory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static MyCompany.Data.Objects.vw_T08 SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new vw_T08Factory().SelectSingle(filter, parameters);
        }
        
        public static MyCompany.Data.Objects.vw_T08 SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new vw_T08Factory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public override string ToString()
        {
            return String.Format("");
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class vw_T08Factory
    {
        
        public vw_T08Factory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("vw_T08");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("vw_T08");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("vw_T08");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("vw_T08");
            }
        }
        
        public static vw_T08Factory Create()
        {
            return new vw_T08Factory();
        }
        
        protected virtual PageRequest CreateRequest(
                    string salesDocumentType, 
                    string salesOrganization, 
                    string distributionChannel, 
                    string division, 
                    string soldTo, 
                    string shipTo, 
                    string purchaseOrderNumber, 
                    string salesDocument, 
                    string invoiceNumber, 
                    string salesDocumentItemCat, 
                    string materialCode, 
                    string keyField1, 
                    string keyField2, 
                    string keyField3, 
                    string rokiDeliveryPlant, 
                    string rokiDelStorageLoc, 
                    string goodsMovementDate, 
                    string lastDeliveryPlant, 
                    string lastDelStorageLoc, 
                    string netValueInDocCurrency, 
                    string sdDocumentCurrency, 
                    string incotermPart1, 
                    string incotermPart2, 
                    string scheduleLineCat, 
                    string scheduleLineDate, 
                    string arrivalTime, 
                    string expr1, 
                    string salesUnit, 
                    string fromTo, 
                    string plantCode, 
                    string addCode, 
                    string vatRate, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (!(String.IsNullOrEmpty(salesDocumentType)))
            	filter.Add(("SalesDocumentType:*" + salesDocumentType));
            if (!(String.IsNullOrEmpty(salesOrganization)))
            	filter.Add(("SalesOrganization:*" + salesOrganization));
            if (!(String.IsNullOrEmpty(distributionChannel)))
            	filter.Add(("DistributionChannel:*" + distributionChannel));
            if (!(String.IsNullOrEmpty(division)))
            	filter.Add(("Division:*" + division));
            if (!(String.IsNullOrEmpty(soldTo)))
            	filter.Add(("SoldTo:*" + soldTo));
            if (!(String.IsNullOrEmpty(shipTo)))
            	filter.Add(("ShipTo:*" + shipTo));
            if (!(String.IsNullOrEmpty(purchaseOrderNumber)))
            	filter.Add(("PurchaseOrderNumber:*" + purchaseOrderNumber));
            if (!(String.IsNullOrEmpty(salesDocument)))
            	filter.Add(("SalesDocument:*" + salesDocument));
            if (!(String.IsNullOrEmpty(invoiceNumber)))
            	filter.Add(("InvoiceNumber:*" + invoiceNumber));
            if (!(String.IsNullOrEmpty(salesDocumentItemCat)))
            	filter.Add(("SalesDocumentItemCat:*" + salesDocumentItemCat));
            if (!(String.IsNullOrEmpty(materialCode)))
            	filter.Add(("MaterialCode:*" + materialCode));
            if (!(String.IsNullOrEmpty(keyField1)))
            	filter.Add(("KeyField1:*" + keyField1));
            if (!(String.IsNullOrEmpty(keyField2)))
            	filter.Add(("KeyField2:*" + keyField2));
            if (!(String.IsNullOrEmpty(keyField3)))
            	filter.Add(("KeyField3:*" + keyField3));
            if (!(String.IsNullOrEmpty(rokiDeliveryPlant)))
            	filter.Add(("RokiDeliveryPlant:*" + rokiDeliveryPlant));
            if (!(String.IsNullOrEmpty(rokiDelStorageLoc)))
            	filter.Add(("RokiDelStorageLoc:*" + rokiDelStorageLoc));
            if (!(String.IsNullOrEmpty(goodsMovementDate)))
            	filter.Add(("GoodsMovementDate:*" + goodsMovementDate));
            if (!(String.IsNullOrEmpty(lastDeliveryPlant)))
            	filter.Add(("LastDeliveryPlant:*" + lastDeliveryPlant));
            if (!(String.IsNullOrEmpty(lastDelStorageLoc)))
            	filter.Add(("LastDelStorageLoc:*" + lastDelStorageLoc));
            if (!(String.IsNullOrEmpty(netValueInDocCurrency)))
            	filter.Add(("NetValueInDocCurrency:*" + netValueInDocCurrency));
            if (!(String.IsNullOrEmpty(sdDocumentCurrency)))
            	filter.Add(("SdDocumentCurrency:*" + sdDocumentCurrency));
            if (!(String.IsNullOrEmpty(incotermPart1)))
            	filter.Add(("IncotermPart1:*" + incotermPart1));
            if (!(String.IsNullOrEmpty(incotermPart2)))
            	filter.Add(("IncotermPart2:*" + incotermPart2));
            if (!(String.IsNullOrEmpty(scheduleLineCat)))
            	filter.Add(("ScheduleLineCat:*" + scheduleLineCat));
            if (!(String.IsNullOrEmpty(scheduleLineDate)))
            	filter.Add(("ScheduleLineDate:*" + scheduleLineDate));
            if (!(String.IsNullOrEmpty(arrivalTime)))
            	filter.Add(("ArrivalTime:*" + arrivalTime));
            if (!(String.IsNullOrEmpty(expr1)))
            	filter.Add(("Expr1:*" + expr1));
            if (!(String.IsNullOrEmpty(salesUnit)))
            	filter.Add(("SalesUnit:*" + salesUnit));
            if (!(String.IsNullOrEmpty(fromTo)))
            	filter.Add(("FromTo:*" + fromTo));
            if (!(String.IsNullOrEmpty(plantCode)))
            	filter.Add(("PlantCode:*" + plantCode));
            if (!(String.IsNullOrEmpty(addCode)))
            	filter.Add(("AddCode:*" + addCode));
            if (!(String.IsNullOrEmpty(vatRate)))
            	filter.Add(("VatRate:*" + vatRate));
            return new PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray());
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public List<MyCompany.Data.Objects.vw_T08> Select(
                    string salesDocumentType, 
                    string salesOrganization, 
                    string distributionChannel, 
                    string division, 
                    string soldTo, 
                    string shipTo, 
                    string purchaseOrderNumber, 
                    string salesDocument, 
                    string invoiceNumber, 
                    string salesDocumentItemCat, 
                    string materialCode, 
                    string keyField1, 
                    string keyField2, 
                    string keyField3, 
                    string rokiDeliveryPlant, 
                    string rokiDelStorageLoc, 
                    string goodsMovementDate, 
                    string lastDeliveryPlant, 
                    string lastDelStorageLoc, 
                    string netValueInDocCurrency, 
                    string sdDocumentCurrency, 
                    string incotermPart1, 
                    string incotermPart2, 
                    string scheduleLineCat, 
                    string scheduleLineDate, 
                    string arrivalTime, 
                    string expr1, 
                    string salesUnit, 
                    string fromTo, 
                    string plantCode, 
                    string addCode, 
                    string vatRate, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex, 
                    string dataView)
        {
            PageRequest request = CreateRequest(salesDocumentType, salesOrganization, distributionChannel, division, soldTo, shipTo, purchaseOrderNumber, salesDocument, invoiceNumber, salesDocumentItemCat, materialCode, keyField1, keyField2, keyField3, rokiDeliveryPlant, rokiDelStorageLoc, goodsMovementDate, lastDeliveryPlant, lastDelStorageLoc, netValueInDocCurrency, sdDocumentCurrency, incotermPart1, incotermPart2, scheduleLineCat, scheduleLineDate, arrivalTime, expr1, salesUnit, fromTo, plantCode, addCode, vatRate, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("vw_T08", dataView, request);
            return page.ToList<MyCompany.Data.Objects.vw_T08>();
        }
        
        public List<MyCompany.Data.Objects.vw_T08> Select(MyCompany.Data.Objects.vw_T08 qbe)
        {
            return Select(qbe.SalesDocumentType, qbe.SalesOrganization, qbe.DistributionChannel, qbe.Division, qbe.SoldTo, qbe.ShipTo, qbe.PurchaseOrderNumber, qbe.SalesDocument, qbe.InvoiceNumber, qbe.SalesDocumentItemCat, qbe.MaterialCode, qbe.KeyField1, qbe.KeyField2, qbe.KeyField3, qbe.RokiDeliveryPlant, qbe.RokiDelStorageLoc, qbe.GoodsMovementDate, qbe.LastDeliveryPlant, qbe.LastDelStorageLoc, qbe.NetValueInDocCurrency, qbe.SdDocumentCurrency, qbe.IncotermPart1, qbe.IncotermPart2, qbe.ScheduleLineCat, qbe.ScheduleLineDate, qbe.ArrivalTime, qbe.Expr1, qbe.SalesUnit, qbe.FromTo, qbe.PlantCode, qbe.AddCode, qbe.VatRate);
        }
        
        public int SelectCount(
                    string salesDocumentType, 
                    string salesOrganization, 
                    string distributionChannel, 
                    string division, 
                    string soldTo, 
                    string shipTo, 
                    string purchaseOrderNumber, 
                    string salesDocument, 
                    string invoiceNumber, 
                    string salesDocumentItemCat, 
                    string materialCode, 
                    string keyField1, 
                    string keyField2, 
                    string keyField3, 
                    string rokiDeliveryPlant, 
                    string rokiDelStorageLoc, 
                    string goodsMovementDate, 
                    string lastDeliveryPlant, 
                    string lastDelStorageLoc, 
                    string netValueInDocCurrency, 
                    string sdDocumentCurrency, 
                    string incotermPart1, 
                    string incotermPart2, 
                    string scheduleLineCat, 
                    string scheduleLineDate, 
                    string arrivalTime, 
                    string expr1, 
                    string salesUnit, 
                    string fromTo, 
                    string plantCode, 
                    string addCode, 
                    string vatRate, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex, 
                    string dataView)
        {
            PageRequest request = CreateRequest(salesDocumentType, salesOrganization, distributionChannel, division, soldTo, shipTo, purchaseOrderNumber, salesDocument, invoiceNumber, salesDocumentItemCat, materialCode, keyField1, keyField2, keyField3, rokiDeliveryPlant, rokiDelStorageLoc, goodsMovementDate, lastDeliveryPlant, lastDelStorageLoc, netValueInDocCurrency, sdDocumentCurrency, incotermPart1, incotermPart2, scheduleLineCat, scheduleLineDate, arrivalTime, expr1, salesUnit, fromTo, plantCode, addCode, vatRate, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("vw_T08", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<MyCompany.Data.Objects.vw_T08> Select(
                    string salesDocumentType, 
                    string salesOrganization, 
                    string distributionChannel, 
                    string division, 
                    string soldTo, 
                    string shipTo, 
                    string purchaseOrderNumber, 
                    string salesDocument, 
                    string invoiceNumber, 
                    string salesDocumentItemCat, 
                    string materialCode, 
                    string keyField1, 
                    string keyField2, 
                    string keyField3, 
                    string rokiDeliveryPlant, 
                    string rokiDelStorageLoc, 
                    string goodsMovementDate, 
                    string lastDeliveryPlant, 
                    string lastDelStorageLoc, 
                    string netValueInDocCurrency, 
                    string sdDocumentCurrency, 
                    string incotermPart1, 
                    string incotermPart2, 
                    string scheduleLineCat, 
                    string scheduleLineDate, 
                    string arrivalTime, 
                    string expr1, 
                    string salesUnit, 
                    string fromTo, 
                    string plantCode, 
                    string addCode, 
                    string vatRate)
        {
            return Select(salesDocumentType, salesOrganization, distributionChannel, division, soldTo, shipTo, purchaseOrderNumber, salesDocument, invoiceNumber, salesDocumentItemCat, materialCode, keyField1, keyField2, keyField3, rokiDeliveryPlant, rokiDelStorageLoc, goodsMovementDate, lastDeliveryPlant, lastDelStorageLoc, netValueInDocCurrency, sdDocumentCurrency, incotermPart1, incotermPart2, scheduleLineCat, scheduleLineDate, arrivalTime, expr1, salesUnit, fromTo, plantCode, addCode, vatRate, null, Int32.MaxValue, 0, SelectView);
        }
        
        public List<MyCompany.Data.Objects.vw_T08> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("vw_T08", dataView, request);
            return page.ToList<MyCompany.Data.Objects.vw_T08>();
        }
        
        public List<MyCompany.Data.Objects.vw_T08> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<MyCompany.Data.Objects.vw_T08> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public MyCompany.Data.Objects.vw_T08 SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<MyCompany.Data.Objects.vw_T08> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
    }
}
