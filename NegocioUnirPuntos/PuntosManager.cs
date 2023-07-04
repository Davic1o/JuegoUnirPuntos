using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace NegocioUnirPuntos
{
    public class PuntosManager
    {
        private List<Punto> puntos;
        private List<Punto> puntosUnidos;
        private string mensaje;
        private int contadorLineas;

        public List<Punto> Puntos => puntos;
        public List<Punto> PuntosUnidos => puntosUnidos;
        public string Mensaje => mensaje;

        public PuntosManager()
        {
            puntos = new List<Punto>();
            puntosUnidos = new List<Punto>();
            mensaje = string.Empty;
            contadorLineas=0;

            puntos.Add(new Punto(50, 50));
            puntos.Add(new Punto(150, 50));
        }

        public Punto EncontrarPuntoCercano(Punto punto)
        {
            foreach (Punto p in puntos)
            {
                double distancia = Math.Sqrt(Math.Pow(p.X - punto.X, 2) + Math.Pow(p.Y - punto.Y, 2));
                if (distancia <= 5)
                {
                    return p;
                }
            }
            return null;
        }

        public void UnirPuntos(Punto punto1, Punto punto2)
        {
            
                if (!puntosUnidos.Contains(punto1))
                {
                    puntosUnidos.Add(punto1);
                }

                if (!puntosUnidos.Contains(punto2))
                {
                    puntosUnidos.Add(punto2);
                }
            contadorLineas++;

            // Verificar si se han unido todas las líneas
                
                AgregarNuevoPunto();
            
        }
            private void AgregarNuevoPunto()
            {
                // Generar un nuevo punto con coordenadas aleatorias
                Random random = new Random();
                int x = random.Next(0, 400);  // Rango de coordenadas en el eje X (ajusta según tus necesidades)
                int y = random.Next(0, 400);  // Rango de coordenadas en el eje Y (ajusta según tus necesidades)

                // Agregar el nuevo punto a la lista de puntos
                puntos.Add(new Punto(x, y));
            }

        public void Reiniciar()
        {
            puntos.Clear();
            puntosUnidos.Clear();
            contadorLineas = 0;
            mensaje = string.Empty;
            puntos.Add(new Punto(50, 50));
            puntos.Add(new Punto(150, 100));
            puntos.Add(new Punto(200, 200));
            puntos.Add(new Punto(200, 300));
        }
    }
}
