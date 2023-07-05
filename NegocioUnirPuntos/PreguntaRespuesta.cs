using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatosUnirPuntos;

namespace NegocioUnirPuntos
{
    public class PreguntaRespuesta
    {
        private string pregunta;
        private string respuesta;

        public string Pregunta => pregunta; 
        public string Respuesta => respuesta;

        public PreguntaRespuesta(string pregunta, string respuesta)
        {
            this.pregunta = pregunta;
            this.respuesta = respuesta;
        }

        public bool ValidarRespuesta(string respuestaUsuario)
        {
            return string.Equals(respuestaUsuario, respuesta, StringComparison.OrdinalIgnoreCase);
        }
    }
}
