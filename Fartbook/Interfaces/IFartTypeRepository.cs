using Fartbook.Objects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fartbook.Interfaces
{
    interface IFartTypeRepository
    {
        void CreateFartType(FartType fartTypeToCreate);
        List<FartType> GetMostPopularFartTypes();
    }
}
