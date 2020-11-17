using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data;
using Xunit;

namespace BleakwindBuffet.DataTests.UnitTests
{
    public class WebsiteSearchTests
    {
        [Fact]
        public void NullSearchTerms()
        {
            IEnumerable<IOrderItem> list = Menu.Search(Menu.FullMenu(), "");
            Assert.Equal(Menu.FullMenu(), list);
        }

        [Fact]
        public void NullCategories()
        {
            IEnumerable<IOrderItem> list = Menu.FilterByCategory(Menu.FullMenu(), null);
            Assert.Equal(Menu.FullMenu(), list);
        }

        [Fact]
        public void NullCalories()
        {
            IEnumerable<IOrderItem> list = Menu.FilterByCalories(Menu.FullMenu(), null, null);
            Assert.Equal(Menu.FullMenu(), list);
        }

        [Fact]
        public void NullPrice()
        {
            IEnumerable<IOrderItem> list = Menu.FilterByPrice(Menu.FullMenu(), null, null);
            Assert.Equal(Menu.FullMenu(), list);
        }
    }
}
