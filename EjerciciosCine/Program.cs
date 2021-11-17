using System;

namespace EjerciciosCine
{
    class Program
    {
        static void Main(string[] args)
        {
            //Aqui mostramos el nombre del concursante
            Participante participante = new Participante();
            Console.WriteLine("El participante se llama:"+participante.Competidor());
            //Aqui hacemos el ingreso de la categoria del laboratorio por medio de la herencia entre la clase categorias y laboratorio
            Laboratorio laboratorio = new Laboratorio();
            Console.WriteLine("Las modalidades son:"+laboratorio.DatosLab());
            laboratorio.Categoria = "Lógica Básica";
            Console.WriteLine("la modalidad escogida fue:"+laboratorio.Categoria);
            

        }
    }
}
