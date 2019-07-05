
using BusinessRules;
using System.Collections.Generic;
using System.Linq;
using WEB.Models;

namespace WEB.Data
{
    public class SwapServices
    {

        public List<SwapViewModel> GetSwaps()
        {
            BrSwap brSwap = new BrSwap();

            var list = brSwap.GetSwaps();

            return list.Select(x => new SwapViewModel
            {
                Id = x.Id,
                Title = x.Title,
                Description = x.Description,
                Code = x.Code,
                Price = x.Price,
                Imageurl = x.Imageurl,
                IdCategoriaServices = x.IdCategoriaServices,
                Location = x.Location
            }).ToList();
        }

    }
}