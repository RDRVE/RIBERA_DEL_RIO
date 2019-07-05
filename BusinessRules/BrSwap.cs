
namespace BusinessRules
{
    using System.Collections.Generic;
    using DataAccess;
    using Entities;

    public class BrSwap
    {
        public List<Swap> GetSwaps()
        {
            return new DaSwap().GetSwaps();
        }
    }
}
