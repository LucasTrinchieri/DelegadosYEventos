using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegadosYEventos
{
    public class CajaAhorro
    {
        public EventHandler<ModificacionSaldo> Caja;

        public delegate decimal modificarSaldo(decimal saldo);

        private string Nombre = "Ibai";
        private decimal SaldoActual = 9000;

        public decimal RetirarSaldo(decimal saldo)
        {
            if (saldo < SaldoActual) SaldoActual -= saldo;

            LanzarEvento(Accion.Retiro);

            return SaldoActual;
        }

        public decimal DepositarSaldo(decimal saldo)
        {
            SaldoActual += saldo;

            LanzarEvento(Accion.Deposito);

            return SaldoActual;
        }

        private void LanzarEvento(Accion accion)
        {
            this.Caja(this, new ModificacionSaldo()
            {
                Nombre = Nombre,
                Saldo = SaldoActual,
                AccionRealizada = accion
            });
        }
    }

    public class ModificacionSaldo : EventArgs
    {
        public string Nombre { get; set; }
        public decimal Saldo { get; set; }
        public Accion AccionRealizada { get; set; }
    }

    public enum Accion
    {
        Deposito,
        Retiro
    }
}
