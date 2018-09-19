using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web1.Models;

namespace Web1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ContactdetailsModel model = GetData().Contactdetails; //ieprieks aiz = bija new COntactdetalsModel() - kas dod tuksu vertibu
            

            return View(model);
        }

        public ActionResult Catalog()
        {
            List<ProductModel> products = GetData().Product; //ieprieks aiz = bija new List<ProductModel> kas dod tuksu vertibu tpc ierakstijam get
                return View(products);
        }

        public ActionResult Buy(string name)
        {
            //parbaudam kura prece ir nopirtka no visa kataloga
            ProductModel product = null;
            foreach (ProductModel m in GetData().Product)
            {
                if (m.ProductName == name)
                {
                    product = m;
                    break;
                }
            }
            //speciala sessija kamer lietotajs ir majaslapa tikmer tas strada un saglaba datus

            //if nostradas kad ieliks pirmo produktu, ecak tad vairak nestradas
            if (Session["preces"] == null)
            {
                Session["preces"] = new List<ProductModel>();
            }
            //sessija ir objekts tapaec jaieliek as lai defineto to ka sarakstu citadi var to definet ar ka kadu citu tipu
            (Session["preces"] as List<ProductModel>).Add(product);

            //sis beigas atgriezis uz katalogu
            return RedirectToAction("Catalog");
        }

        public static StoreModel GetData()
        {
            return new StoreModel()
            {
                StoreName = "Nosaukums Veikala",
                Contactdetails = new ContactdetailsModel()
                {
                    Epasts = "epasts@epasts.com",
                    Talrunis = "tālr. 2345679",
                    Location = new AdressModel()
                    {
                        Country = "Latvija",
                        City = "Riga",
                        Street = "Vagonu iela",
                        HouseNo = "12C",
                        ApartmentNo = 4,

                    }
                },
                Product = new List<ProductModel>()
                {
                    new ProductModel()
                    {//sos kopē un pievieno modeli un cena
                        ProductName = "Dators",
                        Price = new PriceModel()
                        {
                            Amount = 800,
                            Currency = "$"
                        }
                    },
                    new ProductModel()
                    {
                        ProductName = "TV",
                        Price = new PriceModel()
                        {
                            Amount = 200,
                            Currency = "$"
                        }
                    },
                }
            };
        }
    }

    
}