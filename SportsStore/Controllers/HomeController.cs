using Microsoft.AspNetCore.Mvc;
using SportsStore.Models;
using System.Diagnostics;
using SportsStore.Models;

namespace SportsStore.Controllers
{
    public class HomeController : Controller
    {
        private IProductRepository repository;
        public HomeController(IProductRepository repo)
        {
            repository = repo;
        }
        public ViewResult List() => View(repository.Products);
    }
}