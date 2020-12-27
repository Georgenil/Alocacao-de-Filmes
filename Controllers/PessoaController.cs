using Microsoft.AspNetCore.Mvc;
using MinhaAppVS.Data;
using MinhaAppVS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinhaAppVS.Controllers
{
    public class PessoaController : Controller
    {
        public readonly MeuDbContext _context;

        public PessoaController(MeuDbContext contexto)
        {
            _context = contexto;
        }

        public IActionResult index()
        {
            var pessoa = new Pessoa 
            {
                Nome = "Augusto",
                Email = "Au.lux@lulu.com.br",
                
            };

            _context.Pessoa.Add(pessoa);
            _context.SaveChanges();

            //BUSCA
            var pessoa2 = _context.Pessoa.Find(pessoa.Id);
            var pessoa3 = _context.Pessoa.FirstOrDefault(a => a.Email == "Au.lux@lulu.com.br");
            var pessoa4 = _context.Pessoa.Where(a => a.Nome == "Augusto");

            pessoa.Nome = "Biruleibe";
            _context.Pessoa.Update(pessoa);
            _context.SaveChanges();

            _context.Pessoa.Remove(pessoa2);
            _context.SaveChanges();
            return View();
        }
    }
}
