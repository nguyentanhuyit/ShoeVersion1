﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shoe.Models.DBModels;
using Shoe.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shoe.Controllers
{
    public class CartController : Controller
    {
        private ICartItemService ItemService;
        private IProductService ProductService;
        public CartController(ICartItemService Item, IProductService Product)
        {
            ItemService = Item;
            ProductService = Product;
        }
        public IActionResult Index()
        {
            
            if (HttpContext.Session.GetString("userName") != null)
            {
                int UserId = int.Parse(HttpContext.Session.GetString("id"));
                List<CartItem> listCart = ItemService.getListCartItem(UserId);
                List<Product> listProduct = new List<Product>();
                int? totalPrice = 0;
                foreach(var item in listCart)
                {
                    Product product = ProductService.GetProductByShoeSizeID((int)item.ShoeSizeId);
                    listProduct.Add(product);
                    totalPrice += product.Price * item.Quantity;
                  
                }
               
                ViewBag.ListCartItem = listProduct;
                ViewBag.ListCart = listCart;
                ViewBag.TotalPrice = totalPrice;
                ViewBag.CartNumber = listCart.Count();
                return View();
            }
            return Redirect("/Account/Login");
        }

        [HttpPost]
        public void AddToCart(int ProductId, int shoeSizeID, int quanlity)
        {
            int UserId = int.Parse(HttpContext.Session.GetString("id"));

            if (HttpContext.Session.GetString("userName") != null)
            {
                CartItem item = ItemService.GetCartItem(UserId, shoeSizeID);
                if (item == null)
                {
                    
                    ItemService.addCartItem(UserId, shoeSizeID, quanlity);
                }
                else if(item != null)
                {
                    
                    item.Quantity = item.Quantity+1;
                    ItemService.updateQuantity(item);
                }
                
            }
        }

        [HttpDelete]
        public void deleteCartItem(int cartItemID)
        {
            ItemService.deleteCartItem(cartItemID);
        }

        [HttpPut]
        public void updateCartItem(CartItem item)
        {
            int UserId = int.Parse(HttpContext.Session.GetString("id"));
            item.UserId = UserId;
            ItemService.updateQuantity(item);
        }
    }
}
