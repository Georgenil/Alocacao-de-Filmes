using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MinhaAppVS.Data;
using MinhaAppVS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinhaAppVS.Controllers
{
    public class CadastrarUsuarioController : Controller
    {
        private readonly MeuDbContext _context;

        public CadastrarUsuarioController(MeuDbContext context)
        {
            _context = context;
        }

        // GET: Login/Cadastrar
        public async Task<IActionResult> Consultar()
        {
            return View(await _context.CadastrarUsuarios.ToListAsync());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CadastrarUsuario([Bind("Id,Email,Senha")] CadastrarUsuario cadastrarUsuario)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cadastrarUsuario);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Consultar));
            }
            return View(cadastrarUsuario);
        }
    }
}
