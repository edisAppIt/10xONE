using System;
using System.Collections.Generic;
using _10XOne.Core.Models;
using _10XOne.Core.Services.Interfaces;
using _10XOne.Infrastructure.Repository.Interaces;
using _10XOne.Infrastructure.Services.Interfaces;

namespace _10XOne.Infrastructure.Services.Implementations
{
    public class PartnerService : IPartnerService
    {
        private readonly IPartnerRepository _partnerRepository;
        private readonly ICalculation _calculation;

        public PartnerService(IPartnerRepository partnerRepository, ICalculation calculation)
        {
            _partnerRepository = partnerRepository;
            _calculation = calculation;
        }

        /// <summary>
        /// Retrieves list of all partners
        /// </summary>
        /// <returns></returns>
        public List<Partner> GetAll()
        {
            return _partnerRepository.GetAll();
        }

        /// <summary>
        /// Makes calculation per requirements and
        /// returns list of partners with all calculation info
        /// </summary>
        /// <returns></returns>
        public List<Partner> Calculate()
        {
            return _calculation.Calculate();
        }
    }
}
