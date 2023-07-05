using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatosUnirPuntos;

namespace NegocioUnirPuntos
{
    public class ListaPreguntasRespuestas
    {
        PreguntasRespuestas pg = new PreguntasRespuestas();

        public List<(string pregunta, string respuesta)> ObtenerPR()
        {
          return pg.ObtenerPreguntasRespuestas();
        }
  
    }
}
