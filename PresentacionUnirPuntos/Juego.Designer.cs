
namespace PresentacionUnirPuntos
{
    partial class Juego
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Juego));
            this.pnlPantalla = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPuntaje = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnComprobar = new System.Windows.Forms.Button();
            this.lblRespuesta = new System.Windows.Forms.Label();
            this.txtRespuesta = new System.Windows.Forms.TextBox();
            this.lblDatos = new System.Windows.Forms.Label();
            this.lblVida = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnNextLevel = new System.Windows.Forms.Button();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblVidas = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPantalla
            // 
            this.pnlPantalla.BackgroundImage = global::PresentacionUnirPuntos.Properties.Resources.fondo_acuarela_pintada_mano_forma_cielo_nubes;
            this.pnlPantalla.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlPantalla.Location = new System.Drawing.Point(12, 198);
            this.pnlPantalla.Name = "pnlPantalla";
            this.pnlPantalla.Size = new System.Drawing.Size(1077, 570);
            this.pnlPantalla.TabIndex = 0;
            this.pnlPantalla.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlPantalla_Paint);
            this.pnlPantalla.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlPantalla_MouseClick);
            this.pnlPantalla.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlPantalla_MouseDown);
            this.pnlPantalla.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlPantalla_MouseMove);
            this.pnlPantalla.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlPantalla_MouseUp);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lblUsuario);
            this.panel1.Controls.Add(this.lblPuntaje);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1307, 189);
            this.panel1.TabIndex = 1;
            // 
            // lblPuntaje
            // 
            this.lblPuntaje.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPuntaje.AutoSize = true;
            this.lblPuntaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntaje.Location = new System.Drawing.Point(1130, 121);
            this.lblPuntaje.Name = "lblPuntaje";
            this.lblPuntaje.Size = new System.Drawing.Size(144, 51);
            this.lblPuntaje.TabIndex = 2;
            this.lblPuntaje.Text = "label3";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1120, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 51);
            this.label2.TabIndex = 1;
            this.label2.Text = "Puntaje";
            // 
            // btnComprobar
            // 
            this.btnComprobar.BackColor = System.Drawing.Color.Transparent;
            this.btnComprobar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnComprobar.ForeColor = System.Drawing.Color.Transparent;
            this.btnComprobar.Image = global::PresentacionUnirPuntos.Properties.Resources.confirmar__1_;
            this.btnComprobar.Location = new System.Drawing.Point(457, 468);
            this.btnComprobar.Name = "btnComprobar";
            this.btnComprobar.Size = new System.Drawing.Size(121, 111);
            this.btnComprobar.TabIndex = 5;
            this.btnComprobar.UseVisualStyleBackColor = false;
            this.btnComprobar.Click += new System.EventHandler(this.btnComprobar_Click);
            // 
            // lblRespuesta
            // 
            this.lblRespuesta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRespuesta.AutoSize = true;
            this.lblRespuesta.BackColor = System.Drawing.Color.Transparent;
            this.lblRespuesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRespuesta.Location = new System.Drawing.Point(40, 383);
            this.lblRespuesta.Name = "lblRespuesta";
            this.lblRespuesta.Size = new System.Drawing.Size(238, 51);
            this.lblRespuesta.TabIndex = 4;
            this.lblRespuesta.Text = "Respuesta";
            // 
            // txtRespuesta
            // 
            this.txtRespuesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRespuesta.Location = new System.Drawing.Point(318, 383);
            this.txtRespuesta.Name = "txtRespuesta";
            this.txtRespuesta.Size = new System.Drawing.Size(587, 55);
            this.txtRespuesta.TabIndex = 3;
            // 
            // lblDatos
            // 
            this.lblDatos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDatos.AutoSize = true;
            this.lblDatos.BackColor = System.Drawing.Color.Transparent;
            this.lblDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatos.Location = new System.Drawing.Point(415, 258);
            this.lblDatos.Name = "lblDatos";
            this.lblDatos.Size = new System.Drawing.Size(144, 51);
            this.lblDatos.TabIndex = 0;
            this.lblDatos.Text = "label1";
            // 
            // lblVida
            // 
            this.lblVida.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblVida.AutoSize = true;
            this.lblVida.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVida.Location = new System.Drawing.Point(23, 194);
            this.lblVida.Name = "lblVida";
            this.lblVida.Size = new System.Drawing.Size(136, 51);
            this.lblVida.TabIndex = 3;
            this.lblVida.Text = "Vidas";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.lblVidas);
            this.panel2.Controls.Add(this.lblVida);
            this.panel2.Controls.Add(this.btnCerrar);
            this.panel2.Controls.Add(this.btnNextLevel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1107, 189);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 579);
            this.panel2.TabIndex = 2;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCerrar.ForeColor = System.Drawing.Color.Transparent;
            this.btnCerrar.Image = global::PresentacionUnirPuntos.Properties.Resources.cerrar_sesion__1_;
            this.btnCerrar.Location = new System.Drawing.Point(97, 461);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(88, 90);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnNextLevel
            // 
            this.btnNextLevel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNextLevel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextLevel.Image = global::PresentacionUnirPuntos.Properties.Resources.flecha__1_;
            this.btnNextLevel.Location = new System.Drawing.Point(0, 6);
            this.btnNextLevel.Name = "btnNextLevel";
            this.btnNextLevel.Size = new System.Drawing.Size(185, 144);
            this.btnNextLevel.TabIndex = 0;
            this.btnNextLevel.UseVisualStyleBackColor = true;
            this.btnNextLevel.Click += new System.EventHandler(this.btnNextLevel_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(140, 58);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(194, 69);
            this.lblUsuario.TabIndex = 6;
            this.lblUsuario.Text = "label1";
            // 
            // lblVidas
            // 
            this.lblVidas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblVidas.AutoSize = true;
            this.lblVidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVidas.Location = new System.Drawing.Point(28, 264);
            this.lblVidas.Name = "lblVidas";
            this.lblVidas.Size = new System.Drawing.Size(144, 51);
            this.lblVidas.TabIndex = 4;
            this.lblVidas.Text = "label1";
            // 
            // Juego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PresentacionUnirPuntos.Properties.Resources.FondoVideojuego1;
            this.ClientSize = new System.Drawing.Size(1307, 768);
            this.Controls.Add(this.btnComprobar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtRespuesta);
            this.Controls.Add(this.lblRespuesta);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlPantalla);
            this.Controls.Add(this.lblDatos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Juego";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Juego_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlPantalla;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblPuntaje;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDatos;
        private System.Windows.Forms.Button btnNextLevel;
        private System.Windows.Forms.Label lblVida;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnComprobar;
        private System.Windows.Forms.Label lblRespuesta;
        private System.Windows.Forms.TextBox txtRespuesta;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblVidas;
    }
}