namespace PastryShopProductManagementSystem.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Dessert
    {
        public Dessert()
        {
            this.RecipeLines = new HashSet<RecipeLine>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public virtual ICollection<RecipeLine> RecipeLines { get; set; }
    }
}
