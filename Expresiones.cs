using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2
{
    internal class Expresiones
    {

        // Caracteristicas o propiedades de la clase 
        public double num1 { get; set; }
        public double num2 { get; set; }  

        // aqui van los metodos de la clase exporesion 

        public double Suma()
        {
            double varSuma = num1 + num2;

            return varSuma; 

        }

        public double Resta()
        {
            double varResta = num1 - num2;

            return varResta;

        }

        public double Multiplicacion()
        {
            double varMultiplicacion = num1 * num2;

            return varMultiplicacion;

        }

        public double Division()
        {
            double varDivision = num1 / num2;

            return varDivision;

        }

        public void NumMayor()
        {
            
            


        }



    }
}
