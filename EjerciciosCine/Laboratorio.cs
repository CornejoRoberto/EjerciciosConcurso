using System;
using System.Collections.Generic;
using System.Text;

namespace EjerciciosCine
{
    class Laboratorio:Categorias
    {
        public string Lab1 { get; set; }
 


        public string DatosLab()
        {
            return this.Lab1 = "Lógica Básica, Lógica Avanzada, Empresarial, Retos";
        }
}
}
