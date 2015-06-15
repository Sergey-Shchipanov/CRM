﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using DataBaseWCF;
//using WCFTestingServise;
//using DataType = System.ComponentModel.DataAnnotations.DataType;

namespace DataBaseWCF
{
    public class DataService : IDataService
    {

        public List<DataType> GetTestList()
        {
            Console.WriteLine("Method: GetTestList");
            Console.WriteLine("Method: GetTestList");
            using (var db = new CRMEntities())
            {
                return
                    db.tbl_Contact.Select(
                        c => new DataType() {Name = c.Name, Surname = c.Surname, Tel = c.Telephone, Email = c.E_mail})
                        .ToList();
            }
//            return new List<DataType>(
//                new []{
//                    new Model.Test(){Name = "example", Id=1},
//                    new Model.Test(){Name = "e2", Id=2},
//                   new Model.Test(){Name = "ex3", Id=3}
//                });
        }


        public void PrintData(int id, string a1)
        {
            Console.WriteLine("Method: PrintData");
            Console.WriteLine("data: " + a1);
        }

        public List<string> GetLoginData()
        {
            Console.WriteLine("Method: GetLoginData");
            Console.WriteLine("Method: GetLoginData");
            using (var db = new CRMEntities())
            {
                //Data Source=WIN-J2OBO120VJ2;Initial Catalog=CRM;Integrated Security=True;
               // var loginQuery = from c in db.tbl_Manager where c.Name == login select c.Name;
                var managers = (from man in db.tbl_Manager select man.Name).ToList();
                return managers;
            }
        }
    }
}
 