using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelShopOnline.Model
{
    [Table("CommentUser", Schema = "User")]
     public class CommentUser//ارسال نظرات
    {    
        public int Id { get; set; }
        //[MaxLength(50),Required]
        //public string NameUser { get; set; }
        public int ProductIdComment { get; set; }
        [MaxLength(50)]
        public string Comment { get; set; }
        //public int Parent { get; set; }
        public virtual User User { get; set; }
     
        public string UserUserName { get; set; }
    }
}
