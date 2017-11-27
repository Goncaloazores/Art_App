using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Art.Models
{
    class compra : ContentView
    {

        public int row;
        public int col;


        public int ID { get; set; }
        public string titulo { get; set; }
        public string description { get; set; }
        public DateTime data_criacao { get; set; }
        public double valor { get; set; }
        public string image { get; set; }


        public compra()
        {
            this.ID = 1;
            this.data_criacao =  new DateTime().Date;
            this.valor = 60.80;
            this.image = null;
            this.titulo = "test";
            this.description = "esultura";
        }

        public compra(int id, string titulo, string description, int r, int c, DateTime data_criacao, double valor, string image)
        {

            this.ID = id;
            this.titulo = titulo;
            this.description = description;
            this.data_criacao = data_criacao;
            this.valor = valor;
            this.image = image;
            this.row = r;
            this.col = c;
            this.HeightRequest = 100;
        }

    }
}
