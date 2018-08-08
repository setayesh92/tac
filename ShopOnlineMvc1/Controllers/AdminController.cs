using ModelShopOnline.Model;
using ShopOnlineMvc1.Models;
 using ShopOnlineMvc1.ViewModels;
using System;
using System.Net.Sockets;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShopOnlineMvc1.Controllers
{
    public class AdminController : Controller
    {

        // GET: Admin
        public ActionResult Create()
        {
            ShopOnlineDbContext ctx = new ShopOnlineDbContext();
            ViewBag.CategoryId = new SelectList(ctx.Category.ToList(), "Id", "Name");
            return View();
        }
        [HttpPost]
        public ActionResult Create(DetailProductPainting p, HttpPostedFileBase UrlImage1)
        {
            var extention = Path.GetExtension(UrlImage1.FileName).ToLower();
            if (UrlImage1.ContentLength / 1024 <= 150 && (extention == ".jpg" || extention == ".jpeg" || extention == ".png" || extention == "gif"))
            {
                ShopOnlineDbContext ctx = new ShopOnlineDbContext();
                var fileName = $"{Guid.NewGuid().ToString()}{extention}";
                var fullPath = Path.Combine(Server.MapPath("~/images/urlimages"), fileName);
                UrlImage1.SaveAs(fullPath);
                p.UrlImage = $"~/images/urlimages/{fileName}";
                ctx.Product.Add(p);
                ctx.SaveChanges();
                //return Content("ثبت با موفقیت انجام شد ");
                TempData["Messag"] = "ثبت با موفقیت انجام شد ";
                return RedirectToAction("ProductList");
            }
            else
            {
                TempData["Message"] = "فایل ارسالی مناسب نیست ";
                TempData["MessageClass"] = "danger";
                return RedirectToAction("Create");
            }

        }
        public ActionResult ProductList()
        {
            ShopOnlineDbContext ctx = new ShopOnlineDbContext();

            return View(ctx.Product.ToList());
        }
        public ActionResult Edit(int id)
        {
            ShopOnlineDbContext ctx = new ShopOnlineDbContext();
            var model = ctx.Product.Find(id);
            ViewBag.CategoryId = new SelectList(ctx.Category.ToList(), "Id", "Name", model.CategoryId);
            AdminEditViewModel viewModel = new AdminEditViewModel()
            {
                Id = model.Id,
                NameBoard = model.NameBoard,
                FirstPrice = model.FirstPrice,
                 Reduction = model.Reduction,
                LastPrice = model.LastPrice,
                Number = model.Number,
                TimeGaranty = model.TimeGaranty,
                CategoryId = model.CategoryId,
                UrlImage = model.UrlImage,
                NameArtist = ((DetailProductPainting)model).NameArtist,
                SizeBoard = ((DetailProductPainting)model).SizeBoard,
                Technique = ((DetailProductPainting)model).Technique

            };
            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Edit(FormCollection viewModel)
        {
            ShopOnlineDbContext ctx = new ShopOnlineDbContext();
            //var model = ctx.Product.Find(viewModel.Id);
            //if (viewModel.UrlImage1 != null)
            //{
            //    var extention = Path.GetExtension(viewModel.UrlImage1.FileName).ToLower();
            //    if (viewModel.UrlImage1.ContentLength / 1024 >= 150)
            //    {
            //        ModelState.AddModelError("UrlImage1", "سایز فایل باید کمتراز150کیلوبایت باشد");
            //        //ModelState.AddModelError("","این خطای فرم نمونه است");
            //    }

            //    if (!(extention == ".jpg" || extention == ".png" || extention == ".jpeg" || extention == ".gif"))
            //    {
            //        ModelState.AddModelError("UrlImage1", "فرمت فایل ارسالی مناسب نیست");
            //    }

            //}
            //if (ModelState.IsValid)
            //{
            //    //model.Id = viewModel.Id;
            //    model.CategoryId = viewModel.CategoryId;
            //    model.NameBoard = viewModel.NameBoard;
            //    model.FirstPrice = viewModel.FirstPrice;
            //    model.Reduction = viewModel.Reduction;
            //    model.LastPrice = viewModel.LastPrice;
            //    model.Number = viewModel.Number;

            //    //if (viewModel.UrlImage1 != null)
            //    //{
            //    //    var extention = Path.GetExtension(viewModel.UrlImage1.FileName);
            //    //    var fileName = $"{Guid.NewGuid().ToString()}{extention}";
            //    //    var fullPath = Path.Combine(Server.MapPath("~/images/urlimages"), fileName);
            //    //    viewModel.UrlImage1.SaveAs(fullPath);
            //    //    var UrlImage2 = $"~/images/urlimages/{fileName}";
            //    //    model.UrlImage = UrlImage2;
            //    //}
            //    ctx.SaveChanges();
            //    TempData["Message"] = "ویرایش باموفقیت انجام شد";
            //    return RedirectToAction("ProductList", "Admin");
            //}
            //ViewBag.CategoryId = new SelectList(ctx.Category.ToList(), "Id", "Name", viewModel.CategoryId);
            //TempData["Message"] = "ویرایش با خطا مواجه شده است";
            //TempData["MessageClass"] = "danger";
            return View(viewModel);
        }
        public ActionResult Delete(int id)
        {
            ShopOnlineDbContext ctx = new ShopOnlineDbContext();
            var d = ctx.Product.Find(id);
            return View(d);
        }
        [ActionName("Delete")]
        [HttpPost] 
        public ActionResult DeleteConfirm(int id)
        {
            ShopOnlineDbContext ctx = new ShopOnlineDbContext();
            var d = ctx.Product.Find(id);
            TempData["Message"] = $"{d.NameBoard}حذف شد";
            ctx.Product.Remove(d);
            ctx.SaveChanges();
            return RedirectToAction("productlist");
        }

    }

   
}