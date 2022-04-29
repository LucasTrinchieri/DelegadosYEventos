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
            #region Ejercicio1
            /*Persona persona = new Persona();

            Persona.actualizacionNombreCompletado actualizarNombreDelegate = new Persona.actualizacionNombreCompletado(persona.ModificarNombre);

            persona.NombreModificado += Logger.NombreModificadoHandler;

            persona.NombreModificado += Logger.CalculoLetras;

            actualizarNombreDelegate("Lucas");*/
            #endregion
            #region Ejercicio2
            Console.WriteLine(" Retirar: R // Depostiar: D");
            string accion = Console.ReadLine();

            CajaAhorro cajaAhorro = new CajaAhorro();

            CajaAhorro.modificarSaldo modificarSaldo = accion.ToUpper() == "R" ? 
                                        new CajaAhorro.modificarSaldo(cajaAhorro.RetirarSaldo) : 
                                        new CajaAhorro.modificarSaldo(cajaAhorro.DepositarSaldo);

            cajaAhorro.Caja += CajaDelegado.ModiciarSaldoHandler;

            modificarSaldo(4000);
            #endregion

            Console.ReadKey();
        }
    }

    public static class Logger
    {
        public static void NombreModificadoHandler(object sender, NombreModificado args)
        {
            Console.WriteLine($" El nombre fue modificado de {args.NombreViejo} a {args.NombreNuevo}");
        }

        public static void CalculoLetras(object sender, NombreModificado args)
        {
            int diferenciasLetras = Math.Abs(args.NombreViejo.Count() - args.NombreNuevo.Count());

            Console.WriteLine($" La diferencia de letras es de {diferenciasLetras}");
        }
    }

    public static class CajaDelegado
    {
        public static void ModiciarSaldoHandler(object sender, ModificacionSaldo args)
        {
            Console.WriteLine($" Nombre: {args.Nombre}, Saldo: {args.Saldo}, Accion: {args.AccionRealizada}");
        }
    }
}
