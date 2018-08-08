using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelShopOnline.Model
{    [Table("BuyFactor", Schema ="Buy")]
     public class BuyFactor
    {     public int Id { get; set; }
        public string IdUser { get; set; }
        public DateTime BuyDate { get; set; }
        public int Number { get; set; }
        public decimal Amount{ get; set; }
        public decimal TotalAmount { get; set; }
        //public int? AddressTahvil { get; set; }
        public int StatuseFactor { get; set; }
        //public int StatusePardakht { get; set; }
        
    }
}
