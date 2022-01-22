using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Models
{
    public class Account
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long accountCode { get; set; }
        public long msisdn { get; set; }
        public decimal balance { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public bool? identification { get; set; }

        public ICollection<Transaction> Transactions { get; set; }
    }
}
