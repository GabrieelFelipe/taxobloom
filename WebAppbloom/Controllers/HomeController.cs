using Microsoft.AspNetCore.Mvc;

public class HomeControlle:Controller

    {
        public IActionResult Index()
        {
            return View();
        }

    }   