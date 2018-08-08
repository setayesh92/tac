using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelShopOnline.Model
{
    [Table("Category", Schema = "Production")]
    public class Category
    {
        public int Id { get; set; }
        [MaxLength(50),Required]
        public string Name { get; set; }
        [NotMapped]
        public int ProductCount { get; set; }
        public virtual ICollection<Product> Product { get; set; }



    }
}
