using System;
using System.Collections.Generic;
using _10XOne.Core.Models;

namespace _10XOne.Infrastructure.Repository.Interaces
{
    public interface IFinancialItemRepository
    {
        List<FinancialItem> GetAll();
        FinancialItem Get(int id);
        FinancialItem Add(FinancialItem financialItem);
        FinancialItem Edit(FinancialItem financialItem);
        FinancialItem Delete(int id);
    }
}
