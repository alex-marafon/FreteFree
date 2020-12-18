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
using PdfSharpCore.Drawing;
using System.IO;
using Microsoft.AspNetCore.Http;


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

        // GET: OrdemCarregamento/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ordemCarregamento = await _context.OrdemCarregamento
                .Include(o => o.Empresa)
                .Include(o => o.Motorista)
                .FirstOrDefaultAsync(m => m.OrdemCarregamentoId == id);
            if (ordemCarregamento == null)
            {
                return NotFound();
            }

            return View(ordemCarregamento);
        }




        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
