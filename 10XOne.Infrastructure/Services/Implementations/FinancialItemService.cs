using System;
using System.Collections.Generic;
using System.Linq;
using _10XOne.Core.Models;
using _10XOne.Core.ViewModels;
using _10XOne.Infrastructure.Repository.Interaces;
using _10XOne.Infrastructure.Services.Interfaces;

namespace _10XOne.Infrastructure.Services.Implementations
{
    public class FinancialItemService : IFinancialItemService
    {
        private readonly IFinancialItemRepository _financialItemRepository;
        private readonly IPartnerRepository _partnerRepository;

        public FinancialItemService(
            IFinancialItemRepository financialItemRepository,
            IPartnerRepository partnerRepository)
        {
            _financialItemRepository = financialItemRepository;
            _partnerRepository = partnerRepository;
        }


        public List<FinancialItem> GetAll()
        {
            return _financialItemRepository.GetAll();
        }

        /// <summary>
        /// Creates new financial item
        /// </summary>
        /// <param name="financialItem"></param>
        /// <returns></returns>
        public FinancialItem Create(FinancialItem financialItem)
        {
            if (_financialItemRepository
                .GetAll()
                .Count() == 0)
            {
                financialItem.ID = 1;
            }
            else
            {
                financialItem.ID = _financialItemRepository
                    .GetAll()
                    .ToList()
                    .Max(x => x.ID + 1);
            }

            return _financialItemRepository.Add(financialItem);
        }

        /// <summary>
        /// Deletes financial item
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public FinancialItem Delete(int id)
        {
            return _financialItemRepository.Delete(id);
        }

        /// <summary>
        /// Updates financial item
        /// </summary>
        /// <param name="financialItem"></param>
        /// <returns></returns>
        public FinancialItem Edit(FinancialItem financialItem)
        {
            return _financialItemRepository.Edit(financialItem);
        }

        /// <summary>
        /// Retrieves Financial Item ViewModel
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public FinancialItemViewModel Get(int id)
        {
            var financialItem = new FinancialItemViewModel();
            financialItem.Partners = _partnerRepository.GetAll();

            if (id != 0)
            {
                financialItem.FinancialItem = _financialItemRepository.Get(id);
            }
            return financialItem;
        }
    }
}
