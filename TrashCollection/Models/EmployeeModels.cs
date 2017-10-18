using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrashCollection.Models
{
    public class EmployeeModels
    {
        [Key]
        public int EmployeeId { get; set; }
        public string EmployeeEmail { get; set; }
        public int EmployeePassword { get; set; }
        public string EmployeeName { get; set; }
        public int ChargePerPickUp { get; set; }
        public int CollectionRouteZip { get; set; }
        public CustomerModel CustomerModel { get; set; }
        public string CustomerAddress { get; set; }
        public IEnumerable<CustomerModel> Customers {get; set; }
        }
    }
