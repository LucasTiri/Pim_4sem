using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleGastos.DLL
{
    class Gasto
    {
        private int? id;
        private DateTime data;
        private double valor;
        private string descricao;

        public Gasto(DateTime data, double valor,string descricao)
        {
            this.id = null;
            this.Data = data;
            this.Valor = valor;
            this.Descricao = descricao;

        }

        public int? Id { get => id; set => id = value; }
        public DateTime Data { get => data; set => data = value; }
        public double Valor { get => valor; set => valor = value; }
        public string Descricao { get => descricao; set => descricao = value; }
    }
}
