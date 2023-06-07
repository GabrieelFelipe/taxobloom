using Microsoft.AspNetCore.Mvc;

namespace WebAppnbloom.Controllers;





public class CompetenciaController:Controller{



public IActionResult Index(){

    ViewData["competencia"] = "Entender o funcionamento do Razor";
    return View();

}


}