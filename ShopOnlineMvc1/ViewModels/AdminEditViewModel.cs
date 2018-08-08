using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ShopOnlineMvc1.ViewModels
{
    public class AdminEditViewModel
    {
            [Display(Name = "شناسه محصول")]
            public int Id { get; set; }
            [MaxLength(50,ErrorMessage ="نام تابلو باید حداکثر50کاراکترباشد ")]
            [Required(ErrorMessage ="این فیلد اجباری است")]
            //[Index(IsUnique =true)]
            [Display(Name = "نام تابلو")]
            public string NameBoard { get; set; }
            [Display(Name = "قیمت اولیه")]
            public decimal FirstPrice { get; set; }
            [Display(Name = "درصد تخفیف")]
            public double Reduction { get; set; }
            [Required(ErrorMessage = "این فیلد اجباری است")]
              [Display(Name = " قیمت نهایی ")]
             public decimal LastPrice { get; set; }
           
            [Display(Name = "تعداد")]
            public int Number { get; set; }
            [Display(Name = "مدت ضمانت")]
            public int TimeGaranty { get; set; }
           
            public string UrlImage { get; set; }
            [MaxLength(150)]
             [Required(ErrorMessage = "این فیلد اجباری است")]
           // [Display(Name = "تصویرمحصول")]
           //public HttpPostedFileBase UrlImage1 { get; set; }
           [Display(Name = "دسته بندی")]
            public int? CategoryId { get; set; }
            [MaxLength(30)]
            [Display(Name = "نام هنرمند")]
            public string NameArtist { get; set; }
            [MaxLength(20)]
            [Required(ErrorMessage = "این فیلد اجباری است")]
            [Display(Name = "سایزتابلو")]
            public string SizeBoard { get; set; }
            [MaxLength(25)]
             [Required(ErrorMessage = "این فیلد اجباری است")]
            [Display(Name = "تکنیک")]
           public string Technique { get; set; }//تکنیک(سیاه قلم،رنگ روغن
        }
    }