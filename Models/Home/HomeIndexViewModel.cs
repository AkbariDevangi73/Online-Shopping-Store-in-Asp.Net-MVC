using OnlineShoppingStore_MVC.DAL;
using OnlineShoppingStore_MVC.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineShoppingStore_MVC.Models.Home
{
    public class HomeIndexViewModel
    {
        public GenericUnitOfWork _unitWork = new GenericUnitOfWork();
        public List<Tbl_Product> ListOfProducts { get; set; }
        public static HomeIndexViewModel CreateModel()
        {
            return new HomeIndexViewModel()
            {
                ListOfProducts= _unitWork.GetRepositoryInstance<Tbl_Category>().GetAllRecord();
            }
        }
    }
}