using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioPOO.Models{
    public class Samsumg : Smartphone
    {
        public Samsumg(string numero) : base(numero){

         } 

          public override void InstalarAplicativo(string nomeApp)
        {
            System.Console.WriteLine($"{nomeApp} instalado com sucesso no seu A32.\n");
        }
    }
}