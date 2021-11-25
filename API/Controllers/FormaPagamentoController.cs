using System;
using System.Linq;
using API.Data;
using API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/pagamento")]
    public class FormaPagamentoController : ControllerBase
    {
        private readonly DataContext _context;
        public FormaPagamentoController(DataContext context)
        {
            _context = context;
        }

        //POST: api/pagamento/create
        [HttpPost]
        [Route("create")]
        public IActionResult Create()
        {
            _context.FormaPagamentos.AddRange(new FormaPagamento[]
                {
                    new FormaPagamento { Id = 1, Descricao = "Cartão de crédito", Bandeira = "Mastercard", ChavePix = "" },
                    new FormaPagamento { Id = 1, Descricao = "Cartão de débito", Bandeira = "Visa", ChavePix = "" },
                    new FormaPagamento { Id = 1, Descricao = "Pix", Bandeira = "", ChavePix = "456721936258" },
                }
            );
            _context.SaveChanges();
            return Ok(new { message = "Dados inicializados com sucesso!" });
        }

        //GET: api/pagamento/list
        [HttpGet]
        [Route("list")]
        public IActionResult List() => Ok(_context.FormaPagamentos.ToList());
    }
}