using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Aula1_MVC.Models;

namespace Aula1_MVC.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
        public ActionResult Index()
        {
            var cliente = new Cliente() { Nome = "Teste", Sobrenome = "Salazar", DataCadastro = DateTime.Now, ID = 1 } ;

            return View(cliente);
        }

        public ActionResult Lista()
        {
            var listaClientes = new List<Cliente>()
            {
                new Cliente() { Nome = "Teste2", Sobrenome = "Last Name 2"},
                new Cliente() { Nome = "Teste3", Sobrenome = "Last Name 3"}
            };

            return View(listaClientes);
        }

        public ActionResult Pesquisa(string name)
        {
            var listaClientes = new List<Cliente>()
            {
                new Cliente() { Nome = "Teste2", Sobrenome = "Last Name 2", ID = 1},
                new Cliente() { Nome = "Teste3", Sobrenome = "Last Name 3", ID = 2},
                new Cliente() { Nome = "Teste4", Sobrenome = "Last Name 4", ID = 3},
                new Cliente() { Nome = "Teste5", Sobrenome = "Last Name 5", ID = 4}
            };

            var client = listaClientes.Where(c => c.Nome == name).ToList();

            if (!client.Any())
            {
                RedirectToAction("ErroPesquisa");
            }

            return View("Lista", client);
        }

        public ActionResult ErroPesquisa()
        {
            return View("Error");
        }
    }
}