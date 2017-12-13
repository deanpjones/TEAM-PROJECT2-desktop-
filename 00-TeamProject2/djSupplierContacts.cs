using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_TeamProject2
{
    //**********************************************************************
    //**********************************************************************

    //SUPPLIER CONTACTS CLASS
    //Author: Dean Jones
    //Date: Dec.27, 2016

    //**********************************************************************
    //**********************************************************************
    class djSupplierContacts
    {
        //VARIABLES (Supplier_Contacts table)
        private int supplierContactId;
        private string supConFirstName;
        private string supConLastName;
        private string supConCompany;
        private string supConAddress;
        private string supConCity;
        private string supConProv;
        private string supConPostal;
        private string supConCountry;
        private string supConBusPhone;
        private string supConFax;
        private string supConEmail;
        private string supConURL;
        private string affiliationId;
        private int supplierId;

        //CONSTRUCTOR (default)
        public djSupplierContacts(
            int supplier_contact_id,
            string supplier_contact_fname,
            string supplier_contact_lname,
            string supplier_contact_company,
            string supplier_contact_address,
            string supplier_contact_city,
            string supplier_contact_province,
            string supplier_contact_postal,
            string supplier_contact_country,
            string supplier_contact_busphone,
            string supplier_contact_fax,
            string supplier_contact_email,
            string supplier_contact_url,
            string supplier_contact_affiliation_id,
            int supplier_id
            )
        {
            supplierContactId = supplier_contact_id;
            supConFirstName = supplier_contact_fname;
            supConLastName = supplier_contact_lname;
            supConCompany = supplier_contact_company;
            supConAddress = supplier_contact_address;
            supConCity = supplier_contact_city;
            supConProv = supplier_contact_province;
            supConPostal = supplier_contact_postal;
            supConCountry = supplier_contact_country;
            supConBusPhone = supplier_contact_busphone;
            supConFax = supplier_contact_fax;
            supConEmail = supplier_contact_email;
            supConURL = supplier_contact_url;
            affiliationId = supplier_contact_affiliation_id;
            supplierId = supplier_id;
        }

        //GETTERS AND SETTERS (Supplier_Contacts table)
        public int SupplierContactId { get; set; }
        public string SupConFirstName { get; set; }
        public string SupConLastName { get; set; }
        public string SupConCompany { get; set; }
        public string SupConAddress { get; set; }
        public string SupConCity { get; set; }
        public string SupConProv { get; set; }
        public string SupConPostal { get; set; }
        public string SupConCountry { get; set; }
        public string SupConBusPhone { get; set; }
        public string SupConFax { get; set; }
        public string SupConEmail { get; set; }
        public string SupConURL { get; set; }
        public string AffiliationId { get; set; }
        public int SupplierId { get; set; }

        /// <summary>
        /// String of Supplier Contact properties (default tabbed)
        /// </summary>
        public override string ToString()   //OVERRIDE inherited method ToString (Object Class)
        {
            return supplierContactId.ToString() + "\t"
                + supConFirstName + "\t"
                + supConLastName + "\t"
                + supConCompany + "\t"
                + supConAddress + "\t"
                + supConCity + "\t"
                + supConProv + "\t"
                + supConPostal + "\t"
                + supConCountry + "\t"
                + supConBusPhone + "\t"
                + supConFax + "\t"
                + supConEmail + "\t"
                + supConURL + "\t"
                + affiliationId + "\t"
                + supplierId.ToString();
        }

        /// <summary>
        /// String of Supplier Contact properties (custom delimiter)
        /// </summary>
        public string ToString(string delim)
        {
            return supplierContactId.ToString() + delim
                + supConFirstName + delim
                + supConLastName + delim
                + supConCompany + delim
                + supConAddress + delim
                + supConCity + delim
                + supConProv + delim
                + supConPostal + delim
                + supConCountry + delim
                + supConBusPhone + delim
                + supConFax + delim
                + supConEmail + delim
                + supConURL + delim
                + affiliationId + delim
                + supplierId.ToString();
        }

    }
}
