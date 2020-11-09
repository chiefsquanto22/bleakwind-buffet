using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Threading.Tasks;
using BleakwindBuffet.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Website.Pages
{
    public class IndexModel : PageModel
    {
        public IEnumerable<IOrderItem> Entrees { get; set; }
        public IEnumerable<IOrderItem> Sides { get; set; }
        public IEnumerable<IOrderItem> Drinks { get; set; }
        public string SearchTerms { get; set; }
        public string[] Categories { get; set; }
        
        public void OnGet(double? minPrice, double? maxPrice, uint? minCal, uint? maxCal)
        {
            Categories = Request.Query["Categories"];
            Entrees = Menu.Search(Entrees, SearchTerms);
            Entrees = Menu.FilterByCalories(Entrees, minCal, maxCal);
            Entrees = Menu.FilterByPrice(Entrees, minPrice, maxPrice);
            Entrees = Menu.FilterByCategory(Entrees, Categories);
            Sides = Menu.Search(Sides, SearchTerms);
            Sides = Menu.FilterByCalories(Sides, minCal, maxCal);
            Sides = Menu.FilterByPrice(Sides, minPrice, maxPrice);
            Sides = Menu.FilterByCategory(Sides, Categories);
            Drinks = Menu.Search(Drinks, SearchTerms);
            Drinks = Menu.FilterByCalories(Drinks, minCal, maxCal);
            Drinks = Menu.FilterByPrice(Drinks, minPrice, maxPrice);
            Drinks = Menu.FilterByCategory(Drinks, Categories);
        }
    }
}
