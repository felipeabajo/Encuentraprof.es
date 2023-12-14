﻿using BlazorServerSQLite.Data;
using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServerSQLite.Data
{
    public class DBStripeCustomerModel
    {
        public DBStripeCustomerModel()
        {

        }

        public DBStripeCustomerModel(StripeBillingRequest subReq, string clientID)
        {
            ClientID = clientID;
            BillingName = subReq.BillingName;
            BillingEmail = subReq.BillingEmail;
            PaymentMethod = subReq.PaymentMethod;
        }

        [Key][Required] public string ClientID { get; set; }
        [Required] public string BillingName { get; set; }
        [Required] public string BillingEmail { get; set; }
        [Required] public string PaymentMethod { get; set; }
    }
}