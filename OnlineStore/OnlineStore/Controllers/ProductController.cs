﻿using Microsoft.AspNetCore.Mvc;
using OnlineStore.Models;
using System.Linq;
using OnlineStore.Models.ViewModels;

namespace OnlineStore.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepository repository;
        public int PageSize = 4;
        public ProductController(IProductRepository repo)
        {
            repository = repo;
        }

        public ViewResult List(string category, int productPage = 1)
        {
            return View(new ProductsListViewModel
            {
                Products = repository.Products
                                              .Where(p => category == null || p.Category == category)
                                              .OrderBy(p => p.ProductID)
                                              .Skip((productPage - 1) * PageSize)
                                              .Take(PageSize),

                PagingInfo = new PagingInfo
                {
                    CurrentPage = productPage,
                    ItemsPerPage = PageSize,
                    //Displaying correct page number for each category
                    TotalItems = category == null ?
                        repository.Products.Count() :
                        repository.Products.Where(e =>
                            e.Category == category).Count()
                },
            CurrentCategory = category
        });
        }
    }
}
