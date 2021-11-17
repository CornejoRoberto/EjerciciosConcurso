using System;
using System.Collections.Generic;
using System.Text;

namespace EjerciciosCine
{
    //Se crea datos para obtener y guardar los datos del participante, 
    //se crea con el fin de si en algun futuro se desean agregar datos no interferir con el codigo.
    class Participante
    {
     public string Nombre { get; set; }
        public string Competidor()
        {
            return this.Nombre= "Juan";
        }

    }
}
