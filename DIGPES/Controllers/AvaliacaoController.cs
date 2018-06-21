using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DIGPES.Context;
using DIGPES.Models;

namespace DIGPES.Controllers
{
    public class AvaliacaoController : Controller
    {
        private ModelContext db = new ModelContext();

        public ActionResult Index()
        {
            return View(db.Avaliacao.ToList().OrderBy(filed => filed.Data));
        }

        public ActionResult Filter()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Filter(FormCollection formFilter)
        {
            string osAux = formFilter.GetValue("OrdemServico").AttemptedValue;
            string produto = formFilter.GetValue("Produto").AttemptedValue;
            string nome = formFilter.GetValue("Nome").AttemptedValue;
            var dataAux = formFilter.GetValue("Data").AttemptedValue;


            if (osAux == null || produto == null || nome == null || dataAux == null)
            {
                return View("Parâmetros de entrada incorretos.");
            }

            int os = Convert.ToInt32(osAux);
            dataAux= Convert.ToDateTime(dataAux).ToShortDateString();
            DateTime data = Convert.ToDateTime(dataAux);

            Avaliacao avaliacao = new Avaliacao();

            avaliacao.OrdemServico = os;
            avaliacao.Produto = produto;
            avaliacao.Nome = nome;
            avaliacao.Data = data;

            return RedirectToAction("Create", avaliacao);
        }

        public ActionResult Create(Avaliacao avaliacao)
        {


            ViewBag.OrdemServico = avaliacao.OrdemServico;
            ViewBag.Produto = avaliacao.Produto;
            ViewBag.Nome = avaliacao.Nome;
            ViewBag.Data = avaliacao.Data;

            return View(db.Avaliacao.ToList().OrderBy(filed => filed.Data));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Answer([Bind(Include = "AvaliacaoID,OrdemServico,Produto,Nome,Data,QuestaoA,QuestaoB,QuestaoC,QuestaoD,MotivoQuestaoD,QuestaoE")] Avaliacao avaliacao)
        {
            if (ModelState.IsValid)
            {
                db.Avaliacao.Add(avaliacao);
                db.SaveChanges();
                return RedirectToAction("Filter");
            }

            return RedirectToAction("Create");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
