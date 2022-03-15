using System;
using System.Collections.Generic;
using _10XOne.Core.Models;

namespace _10XOne.Infrastructure.Services.Interfaces
{
    public interface IPartnerService
    {

        List<Partner> GetAll();
        List<Partner> Calculate();
    }
}
