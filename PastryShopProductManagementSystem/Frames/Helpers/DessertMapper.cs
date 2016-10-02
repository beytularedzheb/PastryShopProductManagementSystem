namespace PastryShopProductManagementSystem.Frames.Helpers
{
    using Models;
    using Data;
    using System.Linq;
    using System.Windows.Forms;
    using System;

    class DessertMapper
    {
        public static Dessert ReadValues(DataGridView gridView, TextBox tbDessetName, bool saveInDB)
        {
            if (gridView == null || gridView.RowCount - 1 <= 0)
            {
                return null;
            }

            Dessert dessert = new Dessert();
            using (var db = new PastryShopDbContext())
            {
                string dessertName = tbDessetName.Text;
                if (dessertName == null || dessertName.Trim().Length == 0)
                {
                    return null;
                }
                dessert.Name = dessertName.Trim();

                int rowCount = gridView.RowCount - 1;
                for (int i = 0; i < rowCount; i++)
                {
                    var productDetailId = gridView.Rows[i].Cells["Product"].Value;
                    var quantity = gridView.Rows[i].Cells["Quantity"].Value;

                    bool areAllRequiredFieldsFilled = productDetailId != null && quantity != null;

                    if (areAllRequiredFieldsFilled)
                    {
                        RecipeLine line = new RecipeLine();
                        line.Dessert = dessert;
                        line.Quantity = Convert.ToDouble(quantity);
                        line.ProductDetail = db.ProductDetails.First(p => p.Id == (int)productDetailId);
                        dessert.RecipeLines.Add(line);
                    }
                    else
                    {
                        return null;
                    }
                }
                if (saveInDB)
                {
                    db.Desserts.Add(dessert);
                    db.SaveChanges();
                }
            }
            return dessert;
        }
    }
}
