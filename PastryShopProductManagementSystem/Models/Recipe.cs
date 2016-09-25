using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PastryShopProductManagementSystem.Models
{
    public class Recipe
    {
        public Recipe()
        {
            this.RecipeLines = new HashSet<RecipeLine>();
        }

        [Key]
        public int Id { get; set; }

        public virtual ICollection<RecipeLine> RecipeLines { get; set; }
    }
}
