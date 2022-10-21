using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp
{
    public record struct Product
    {
        //public string Name { get; set; }
        /// <summary>
        /// Immutability
        ///Init-only properties are allowed on record structs
        ///If you try to reassign a property that has the init keyword set after its initialization you’ll get a compilation error
        /// </summary>
        public string Name { get; init; }
        public int Id { get; init; }
    }
    internal class RecordStruct
    {
        public static void Main()
        {
            var product = new Product
            {
                Name = "Books1",
                Id = 1
            };
            var product1 = new Product
            {
                Name = "Books2",
                Id = 2
            };

            //Printing members
            Console.WriteLine(product);
            Console.WriteLine(product.ToString());
            Console.WriteLine($"{product}");
            Console.WriteLine(product1);
            Console.WriteLine(product1.ToString());
            Console.WriteLine($"{product1}");

            //Equality comparison - compares the value
            Console.WriteLine(product.Equals(product1)); // Returns true

            Console.WriteLine(product == product1); // Returns true

            //With-expressions
            //with keyword ->product1 (Name="Books2" and assigning Id=3 using with keyword)
            var newProduct = product1 with { Id = 3 };

            Console.WriteLine(newProduct.ToString());

            //product.Name = "Book3"; // Error CS8852  Init-only property or indexer 'Product.Name' can only be assigned in an object initializer, or on 'this' or 'base' in an instance constructor or an 'init' accessor.

            Console.WriteLine(product);
        }

    }
}
