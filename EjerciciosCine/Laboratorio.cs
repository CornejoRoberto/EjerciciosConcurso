using System;
using System.Collections.Generic;
using System.Text;

namespace EjerciciosCine
{
    //Se crea la herencia con categorias para el ingreso de la modalidad y en caso de querer agregar modalidades poder hacerlas 
    class Laboratorio:Categorias
    {
        public string Lab1 { get; set; }
 


        public string DatosLab()
        {
            return this.Lab1 = "Lógica Básica, Lógica Avanzada, Empresarial, Retos";
        }
}
}
