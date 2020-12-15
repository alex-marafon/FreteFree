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


        public FileResult GerarPDF()
        {
            using (var doc = new PdfSharpCore.Pdf.PdfDocument()) 
            {
                var page = doc.AddPage();
                page.Size = PdfSharpCore.PageSize.A4;
                page.Orientation = PdfSharpCore.PageOrientation.Portrait;

                var graphics = PdfSharpCore.Drawing.XGraphics.FromPdfPage(page);
                var corFonte = PdfSharpCore.Drawing.XBrushes.Black;

                var textFormatter = new PdfSharpCore.Drawing.Layout.XTextFormatter(graphics);
                var fonteOrganzacao = new PdfSharpCore.Drawing.XFont("Arial", 10);
                var fonteDescricao = new PdfSharpCore.Drawing.XFont("Arial", 8, PdfSharpCore.Drawing.XFontStyle.BoldItalic);
                var titulodetalhes = new PdfSharpCore.Drawing.XFont("Arial", 14, PdfSharpCore.Drawing.XFontStyle.Bold);
                var fonteDetalhesDescricao = new PdfSharpCore.Drawing.XFont("Arial", 7);

                var logo = @"C:\Users\Trut4\source\repos\FreteFree\wwwroot\imagens\Capturar.JPG";

                var artPaginas = doc.PageCount;

                var qtdPaginas = doc.PageCount;
                textFormatter.DrawString(qtdPaginas.ToString(), new PdfSharpCore.Drawing.XFont("Arial", 10), corFonte, new PdfSharpCore.Drawing.XRect(578, 825, page.Width, page.Height));

                XImage imagem = XImage.FromFile(logo);
                graphics.DrawImage(imagem, 20, 5, 300, 50);









                using (MemoryStream stream = new MemoryStream())
                {
                    var contantType = "application/pdf";
                    doc.Save(stream, false);

                    var nomeArquivo = "RelatorioValdir.pdf";

                    return File(stream.ToArray(), contantType, nomeArquivo);
                }
            }
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
