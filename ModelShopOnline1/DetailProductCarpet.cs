using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelShopOnline.Model
{     [Table("DetailProductCarpet",Schema ="Production")]
     public class DetailProductCarpet
    {  public int Id { get; set; }
        public int NumberOfRidger { get; set; }//رجشمار
        public string DemensionsTocm { get; set; }//ابعادبه سانت
        public string TypeOfTissue { get; set; }//نوع بافت
        public string Genus  { get; set; }//جنس
        public double Clips { get; set; }//مقاط
        public double Knot { get; set; }//گره
        public string Color { get; set;}//رنگ
        public string Description { get; set; }//

    }


}
