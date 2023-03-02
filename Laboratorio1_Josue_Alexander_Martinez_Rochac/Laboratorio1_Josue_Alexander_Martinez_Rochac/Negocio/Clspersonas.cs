using Laboratorio1_Josue_Alexander_Martinez_Rochac.Entidades;
using Laboratorio1_Josue_Alexander_Martinez_Rochac.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio1_Josue_Alexander_Martinez_Rochac.Negocio
{
    public class Clspersonas
    {
        List<Personas> Per = new List<Personas>();

        public void AgregarPersonas(Personas per)
        {

            Per.Add(per);

        }

        public List<Personas> ListarPersonas()
        {

            return Per;
        }
    }
}
