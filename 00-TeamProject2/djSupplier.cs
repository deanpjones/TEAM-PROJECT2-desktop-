using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_TeamProject2
{
    //**********************************************************************
    //**********************************************************************

    //SUPPLIER CLASS
    //Author: Dean Jones
    //Date: Dec.27, 2016

    //**********************************************************************
    //**********************************************************************
    class djSupplier
    {
        //VARIABLES
        private int supplierId;
        private string supName;

        //CONSTRUCTOR (default)
        public djSupplier(int supplier_id, string supplier_name)
        {
            supplierId = supplier_id;
            supName = supplier_name;
        }

        //GETTERS AND SETTERS
        /// <summary>
        /// Suppliers ID
        /// </summary>
        public int SupplierId
        {
            get
            {
                return supplierId;
            }
            set
            {
                supplierId = value;
            }
        }

        /// <summary>
        /// Suppliers Name
        /// </summary>
        public string SupName
        {
            get
            {
                return supName;
            }
            set
            {
                supName = value;
            }
        }

        /// <summary>
        /// String of Supplier properties (default tabbed)
        /// </summary>
        public override string ToString()   //OVERRIDE inherited method ToString (Object Class)
        {
            return supplierId.ToString() + "\t"
                + supName;
        }

        /// <summary>
        /// String of Supplier properties (custom delimiter)
        /// </summary>
        public string ToString(string delim)
        {
            return supplierId.ToString() + delim
                + supName;
        }
    }
}
