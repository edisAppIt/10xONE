using System;
using System.ComponentModel.DataAnnotations;

namespace _10XOne.Core.Models
{
    public class FinancialItem
    {
        public int ID { get; set; }
        public decimal PARTNER_ID { get; set; }
        public DateTime DATE { get; set; }
        public decimal AMOUNT { get; set; }

        public FinancialItem()
        {
            DATE = DateTime.Now;
        }
    }
}
