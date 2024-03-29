﻿using DealerApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealerApp.Model
{
    public class PaymentDetailDto:PaymentDto
    {
        public DateTime DueDate { get; set; }
        public DateTime StartDate { get; set; }
        public decimal? AmountPaid { get; set; }
        public decimal? ProcessingCharges { get; set; }

        public string DaysLeft
        {
            get; set;

        }
        public string AccountNumber { get; set; }


        public string IFSCCode { get; set; }

        public string BankName { get; set; }
        public string Name { get; set; }
    }
}
