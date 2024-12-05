﻿using ShopWeb.Data;
using ShopWeb.Models;
using ShopWeb.Repository.IRepository;
using System.Linq.Expressions;

namespace ShopWeb.Repository
{
    public class ProductRepository :Repository<Product>, IProductRepository
    {
        private ApplicationDbContext _db;
        public ProductRepository(ApplicationDbContext db) : base(db) 
        {
          _db = db;
        }
       

        public void Update(Product Obj)
        {
           var objFormDB=_db.Products.FirstOrDefault(u=>u.Id == Obj.Id);
            if (objFormDB != null)
            {
                objFormDB.Title = Obj.Title;
                objFormDB.Description = Obj.Description;
                objFormDB.Price = Obj.Price;
                objFormDB.Maker = Obj.Maker;
                objFormDB.CategoryId = Obj.CategoryId;
                objFormDB.Quantity = Obj.Quantity;
                if(Obj.ImageUrl != null)
                {
                    objFormDB.ImageUrl = Obj.ImageUrl;
                }
            }
        }
    }
}
