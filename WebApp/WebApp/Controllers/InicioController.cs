using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class InicioController : Controller
    {
        readonly GruposanchoEntities db = new GruposanchoEntities();
        
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public PartialViewResult CrearEmpleado()
        {
            ViewBag.tipodocumento = db.TipoDocumento.ToList();
            ViewBag.genero = db.Genero.ToList();
            return PartialView();
        }

        [HttpPost]
        public JsonResult CrearEmpleado(string nombre, string apellidos, int tipodocumento, string numerodocumento, string correo,
            int genero, int edad)
        {



            ViewBag.tipodocumento = db.TipoDocumento.ToList();
            ViewBag.genero = db.Genero.ToList();
            return Json(0);
        }
    }
}