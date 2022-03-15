using System;
using System.Collections.Generic;
using _10XOne.Core.Models;

namespace _10XOne.Core.ViewModels
{
    public class FinancialItemViewModel
    {
        public FinancialItem FinancialItem { get; set; }
        public List<Partner> Partners { get; set; }

        public FinancialItemViewModel()
        {
            FinancialItem = new FinancialItem();
            Partners = new List<Partner>();
        }
    }
}
