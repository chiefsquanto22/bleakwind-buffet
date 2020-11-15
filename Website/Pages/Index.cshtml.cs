using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Threading.Tasks;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Website.Pages
{
    public class IndexModel : PageModel
    {
        public IEnumerable<IOrderItem> Items { get; set; }
        public string SearchTerms { get; set; }
        public string[] Categories { get; set; }

        public void OnGet(double? minPrice, double? maxPrice, uint? minCal, uint? maxCal)
        {
            Categories = Request.Query["Categories"];
            Items = Menu.Search(Items, SearchTerms);
            Items = Menu.FilterByCalories(Items, minCal, maxCal);
            Items = Menu.FilterByPrice(Items, minPrice, maxPrice);
            Items = Menu.FilterByCategory(Items, Categories);
        }
    }
}
