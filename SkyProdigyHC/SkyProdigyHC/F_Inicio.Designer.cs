namespace SkyProdigyHC
{
    partial class F_Inicio
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Inicio));
            this.Btn_Izquierda = new System.Windows.Forms.Button();
            this.Btn_Derecha = new System.Windows.Forms.Button();
            this.Btn_Abajo = new System.Windows.Forms.Button();
            this.Btn_Arriba = new System.Windows.Forms.Button();
            this.Btn_Alinear = new System.Windows.Forms.Button();
            this.Btn_iCap = new System.Windows.Forms.Button();
            this.Gb_Puerto_Serie = new System.Windows.Forms.GroupBox();
            this.Btn_Conectar = new System.Windows.Forms.Button();
            this.Cbo_Puertos = new System.Windows.Forms.ComboBox();
            this.Btn_DeterminarConexion = new System.Windows.Forms.Button();
            this.Btn_Intro = new System.Windows.Forms.Button();
            this.Btn_Atras = new System.Windows.Forms.Button();
            this.Gb_iCap = new System.Windows.Forms.GroupBox();
            this.Gb_Botones_Mando = new System.Windows.Forms.GroupBox();
            this.Btn_InfoObjeto = new System.Windows.Forms.Button();
            this.Btn_Celestron = new System.Windows.Forms.Button();
            this.Btn_VelocidadMotor = new System.Windows.Forms.Button();
            this.Btn_Ayuda = new System.Windows.Forms.Button();
            this.Btn_Menu = new System.Windows.Forms.Button();
            this.Btn_DesplazarAbajo = new System.Windows.Forms.Button();
            this.Btn_TourCielo = new System.Windows.Forms.Button();
            this.Btn_Identificar = new System.Windows.Forms.Button();
            this.Btn_DesplazarArriba = new System.Windows.Forms.Button();
            this.Btn_Estrellas = new System.Windows.Forms.Button();
            this.Btn_SistemaSolar = new System.Windows.Forms.Button();
            this.Btn_CieloProfundo = new System.Windows.Forms.Button();
            this.Tmr_Timer = new System.Windows.Forms.Timer(this.components);
            this.Sp_Puertos = new System.IO.Ports.SerialPort(this.components);
            this.Gb_Puerto_Serie.SuspendLayout();
            this.Gb_iCap.SuspendLayout();
            this.Gb_Botones_Mando.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_Izquierda
            // 
            this.Btn_Izquierda.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Izquierda.Image")));
            this.Btn_Izquierda.Location = new System.Drawing.Point(306, 127);
            this.Btn_Izquierda.Name = "Btn_Izquierda";
            this.Btn_Izquierda.Size = new System.Drawing.Size(118, 46);
            this.Btn_Izquierda.TabIndex = 13;
            this.Btn_Izquierda.UseVisualStyleBackColor = true;
            this.Btn_Izquierda.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Btn_Izquierda_MouseDown);
            this.Btn_Izquierda.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Btn_Izquierda_MouseUp);
            // 
            // Btn_Derecha
            // 
            this.Btn_Derecha.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Derecha.Image")));
            this.Btn_Derecha.Location = new System.Drawing.Point(58, 127);
            this.Btn_Derecha.Name = "Btn_Derecha";
            this.Btn_Derecha.Size = new System.Drawing.Size(118, 46);
            this.Btn_Derecha.TabIndex = 12;
            this.Btn_Derecha.UseVisualStyleBackColor = true;
            this.Btn_Derecha.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Btn_Derecha_MouseDown);
            this.Btn_Derecha.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Btn_Derecha_MouseUp);
            // 
            // Btn_Abajo
            // 
            this.Btn_Abajo.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Abajo.Image")));
            this.Btn_Abajo.Location = new System.Drawing.Point(182, 150);
            this.Btn_Abajo.Name = "Btn_Abajo";
            this.Btn_Abajo.Size = new System.Drawing.Size(118, 44);
            this.Btn_Abajo.TabIndex = 11;
            this.Btn_Abajo.UseVisualStyleBackColor = true;
            this.Btn_Abajo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Btn_Abajo_MouseDown);
            this.Btn_Abajo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Btn_Abajo_MouseUp);
            // 
            // Btn_Arriba
            // 
            this.Btn_Arriba.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Arriba.Image")));
            this.Btn_Arriba.Location = new System.Drawing.Point(182, 94);
            this.Btn_Arriba.Name = "Btn_Arriba";
            this.Btn_Arriba.Size = new System.Drawing.Size(118, 46);
            this.Btn_Arriba.TabIndex = 10;
            this.Btn_Arriba.UseVisualStyleBackColor = true;
            this.Btn_Arriba.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Btn_Arriba_MouseDown);
            this.Btn_Arriba.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Btn_Arriba_MouseUp);
            // 
            // Btn_Alinear
            // 
            this.Btn_Alinear.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Alinear.Location = new System.Drawing.Point(10, 16);
            this.Btn_Alinear.Name = "Btn_Alinear";
            this.Btn_Alinear.Size = new System.Drawing.Size(150, 70);
            this.Btn_Alinear.TabIndex = 9;
            this.Btn_Alinear.Text = "ALINEAR";
            this.Btn_Alinear.UseVisualStyleBackColor = true;
            this.Btn_Alinear.Click += new System.EventHandler(this.Btn_Alinear_Click);
            // 
            // Btn_iCap
            // 
            this.Btn_iCap.Image = ((System.Drawing.Image)(resources.GetObject("Btn_iCap.Image")));
            this.Btn_iCap.Location = new System.Drawing.Point(29, 19);
            this.Btn_iCap.Name = "Btn_iCap";
            this.Btn_iCap.Size = new System.Drawing.Size(110, 90);
            this.Btn_iCap.TabIndex = 14;
            this.Btn_iCap.UseVisualStyleBackColor = true;
            this.Btn_iCap.Click += new System.EventHandler(this.Btn_iCap_Click);
            // 
            // Gb_Puerto_Serie
            // 
            this.Gb_Puerto_Serie.Controls.Add(this.Btn_Conectar);
            this.Gb_Puerto_Serie.Controls.Add(this.Cbo_Puertos);
            this.Gb_Puerto_Serie.Controls.Add(this.Btn_DeterminarConexion);
            this.Gb_Puerto_Serie.Location = new System.Drawing.Point(196, 12);
            this.Gb_Puerto_Serie.Name = "Gb_Puerto_Serie";
            this.Gb_Puerto_Serie.Size = new System.Drawing.Size(303, 122);
            this.Gb_Puerto_Serie.TabIndex = 16;
            this.Gb_Puerto_Serie.TabStop = false;
            this.Gb_Puerto_Serie.Text = "Puerto Serie";
            // 
            // Btn_Conectar
            // 
            this.Btn_Conectar.Location = new System.Drawing.Point(15, 74);
            this.Btn_Conectar.Name = "Btn_Conectar";
            this.Btn_Conectar.Size = new System.Drawing.Size(272, 38);
            this.Btn_Conectar.TabIndex = 11;
            this.Btn_Conectar.Text = "Conectar";
            this.Btn_Conectar.UseVisualStyleBackColor = true;
            this.Btn_Conectar.Click += new System.EventHandler(this.Btn_Conectar_Click);
            // 
            // Cbo_Puertos
            // 
            this.Cbo_Puertos.FormattingEnabled = true;
            this.Cbo_Puertos.Location = new System.Drawing.Point(150, 32);
            this.Cbo_Puertos.Name = "Cbo_Puertos";
            this.Cbo_Puertos.Size = new System.Drawing.Size(137, 21);
            this.Cbo_Puertos.TabIndex = 10;
            // 
            // Btn_DeterminarConexion
            // 
            this.Btn_DeterminarConexion.Location = new System.Drawing.Point(15, 19);
            this.Btn_DeterminarConexion.Name = "Btn_DeterminarConexion";
            this.Btn_DeterminarConexion.Size = new System.Drawing.Size(122, 45);
            this.Btn_DeterminarConexion.TabIndex = 7;
            this.Btn_DeterminarConexion.Text = "Actualizar Puertos Disponibles";
            this.Btn_DeterminarConexion.UseVisualStyleBackColor = true;
            this.Btn_DeterminarConexion.Click += new System.EventHandler(this.Btn_DeterminarConexion_Click);
            // 
            // Btn_Intro
            // 
            this.Btn_Intro.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Intro.Location = new System.Drawing.Point(168, 16);
            this.Btn_Intro.Name = "Btn_Intro";
            this.Btn_Intro.Size = new System.Drawing.Size(150, 70);
            this.Btn_Intro.TabIndex = 17;
            this.Btn_Intro.Text = "INTRO";
            this.Btn_Intro.UseVisualStyleBackColor = true;
            this.Btn_Intro.Click += new System.EventHandler(this.Btn_Intro_Click);
            // 
            // Btn_Atras
            // 
            this.Btn_Atras.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Atras.Location = new System.Drawing.Point(327, 16);
            this.Btn_Atras.Name = "Btn_Atras";
            this.Btn_Atras.Size = new System.Drawing.Size(150, 70);
            this.Btn_Atras.TabIndex = 18;
            this.Btn_Atras.Text = "ATRÁS";
            this.Btn_Atras.UseVisualStyleBackColor = true;
            this.Btn_Atras.Click += new System.EventHandler(this.Btn_Atras_Click);
            // 
            // Gb_iCap
            // 
            this.Gb_iCap.Controls.Add(this.Btn_iCap);
            this.Gb_iCap.Location = new System.Drawing.Point(13, 12);
            this.Gb_iCap.Name = "Gb_iCap";
            this.Gb_iCap.Size = new System.Drawing.Size(170, 122);
            this.Gb_iCap.TabIndex = 19;
            this.Gb_iCap.TabStop = false;
            this.Gb_iCap.Text = "iCap";
            // 
            // Gb_Botones_Mando
            // 
            this.Gb_Botones_Mando.Controls.Add(this.Btn_InfoObjeto);
            this.Gb_Botones_Mando.Controls.Add(this.Btn_Celestron);
            this.Gb_Botones_Mando.Controls.Add(this.Btn_VelocidadMotor);
            this.Gb_Botones_Mando.Controls.Add(this.Btn_Ayuda);
            this.Gb_Botones_Mando.Controls.Add(this.Btn_Menu);
            this.Gb_Botones_Mando.Controls.Add(this.Btn_DesplazarAbajo);
            this.Gb_Botones_Mando.Controls.Add(this.Btn_TourCielo);
            this.Gb_Botones_Mando.Controls.Add(this.Btn_Identificar);
            this.Gb_Botones_Mando.Controls.Add(this.Btn_DesplazarArriba);
            this.Gb_Botones_Mando.Controls.Add(this.Btn_Estrellas);
            this.Gb_Botones_Mando.Controls.Add(this.Btn_SistemaSolar);
            this.Gb_Botones_Mando.Controls.Add(this.Btn_CieloProfundo);
            this.Gb_Botones_Mando.Controls.Add(this.Btn_Intro);
            this.Gb_Botones_Mando.Controls.Add(this.Btn_Alinear);
            this.Gb_Botones_Mando.Controls.Add(this.Btn_Atras);
            this.Gb_Botones_Mando.Controls.Add(this.Btn_Izquierda);
            this.Gb_Botones_Mando.Controls.Add(this.Btn_Arriba);
            this.Gb_Botones_Mando.Controls.Add(this.Btn_Derecha);
            this.Gb_Botones_Mando.Controls.Add(this.Btn_Abajo);
            this.Gb_Botones_Mando.Location = new System.Drawing.Point(13, 140);
            this.Gb_Botones_Mando.Name = "Gb_Botones_Mando";
            this.Gb_Botones_Mando.Size = new System.Drawing.Size(486, 541);
            this.Gb_Botones_Mando.TabIndex = 20;
            this.Gb_Botones_Mando.TabStop = false;
            this.Gb_Botones_Mando.Text = "Mando";
            // 
            // Btn_InfoObjeto
            // 
            this.Btn_InfoObjeto.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_InfoObjeto.Location = new System.Drawing.Point(165, 460);
            this.Btn_InfoObjeto.Name = "Btn_InfoObjeto";
            this.Btn_InfoObjeto.Size = new System.Drawing.Size(150, 70);
            this.Btn_InfoObjeto.TabIndex = 29;
            this.Btn_InfoObjeto.Text = "INFORMACIÓN DEL OBJETO";
            this.Btn_InfoObjeto.UseVisualStyleBackColor = true;
            this.Btn_InfoObjeto.Click += new System.EventHandler(this.Btn_InfoObjeto_Click);
            // 
            // Btn_Celestron
            // 
            this.Btn_Celestron.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Celestron.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn_Celestron.Location = new System.Drawing.Point(7, 460);
            this.Btn_Celestron.Name = "Btn_Celestron";
            this.Btn_Celestron.Size = new System.Drawing.Size(150, 70);
            this.Btn_Celestron.TabIndex = 28;
            this.Btn_Celestron.Text = "CELESTRON";
            this.Btn_Celestron.UseVisualStyleBackColor = true;
            this.Btn_Celestron.Click += new System.EventHandler(this.Btn_Celestron_Click);
            // 
            // Btn_VelocidadMotor
            // 
            this.Btn_VelocidadMotor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_VelocidadMotor.Location = new System.Drawing.Point(324, 460);
            this.Btn_VelocidadMotor.Name = "Btn_VelocidadMotor";
            this.Btn_VelocidadMotor.Size = new System.Drawing.Size(150, 70);
            this.Btn_VelocidadMotor.TabIndex = 30;
            this.Btn_VelocidadMotor.Text = "VELOCIDAD DEL MOTOR";
            this.Btn_VelocidadMotor.UseVisualStyleBackColor = true;
            this.Btn_VelocidadMotor.Click += new System.EventHandler(this.Btn_VelocidadMotor_Click);
            // 
            // Btn_Ayuda
            // 
            this.Btn_Ayuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Ayuda.Location = new System.Drawing.Point(165, 374);
            this.Btn_Ayuda.Name = "Btn_Ayuda";
            this.Btn_Ayuda.Size = new System.Drawing.Size(150, 70);
            this.Btn_Ayuda.TabIndex = 26;
            this.Btn_Ayuda.Text = "AYUDA";
            this.Btn_Ayuda.UseVisualStyleBackColor = true;
            this.Btn_Ayuda.Click += new System.EventHandler(this.Btn_Ayuda_Click);
            // 
            // Btn_Menu
            // 
            this.Btn_Menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Menu.Location = new System.Drawing.Point(7, 374);
            this.Btn_Menu.Name = "Btn_Menu";
            this.Btn_Menu.Size = new System.Drawing.Size(150, 70);
            this.Btn_Menu.TabIndex = 25;
            this.Btn_Menu.Text = "MENÚ";
            this.Btn_Menu.UseVisualStyleBackColor = true;
            this.Btn_Menu.Click += new System.EventHandler(this.Btn_Menu_Click);
            // 
            // Btn_DesplazarAbajo
            // 
            this.Btn_DesplazarAbajo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_DesplazarAbajo.Image = ((System.Drawing.Image)(resources.GetObject("Btn_DesplazarAbajo.Image")));
            this.Btn_DesplazarAbajo.Location = new System.Drawing.Point(324, 374);
            this.Btn_DesplazarAbajo.Name = "Btn_DesplazarAbajo";
            this.Btn_DesplazarAbajo.Size = new System.Drawing.Size(150, 70);
            this.Btn_DesplazarAbajo.TabIndex = 27;
            this.Btn_DesplazarAbajo.UseVisualStyleBackColor = true;
            this.Btn_DesplazarAbajo.Click += new System.EventHandler(this.Btn_DesplazarAbajo_Click);
            // 
            // Btn_TourCielo
            // 
            this.Btn_TourCielo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_TourCielo.Location = new System.Drawing.Point(165, 289);
            this.Btn_TourCielo.Name = "Btn_TourCielo";
            this.Btn_TourCielo.Size = new System.Drawing.Size(150, 70);
            this.Btn_TourCielo.TabIndex = 23;
            this.Btn_TourCielo.Text = "TOUR POR EL CIELO";
            this.Btn_TourCielo.UseVisualStyleBackColor = true;
            this.Btn_TourCielo.Click += new System.EventHandler(this.Btn_TourCielo_Click);
            // 
            // Btn_Identificar
            // 
            this.Btn_Identificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Identificar.Location = new System.Drawing.Point(7, 289);
            this.Btn_Identificar.Name = "Btn_Identificar";
            this.Btn_Identificar.Size = new System.Drawing.Size(150, 70);
            this.Btn_Identificar.TabIndex = 22;
            this.Btn_Identificar.Text = "IDENTIFICAR";
            this.Btn_Identificar.UseVisualStyleBackColor = true;
            this.Btn_Identificar.Click += new System.EventHandler(this.Btn_Identificar_Click);
            // 
            // Btn_DesplazarArriba
            // 
            this.Btn_DesplazarArriba.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_DesplazarArriba.Image = ((System.Drawing.Image)(resources.GetObject("Btn_DesplazarArriba.Image")));
            this.Btn_DesplazarArriba.Location = new System.Drawing.Point(324, 289);
            this.Btn_DesplazarArriba.Name = "Btn_DesplazarArriba";
            this.Btn_DesplazarArriba.Size = new System.Drawing.Size(150, 70);
            this.Btn_DesplazarArriba.TabIndex = 24;
            this.Btn_DesplazarArriba.UseVisualStyleBackColor = true;
            this.Btn_DesplazarArriba.Click += new System.EventHandler(this.Btn_DesplazarArriba_Click);
            // 
            // Btn_Estrellas
            // 
            this.Btn_Estrellas.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Estrellas.Location = new System.Drawing.Point(165, 204);
            this.Btn_Estrellas.Name = "Btn_Estrellas";
            this.Btn_Estrellas.Size = new System.Drawing.Size(150, 70);
            this.Btn_Estrellas.TabIndex = 20;
            this.Btn_Estrellas.Text = "ESTRELLAS";
            this.Btn_Estrellas.UseVisualStyleBackColor = true;
            this.Btn_Estrellas.Click += new System.EventHandler(this.Btn_Estrellas_Click);
            // 
            // Btn_SistemaSolar
            // 
            this.Btn_SistemaSolar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_SistemaSolar.Location = new System.Drawing.Point(7, 204);
            this.Btn_SistemaSolar.Name = "Btn_SistemaSolar";
            this.Btn_SistemaSolar.Size = new System.Drawing.Size(150, 70);
            this.Btn_SistemaSolar.TabIndex = 19;
            this.Btn_SistemaSolar.Text = "SISTEMA SOLAR";
            this.Btn_SistemaSolar.UseVisualStyleBackColor = true;
            this.Btn_SistemaSolar.Click += new System.EventHandler(this.Btn_SistemaSolar_Click);
            // 
            // Btn_CieloProfundo
            // 
            this.Btn_CieloProfundo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_CieloProfundo.Location = new System.Drawing.Point(324, 204);
            this.Btn_CieloProfundo.Name = "Btn_CieloProfundo";
            this.Btn_CieloProfundo.Size = new System.Drawing.Size(150, 70);
            this.Btn_CieloProfundo.TabIndex = 21;
            this.Btn_CieloProfundo.Text = "CIELO";
            this.Btn_CieloProfundo.UseVisualStyleBackColor = true;
            this.Btn_CieloProfundo.Click += new System.EventHandler(this.Btn_CieloProfundo_Click);
            // 
            // Tmr_Timer
            // 
            this.Tmr_Timer.Interval = 60;
            //this.Tmr_Timer.Tick += new System.EventHandler(this.Tmr_Timer_Tick);
            // 
            // F_Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(511, 689);
            this.Controls.Add(this.Gb_Botones_Mando);
            this.Controls.Add(this.Gb_iCap);
            this.Controls.Add(this.Gb_Puerto_Serie);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "F_Inicio";
            this.Text = "StarSense PC Controller";
            this.Load += new System.EventHandler(this.F_Inicio_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.F_Inicio_FormClosing);
            this.Gb_Puerto_Serie.ResumeLayout(false);
            this.Gb_iCap.ResumeLayout(false);
            this.Gb_Botones_Mando.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Izquierda;
        private System.Windows.Forms.Button Btn_Derecha;
        private System.Windows.Forms.Button Btn_Abajo;
        private System.Windows.Forms.Button Btn_Arriba;
        private System.Windows.Forms.Button Btn_Alinear;
        private System.Windows.Forms.Button Btn_iCap;
        private System.Windows.Forms.GroupBox Gb_Puerto_Serie;
        private System.Windows.Forms.Button Btn_Intro;
        private System.Windows.Forms.Button Btn_Atras;
        private System.Windows.Forms.Button Btn_DeterminarConexion;
        private System.Windows.Forms.ComboBox Cbo_Puertos;
        private System.Windows.Forms.GroupBox Gb_iCap;
        private System.Windows.Forms.GroupBox Gb_Botones_Mando;
        private System.Windows.Forms.Button Btn_Conectar;
        private System.Windows.Forms.Timer Tmr_Timer;
        private System.IO.Ports.SerialPort Sp_Puertos;
        private System.Windows.Forms.Button Btn_Ayuda;
        private System.Windows.Forms.Button Btn_Menu;
        private System.Windows.Forms.Button Btn_DesplazarAbajo;
        private System.Windows.Forms.Button Btn_TourCielo;
        private System.Windows.Forms.Button Btn_Identificar;
        private System.Windows.Forms.Button Btn_DesplazarArriba;
        private System.Windows.Forms.Button Btn_Estrellas;
        private System.Windows.Forms.Button Btn_SistemaSolar;
        private System.Windows.Forms.Button Btn_CieloProfundo;
        private System.Windows.Forms.Button Btn_InfoObjeto;
        private System.Windows.Forms.Button Btn_Celestron;
        private System.Windows.Forms.Button Btn_VelocidadMotor;
    }
}

