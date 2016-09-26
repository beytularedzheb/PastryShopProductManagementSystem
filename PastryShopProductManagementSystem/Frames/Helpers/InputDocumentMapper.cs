using PastryShopProductManagementSystem.Data;
using PastryShopProductManagementSystem.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace PastryShopProductManagementSystem.Frames.Helpers
{
    class InputDocumentMapper
    {
        public static InputDocument ReadValues(DataGridView gridView, bool saveInDB)
        {
            if (gridView == null || gridView.RowCount - 1 <= 0)
            {
                return null;
            }

            InputDocument inputDocument = new InputDocument();

            using (var db = new PastryShopDbContext())
            {
                int rowCount = gridView.RowCount - 1;
                for (int i = 0; i < rowCount; i++)
                {
                    var receivingDate = gridView.Rows[i].Cells["ReceivingDate"].Value;
                    var providerId = gridView.Rows[i].Cells["Provider"].Value;
                    var productDetailId = gridView.Rows[i].Cells["Product"].Value;
                    var receivedQuantity = gridView.Rows[i].Cells["ReceivedQuantity"].Value;
                    var batchNumber = gridView.Rows[i].Cells["BatchNumber"].Value;
                    var expiryDate = gridView.Rows[i].Cells["ExpiryDate"].Value;
                    var storageCondition = gridView.Rows[i].Cells["StorageCondition"].Value;
                    var vehicle = gridView.Rows[i].Cells["Vehicle"].Value;
                    var document = gridView.Rows[i].Cells["Document"].Value;

                    bool areAllRequiredFieldsFilled = batchNumber != null
                        && receivingDate != null
                        && productDetailId != null
                        && expiryDate != null
                        && receivedQuantity != null
                        && providerId != null;

                    if (areAllRequiredFieldsFilled)
                    {
                        InputDocumentLine line = new InputDocumentLine();
                        line.InputDocument = inputDocument;
                        line.ReceivingDate = Convert.ToDateTime(receivingDate.ToString());
                        line.Provider = (from p in db.Providers
                                         where p.Id == (int)providerId
                                         select p).First();

                        line.ReceivedQuantity = Convert.ToDecimal(receivedQuantity.ToString());
                        line.Vehicle = vehicle != null ? vehicle.ToString() : String.Empty;
                        line.Document = document != null ? document.ToString() : String.Empty;

                        var retrievedProductFromDB = (from p in db.Products
                                                    where p.BatchNumber == batchNumber.ToString()
                                                    select p).FirstOrDefault();
                        if (retrievedProductFromDB == null)
                        {
                            Product product = new Product();
                            product.AvailableQuantity = line.ReceivedQuantity;
                            product.BatchNumber = batchNumber.ToString();
                            product.ExpiryDate = Convert.ToDateTime(expiryDate);
                            product.StorageCondition = storageCondition != null ? storageCondition.ToString() : String.Empty;
                            product.ProductDetail = (from pd in db.ProductDetails
                                                     where pd.Id == (int)productDetailId
                                                     select pd).First();

                            line.Product = product;
                        }
                        else
                        {
                            line.Product = retrievedProductFromDB;
                            line.Product.AvailableQuantity += line.ReceivedQuantity;
                        }

                        inputDocument.Lines.Add(line);
                    }
                    else
                    {
                        return null;
                    }
                }
                if (saveInDB)
                {
                    db.InputDocuments.Add(inputDocument);
                    db.SaveChanges();
                }
            }

            return inputDocument;
        }
    }
}
