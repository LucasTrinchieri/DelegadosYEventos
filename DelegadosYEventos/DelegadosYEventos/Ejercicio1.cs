using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegadosYEventos
{
    public class Persona
    {
        public EventHandler<NombreModificado> NombreModificado;

        public delegate void actualizacionNombreCompletado(string nombre);

        private string Nombre { get; set; }

        public string ModificarNombre(string nombre)
        {
            string NombreViejo = Nombre;

            Nombre = nombre;

            this.NombreModificado(this, new NombreModificado()
            {
                NombreNuevo = nombre,
                NombreViejo = NombreViejo
            });

            return Nombre;
        }
    }

    public class NombreModificado : EventArgs
    {
        public string NombreNuevo { get; set; }
        public string NombreViejo { get; set; }
    }
}
