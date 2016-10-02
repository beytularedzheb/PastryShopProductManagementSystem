namespace PastryShopProductManagementSystem.Frames.Helpers
{
    using Models;
    using Data;
    using System;
    using System.Windows.Forms;

    class ProductDetailMapper
    {
        public static ProductDetail ReadValues(TextBox name, TextBox unit, bool saveInDB)
        {
            string productName = (name.Text != null) ? name.Text.Trim() : String.Empty;
            string productUnit = (unit.Text != null) ? unit.Text.Trim() : String.Empty;

            bool areAllRequiredFieldsFilled = productName != String.Empty && productUnit != String.Empty;

            if (areAllRequiredFieldsFilled)
            {
                ProductDetail productDetail = new ProductDetail();
                productDetail.Name = productName;
                productDetail.Unit = productUnit;

                if (saveInDB)
                {
                    using (var db = new PastryShopDbContext())
                    {
                        db.ProductDetails.Add(productDetail);
                        db.SaveChanges();
                    }
                }

                return productDetail;
            }

            return null;
        }
    }
}
