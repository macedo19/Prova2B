using System;

namespace API.Models
{
    public class FormaPagamento
    {
        public FormaPagamento() => CriadoEm = DateTime.Now;
        public int Id { get; set; }
        public string Bandeira { get; set; }
        public string ChavePix { get; set; }
        public string Descricao { get; set; }
        public DateTime CriadoEm { get; set; }
    }
}