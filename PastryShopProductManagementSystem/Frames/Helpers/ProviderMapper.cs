namespace PastryShopProductManagementSystem.Frames.Helpers
{
    using Models;
    using Data;
    using System;
    using System.Windows.Forms;

    class ProviderMapper
    {
        public static Provider ReadValues(TextBox name, bool saveInDB)
        {
            string providerName = (name.Text != null) ? name.Text.Trim() : String.Empty;

            bool areAllRequiredFieldsFilled = providerName != String.Empty;

            if (areAllRequiredFieldsFilled)
            {
                Provider provider = new Provider();
                provider.Name = providerName;

                if (saveInDB)
                {
                    using (var db = new PastryShopDbContext())
                    {
                        db.Providers.Add(provider);
                        db.SaveChanges();
                    }
                }

                return provider;
            }

            return null;
        }
    }
}
