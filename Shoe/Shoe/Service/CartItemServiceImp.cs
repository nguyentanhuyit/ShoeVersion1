﻿using Shoe.DAO;
using Shoe.Models.DBModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shoe.Service
{
    public class CartItemServiceImp : ICartItemService
    {
        private ICartItemDAO cartItemDAO;
        public CartItemServiceImp(ICartItemDAO cartItem)
        {
            cartItemDAO = cartItem;
        }
        public CartItem addCartItem(int userID, int shoeSizeID, int quantity)
        {
            return cartItemDAO.addCartItem(userID, shoeSizeID, quantity);
        }

        public bool deleteCartItem(int cartItemID)
        {
            return cartItemDAO.deleteCartItem(cartItemID);
        }

        public void deleteItemUser(int userID)
        {
             cartItemDAO.deleteCartItemUser(userID);
        }

        public CartItem GetCartItem(int userID, int shoeSizeID)
        {
            return cartItemDAO.GetCartItem(userID, shoeSizeID);
        }

        public List<CartItem> getListCartItem(int userUD)
        {
            return cartItemDAO.getListCartItem(userUD);
        }

        public CartItem updateQuantity(CartItem item)
        {
            return cartItemDAO.updateQuantity(item);
        }
    }
}
