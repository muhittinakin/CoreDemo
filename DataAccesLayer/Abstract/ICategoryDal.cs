﻿using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Abstract
{
   public  interface ICategoryDal:IGenericDal<Category>
    {

        /* generic yapmak için kapatıldı
        List<Category> ListAllCategory();//metot oluşturduk

        void AddCategory(Category category);
        void DeleteCategory(Category category);
        void UpdateCategory(Category category);
        Category GetById(int id);
        */




    }
}
