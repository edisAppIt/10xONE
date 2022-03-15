using System;
using System.Collections.Generic;
using System.Linq;
using _10XOne.Core.Models;
using _10XOne.Infrastructure.Persistence;
using _10XOne.Infrastructure.Repository.Interaces;

namespace _10XOne.Infrastructure.Repository.Implementations
{
    public class PartnerRepository : IPartnerRepository
    {
        private readonly ApplicationContext _context;

        public PartnerRepository(ApplicationContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Returns all partners
        /// </summary>
        /// <returns></returns>
        public List<Partner> GetAll()
        {
            return _context.Partners
                .OrderBy(x=>x.ID)
                .ToList();
        }        
    }
}
