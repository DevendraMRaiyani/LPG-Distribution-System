﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService2
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : ICustomerMgnt
    {
        LPGContext cc = new LPGContext();
        public Customer AddCustomer(Customer customer)
        {
            Customer c = cc.Customers.Add(customer);
            cc.SaveChanges();
            return c;
        }

        public Customer GetCustomer(string name)
        {
            return cc.Customers.Where(x => x.CustomerName.Equals(name)).FirstOrDefault();
        }

        public string[] GetCustomersName()
        {
            return cc.Customers.Select(x => x.CustomerName).ToArray();
        }

        public string[] GetCustomersTypes()
        {
            return cc.CylCustMappings.Select(x=>x.CustomerType).ToArray();
        }
    }
}
