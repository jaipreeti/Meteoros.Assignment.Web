using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Meteoros.Assignment.Web.Data;
using Meteoros.Assignment.Web.Models;
using Meteoros.Assignment.Web.Helper;
using Newtonsoft.Json;

namespace Meteoros.Assignment.Web.Controllers
{
    public class ProductController : Controller
    {
        private readonly string baseUrl = "https://localhost:7084/";
        public ProductController()
        {

        }

        // GET: Product
        public async Task<IActionResult> Index()
        {
            //var respons = await ApiClient.GetAsync(baseUrl + "api/Product");
            //var data = JsonConvert.DeserializeObject<List<Product>>(respons);
            return View();
        }

        // GET: Product/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            var respons = await ApiClient.GetAsync(baseUrl + "api/Product/" + id);
            var product = JsonConvert.DeserializeObject<Product>(respons);
            return View(product);
        }

        // GET: Product/Create
        public IActionResult Create()
        {
            return View();
        }

 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Description,Price,Discount")] Product product)
        {
            if (ModelState.IsValid)
            {
                var respons = await ApiClient.PostAsync(baseUrl + "api/Product",JsonConvert.SerializeObject(product));
                //var response = JsonConvert.DeserializeObject<Product>(respons);
                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }

    }
}
