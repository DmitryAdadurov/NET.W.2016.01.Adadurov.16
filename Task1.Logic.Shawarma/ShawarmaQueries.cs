using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Logic.Shawarma
{
    public class ShawarmaQueries
    {
        private readonly ShawarmaContext shawarmaDb;

        public ShawarmaQueries()
        {
            shawarmaDb = new ShawarmaContext();
        }

        public void AddIngridients(string name, int weight, int catId)
        {
            Ingredient i = new Ingredient { IngredientName = name, TotalWeight = weight, CategoryId = catId };
            shawarmaDb.Ingredient.Add(i);
            shawarmaDb.SaveChanges();
        }

        public void ShawarmaSell(int ingridientId)
        {
            Ingredient i = shawarmaDb.Ingredient.FirstOrDefault(t => t.IngredientId == ingridientId);
            shawarmaDb.Ingredient.Remove(i);
            shawarmaDb.SaveChanges();
        }

        public void CreateRecipt(int weight, int shawarmaId, int ingridientId)
        {
            shawarmaDb.ShawarmaRecipe.Add(new ShawarmaRecipe { IngredientId = ingridientId, ShawarmaId = shawarmaId, Weight = weight });
            shawarmaDb.SaveChanges();
        }

        public void SetNewPrice(int priceControllerId, decimal price, string comment = null)
        {
            PriceController pc = shawarmaDb.PriceController.FirstOrDefault(t => t.PriceControllerId == priceControllerId);

            if (pc != null)
            {
                pc.Price = price;
                shawarmaDb.SaveChanges();
            }
        }

        public void AddSellingPoint(string address, SellingPointCategory spc, string shawarmaTitle)
        {
            var sp = new SellingPoint { Address = address, SellingPointCategory = spc, ShawarmaTitle = shawarmaTitle };
            shawarmaDb.SellingPoint.Add(sp);
            shawarmaDb.SaveChanges();
        }

        public void AddNewChief(string name, SellingPoint sp)
        {
            shawarmaDb.Seller.Add(new Seller { SellerName = name, SellingPoint = sp });
        }

        public IEnumerable GenerateSellingPointReport(SellingPoint sp, DateTime from, DateTime at)
        {
            return shawarmaDb.OrderDetails
                .Where(t => t.OrderHeader.Seller.SellingPoint == sp && t.OrderHeader.OrderDate > from && t.OrderHeader.OrderDate < at)
                .Join(shawarmaDb.Shawarma,
                    a => a.ShawarmaId,
                    b => b.ShawarmaId,
                    (a, b) => new { a, b }
                    ) as IEnumerable;

        }
    }
}
