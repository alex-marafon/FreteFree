using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FreteFree.Models;
using FreteFree.Data;
using Microsoft.EntityFrameworkCore;

namespace FreteFree.Controllers
{
    public class HomeController : Controller
    {
     
        private readonly FreteFreeContext _context;

        public HomeController(FreteFreeContext context)
        {
            _context = context;
        }

        //public IActionResult Index()
        //{
        //    return View();
        //}



       //// GET: OrdemCarregamento
        public async Task<IActionResult> Index()
        {
            var freteFreeContext = _context.OrdemCarregamento.Include(o => o.Empresa).Include(o => o.Motorista);
            return View(await freteFreeContext.ToListAsync());
        }




        //pesquisa SQL Like   nao funciona com class agrupadas pois o valor de retorno da colsulta é o ID e nao a string pesquisada
        //public async Task<IActionResult> Index(string searchString)
        //{
        //    var pesquisa = _context.OrdemCarregamento;


        //    if (!String.IsNullOrEmpty(searchString))
        //    {
        //        pesquisa = pesquisa.Where(s => s.Empresa.NomeEmpresa(searchString));
        //    }

        //    return View(await pesquisa.ToListAsync());
        //}



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
