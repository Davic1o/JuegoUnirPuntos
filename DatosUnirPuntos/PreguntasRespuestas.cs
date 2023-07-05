using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosUnirPuntos
{
    public class PreguntasRespuestas
    {
        public List<(string pregunta, string respuesta)> ObtenerPreguntasRespuestas()
        {
            List<(string pregunta, string respuesta)> preguntasRespuestas = new List<(string, string)>();

            // Agregar preguntas y respuestas predeterminadas
            preguntasRespuestas.Add(("Operador que asigna memoria para una instancia creada", "new"));
            preguntasRespuestas.Add(("Metodo que se lanza al interactuar con el sistema", "evento"));
            preguntasRespuestas.Add(("Control que el usuario no pude editar", "label"));
            preguntasRespuestas.Add(("Valor que retorna el control CheckBox", "boolean"));
            preguntasRespuestas.Add(("Que cuadro de dialogo se utiliza para interactuar el usuario", "messagebox"));
            preguntasRespuestas.Add(("Control que tiene coleccion de objetos", "listbox"));
            preguntasRespuestas.Add(("Control que el usuario no pude editar", "label"));
            preguntasRespuestas.Add(("Metodologia que involucra al cliente en el proceso de desarrollo", "agil"));

            // Puedes agregar más preguntas y respuestas aquí

            return preguntasRespuestas;
        }
    }
        
    }
