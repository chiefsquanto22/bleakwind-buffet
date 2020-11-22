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
        public IEnumerable<IOrderItem> Entrees { get; set; }
        public IEnumerable<IOrderItem> Sides { get; set; }
        public IEnumerable<IOrderItem> Drinks { get; set; }
        public string SearchTerms { get; set; }
        public string[] Categories { get; set; }

        public void OnGet(double? minPrice, double? maxPrice, uint? minCal, uint? maxCal)
        {
            Entrees = Menu.Entrees();
            Sides = Menu.Sides();
            Drinks = Menu.Drinks();
            SearchTerms = Request?.Query["SearchTerms"];
            if (SearchTerms != null)
            {
                Entrees = from item in Entrees where item.ToString().Contains(SearchTerms, StringComparison.InvariantCultureIgnoreCase) select item;
                Sides = from item in Sides where item.ToString().Contains(SearchTerms, StringComparison.InvariantCultureIgnoreCase) select item;
                Drinks = from item in Drinks where item.ToString().Contains(SearchTerms, StringComparison.InvariantCultureIgnoreCase) select item;
            }
            Categories = Request?.Query["Categories"];

            /*Entrees = Menu.Search(Entrees, SearchTerms);
            Entrees = Menu.FilterByCalories(Entrees, minCal, maxCal);
            Entrees = Menu.FilterByPrice(Entrees, minPrice, maxPrice);*/


            Entrees = Menu.FilterByCategory(Entrees, Categories);
            Sides = Menu.FilterByCategory(Sides, Categories);
            Drinks = Menu.FilterByCategory(Drinks, Categories);
            if (minCal != null || maxCal != null)
            {
                if(minCal!= null && maxCal == null)
                {
                    Entrees = Entrees.Where(item => item.Calories >= minCal);
                    Sides = Sides.Where(item => item.Calories >= minCal);
                    Drinks = Drinks.Where(item => item.Calories >= minCal);
                }
                if(minCal== null && maxCal != null)
                {
                    Entrees = Entrees.Where(item => item.Calories <= maxCal);
                    Sides = Sides.Where(item => item.Calories <= maxCal);
                    Drinks = Drinks.Where(item => item.Calories <= maxCal);
                }
                if(minCal!= null && maxCal != null)
                {
                    Entrees = Entrees.Where(item => item.Calories <= maxCal && item.Calories >= minCal);
                    Sides = Sides.Where(item => item.Calories <= maxCal && item.Calories >= minCal);
                    Drinks = Drinks.Where(item => item.Calories <= maxCal && item.Calories >= minCal);
                }
                
            }
            /*Sides = Menu.Search(Sides, SearchTerms);
            Sides = Menu.FilterByCalories(Sides, minCal, maxCal);
            Sides = Menu.FilterByPrice(Sides, minPrice, maxPrice);
            Sides = Menu.FilterByCategory(Sides, Categories);*/
            if (minPrice != null || maxPrice != null)
            {
                if (minPrice != null && maxPrice == null)
                {
                    Entrees = Entrees.Where(item => item.Price >= minPrice);
                    Sides = Sides.Where(item => item.Price >= minPrice);
                    Drinks = Drinks.Where(item => item.Price >= minPrice);
                }
                if (minPrice == null && maxPrice != null)
                {
                    Entrees = Entrees.Where(item => item.Price <= maxPrice);
                    Sides = Sides.Where(item => item.Price <= maxPrice);
                    Drinks = Drinks.Where(item => item.Price <= maxPrice);
                }
                if (minPrice != null && maxPrice != null)
                {
                    Entrees = Entrees.Where(item => item.Price <= maxPrice && item.Price >= minPrice);
                    Sides = Sides.Where(item => item.Price <= maxPrice && item.Price >= minPrice);
                    Drinks = Drinks.Where(item => item.Price <= maxPrice && item.Price >= minPrice);
                }

                /*Drinks = Menu.Search(Drinks, SearchTerms);
                Drinks = Menu.FilterByCalories(Drinks, minCal, maxCal);
                Drinks = Menu.FilterByPrice(Drinks, minPrice, maxPrice);
                Drinks = Menu.FilterByCategory(Drinks, Categories);*/
            }
        }
    }
}
