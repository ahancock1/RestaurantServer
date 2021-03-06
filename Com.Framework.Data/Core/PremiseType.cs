﻿using System.Runtime.Serialization;

namespace Com.Framework.Data
{
    //[DataContract]
    //public class PremiseType : Entity<long>
    //{
    //    [DataMember]
    //    public int PremiseTypeID { get; set; }

    //    [DataMember]
    //    public string Name { get; set; }

    //    [DataMember]
    //    public string Description { get; set; }
    //}

    /// <summary>
    /// Specifies the organisation type. I think this covers
    /// all types of organisations. However, it may be worth
    /// having this as its own table in the database alowing 
    /// organisations the ability to specify their own 
    /// organisation type.
    /// </summary>
    [DataContract]
    public enum PremiseType
    {
        [EnumMember(Value = "SOLETRADER")]
        SoleTrader,
        [EnumMember(Value = "PARTNERSHIP")]
        Partnership,
        [EnumMember(Value = "COMPANY")]
        Company,
        [EnumMember(Value = "FRANCHISE")]
        Franchise,
        [EnumMember(Value = "CHARITY")]
        Charity,
        [EnumMember(Value = "SOCIETY")]
        Society,
        [EnumMember(Value = "Trust")]
        Trust
    }
}