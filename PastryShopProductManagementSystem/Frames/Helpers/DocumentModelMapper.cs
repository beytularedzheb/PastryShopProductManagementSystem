namespace PastryShopProductManagementSystem.Frames.Helpers
{
    using DocumentTemplate;
    using Models;
    using System.Linq;

    public class DocumentModelMapper
    {
        public static DocumentModel CreateDocumentModel(OutputDocument outputDoc)
        {
            DocumentModel docModel = new DocumentModel();
            docModel.IssueDate = outputDoc.IssueDate;
            foreach (var docLine in outputDoc.Lines)
            {
                DessertInfo dessert = new DessertInfo();
                dessert.Name = docLine.Dessert.Name;
                dessert.Quantity = docLine.Quantity;

                foreach (var outputDocProdLine in docLine.OutputDocLineProducts)
                {
                    Ingredient ingredient = new Ingredient();
                    ingredient.Name = outputDocProdLine.Product.ProductDetail.Name;
                    ingredient.Quantity = outputDocProdLine.CalcualtedQuantity;
                    ingredient.Unit = outputDocProdLine.Product.ProductDetail.Unit;
                    ingredient.BatchNumber = outputDocProdLine.Product.BatchNumber;
                    dessert.Ingredients.Add(ingredient);
                }
                dessert.Ingredients = dessert.Ingredients.OrderBy(x => x.Name).ToList();
                docModel.Desserts.Add(dessert);
            }

            return docModel;
        }
    }
}
