using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Meal
    {
        private string name, type;
        private List<Product> products;
        private int ordered;
        private double price;

        public Meal(string name, string type)
           :this(name, type, new List<Product>())
        {
        }


        public Meal(string name, string type,List<Product> products)
        {
            this.Name = name;
            this.Type = type;
            this.Products = products;
            this.Price = products.Sum(x => x.Price)*1.3;
            this.ordered = 0;
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("...");
                }
                name = value;
            }
        }


        public string Type
        {
            get { return type; }
            set
            {
                if (value== "")
                {
                    throw new ArgumentException("...");
                }
                type = value;
            }
        }

        public List<Product> Products
        {
            get { return products; }
            set { products = value; }
        }

        public int Ordered
        {
            get { return ordered; }
            set { ordered = value; }
        }

        public double Price
        {
            get { return this.products.Sum(x => x.Price) * 1.3; }
            set { price = value; }
        }

        public override string ToString()
        {
            string result = this.Name+" - "+ this.Type;
            return result;
        }

        public void AddProduct(Product p)
        {
            List<Product> allProducts = this.Products;
            allProducts.Add(p);
            this.Price = products.Sum(x => x.Price) * 1.3;
            this.Products = allProducts;
        }

        public bool ContainsProduct(string name)
        {
            List<Product> products = this.Products;
            int countEncountered = products.Count(x=> x.Name==name);
            if (countEncountered > 0)
            {
                return true;
            }
            else return false;
        }

       

        public void PrintRecipe()
        {
            Console.WriteLine(new string('-',25));
            string name = this.Name;
            Console.WriteLine($"{name} RECEPE");
            Console.WriteLine(new string('-', 25));

            List<Product> products = this.Products;
            foreach (Product product in products)
            {
                string productName = product.Name;
                int productWeight = product.Weight;
                Console.WriteLine($"{productName} - {productWeight}");
            }
            Console.WriteLine(new string('-', 25));
        }

        public void Order()
        {
            this.Ordered += 1;
        }

        public static Meal GetSpecialty(Dictionary<string, Meal> meals)
        {
            int maxOrdered = meals.Values.Max(x => x.Ordered);
            List<Meal> specialtyMeal = meals
                .Values
                .Where(x=> x.Ordered==maxOrdered)
                .ToList();
            return specialtyMeal[0];
        }

        public static Meal RecommendByPrice(double price, Dictionary<string, Meal> meals)
        {
            
            Dictionary<string, Meal> mealsWithLessPrice = meals
                .Where(x => x.Value.Price <= price)
                .OrderBy(x => x.Value.Price)
                .ToDictionary(x => x.Key, x => x.Value);
            Console.WriteLine($"count Row={mealsWithLessPrice.Count()}");
            return mealsWithLessPrice.First().Value;
        }

        public static Meal RecommendByPriceAndType(double price, string type, Dictionary<string, Meal> meals)
        {
            Dictionary<string, Meal> mealsWithLessPrice = meals
                .Where(x => (x.Value.Price <= price) && (x.Value.Type == type))
                .OrderByDescending(x => x.Value.Price)
                .ToDictionary(x => x.Key, x => x.Value);
            return mealsWithLessPrice.First().Value;
        }
    }
}
