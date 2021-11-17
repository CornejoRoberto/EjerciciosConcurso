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
            //Escribimos e imprimimos la modalidad del concurso.
            laboratorio.Categoria = "Lógica Básica";
            Console.WriteLine("la modalidad escogida fue:"+laboratorio.Categoria);
            Computadoras computadoras = new Computadoras();
            //Imprimimos los tipos de software con los que contamos que fueron almacenados en su clase correspondiente.
            Console.WriteLine("Los tipos de software locales son:" + computadoras.Softwareinlcuido());
            //Escribimos e imprimimos el software requerido por el usuario mediante el uso de herencia.
            computadoras.TipoSoftware = "C++";
            Console.WriteLine("El tipo de computadoras a usar es una con software de tipo:" + computadoras.TipoSoftware);
        }
    }
}
