using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpTestBench
{
    public class Item
    {
        public int Price { get; set; }
    }

    public class Calculator
    {
        public int CalculateTotal(List<Item> items)
        {
            // BUG: This will throw a NullReferenceException if items is null
            // or an ArgumentNullException if the collection logic is unhandled.
            return items.Sum(i => i.Price);
        }
    }
}
