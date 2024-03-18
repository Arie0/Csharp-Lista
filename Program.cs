using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprendendoListas
{

    class Program
    {

        static void Main(string[] args)
        {

            List<string> clientes = new List<string>();
            clientes.Add("Arie");
            clientes.Add("Carla");
            string pessoa = "Amelia";
            clientes.Add(pessoa);

            foreach (string cliente in clientes)
            {
                Console.WriteLine(cliente);
            }

            clientes.RemoveAt(1);

            Console.WriteLine("*************");

            foreach (string cliente in clientes)
            {
                Console.WriteLine(cliente);
            }

            Console.ReadLine();


        }
    }

}