using System;
using System.Collections.Generic;

namespace Technoloshe
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> concursantes = new List<string>();
            int flag = 1;
            string concursante;
            int ganador;
            Random r = new Random();

            Console.WriteLine("Ingrese -1 cuando haya terminado de cargar a los concursantes");

            while (flag != -1)
            {
                Console.WriteLine("Ingrese el nombre completo del concursante");
                concursante = Console.ReadLine();

                if (int.TryParse(concursante, out flag) != true)
                {
                    concursantes.Add(concursante);
                }

            }

            Console.WriteLine("Los concursantes son: ");
            
            for(int i = 0; i < concursantes.Count; i++){
                Console.WriteLine(concursantes[i]);
            }

            if (concursantes.Count > 0)
            {
                ganador = r.Next(concursantes.Count);
                Console.WriteLine("El ganador o ganadora es " + concursantes[ganador]);
            }
            else
            {
                Console.WriteLine("Nadie se anoto al concurso");
            }
        }
    }
}
