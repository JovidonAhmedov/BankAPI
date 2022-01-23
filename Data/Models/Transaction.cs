using System;
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
        public long PaymentId { get; set; }
        public long TransactionId { get; set; }
        public long Merchant { get; set; }
        public decimal Sum { get; set; }

        //[ForeignKey(nameof(Account))]
        public long AccountCode { get; set; }

        //public Account Account { get; set; }

    }
}
