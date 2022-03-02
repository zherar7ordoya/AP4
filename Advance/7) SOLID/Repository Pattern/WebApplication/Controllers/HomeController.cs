using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication.Models;
using WebApplication.Repository;

namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            IEmpleadosRepository eRepositorio = new EmpleadosRepository();
            Empleados empleado = new Empleados()
            {
                Legajo = "6587542368",
                Nombre = "Rodolfo",
                Email = "rtordoya@hotmail.com.ar",
                Nacimiento = Convert.ToDateTime("1947-06-26")
            };
            eRepositorio.Agregar(empleado);
            eRepositorio.Guardar();
            //return View(eRepositorio);
            return Content("OK!");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}