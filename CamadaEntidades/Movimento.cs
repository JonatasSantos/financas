using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaEntidades
{
    public class Movimento
    {

        public Movimento(){ }
        public Movimento(int tipo, string titulo, DateTime data, decimal valor, string observacoes) {
            this.tipo = tipo;
            this.titulo = titulo;
            this.data = data;
            this.valor = valor;
            this.observacoes = observacoes;
        }

        private int id { get; set; }

        private int tipo { get; set; }

        private string titulo { get; set; }

        private DateTime data { get; set; }

        private decimal valor { get; set; }

        private string observacoes { get; set; }
    }
}
