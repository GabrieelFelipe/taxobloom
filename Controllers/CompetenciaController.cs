
using Microsoft.AspNetCore.Mvc;
using WebAppBloom.Models;
using WebAppBloom.ViewModels;
using WebAppBloom.Contexts;
namespace WebAppBloom.Controllers;
public class CompetenciaController:Controller{

   private readonly AppDbContext _context;

   public CompetenciaController(AppDbContext context){   
      _context = context;
   }
      

   //public CompetenciaController()
   //{
   //
   //}   
    
   public IActionResult Index(){

         Competencia competencia = new Competencia();
         competencia.ColunaBloom = "Memorizar";
         competencia.LinhaBloom = "Listar";
         ViewData["titulo"] = "Compreender o funcionamento do Razor";
         ViewData["tablebloom"] = competencia;
         return View();
   }

   public IActionResult RelatorioCompe(){
      
      
      var competencia = new Competencia(){
           ColunaBloom = "Teste Coluna",
           LinhaBloom = "Teste Linha"
      };
      
      var viewModel = new DetalhesCompViewModel(){
            Competencia = competencia,
            TituloPagina = "Página de Teste"
      };
      return View(viewModel);
      

   }
   
   public IActionResult Listar(){
      //pega os dados do banco
      var listaCompe = _context.Competencias.ToList();
      
      //envia o objeto listaCompe (dados do banco)
      //para a ViewModel (ICollection<>   List<>)
      var listaViewModel = new ListaCompetenciaViewModel{           
           Competencias = listaCompe
      };
      return View(listaViewModel);
   }
   
   

}