using System;
using System.Collections.Generic;
using _10XOne.Core.Models;

namespace _10XOne.Core.Services.Interfaces
{
    public interface ICalculation
    {
        List<Partner> Calculate();
    }
}
