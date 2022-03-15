using System;
using _10XOne.Core.Models;
using _10XOne.Core.ViewModels;
using _10XOne.Infrastructure.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace _10XOne.Web.Controllers
{
    public class FinancialItemsController : Controller
    {
        private readonly IFinancialItemService _financialItemService;

        public FinancialItemsController(IFinancialItemService financialItemsService)
        {
            _financialItemService = financialItemsService;
        }

        public IActionResult Index()
        {
            var financialItems =_financialItemService.GetAll();
            return View("Index", financialItems);
        }

        public IActionResult Save(FinancialItemViewModel financialItemViewModel)
        {
            if (financialItemViewModel.FinancialItem.ID == 0)
            {
               _financialItemService
                    .Create(financialItemViewModel.FinancialItem);
            }
            else
            {
                _financialItemService
                    .Edit(financialItemViewModel.FinancialItem);
            }


            var financialItems = _financialItemService.GetAll();
            return View("Index", financialItems);
        }

        public IActionResult Edit(int id = 0)
        {
            var financialItem = _financialItemService.Get(id);
            return View("Create", financialItem);
        }

        public IActionResult Delete(int id)
        {
            _financialItemService.Delete(id);
            return RedirectToAction("Index");
        }
    }
}