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
        string Pregunta1 = "PRegunta1";
        string Respuesta1 = "1";
        string Pregunta2 = "Pregunta2";
        string Respuesta2 = "2";
        string Pregunta3 = "Pregunta3";
        string Respuesta3 = "3";
        string Pregunta4 = "Pregunta4";
        string Respuesta4 = "4";
        string Pregunta5 = "Pregunta5";
        string Respuesta5 = "5";
        string Pregunta6 = "Pregunta6";
        string Respuesta6 = "6";
        string Pregunta7 = "Pregunta7";
        string Respuesta7 = "7";
        string Pregunta8 = "Pregunta8";
        string Respuesta8 = "8";

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
        private bool validador8;
        public Juego(string dato)
        {
            InitializeComponent();
            lblUsuario.Text = "Bienvenido "+dato;
            lblRespuesta.Visible = false;
            btnComprobar.Visible = false;
            lblDatos.Visible = false;
            txtRespuesta.Visible = false;
            Vidas = 3;
            
            
            
            
            puntosManager = new PuntosManager();
            Opcion1 = new PreguntaRespuesta(Pregunta1, Respuesta1);
            Opcion2 = new PreguntaRespuesta(Pregunta2, Respuesta2);
            Opcion3 = new PreguntaRespuesta(Pregunta3, Respuesta3);
            Opcion4 = new PreguntaRespuesta(Pregunta4, Respuesta4);
            Opcion5 = new PreguntaRespuesta(Pregunta5, Respuesta5);
            Opcion6 = new PreguntaRespuesta(Pregunta6, Respuesta6);
            Opcion7 = new PreguntaRespuesta(Pregunta7, Respuesta7);
            Opcion8 = new PreguntaRespuesta(Pregunta8, Respuesta8);
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
                        validador = true;
                        validador1 = true;
                        validador2 = true;
                        validador3 = true;
                        validador4 = true;
                        validador5 = true;
                        validador6 = true;
                        validador7 = true;
                        validador8 = true;

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
                mostrarPregunta(Pregunta1);
            }
            if (contarLineas == 2 && validador1)
            {
                mostrarPregunta(Pregunta2);

            }
            if (contarLineas == 3 && validador2)
            {
                mostrarPregunta(Pregunta3);
            }
            if (contarLineas == 4 && validador3)
            {
                mostrarPregunta(Pregunta4);
            }
            if (contarLineas == 5 && validador4)
            {
                mostrarPregunta(Pregunta5);
            }
            if (contarLineas == 6 && validador5)
            {
                mostrarPregunta(Pregunta6);
            }
            if (contarLineas == 7 && validador6)
            {
                mostrarPregunta(Pregunta7);
            }
            if (contarLineas == 8 && validador7)
            {
                mostrarPregunta(Pregunta8);
            }
            else
            {
                MessageBox.Show("Felicidades eres un Pro");
                Inicio fri = new Inicio();
                this.Hide();
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
                Vidas=Vidas-1;
                MessageBox.Show("Respuesta equivocada");
                lblPuntaje.Text=Puntaje.ToString();
                lblVidas.Text=Vidas.ToString();
                if (Vidas==0)
                {
                    MessageBox.Show("Game Over");
                    Inicio inicio = new Inicio();
                    this.Hide();
                   inicio.Show();
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

