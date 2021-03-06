﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrashCollection.Models
{
    public class CustomerModel
    {
        [Key]
        public int CustomerId { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerPassword { get; set; }

        [Key]
        public string CustomerName { get; set; }
        public string CustomerStreet { get; set; }
        public string CustomerCityState { get; set; }
        public int CustomerZip { get; set; }
        public string WeeklyPickUpDay { get; set; }
        public DateTime? VacationBegins { get; set; }
        public DateTime? VacationEnds { get; set; }
        public bool CancelWeeklyPickUp { get; set; }
        public bool RescheduleWeeklyPickUp { get;  set;}
        public string RescheduledDay { get; set; }
        public bool ChangeWeeklyPickUp { get; set; }
        public string NewPickUpDay { get; set; }
        public int CollectionCharge { get; set; }
        public int PickUpsThisMonth { get; set; }
        public int MonthlyBill { get; set; }
        public int PaymentAmount { get; set; }
        public int CurrentBalance { get; set; }
    }
}