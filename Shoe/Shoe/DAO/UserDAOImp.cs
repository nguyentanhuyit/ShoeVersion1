﻿using Shoe.Models.DBModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shoe.DAO
{
    public class UserDAOImp : IUserDAO
    {
        private shoeContext _context;
        public UserDAOImp(shoeContext ShoeContext)
        {
            _context = ShoeContext;
        }

        public User getUser(int id)
        {
            User user = _context.Users.Where(o => o.Id == id).FirstOrDefault();
            return user;
        }

        public User login(User userLogin)
        {
            User user = _context.Users.Where(o => o.Email.Contains(userLogin.Email) && o.Password == userLogin.Password).FirstOrDefault();
           
            return user;
        }

        public User signUp(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
            return user;
        }
    }
}
