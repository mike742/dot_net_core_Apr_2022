﻿using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace dot_net_core_Apr_2022.Models
{
    [Serializable()]
    [XmlInclude(typeof(Customers))]
    public partial class Customers : ISerializable
    {
        public Customers()
        {
            Orders = new HashSet<Orders>();
        }

        public Customers(SerializationInfo info, StreamingContext context)
        {
            Id = info.GetInt32("Id");
            FirstName = info.GetString("FirstName");
            LastName = info.GetString("LastName");
            Company = info.GetString("Company");
            EmailAddress = info.GetString("EmailAddress");
        }
        public int Id { get; set; }
        public string Company { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string EmailAddress { get; set; }
        public string JobTitle { get; set; }
        public string BusinessPhone { get; set; }
        public string HomePhone { get; set; }
        public string MobilePhone { get; set; }
        public string FaxNumber { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string StateProvince { get; set; }
        public string ZipPostalCode { get; set; }
        public string CountryRegion { get; set; }
        public string WebPage { get; set; }
        public string Notes { get; set; }
        [XmlIgnore]
        public byte[] Attachments { get; set; }
        [XmlIgnore]
        public virtual ICollection<Orders> Orders { get; set; }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Id", Id);
            info.AddValue("Company", Company);
            info.AddValue("LastName", LastName);
            info.AddValue("FirstName", FirstName);
            info.AddValue("EmailAddress", EmailAddress);
        }
    }
}
