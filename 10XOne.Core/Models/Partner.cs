using System;
namespace _10XOne.Core.Models
{
    public class Partner
    {
        public decimal ID { get; set; }
        public string PARTNER_NAME { get; set; }
        public decimal PARENT_PARTNER_ID { get; set; }
        public decimal FEE_PERCENT { get; set; }
        public decimal TeamShopingAmount { get; set; }
        public decimal TotalShopingAmount { get; set; }
    }
}
