﻿using Shoe.Models.DBModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shoe.DAO
{
    public interface ICategoryDAO
    {
        public List<Category> getListCategoryByGender(string gender);
        //NguyenDoanMinhNhat
        public List<Category> getAll();
        //NguyenDoanMinhNhat
        public Category getById(int id);
    }
}
