using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DelegadosYEventos;
using System.Timers;


namespace MuestraEventos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Ejercicio1
            /*Persona persona = new Persona();

            Persona.actualizacionNombreCompletado actualizarNombreDelegate = new Persona.actualizacionNombreCompletado(persona.ModificarNombre);

            persona.NombreModificado += NombreModificadoHandler;

            persona.NombreModificado += CalculoLetras;

            actualizarNombreDelegate("Lucas"); 
            */

            #endregion
            #region Ejercicio2
            /*Console.WriteLine(" Retirar: R // Depostiar: D");
            string accion = Console.ReadLine();

            CajaAhorro cajaAhorro = new CajaAhorro();

            CajaAhorro.modificarSaldo modificarSaldo = accion.ToUpper() == "R" ? 
                                        new CajaAhorro.modificarSaldo(cajaAhorro.RetirarSaldo) : 
                                        new CajaAhorro.modificarSaldo(cajaAhorro.DepositarSaldo);

            cajaAhorro.Caja += ModiciarSaldoHandler;

            modificarSaldo(4000);
            
            */
            #endregion
            #region Ejercicio3

            Timer timer = new Timer(1000);

            Console.WriteLine("Presiona una tecla para parar la ejecucion");

            timer.Elapsed += TimerHandler;

            timer.Enabled = true;

            #endregion

            Console.ReadKey();
        }

        public static void NombreModificadoHandler(object sender, NombreModificado a)
        {
            Console.WriteLine($" El nombre fue modificado de {a.NombreViejo} a {a.NombreNuevo}");
        }

        public static void CalculoLetras(object sender, NombreModificado a)
        {
            int diferenciasLetras = Math.Abs(a.NombreViejo.Count() - a.NombreNuevo.Count());

            Console.WriteLine($" La diferencia de letras es de {diferenciasLetras}");
        }

        public static void ModiciarSaldoHandler(object sender, ModificacionSaldo a)
        {
            Console.WriteLine($" Nombre: {a.Nombre}, Saldo: {a.Saldo}, Accion: {a.AccionRealizada}");
        }

        public static void TimerHandler(object o, ElapsedEventArgs a)
        {
            Console.WriteLine(a.SignalTime);
        }
    }
}
