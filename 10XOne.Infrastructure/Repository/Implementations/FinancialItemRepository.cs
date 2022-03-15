using System;
using System.Collections.Generic;
using System.Linq;
using _10XOne.Core.Models;
using _10XOne.Infrastructure.Persistence;
using _10XOne.Infrastructure.Repository.Interaces;

namespace _10XOne.Infrastructure.Repository.Implementations
{
    public class FinancialItemRepository : IFinancialItemRepository
    {
        private readonly ApplicationContext _context;

        public FinancialItemRepository(ApplicationContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Returns all financial items
        /// </summary>
        /// <returns></returns>
        public List<FinancialItem> GetAll()
        {
            return _context.FinancialItems.ToList();
        }

        /// <summary>
        /// Adds new financial item
        /// </summary>
        /// <param name="financialItem"></param>
        /// <returns></returns>
        public FinancialItem Add(FinancialItem financialItem)
        {
            _context.FinancialItems.Add(financialItem);
            _context.SaveChanges();
            return financialItem;
        }

        /// <summary>
        /// Deletes financial item
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public FinancialItem Delete(int id)
        {
            var item = Get(id);

            if(item != null)
            {
                _context.FinancialItems.Remove(item);
                _context.SaveChanges();
                return item;
            }

            return null;
        }

        /// <summary>
        /// UPdates financial item
        /// </summary>
        /// <param name="financialItem"></param>
        /// <returns></returns>
        public FinancialItem Edit(FinancialItem financialItem)
        {
            _context.Entry(financialItem).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return financialItem;
        }

        /// <summary>
        /// Returns single financial item
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public FinancialItem Get(int id)
        {
            return _context.FinancialItems.FirstOrDefault(x => x.ID == id);
        }
    }
}
