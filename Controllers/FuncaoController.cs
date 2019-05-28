using AULADAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AULADAL.Controllers
{
    public class FuncaoController : Controller
    {
        EMPRESAEntities ctx = new EMPRESAEntities();

        // GET: Funcao
        public ActionResult Index()
        {            
            return View(ctx.FUNCAO.ToList());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(FUNCAO funcao)
        {
            if(ModelState.IsValid)
                {
                    ctx.FUNCAO.Add(funcao);
                    ctx.SaveChanges();
                    return RedirectToAction("Index");
                }
            return View(funcao);
        }
    }
}