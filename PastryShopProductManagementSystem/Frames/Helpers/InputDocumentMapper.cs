namespace PastryShopProductManagementSystem.Frames.Helpers
{
    using Data;
    using Models;
    using CustomControls;
    using System;
    using System.Linq;
    using System.Windows.Forms;

    class InputDocumentMapper
    {
        public static InputDocument ReadValues(DataGridView gridView, bool saveInDB)
        {
            if (gridView == null || gridView.RowCount - 1 <= 0)
            {
                return null;
            }

            InputDocument inputDocument = new InputDocument();
            inputDocument.CreatedOn = DateTime.Now;

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
                        line.Provider = db.Providers.Single(pr => pr.Id == (int)providerId);

                        line.ReceivedQuantity = Convert.ToDouble(receivedQuantity.ToString());
                        line.Vehicle = (vehicle != null) ? vehicle.ToString() : String.Empty;
                        line.Document = (document != null) ? document.ToString() : String.Empty;

                        var retrievedProductFromDB = db.Products
                            .FirstOrDefault(p => p.ProductDetail.Id == (int)productDetailId
                                && p.BatchNumber == batchNumber.ToString()
                            );
                        if (retrievedProductFromDB == null)
                        {
                            Product product = new Product();
                            product.AvailableQuantity = line.ReceivedQuantity;
                            product.BatchNumber = batchNumber.ToString();
                            product.ExpiryDate = Convert.ToDateTime(expiryDate).Date;
                            product.StorageCondition = (storageCondition != null) ? storageCondition.ToString() : String.Empty;
                            product.ProductDetail = db.ProductDetails.Single(p => p.Id == (int)productDetailId);

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
