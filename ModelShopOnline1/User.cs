using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelShopOnline.Model
{
    [Table("User", Schema = "User")]
     public class User
    {    [Key,DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string UserName { get; set; }
        [MaxLength(30),Required]
        public string Passworde { get; set; }
        [MaxLength(30),Required]
        public string FullName { get; set; }
        [MaxLength(15),Required]
        public string Rule { get; set; }
        public virtual ICollection<CommentUser> CommentUser { get; set; }
        public virtual ICollection<AddressUser> AddressUser { get; set; }
    }
}
