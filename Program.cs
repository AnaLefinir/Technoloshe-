using System;
using System.Collections.Generic;

namespace Technoloshe
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> contestants = new List<string>();
            int idWinner;
            Random r = new Random();

            Console.WriteLine("Aprete <enter> cuando haya terminado de cargar a los concursantes");

            while (true)
            {
                string contestant;
                int flag = 1;
                bool isInt;
                bool isWhiteSpace;
                bool isGoOut;

                Console.Write("Ingrese el nombre completo del concursante: ");
                contestant = Console.ReadLine();

                isGoOut = string.IsNullOrEmpty(contestant);
                isInt = int.TryParse(contestant, out flag);
                isWhiteSpace = string.IsNullOrWhiteSpace(contestant);

                if (isGoOut)
                {
                    break;
                }
                else if (isWhiteSpace | isInt)
                {
                    Console.WriteLine("Nombre Inválido");
                    continue;
                }
                else
                {
                    contestants.Add(contestant);
                }
            }

            if (contestants.Count > 0)
            {
                Console.WriteLine("Los concursantes son: ");

                foreach (string Name in contestants)
                {
                    Console.WriteLine(Name);
                }

                idWinner = r.Next(contestants.Count);
                Console.WriteLine("El ganador o ganadora es: " + contestants[idWinner] + "!");
            }
            else
            {
                Console.WriteLine("Nadie se anoto al concurso");
            }
        }
    }
}
