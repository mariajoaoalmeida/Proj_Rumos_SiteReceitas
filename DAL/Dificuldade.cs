using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Dificuldade
    {
        private int _dificuldadeid;
        private string _dificuldadenome;

        public int DificuldadeId { get => _dificuldadeid; set => _dificuldadeid= value; }
        public string Dificuldadenome { get => _dificuldadenome; set => _dificuldadenome = value; }

        public Dificuldade()
        {
        }
    }
}
