﻿using Shoe.Models.DBModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shoe.DAO
{
    public class CartItemDAOImp : ICartItemDAO
    {
        private shoeContext _context;
        public CartItemDAOImp(shoeContext shoeContext)
        {
            _context = shoeContext;
        }
        public CartItem addCartItem(int userID, int shoeSizeID, int quantity)
        {
            CartItem Item = new CartItem();
            Item.UserId = userID;
            Item.ShoeSizeId = shoeSizeID;
            Item.Quantity = 1;
             _context.CartItems.Add(Item);
            _context.SaveChanges();
            return Item;
        }

        public bool deleteCartItem(int cartItemID)
        {
            var cartItem = _context.CartItems.Where(o => o.Id == cartItemID).FirstOrDefault();
            if(cartItem!= null)
            {
                _context.CartItems.Remove(cartItem);
                _context.SaveChanges();
                return true;
            }
            return false;
           
           
        }

        public void deleteCartItemUser(int userID)
        {
            var cartItem = _context.CartItems.Where(o => o.UserId == userID).ToList();
            foreach(var item in cartItem)
            {
                _context.CartItems.Remove(item);
                _context.SaveChanges();
            }
        }

        public CartItem GetCartItem(int userID, int shoeSizeID)
        {
            CartItem cartItem = _context.CartItems.Where(o => o.UserId == userID && o.ShoeSizeId == shoeSizeID).FirstOrDefault();
            return cartItem;
        }

        public List<CartItem> getListCartItem(int userUD)
        {
            List<CartItem> listCartItem = _context.CartItems.Where(o => o.UserId == userUD).ToList();
            return listCartItem;
        }

        public CartItem updateQuantity(CartItem item)
        {
            _context.CartItems.Update(item);
            _context.SaveChanges();
            return item;
        }

      

    }
}
