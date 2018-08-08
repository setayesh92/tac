using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelShopOnline.Model
{     [Table("AddressUser",Schema="User")]
   public class AddressUser//آدرس مشتری
    {    public int Id { get; set; }
        [MaxLength(20)]
        public string AddressLocate { get; set; }
        [MaxLength(20),Required]
        public string NameOstan { get; set; }
        [MaxLength(20),Required]
        public string Namecity { get; set; }
        [MaxLength(50)]
        public string Descripton { get; set; }
        [MaxLength(11),Required]
         public string  Telephone  { get; set; }
        [MaxLength(11),Required]
        public string Mobile { get; set; }
        [MaxLength(10)]
        public string PostalCode { get; set; }
        public virtual User User { get; set; }
         
        public string UserUserName { get; set; }


    }
}
