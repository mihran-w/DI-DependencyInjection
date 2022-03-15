using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DI.Models;
using DI.Repositories;

namespace DI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private ITransientRepository _transientRepository;
        private IScopeRepository _scopeRepository;
        private ISingletonRepository _singletonRepository;


        public HomeController(ILogger<HomeController> logger , IScopeRepository scopeRepository , ITransientRepository transientRepository,ISingletonRepository singletonRepository)
        {
            _logger = logger;
            _transientRepository = transientRepository;
            _scopeRepository = scopeRepository;
            _singletonRepository = singletonRepository;
        }


        public IActionResult Index()
        {
            ViewData["Transient"] = _transientRepository.GetNumber();
            ViewData["Scope"] = _scopeRepository.GetNumber();
            ViewData["Singleton"] = _singletonRepository.GetNumber();
            return View();
        }

        public IActionResult Description()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
