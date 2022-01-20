﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Data.Models
{
    public class Transaction
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long paymentId { get; set; }
        public long transactionId { get; set; }
        public long accountCode { get; set; }
        public long merchant { get; set; }
        public decimal sum { get; set; }
        
        //public byte? paymentstatus { get; set; }

        //public ICollection<Account> Account { get; set; }
    }
}