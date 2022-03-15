using System.Collections.Generic;
using System.Linq;
using _10XOne.Core.Models;
using _10XOne.Core.Services.Interfaces;
using _10XOne.Infrastructure.Repository.Interaces;

namespace _10XOne.Infrastructure.Services.Implementations
{
    public class Calculation : ICalculation
    {
        private readonly IFinancialItemRepository _financialItemRepository;
        private readonly IPartnerRepository _partnerRepository;

        public Calculation(
            IPartnerRepository partnerRepository,
            IFinancialItemRepository financialItemRepository)
        {
            _partnerRepository = partnerRepository;
            _financialItemRepository = financialItemRepository;
        }


        /// <summary>
        /// Method to calculate amounts for partners
        /// </summary>
        /// <returns></returns>
        public List<Partner> Calculate()
        {
            var partnerList = _partnerRepository.GetAll();
            var partner = partnerList.FirstOrDefault(partner => partner.ID == 1);

            partner.TotalShopingAmount = CalculateAmounts(partnerList, partner);

            return partnerList;
        }

        /// <summary>
        /// Recursive method to calculate all amounts
        /// </summary>
        /// <param name="partnerList"></param>
        /// <param name="partner"></param>
        /// <returns></returns>
        private decimal CalculateAmounts(List<Partner> partnerList, Partner partner)
        {
            //Iterate over all partners and find team shopping account
            foreach (Partner item in partnerList)
            {
                if (item.PARENT_PARTNER_ID == partner.ID)
                {
                    partner.TeamShopingAmount += CalculateAmounts(partnerList, item);
                }
            }

            //Get all partner sales
            decimal partnerSales = _financialItemRepository
                .GetAll()
                .Where(financialItem =>
                    financialItem.PARTNER_ID.Equals(partner.ID))
                .ToList()
                .Sum(partner => partner.AMOUNT);

            //Calculate total shopping amount with fee percent
            partner.TotalShopingAmount = (partner.TeamShopingAmount + partnerSales) * (partner.FEE_PERCENT / 100 + 1);
            return partner.TotalShopingAmount;
        }
    }
}
