using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DelegadosYEventos;

namespace MuestraEventos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona();

            persona.NombreModificado += NombreModificadoHandler;

            persona.ModificarNombre("Lucas");

            Console.ReadKey();
        }

        static void NombreModificadoHandler(object sender, NombreModificado args)
        {
            Console.WriteLine($" NOmbre Nuevo: {args.NombreNuevo} y el NombreViejo: {args.NombreViejo}");
        }
    }
}
