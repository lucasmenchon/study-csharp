using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExDIO
{
    public class Pessoa
    {
        public int Idade { get; set; }

        public string Nome { get; set; }

        public string Documento { get; set; } 

        public Pessoa Clone()
        {
            return new Pessoa()
            {
                Nome = this.Nome,
                Documento = this.Documento,
                Idade = this.Idade,
            };
        }

    }
}
