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
        private ListaPreguntasRespuestas lpr = new ListaPreguntasRespuestas();

        private PuntosManager puntosManager;
        private bool uniendoPuntos;
        private Punto puntoSeleccionado;
        private PreguntaRespuesta Opcion1;
        private PreguntaRespuesta Opcion2;
        private PreguntaRespuesta Opcion3;
        private PreguntaRespuesta Opcion4;
        private PreguntaRespuesta Opcion5;
        private PreguntaRespuesta Opcion6;
        private PreguntaRespuesta Opcion7;
        private PreguntaRespuesta Opcion8;
        private List<(string pregunta, string respuesta)> preguntasRespuestas;
        private int contarLineas;
        private int respuestasCorrectas;
        private ManualResetEvent botonPresionado = new ManualResetEvent(false);
        private int Puntaje;
        private int Vidas;
        private bool validador;
        private bool validador1;
        private bool validador2;
        private bool validador3;
        private bool validador4;
        private bool validador5;
        private bool validador6;
        private bool validador7;
        public Juego(string dato)
        {
            InitializeComponent();
            lblUsuario.Text = "Bienvenido "+dato;
            lblRespuesta.Visible = false;

            lblDatos.Visible = false;
            txtRespuesta.Visible = false;
            Vidas = 3;
            lblPuntaje.Text = "0";
            btnComprobar1.Visible = false;
            btnComprobar2.Visible = false;
            btnComprobar3.Visible = false;
            btnComprobar4.Visible = false;
            btnComprobar5.Visible = false;
            btnComprobar6.Visible = false;
            btnComprobar7.Visible = false;
            btnComprobar8.Visible = false;
            puntosManager = new PuntosManager();
            preguntasRespuestas = lpr.ObtenerPR();
            Opcion1 = new PreguntaRespuesta(preguntasRespuestas[0].pregunta, preguntasRespuestas[0].respuesta);
            Opcion2 = new PreguntaRespuesta(preguntasRespuestas[1].pregunta, preguntasRespuestas[1].respuesta);
            Opcion3 = new PreguntaRespuesta(preguntasRespuestas[2].pregunta, preguntasRespuestas[2].respuesta);
            Opcion4 = new PreguntaRespuesta(preguntasRespuestas[3].pregunta, preguntasRespuestas[3].respuesta);
            Opcion5 = new PreguntaRespuesta(preguntasRespuestas[4].pregunta, preguntasRespuestas[4].respuesta);
            Opcion6 = new PreguntaRespuesta(preguntasRespuestas[5].pregunta, preguntasRespuestas[5].respuesta);
            Opcion7 = new PreguntaRespuesta(preguntasRespuestas[6].pregunta, preguntasRespuestas[6].respuesta);
            Opcion8 = new PreguntaRespuesta(preguntasRespuestas[7].pregunta, preguntasRespuestas[7].respuesta);
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
                        validador = true;
                        validador1 = true;
                        validador2 = true;
                        validador3 = true;
                        validador4 = true;
                        validador5 = true;
                        validador6 = true;
                        validador7 = true;
                      

                    }
                    else
                    {
                        if (contarLineas ==0)
                        {
                        MessageBox.Show("Te equivocaste uniendo la primera Linea");
                            contarLineas --;
                            validador = false;

                        }
                        if (contarLineas == 1)
                        {
                            MessageBox.Show("Te equivocaste uniendo la segunda linea");
                            contarLineas --;
                            validador = false;
                            validador1 = false;
                        }
                        if (contarLineas == 2)
                        {
                            MessageBox.Show("Te equivocaste uniendo la tercera linea");
                            contarLineas--;
                            validador = false;
                            validador1 = false;
                            validador2 = false;
                        }
                        if (contarLineas == 3)
                        {
                            MessageBox.Show("Te equivocaste uniendo la cuarta linea");
                            contarLineas--;
                            validador = false;
                            validador1 = false;
                            validador2 = false;
                            validador3 = false;
                        }
                        if (contarLineas == 4)
                        {
                            MessageBox.Show("Te equivocaste uniendo la quinta linea");
                            contarLineas--;
                            validador = false;
                            validador1 = false;
                            validador2 = false;
                            validador3 = false;
                            validador4 = false;
                        }
                        if (contarLineas == 5)
                        {
                            MessageBox.Show("Te equivocaste uniendo la sexta linea");
                            contarLineas--;
                            validador = false;
                            validador1 = false;
                            validador2 = false;
                            validador3 = false;
                            validador4 = false;
                            validador5 = false;
                        }
                        if (contarLineas == 6)
                        {
                            MessageBox.Show("Te equivocaste uniendo la septima linea");
                            contarLineas--;
                            validador = false;
                            validador1 = false;
                            validador2 = false;
                            validador3 = false;
                            validador4 = false;
                            validador6 = false;
                        }
                        if (contarLineas == 7)
                        {
                            MessageBox.Show("Te equivocaste uniendo la octava linea");
                            contarLineas--;
                            validador = false;
                            validador1 = false;
                            validador2 = false;
                            validador3 = false;
                            validador4 = false;
                            validador6 = false;
                            validador7 = false;
                        }
                    }
                uniendoPuntos = false;
                puntoSeleccionado = null;
                Refresh();
                    contarLineas++;
                    lblPuntaje.Text = Puntaje.ToString(); ;
                }
            }
            if (contarLineas == 1 && validador)
            {
                mostrarPregunta(preguntasRespuestas[0].pregunta);
                btnComprobar1.Visible = true;
            }
            if (contarLineas == 2 && validador1)
            {
                mostrarPregunta(preguntasRespuestas[1].pregunta);
                btnComprobar2.Visible = true;
            }
            if (contarLineas == 3 && validador2)
            {
                mostrarPregunta(preguntasRespuestas[2].pregunta);
                btnComprobar3.Visible = true;
            }
            if (contarLineas == 4 && validador3)
            {
                mostrarPregunta(preguntasRespuestas[3].pregunta);
                btnComprobar4.Visible = true;
            }
            if (contarLineas == 5 && validador4)
            {
                mostrarPregunta(preguntasRespuestas[4].pregunta);
                btnComprobar5.Visible = true;
            }
            if (contarLineas == 6 && validador5)
            {
                mostrarPregunta(preguntasRespuestas[5].pregunta);
                btnComprobar6.Visible = true;
            }
            if (contarLineas == 7 && validador6)
            {
                mostrarPregunta(preguntasRespuestas[6].pregunta);
                btnComprobar7.Visible = true;
            }
            if (contarLineas == 8 && validador7)
            {
                mostrarPregunta(preguntasRespuestas[7].pregunta);
                btnComprobar8.Visible = true;
            }

        }
        private void pnlPantalla_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void btnComprobar1_Click(object sender, EventArgs e)
        {
            if (Opcion1.ValidarRespuesta(txtRespuesta.Text))
                {
                Puntaje=Puntaje+2;
                respuestasCorrectas++;
                txtRespuesta.Text = string.Empty;
                MessageBox.Show("CORRECTO!!!");
                pnlPantalla.Visible = true;
                lblRespuesta.Visible = false;
                btnComprobar1.Visible = false;
                lblDatos.Visible = false;
                txtRespuesta.Visible = false;
                lblPuntaje.Text = Puntaje.ToString();

            }
          
            else
            {
                Vidas = Vidas - 1;
                MessageBox.Show("Respuesta equivocada");
                lblVidas.Text = Vidas.ToString();
                if (Vidas == 0)
                {
                    MessageBox.Show("Game OverTu puntaje es:" + Puntaje.ToString());
                    Inicio inicio = new Inicio();
                    this.Hide();
                    inicio.Show();
                }
            }
        }
        public void mostrarPregunta(string pregunta)
        {
            MessageBox.Show("Contesta la Pregunta");
            //btnComprobar1.Visible = true;
            lblDatos.Text = pregunta;
            pnlPantalla.Visible = false;
            lblRespuesta.Visible = true;

            lblDatos.Visible = true;
            txtRespuesta.Visible = true;
            lblPuntaje.Text=Puntaje.ToString();
            lblVidas.Text=Vidas.ToString();

        }

        private void btnComprobar8_Click(object sender, EventArgs e)
        {
            if (Opcion8.ValidarRespuesta(txtRespuesta.Text))
            {

                Puntaje=Puntaje+2;
                respuestasCorrectas++;
                txtRespuesta.Text = string.Empty;
                MessageBox.Show("CORRECTO!!!");
                lblPuntaje.Text = Puntaje.ToString();
                MessageBox.Show("Felicidades tu puntaje es:" + Puntaje);
                Inicio fri = new Inicio();
                this.Hide();
                fri.Show();
            }

            else
            {
                Vidas = Vidas - 1;
                MessageBox.Show("Respuesta equivocada");
                lblVidas.Text = Vidas.ToString();
                if (Vidas == 0)
                {
                    MessageBox.Show("Game Over Tu puntaje es:" + Puntaje.ToString());
                    Inicio inicio = new Inicio();
                    this.Hide();
                    inicio.Show();
                }
            }

        }

        private void btnComprobar4_Click(object sender, EventArgs e)
        {
            if (Opcion4.ValidarRespuesta(txtRespuesta.Text))
            {

                Puntaje=Puntaje+2;
                respuestasCorrectas++;
                txtRespuesta.Text = string.Empty;
                MessageBox.Show("CORRECTO!!!");
                pnlPantalla.Visible = true;
                lblRespuesta.Visible = false;
                btnComprobar4.Visible = false;
                lblDatos.Visible = false;
                txtRespuesta.Visible = false;
                btnComprobar4.Visible = false;
                lblPuntaje.Text = Puntaje.ToString();
            }

            else
            {
                Vidas = Vidas - 1;
                MessageBox.Show("Respuesta equivocada");
                lblVidas.Text = Vidas.ToString();
                if (Vidas == 0)
                {
                    MessageBox.Show("Game Over Tu puntaje es:" + Puntaje.ToString());
                    Inicio inicio = new Inicio();
                    this.Hide();
                    inicio.Show();
                }
            }

        }

        private void btnComprobar6_Click(object sender, EventArgs e)
        {
            if (Opcion6.ValidarRespuesta(txtRespuesta.Text))
            {

                Puntaje=Puntaje+2;
                respuestasCorrectas++;
                txtRespuesta.Text = string.Empty;
                MessageBox.Show("Maravilloso bien contestado");
                pnlPantalla.Visible = true;
                lblRespuesta.Visible = false;
                btnComprobar6.Visible = false;
                lblDatos.Visible = false;
                txtRespuesta.Visible = false;
                btnComprobar6.Visible = false;
                lblPuntaje.Text = Puntaje.ToString();
            }

            else
            {
                Vidas = Vidas - 1;
                MessageBox.Show("Respuesta equivocada");
                lblVidas.Text = Vidas.ToString();
                if (Vidas == 0)
                {
                    MessageBox.Show("Game OveR Tu puntaje es:" + Puntaje.ToString());
                    Inicio inicio = new Inicio();
                    this.Hide();
                    inicio.Show();
                }
            }
        }

        private void btnComprobar5_Click(object sender, EventArgs e)
        {
            if (Opcion5.ValidarRespuesta(txtRespuesta.Text))
            {

                Puntaje=Puntaje+2;
                respuestasCorrectas++;
                txtRespuesta.Text = string.Empty;
                MessageBox.Show("CORRECTO!!!");
                pnlPantalla.Visible = true;
                lblRespuesta.Visible = false;
                btnComprobar5.Visible = false;
                lblDatos.Visible = false;
                txtRespuesta.Visible = false;
                btnComprobar5.Visible = false;
                lblPuntaje.Text = Puntaje.ToString();
            }

            else
            {
                Vidas = Vidas - 1;
                MessageBox.Show("Respuesta equivocada");
                lblVidas.Text = Vidas.ToString();
                if (Vidas == 0)
                {
                    MessageBox.Show("Game Over Tu puntaje es:" + Puntaje.ToString());
                    Inicio inicio = new Inicio();
                    this.Hide();
                    inicio.Show();
                }
            }

        }

        private void btnComprobar3_Click(object sender, EventArgs e)
        {
            if (Opcion3.ValidarRespuesta(txtRespuesta.Text))
            {

                Puntaje=Puntaje+2;
                respuestasCorrectas++;
                txtRespuesta.Text = string.Empty;
                MessageBox.Show("CORRECTO!!!");
                pnlPantalla.Visible = true;
                lblRespuesta.Visible = false;
                btnComprobar3.Visible = false;
                lblDatos.Visible = false;
                txtRespuesta.Visible = false;
                btnComprobar3.Visible = false;
                lblPuntaje.Text = Puntaje.ToString();
            }

            else
            {
                Vidas = Vidas - 1;
                MessageBox.Show("Respuesta equivocada");
                lblVidas.Text = Vidas.ToString();
                if (Vidas == 0)
                {
                    MessageBox.Show("Game Over Tu puntaje es:" + Puntaje.ToString());
                    Inicio inicio = new Inicio();
                    this.Hide();
                    inicio.Show();
                }
            }
        }

        private void btnComprobar7_Click(object sender, EventArgs e)
        {
            if (Opcion7.ValidarRespuesta(txtRespuesta.Text))
            {

                Puntaje=Puntaje+2;
                respuestasCorrectas++;
                txtRespuesta.Text = string.Empty;
                MessageBox.Show("CORRECTO!!!");
                pnlPantalla.Visible = true;
                lblRespuesta.Visible = false;
                btnComprobar7.Visible = false;
                lblDatos.Visible = false;
                txtRespuesta.Visible = false;
                btnComprobar7.Visible = false;
                lblPuntaje.Text = Puntaje.ToString();
            }

            else
            {
                Vidas = Vidas - 1;
                MessageBox.Show("Respuesta equivocada");
                lblVidas.Text = Vidas.ToString();
                if (Vidas == 0)
                {
                    MessageBox.Show("Game Over Tu puntaje es:" + Puntaje.ToString());
                    Inicio inicio = new Inicio();
                    this.Hide();
                    inicio.Show();
                }
            }

        }

        private void btnComprobar2_Click(object sender, EventArgs e)
        {
            if (Opcion2.ValidarRespuesta(txtRespuesta.Text))
            {

                Puntaje=Puntaje+2;
                respuestasCorrectas++;
                txtRespuesta.Text = string.Empty;
                MessageBox.Show("CORRECTO!!!");
                pnlPantalla.Visible = true;
                lblRespuesta.Visible = false;
                btnComprobar2.Visible = false;
                lblDatos.Visible = false;
                txtRespuesta.Visible = false;
                btnComprobar2.Visible = false;
                lblPuntaje.Text = Puntaje.ToString();
            }

            else
            {
                Vidas = Vidas - 1;
                MessageBox.Show("Respuesta equivocada");
                lblVidas.Text = Vidas.ToString();
                if (Vidas == 0)
                {
                    MessageBox.Show("Game Over Tu puntaje es:"+Puntaje.ToString());
                    Inicio inicio = new Inicio();
                    this.Hide();
                    inicio.Show();
                }
            }
        }

        private void txtRespuesta_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

