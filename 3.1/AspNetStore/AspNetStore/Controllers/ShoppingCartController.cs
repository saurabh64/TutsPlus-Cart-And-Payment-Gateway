﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using AspNetStore.Services;

namespace AspNetStore.Controllers
{
    public class ShoppingCartController : Controller
    {
        // GET: ShoppingCart
        public ActionResult Index()
        {
            return View();
        }

        public async Task<ActionResult> AddToCart(int id)
        {
            var cart = new ShoppingCart(HttpContext);

            await cart.AddAsync(id);

            return RedirectToAction("index");
        }

        public async Task<ActionResult> RemoveFromCart(int id)
        {
            var cart = new ShoppingCart(HttpContext);

            await cart.RemoveAsync(id);

            return RedirectToAction("index");
        }
    }
}