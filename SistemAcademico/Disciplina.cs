﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemAcademico
{
    internal class Disciplina
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }

        public Disciplina(int codigo, string nome) 
        { 
            this.Codigo = codigo;
            this.Nome = nome;
        }
    }
}
