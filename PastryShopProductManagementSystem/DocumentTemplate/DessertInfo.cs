namespace PastryShopProductManagementSystem.DocumentTemplate
{
    using System.Collections.Generic;

    public class DessertInfo
    {
        public DessertInfo()
        {
            this.Ingredients = new List<Ingredient>();
        }

        public string Name { get; set; }

        public int Quantity { get; set; }

        public List<Ingredient> Ingredients { get; set; }
    }
}