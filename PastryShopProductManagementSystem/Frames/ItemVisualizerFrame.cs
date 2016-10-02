namespace PastryShopProductManagementSystem.Frames
{
    using Data;
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;
    using System.Windows.Forms;

    public partial class ItemVisualizerFrame : Form
    {
        private List<Product> availableAndNotExpiredProducts;
        private List<Product> notAvailableAndNotExpiredProducts;
        private List<Product> productsWithExpiredDate;

        public ItemVisualizerFrame()
        {
            InitializeComponent();
            Cursor = Cursors.WaitCursor;
            LoadDesserts();
            LoadProviders();
            LoadProductsBySelectedOption(0);
            Cursor = Cursors.Default;
        }

        private void LoadProductsBySelectedOption(int option)
        {
            var dateNow = DateTime.Now.Date;
            if (option == 0)
            {
                if (this.availableAndNotExpiredProducts == null)
                {
                    using (var db = new PastryShopDbContext())
                    {
                        this.availableAndNotExpiredProducts = db.Products.Include("ProductDetail")
                            .Where(p =>
                                p.AvailableQuantity > 0
                                && p.ExpiryDate > dateNow)
                            .ToList();
                    }
                }
                LoadProductsIntoDataGridView(this.availableAndNotExpiredProducts);
            }
            else if (option == 1)
            {
                if (notAvailableAndNotExpiredProducts == null)
                {
                    using (var db = new PastryShopDbContext())
                    {
                        this.notAvailableAndNotExpiredProducts = db.Products.Include("ProductDetail")
                            .Where(p =>
                                p.AvailableQuantity <= 0
                                && p.ExpiryDate > dateNow)
                            .ToList();
                    }
                }
                LoadProductsIntoDataGridView(this.notAvailableAndNotExpiredProducts);
            }
            else if (option == 2)
            {
                if (productsWithExpiredDate == null)
                {
                    using (var db = new PastryShopDbContext())
                    {
                        this.productsWithExpiredDate = db.Products.Include("ProductDetail")
                            .Where(p => p.ExpiryDate < dateNow)
                            .ToList();
                    }
                }
                LoadProductsIntoDataGridView(this.productsWithExpiredDate);
            }
        }

        private void LoadProductsIntoDataGridView(List<Product> products)
        {
            if (products != null)
            {
                this.dgwProducts.Rows.Clear();

                foreach (var product in products)
                {
                    int newRowIndex = this.dgwProducts.Rows.Add();
                    DataGridViewRow row = this.dgwProducts.Rows[newRowIndex];
                    row.Cells["ProductName"].Value = product.ProductDetail.Name;
                    row.Cells["BatchNumber"].Value = product.BatchNumber;
                    row.Cells["AvailableQuantity"].Value = product.AvailableQuantity.ToString("0.#######");
                    row.Cells["ExpiryDate"].Value = product.ExpiryDate.Date.ToShortDateString();
                    row.Cells["StorageCondition"].Value = product.StorageCondition;
                }
                UpdateDataGridView();
            }
        }

        private void LoadProviders()
        {
            using (var db = new PastryShopDbContext())
            {
                List<string> providerNames = db.Providers.Select(p => p.Name).ToList<string>();
                foreach (var providerName in providerNames)
                {
                    int newRowIndex = this.dgwProviders.Rows.Add();
                    DataGridViewRow row = this.dgwProviders.Rows[newRowIndex];
                    row.Cells["ProviderName"].Value = providerName;
                }
            }
        }

        private void LoadDesserts()
        {
            using (var db = new PastryShopDbContext())
            {
                List<Dessert> desserts = db.Desserts.OrderBy(d => d.Name).ToList();
                foreach (var dessert in desserts)
                {
                    int newRowIndex = this.dgwDesserts.Rows.Add();
                    DataGridViewRow row = this.dgwDesserts.Rows[newRowIndex];
                    row.Cells["DessertName"].Value = dessert.Name;
                    var recipeLines = (DataGridViewComboBoxCell)row.Cells["DessertRecipeLines"];
                    List<string> productNameQuantityList = dessert.RecipeLines
                        .Select(
                            rl => rl.ProductDetail.Name
                            + " - "
                            + rl.Quantity.ToString("0.#######")
                            + " "
                            + rl.ProductDetail.Unit
                        ).ToList<string>();
                    productNameQuantityList.ForEach(x => recipeLines.Items.Add(x));
                }
            }
        }

        private void UpdateDataGridView()
        {
            this.dgwProducts.Update();
            this.dgwProducts.Refresh();
        }

        private void rbAvailableProducts_CheckedChanged(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            LoadProductsBySelectedOption(0);
            Cursor = Cursors.Default;
        }

        private void rbNotAvailableProducts_CheckedChanged(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            LoadProductsBySelectedOption(1);
            Cursor = Cursors.Default;
        }

        private void rbProductsWithExpiredDate_CheckedChanged(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            LoadProductsBySelectedOption(2);
            Cursor = Cursors.Default;
        }
    }
}
