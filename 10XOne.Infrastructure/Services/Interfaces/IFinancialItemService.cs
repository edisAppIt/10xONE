using System;
using System.Collections.Generic;
using _10XOne.Core.Models;
using _10XOne.Core.ViewModels;

namespace _10XOne.Infrastructure.Services.Interfaces
{
    public interface IFinancialItemService
    {
        List<FinancialItem> GetAll();
        FinancialItemViewModel Get(int id);
        FinancialItem Create(FinancialItem financialItem);
        FinancialItem Edit(FinancialItem financialItem);
        FinancialItem Delete(int id);
    }
}
