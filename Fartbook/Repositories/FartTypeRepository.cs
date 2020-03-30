using Fartbook.Interfaces;
using Fartbook.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fartbook
{
    class FartTypeRepository : IFartTypeRepository
    {
        private List<FartType> _fartTypes = new List<FartType>();
        public void CreateFartType(FartType fartTypeToCreate)
        {
            _fartTypes.Add(fartTypeToCreate);
        }
        public List<FartType> GetMostPopularFartTypes()
        {
            return _fartTypes.OrderByDescending(fartType => fartType.Count).ToList();
        }
    }
}
