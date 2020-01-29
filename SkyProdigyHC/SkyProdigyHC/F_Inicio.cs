using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace SkyProdigyHC
{
    public partial class F_Inicio : Form
    {
        int Proceso_ID;
        string Abrir_iCap = "Cerrado";

        string BufferOut;
        string BufferIn;
        public string Activar_Botones;

        public F_Inicio()
        {
            InitializeComponent();
        }

        private void F_Inicio_Load(object sender, EventArgs e)
        {
            Fnc_Desactivar_Botones();

            BufferOut = "";
            BufferIn = "";
            Btn_Conectar.Enabled = false;
            //Tmr_Timer.Enabled = false;
        }

        private void Btn_iCap_Click(object sender, EventArgs e) // Abrir o cerrar proceso iCap
        {
            if (Abrir_iCap == "Cerrado")
            {
                try
                {
                    OpenFileDialog openFileDialog1 = new OpenFileDialog();
                    openFileDialog1.InitialDirectory = "C:\\Program Files\\Celestron";
                    openFileDialog1.Filter = "iCap file|iCap.exe|All files (*.*)|*.*";
                    MessageBox.Show("Selecciona el directorio donde has instalado el programa.", "Abrir iCap");

                    if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        Process Proceso_iCap_Abrir = Process.Start(openFileDialog1.FileName);
                        Proceso_ID = Proceso_iCap_Abrir.Id;
                        Abrir_iCap = "Abierto";
                    }
                }
                catch
                {
                    MessageBox.Show("No se puede abrir el capturador de imagenes iCap_V2. Asegurate de seleccionado bien la ruta.");
                }
            }
            else if (Abrir_iCap == "Abierto")
            {
                try
                {
                    Process Proceso_iCap_Cerrar = Process.GetProcessById(Proceso_ID);
                    Proceso_iCap_Cerrar.CloseMainWindow();
                    Proceso_iCap_Cerrar.WaitForExit();
                    Abrir_iCap = "Cerrado";
                }
                catch
                {
                    MessageBox.Show("No se puede cerrar el capturador de imagenes iCap_V2.");
                }
            }
        }

        private void F_Inicio_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult Salir_App = MessageBox.Show("¿Desea salir de la aplicación?", "Advertencia", MessageBoxButtons.YesNo);
            if (Salir_App == DialogResult.Yes)
            {
                if (Abrir_iCap == "Abierto")
                {
                    try
                    {
                        Process Proceso_iCap_Cerrar = Process.GetProcessById(Proceso_ID);
                        Proceso_iCap_Cerrar.CloseMainWindow();
                        Proceso_iCap_Cerrar.WaitForExit();
                        Abrir_iCap = "Cerrado";
                    }
                    catch
                    {
                        MessageBox.Show("No se puede cerrar el capturador de imagenes iCap_V2.");
                    }
                }
            }
            else if (Salir_App == DialogResult.No)
            {
                e.Cancel = true;
            } 
        }

        private void Btn_DeterminarConexion_Click(object sender, EventArgs e)
        {
            Cbo_Puertos.Items.Clear();

            foreach (string PuertoDisponible in System.IO.Ports.SerialPort.GetPortNames())
            {
                Cbo_Puertos.Items.Add(PuertoDisponible);
            }

            if (Cbo_Puertos.Items.Count > 0)
            {
                MessageBox.Show("Seleccione el puerto a trabajar", "Información");
                Btn_Conectar.Enabled = true;
                Cbo_Puertos.DroppedDown = true;
            }
            else
            {
                MessageBox.Show("Ningún puerto encontrado", "Información");
                Btn_Conectar.Enabled = false;
                Cbo_Puertos.Items.Clear();
                Cbo_Puertos.Text = "";
            }
        }

        private void Btn_Conectar_Click(object sender, EventArgs e)
        {
            if (Btn_Conectar.Text == "Conectar")
            {
                try
                {
                    Sp_Puertos.PortName = Cbo_Puertos.Text;
                    Sp_Puertos.Open();
                    //Tmr_Timer.Enabled = true;
                    Btn_Conectar.Text = "Desconectar";
                    Btn_DeterminarConexion.Enabled = false;
                    Fnc_Activar_Botones();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (Btn_Conectar.Text == "Desconectar")
            {
                try 
                {
                    Btn_Conectar.Text = "Conectar";
                    //Tmr_Timer.Enabled = false;
                    Sp_Puertos.Close();
                    Btn_DeterminarConexion.Enabled = true;
                    Fnc_Desactivar_Botones();
                    Btn_DeterminarConexion_Click(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Btn_DeterminarConexion_Click(sender, e);
                    Btn_DeterminarConexion.Enabled = true;
                    Fnc_Desactivar_Botones();
                }
            }
        }

        private void Fnc_Activar_Botones()
        {
            Btn_Alinear.Enabled = true;
            Btn_Intro.Enabled = true;
            Btn_Atras.Enabled = true;
            Btn_Arriba.Enabled = true;
            Btn_Derecha.Enabled = true;
            Btn_Abajo.Enabled = true;
            Btn_Izquierda.Enabled = true;
            Btn_SistemaSolar.Enabled = true;
            Btn_Estrellas.Enabled = true;
            Btn_CieloProfundo.Enabled = true;
            Btn_Identificar.Enabled = true;
            Btn_TourCielo.Enabled = true;
            Btn_DesplazarArriba.Enabled = true;
            Btn_Menu.Enabled = true;
            Btn_Ayuda.Enabled = true;
            Btn_DesplazarAbajo.Enabled = true;
            Btn_Celestron.Enabled = true;
            Btn_InfoObjeto.Enabled = true;
            Btn_VelocidadMotor.Enabled = true;

        }

        private void Fnc_Desactivar_Botones()
        {
            Btn_Alinear.Enabled = false;
            Btn_Intro.Enabled = false;
            Btn_Atras.Enabled = false;
            Btn_Arriba.Enabled = false;
            Btn_Derecha.Enabled = false;
            Btn_Abajo.Enabled = false;
            Btn_Izquierda.Enabled = false;
            Btn_SistemaSolar.Enabled = false;
            Btn_Estrellas.Enabled = false;
            Btn_CieloProfundo.Enabled = false;
            Btn_Identificar.Enabled = false;
            Btn_TourCielo.Enabled = false;
            Btn_DesplazarArriba.Enabled = false;
            Btn_Menu.Enabled = false;
            Btn_Ayuda.Enabled = false;
            Btn_DesplazarAbajo.Enabled = false;
            Btn_Celestron.Enabled = false;
            Btn_InfoObjeto.Enabled = false;
            Btn_VelocidadMotor.Enabled = false;
        }

        private void Fnc_Activar_Botones2()
        {
            Btn_Intro.Enabled = true;
            Btn_Atras.Enabled = true;
            Btn_Arriba.Enabled = true;
            Btn_Derecha.Enabled = true;
            Btn_Abajo.Enabled = true;
            Btn_Izquierda.Enabled = true;
            Btn_CieloProfundo.Enabled = true;
            Btn_SistemaSolar.Enabled = true;
            Btn_Estrellas.Enabled = true;
            Btn_Identificar.Enabled = true;
            Btn_TourCielo.Enabled = true;
            Btn_DesplazarArriba.Enabled = true;
            Btn_Menu.Enabled = true;
            Btn_Ayuda.Enabled = true;
            Btn_DesplazarAbajo.Enabled = true;
            Btn_InfoObjeto.Enabled = true;
            Btn_VelocidadMotor.Enabled = true;
        }

        private void Fnc_Desactivar_Botones2()
        {
            Btn_Intro.Enabled = false;
            Btn_Atras.Enabled = false;
            Btn_Arriba.Enabled = false;
            Btn_Derecha.Enabled = false;
            Btn_Abajo.Enabled = false;
            Btn_Izquierda.Enabled = false;
            Btn_SistemaSolar.Enabled = false;
            Btn_Estrellas.Enabled = false;
            Btn_CieloProfundo.Enabled = false;
            Btn_Identificar.Enabled = false;
            Btn_TourCielo.Enabled = false;
            Btn_DesplazarArriba.Enabled = false;
            Btn_Menu.Enabled = false;
            Btn_Ayuda.Enabled = false;
            Btn_DesplazarAbajo.Enabled = false;
            Btn_InfoObjeto.Enabled = false;
            Btn_VelocidadMotor.Enabled = false;
        }



        /*private void Tmr_Timer_Tick(object sender, EventArgs e)
        {
            try
            {
                BufferIn = Sp_Puertos.ReadExisting();
                if (BufferIn != "")
                {
                    //Txt_BufferIn.Text = BufferIn;
                    BufferIn = "";
                    Sp_Puertos.DiscardInBuffer();
                }
            }
            catch { }
        }*/

        private void Btn_Alinear_Click(object sender, EventArgs e)
        {
            try
            {
                Sp_Puertos.DiscardOutBuffer();
                BufferOut = "A";
                Sp_Puertos.Write(BufferOut);
                if (Btn_Celestron.BackColor == Color.Green)
                {
                    Sp_Puertos.DiscardOutBuffer();
                    BufferOut = "X";
                    Sp_Puertos.Write(BufferOut);
                    Btn_Celestron.BackColor = Btn_Alinear.BackColor;
                    Fnc_Activar_Botones2();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message+" Pulse 'Desconectar' y vuelva a probar.");
            }
        }

        private void Btn_Intro_Click(object sender, EventArgs e)
        {
            try
            {
                Sp_Puertos.DiscardOutBuffer();
                BufferOut = "B";
                Sp_Puertos.Write(BufferOut);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message+" Pulse 'Desconectar' y vuelva a probar.");
            }
        }

        private void Btn_Atras_Click(object sender, EventArgs e)
        {   
            try
            {
                Sp_Puertos.DiscardOutBuffer();
                BufferOut = "C";
                Sp_Puertos.Write(BufferOut);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message+" Pulse 'Desconectar' y vuelva a probar.");
            }
        }

        private void Btn_Arriba_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                Sp_Puertos.DiscardOutBuffer();
                BufferOut = "D";
                Sp_Puertos.Write(BufferOut);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message+" Pulse 'Desconectar' y vuelva a probar.");
            }
        }

        private void Btn_Arriba_MouseUp(object sender, MouseEventArgs e)
        {
            Sp_Puertos.DiscardOutBuffer();
            BufferOut = "E";
            Sp_Puertos.Write(BufferOut);
        }

        private void Btn_Izquierda_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                Sp_Puertos.DiscardOutBuffer();
                BufferOut = "F";
                Sp_Puertos.Write(BufferOut);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message+" Pulse 'Desconectar' y vuelva a probar.");
            }
        }

        private void Btn_Izquierda_MouseUp(object sender, MouseEventArgs e)
        {
            Sp_Puertos.DiscardOutBuffer();
            BufferOut = "G";
            Sp_Puertos.Write(BufferOut);
        }


        private void Btn_Derecha_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                Sp_Puertos.DiscardOutBuffer();
                BufferOut = "H";
                Sp_Puertos.Write(BufferOut);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message+" Pulse 'Desconectar' y vuelva a probar.");
            }
        }

        private void Btn_Derecha_MouseUp(object sender, MouseEventArgs e)
        {
            Sp_Puertos.DiscardOutBuffer();
            BufferOut = "I";
            Sp_Puertos.Write(BufferOut);
        }

        private void Btn_Abajo_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                Sp_Puertos.DiscardOutBuffer();
                BufferOut = "J";
                Sp_Puertos.Write(BufferOut);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message+" Pulse 'Desconectar' y vuelva a probar.");
            }
        }

        private void Btn_Abajo_MouseUp(object sender, MouseEventArgs e)
        {
            Sp_Puertos.DiscardOutBuffer();
            BufferOut = "K";
            Sp_Puertos.Write(BufferOut);
        }

        private void Btn_SistemaSolar_Click(object sender, EventArgs e)
        {
            try
            {
                Sp_Puertos.DiscardOutBuffer();
                BufferOut = "L";
                Sp_Puertos.Write(BufferOut);
                }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message+" Pulse 'Desconectar' y vuelva a probar.");
            }
        }

        private void Btn_Estrellas_Click(object sender, EventArgs e)
        {
            try
            {
                Sp_Puertos.DiscardOutBuffer();
                BufferOut = "M";
                Sp_Puertos.Write(BufferOut);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message+" Pulse 'Desconectar' y vuelva a probar.");
            }
        }

        private void Btn_CieloProfundo_Click(object sender, EventArgs e)
        {
            try
            {
                Sp_Puertos.DiscardOutBuffer();
                BufferOut = "N";
                Sp_Puertos.Write(BufferOut);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message+" Pulse 'Desconectar' y vuelva a probar.");
            }
        }

        private void Btn_Identificar_Click(object sender, EventArgs e)
        {
            try
            {
                Sp_Puertos.DiscardOutBuffer();
                BufferOut = "O";
                Sp_Puertos.Write(BufferOut);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message+" Pulse 'Desconectar' y vuelva a probar.");
            }
        }

        private void Btn_TourCielo_Click(object sender, EventArgs e)
        {
            try
            {
                Sp_Puertos.DiscardOutBuffer();
                BufferOut = "P";
                Sp_Puertos.Write(BufferOut);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message+" Pulse 'Desconectar' y vuelva a probar.");
            }
        }

        private void Btn_DesplazarArriba_Click(object sender, EventArgs e)
        {
            try
            {
                Sp_Puertos.DiscardOutBuffer();
                BufferOut = "Q";
                Sp_Puertos.Write(BufferOut);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message+" Pulse 'Desconectar' y vuelva a probar.");
            }
        }

        private void Btn_Menu_Click(object sender, EventArgs e)
        {
            try
            {
                Sp_Puertos.DiscardOutBuffer();
                BufferOut = "R";
                Sp_Puertos.Write(BufferOut);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message+" Pulse 'Desconectar' y vuelva a probar.");
            }
        }

        private void Btn_Ayuda_Click(object sender, EventArgs e)
        {
            try
            {
                Sp_Puertos.DiscardOutBuffer();
                BufferOut = "S";
                Sp_Puertos.Write(BufferOut);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message+" Pulse 'Desconectar' y vuelva a probar.");
            }
        }

        private void Btn_DesplazarAbajo_Click(object sender, EventArgs e)
        {
            try
            {
                Sp_Puertos.DiscardOutBuffer();
                BufferOut = "T";
                Sp_Puertos.Write(BufferOut);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message+" Pulse 'Desconectar' y vuelva a probar.");
            }
        }

        private void Btn_Celestron_Click(object sender, EventArgs e)
        {
            try
            {
                if (Btn_Celestron.BackColor != Color.Green)
                {
                    Sp_Puertos.DiscardOutBuffer();
                    BufferOut = "U";
                    Sp_Puertos.Write(BufferOut);
                    Btn_Celestron.BackColor = Color.Green;
                    MessageBox.Show("Pulse 'Alinear' para escoger alineación manual o alineación del sistema solar.", "Celestron Presionado");
                    Fnc_Desactivar_Botones2();
                }
                else
                {
                    Sp_Puertos.DiscardOutBuffer();
                    BufferOut = "X";
                    Sp_Puertos.Write(BufferOut);
                    Btn_Celestron.BackColor = Btn_Alinear.BackColor;
                    Fnc_Activar_Botones2();
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message+" Pulse 'Desconectar' y vuelva a probar.");
            }
        }

        private void Btn_InfoObjeto_Click(object sender, EventArgs e)
        {
            try
            {
                Sp_Puertos.DiscardOutBuffer();
                BufferOut = "V";
                Sp_Puertos.Write(BufferOut);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message+" Pulse 'Desconectar' y vuelva a probar.");
            }
        }

        private void Btn_VelocidadMotor_Click(object sender, EventArgs e)
        {
            try
            {
                Sp_Puertos.DiscardOutBuffer();
                BufferOut = "W";
                Sp_Puertos.Write(BufferOut);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " Pulse 'Desconectar' y vuelva a probar.");
            }
        }
    }
}
