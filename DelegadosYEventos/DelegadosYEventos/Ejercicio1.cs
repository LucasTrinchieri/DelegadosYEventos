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

        public delegate string actualizacionNombreCompletado(string nombre);

        private string Nombre = "NombreViejo";

        public string ModificarNombre(string nombre)
        {
            string NombreViejo = Nombre;

            Nombre = nombre;

            this.NombreModificado(this, new NombreModificado()
            {
                NombreViejo = NombreViejo,
                NombreNuevo = nombre
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
