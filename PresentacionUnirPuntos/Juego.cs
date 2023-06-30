using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NegocioUnirPuntos;
using System.Threading;

namespace PresentacionUnirPuntos
{
    public partial class Juego : Form
    {
        string Pregunta1 = "hola";
        string Pregunta2 = "Chao";
        private PuntosManager puntosManager;
        private bool uniendoPuntos;
        private Punto puntoSeleccionado;
        private PreguntaRespuesta Opcion1;
        private int contarLineas;
        private int respuestasCorrectas;
        private ManualResetEvent botonPresionado = new ManualResetEvent(false);
        private int Puntaje;
        private int Vidas=3;
        public Juego(string dato)
        {
            InitializeComponent();
            lblUsuario.Text = "Bienvenido "+dato;
            lblRespuesta.Visible = false;
            btnComprobar.Visible = false;
            lblDatos.Visible = false;
            txtRespuesta.Visible = false;
            
            
            
            puntosManager = new PuntosManager();
            Opcion1 = new PreguntaRespuesta(Pregunta1, Pregunta2);
            uniendoPuntos = false;
            puntoSeleccionado = null;
            Puntaje = 0;
            Vidas = 3;
            contarLineas = 0;
            respuestasCorrectas = 3;
            lblVidas.Text = Vidas.ToString();

        }



        private void pnlPantalla_Paint(object sender, PaintEventArgs e)
        {

                // Dibuja los puntos
                foreach (Punto punto in puntosManager.Puntos)
                {
                    e.Graphics.FillEllipse(Brushes.Red, punto.X - 5, punto.Y - 5, 10, 10);
                }

                // Dibuja las líneas entre los puntos
                List<Punto> puntosUnidos = puntosManager.PuntosUnidos;
                if (puntosUnidos.Count >= 2)
                {
                    for (int i = 0; i < puntosUnidos.Count - 1; i++)
                    {

                        Punto punto1 = puntosUnidos[i];
                        Punto punto2 = puntosUnidos[i + 1];
                        e.Graphics.DrawLine(Pens.Blue, punto1.X, punto1.Y, punto2.X, punto2.Y);
                       
                        

                    }

                }

                // Dibuja la línea en tiempo real mientras se arrastra el punto seleccionado
                if (uniendoPuntos && puntoSeleccionado != null)
                {

                    Punto puntoActual = new Punto(PointToClient(MousePosition).X, PointToClient(MousePosition).Y);
                    e.Graphics.DrawLine(Pens.Blue, puntoSeleccionado.X, puntoSeleccionado.Y, puntoActual.X, puntoActual.Y);
                    

                }
           
        }


        private void btnNextLevel_Click(object sender, EventArgs e)
        {
            puntosManager.Reiniciar();
            Refresh();
            lblDatos.Text = string.Empty;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Inicio fri = new Inicio();
            fri.Show();
            this.Hide();
        }

        private void Juego_Load(object sender, EventArgs e)
        {
           
        }

        private void pnlPantalla_MouseClick(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Right)
            {
                Refresh();
                lblDatos.Text = string.Empty;
                puntosManager.Reiniciar();
            }
        }


        private void pnlPantalla_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
  
                    Punto puntoClic = new Punto(e.X, e.Y);
                    puntoSeleccionado = puntosManager.EncontrarPuntoCercano(puntoClic);
                    if (puntoSeleccionado != null)
                    {
                        uniendoPuntos = true;
                        Refresh();
                    }
                }
           
        }


private void pnlPantalla_MouseUp(object sender, MouseEventArgs e)
        {
    if (contarLineas < respuestasCorrectas)
    {
        if (e.Button == MouseButtons.Left && uniendoPuntos && puntoSeleccionado != null)
            {
                Punto puntoSoltado = new Punto(e.X, e.Y);
                Punto puntoCercano = puntosManager.EncontrarPuntoCercano(puntoSoltado);
                if (puntoCercano != null && puntoCercano != puntoSeleccionado)
                {
                    puntosManager.UnirPuntos(puntoSeleccionado, puntoCercano);
                }
                uniendoPuntos = false;
                puntoSeleccionado = null;
                Refresh();
                    contarLineas++;
                    lblPuntaje.Text = Puntaje.ToString(); ;
                }
            }
            if (contarLineas == 3)
            {
                mostrarPregunta(Pregunta1);
            }
            if (respuestasCorrectas == 4)
            {
                mostrarPregunta(Pregunta1);

            }
            if (contarLineas == 5)
            {
                mostrarPregunta(Pregunta1);
            }
            if (contarLineas == 6)
            {
                mostrarPregunta(Pregunta1);
            }
            if (contarLineas == 7)
            {
                mostrarPregunta(Pregunta1);
            }
            if (contarLineas == 8)
            {
                MessageBox.Show("Felicidades eres un Pro");
                this.Hide();
                Inicio fri = new Inicio();
                fri.Show();
            }
        }
        private void pnlPantalla_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void btnComprobar_Click(object sender, EventArgs e)
        {
           
            if (Opcion1.ValidarRespuesta(txtRespuesta.Text))
            {
                Puntaje++;
                respuestasCorrectas++;
                txtRespuesta.Text = string.Empty;
                MessageBox.Show("Maravilloso bien contestado");
                pnlPantalla.Visible = true;
                lblRespuesta.Visible = false;
                btnComprobar.Visible = false;
                lblDatos.Visible = false;
                txtRespuesta.Visible = false;
                lblPuntaje.Refresh();

            }
            else
            {
                MessageBox.Show("Respuesta equivocada");
                Puntaje--;
                Vidas--;
                lblPuntaje.Refresh();
                lblVidas.Refresh();
                if (Puntaje == 0||Vidas==0)
                {
                    MessageBox.Show("Game Over");
                    this.Hide();
                }
            }
            
        }
        public void mostrarPregunta(string pregunta)
        {
            MessageBox.Show("Contesta la Pregunta");
            lblDatos.Text = pregunta;
            pnlPantalla.Visible = false;
            lblRespuesta.Visible = true;
            btnComprobar.Visible = true;
            lblDatos.Visible = true;
            txtRespuesta.Visible = true;
            lblPuntaje.Text=Puntaje.ToString();
            lblVidas.Text=Vidas.ToString();

        }
       
       
    }
}

