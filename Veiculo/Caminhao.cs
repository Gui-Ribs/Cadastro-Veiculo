using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoVeiculo
{
    public class Caminhao : Tveiculo
    {
            private string carga;
            private string eixo;
            private string plataforma;


            public string Carga
            {
                get { return carga; }
                set { carga = value; }
            }

            public string Eixo
            {
                get { return eixo; }
                set { eixo = value; }
            }

            public string Plataforma
            {
                get { return plataforma; }
                set { plataforma = value; }
            }

            public Caminhao(string combustivel, string marca, string modelo, string categoria, int ano, string chassi, string carga, string eixo, string plataforma)
            {
                this.Combustivel = combustivel;
                this.Marca = marca;
                this.Modelo = modelo;
                this.Categoria = categoria;
                this.Ano = ano;
                this.Chassi = chassi;
                this.Carga = carga;
                this.Eixo = eixo;
                this.Plataforma = plataforma;
            }

        public override String ImprimeDados()
            {
                String cad = String.Empty;
                cad = String.Concat($"{this.Combustivel}, {this.Marca}, {this.Modelo}, {this.Categoria}, {this.Ano.ToString()}, {this.Chassi}, {this.Carga}, {this.Eixo}, {this.Plataforma}");
                return cad;
            }
    }
}
