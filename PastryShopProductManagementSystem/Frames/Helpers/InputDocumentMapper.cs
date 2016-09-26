using PastryShopProductManagementSystem.Data;
using PastryShopProductManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PastryShopProductManagementSystem.Frames.Helpers
{
    class InputDocumentMapper
    {
        public static InputDocument ReadValues(DataGridView gridView)
        {
            if (gridView == null || gridView.RowCount - 1 <= 0)
            {
                return null;
            }

            InputDocument inputDocument = new InputDocument();
            ICollection<InputDocumentLine> lines = new LinkedList<InputDocumentLine>();
            inputDocument.Lines = lines;

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
                        line.Provider = db.Providers.Find(providerId);
                        line.ReceivedQuantity = Convert.ToDecimal(receivedQuantity.ToString());
                        line.Vehicle = vehicle != null ? vehicle.ToString() : String.Empty;
                        line.Document = document != null ? document.ToString() : String.Empty;

                        var fetchedProductFromDB = (from p in db.Products
                                                    where p.BatchNumber == batchNumber.ToString()
                                                    select p).FirstOrDefault();
                        if (fetchedProductFromDB == null)
                        {
                            Product product = new Product();
                            product.AvailableQuantity = line.ReceivedQuantity;
                            product.BatchNumber = batchNumber.ToString();
                            product.ExpiryDate = Convert.ToDateTime(expiryDate);
                            product.StorageCondition = storageCondition != null ? storageCondition.ToString() : String.Empty;
                            product.ProductDetail = db.ProductDetails.Find(productDetailId);

                            line.Product = product;
                        }
                        else
                        {
                            line.Product = fetchedProductFromDB;
                            line.Product.AvailableQuantity += line.ReceivedQuantity;
                        }

                        lines.Add(line);
                    }
                    else
                    {
                        return null;
                    }
                }
            }

            return inputDocument;
        }
    }
}
