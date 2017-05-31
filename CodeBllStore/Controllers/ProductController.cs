using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CodeBllStore.Data.Repository;
using CodeBllStore.Models.ViewModels;

namespace CodeBllStore.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepository repository;

        public ProductController(IProductRepository repo)
        {
            repository = repo;
        }

        public IActionResult Index(int page = 1)
        {
            int PageSize = 10;
            var model = new ProductsListViewModel
            {
                Products = repository.Products
                .Skip((page - 1) * PageSize)
                .Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = PageSize,
                    TotalItems = repository.Products.Count()
                }

            };


            return View(model);
        }
    }
}