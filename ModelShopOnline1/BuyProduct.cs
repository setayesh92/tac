using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelShopOnline.Model
{   [Table("BuyProduct", Schema ="Buy")]
  public  class BuyProduct
    {   public int Id { get; set; }
        public int BuyProductId { get; set; }//کلیدخارجی
        [MaxLength(30)]
        public string BuyName { get; set; }
         public int BuyNumber { get; set; }
        [MaxLength(25)]
        public string BuyTechnique { get; set; }
        [MaxLength(20)]
        public string SizeBoard { get; set; } 
         public double FirstPrice { get; set; }
        public double Reduction { get; set; }
        public double LastPrice { get; set; }
        public string PaikName { get; set; }
        public int FactorId { get; set; }
        [MaxLength(80)]
        public string Description { get; set; }
        public int Statuse { get; set; }//تحویل پیک شد،برگشت خورد
    }
}
