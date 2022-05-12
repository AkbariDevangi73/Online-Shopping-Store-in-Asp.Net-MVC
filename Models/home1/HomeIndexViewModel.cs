using OnlineShoppingStore_MVC.DAL;
using OnlineShoppingStore_MVC.Repository;
using PagedList.Mvc;
using PagedList;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace OnlineShoppingStore_MVC.Models.home1
{
    public class HomeIndexViewModel
    {
        public GenericUnitOfWork _unitWork = new GenericUnitOfWork();
        OnlineShoppingStoreMVCEntities context = new OnlineShoppingStoreMVCEntities();
        public IPagedList<Tbl_Product> ListOfProducts { get; set; }
        public HomeIndexViewModel CreateModel(string search,int pagesize,int? page)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@search",search??(object)DBNull.Value)
            };
            IPagedList<Tbl_Product> data = context.Database.SqlQuery<Tbl_Product>("GetBySearch @search", param).ToList().ToPagedList(page ?? 1, pagesize);
            return new HomeIndexViewModel()
            {
                ListOfProducts = data
            };
        }
    }
}