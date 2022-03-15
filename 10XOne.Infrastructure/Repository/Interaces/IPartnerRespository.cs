using System;
using System.Collections.Generic;
using _10XOne.Core.Models;

namespace _10XOne.Infrastructure.Repository.Interaces
{
    public interface IPartnerRepository
    {
        List<Partner> GetAll();
    }
}
