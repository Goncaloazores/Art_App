using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Art
{
    public class leilao : ContentView
    {
        public int row;
        public int col;
        //Label lbl;

        public int ID { get; set; }
        public int ID_Obra { get; set; }
        public int ID_Estado { get; set; }
        //public DateTime data_inicio { get; set; }
        public string titulo { get; set; }
        public DateTime data_fim { get; set; }
        public double valor { get; set; }
        public string image { get; set; }
       
        public leilao()
        {

        }
         
        public leilao(leilao leilota)
        {
            this.ID = 1;
            this.ID_Obra = 1;
            this.ID_Estado = 1;
            this.data_fim = DateTime.Now.AddDays(1);
            this.valor = 12.12;
            this.image = null;
            //Label lbl = new Label();
            this.titulo = "test";
        }


        


        public leilao(int id, string titulo, int r, int c, int id_obra, int id_estado, DateTime data_fim, double valor, string image)
        {
            this.ID = id;
            this.ID_Obra = id_obra;
            this.ID_Estado = id_estado;
            this.data_fim = data_fim;
            this.valor = valor;
            this.image = image;
            //Label lbl = new Label();
            this.titulo = titulo;
            this.row = r;
            this.col = c;
            this.HeightRequest = 100;
            
        }
      

        

    }
}
