using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoVeiculo
{
    public class Carro : Tveiculo
    {
        private string motor;
        private string transmissao;
        private string carroceria;


        public Carro()
        {
            this.motor = null;
            this.transmissao = null;
            this.carroceria = null;
        }

        public string Motor
        { 
            get { return this.motor; }
            set { this.motor = value; }
        }

        public string Transmissao
        {
            get { return this.transmissao; }
            set { this.transmissao = value; }
        }

        public string Carroceria
        {
            get { return this.carroceria; }
            set { this.carroceria = value; }
        }

        public Carro(string combustivel, string marca, string modelo, string categoria, int ano, string chassi, string motor, string transmissao, string carroceria)
        {
            this.Combustivel = combustivel;
            this.Marca = marca;
            this.Modelo = modelo;
            this.Categoria = categoria;
            this.Ano = ano;
            this.Chassi = chassi;
            this.Motor = motor;
            this.Transmissao = transmissao;
            this.Carroceria = carroceria;
        }

        public override String ImprimeDados()
        {
            String cad = String.Empty;
            cad = String.Concat($"{this.Combustivel}, {this.Marca}, {this.Modelo}, {this.Categoria}, {this.Ano.ToString()}, {this.Chassi}, {this.Motor}, {this.Transmissao}, {this.Carroceria}");
            return cad;
        }
    }
}
