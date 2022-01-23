using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Models
{
    public class Account
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long AccountCode { get; set; }
        public long Msisdn { get; set; }
        public decimal Balance { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public bool? Identification { get; set; }

        public ICollection<Transaction> Transactions { get; set; }
    }
}
