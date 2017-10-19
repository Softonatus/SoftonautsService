﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace SoftonautsService.CResponse
{
    [DataContract]
    public class ResAdvance
    {
        [DataMember]
        public int? AdvanceId
        { get; set; }

        [DataMember]
        public int? UserId
        { get; set; }

        [DataMember]
        public int? CustomerId
        { get; set; }

        [DataMember]
        public int? AdvanceNo
        { get; set; }

        [DataMember]
        public DateTime AdvanceDate
        { get; set; }

        [DataMember]
        public string PaymentTerm
        { get; set; }

        [DataMember]
        public string ShippingAddress1
        { get; set; }

        [DataMember]
        public string ShippingAddress2
        { get; set; }

        [DataMember]
        public string City
        { get; set; }

        [DataMember]
        public string State
        { get; set; }

        [DataMember]
        public string PinCode
        { get; set; }

        [DataMember]
        public string Country
        { get; set; }

        [DataMember]
        public string RefNo
        { get; set; }

        [DataMember]
        public bool? IsTaxInclusive
        { get; set; }

        [DataMember]
        public string Note
        { get; set; }

        [DataMember]
        public string AttachmentUrl
        { get; set; }

        [DataMember]
        public string TotalAmount
        { get; set; }

        [DataMember]
        public bool? IsDeleted
        { get; set; }

        [DataMember]
        public List<ResAdvanceItem> ResAdvanceItemList
        { get; set; }

    }

    [DataContract]
    public class ResAdvanceItem
    {
        [DataMember]
        public int? Id
        { get; set; }

        [DataMember]
        public int? AdvanceNo
        { get; set; }

        [DataMember]
        public int? AdvanceId
        { get; set; }

        [DataMember]
        public int? ItemId
        { get; set; }

        [DataMember]
        public string Description
        { get; set; }

        [DataMember]
        public string Price
        { get; set; }

        [DataMember]
        public string Quantity
        { get; set; }

        [DataMember]
        public string Unit
        { get; set; }

        [DataMember]
        public string Amount
        { get; set; }

        [DataMember]
        public string Tax
        { get; set; }

        [DataMember]
        public string Igst
        { get; set; }

        [DataMember]
        public string Cgst
        { get; set; }

        [DataMember]
        public string Sgst
        { get; set; }

        [DataMember]
        public string Utgst
        { get; set; }

        [DataMember]
        public string Cess
        { get; set; }

    }

    [DataContract]
    public class ResAdvanceGet : ResCommon
    {
        [DataMember]
        public int? AdvanceId
        { get; set; }

        [DataMember]
        public int? UserId
        { get; set; }

        [DataMember]
        public int? CustomerId
        { get; set; }
        [DataMember]
        public string CustomerName
        { get; set; }

        [DataMember]
        public int? AdvanceNo
        { get; set; }

        [DataMember]
        public string AdvanceDate
        { get; set; }

        [DataMember]
        public string PaymentTerm
        { get; set; }

        [DataMember]
        public string ShippingAddress1
        { get; set; }

        [DataMember]
        public string ShippingAddress2
        { get; set; }

        [DataMember]
        public string City
        { get; set; }

        [DataMember]
        public string State
        { get; set; }

        [DataMember]
        public string PinCode
        { get; set; }

        [DataMember]
        public string Country
        { get; set; }

        [DataMember]
        public string RefNo
        { get; set; }

        [DataMember]
        public bool? IsTaxInclusive
        { get; set; }

        [DataMember]
        public string Note
        { get; set; }

        [DataMember]
        public string AttachmentUrl
        { get; set; }

        [DataMember]
        public string TotalAmount
        { get; set; }

        [DataMember]
        public bool? IsDeleted
        { get; set; }

        [DataMember]
        public List<ResAdvanceItem> ResAdvanceItemList
        { get; set; }

        [DataMember]
        public string Frieght
        { get; set; }

        [DataMember]
        public string LabourCharge
        { get; set; }

        [DataMember]
        public string InsuranceAmount
        { get; set; }

        [DataMember]
        public string OtherCharge
        { get; set; }

        [DataMember]
        public string Cess
        { get; set; }

        [DataMember]
        public string Prefix
        { get; set; }

        [DataMember]
        public string TermCondition
        { get; set; }

        [DataMember]
        public string InvoiceRefNo
        { get; set; }

        [DataMember]
        public string InvoicePaymentDetail
        { get; set; }

    }

    [DataContract]
    public class ResAdvanceGetList
    {
        [DataMember]
        public List<ResAdvanceGet> resAdvanceGetList
        {
            get;set;
        }
    }

}