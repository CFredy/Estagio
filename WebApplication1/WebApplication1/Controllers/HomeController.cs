using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var tarefa = new Tarefa
            {
                TarefaId = "nome"
            };


            return View(tarefa);
        }

        [HttpPost]
        public ActionResult Lista(Tarefa tarefa)
        {


            return View(tarefa);
        }


    }
}