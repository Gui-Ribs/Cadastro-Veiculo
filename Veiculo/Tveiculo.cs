using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoVeiculo
{
    public abstract class Tveiculo
    {
        private string combustivel;
        private string marca;
        private string modelo;
        private string categoria;
        private int ano;
        private string chassi;


        public Tveiculo() 
        {
            this.combustivel = null;
            this.marca = null;
            this.modelo = null;
            this.categoria = null;
            this.ano = 0;
            this.chassi = null;
        }

        public string Combustivel
        { 
            get { return this.combustivel; }
            set { this.combustivel = value; }
        }

        public string Marca
        {
            get { return this.marca; }
            set { this.marca = value; }
        }

        public string Modelo
        {
            get { return this.modelo; }
            set { this.modelo = value; }
        }

        public string Categoria 
        { 
            get { return this.categoria; } 
            set { this.categoria = value; }
        }  

        public int Ano
        {
            get { return this.ano; }
            set { this.ano = value; }
        }

        public string Chassi
        {
            get { return this.chassi; }
            set { this.chassi = value; }
        }

        public abstract String ImprimeDados();
    }
}
