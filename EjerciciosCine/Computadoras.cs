using System;
using System.Collections.Generic;
using System.Text;

namespace EjerciciosCine
{
    //Se crea la herencia para poder ingresar la categoria especifica del usuario
    class Computadoras:Software
    {
        public string software { get; set; }

        public string Softwareinlcuido()
        {
            return this.software = "Visual Studio, PostgreSQL, SQL Server, Java, C++";
        }
    }
}
