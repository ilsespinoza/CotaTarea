using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica5_Ilse220215783
{
    public partial class Form1 : Form
    {
        private MailMessage envio_mensaje;
        private MailAddress agrega_correo;
        private string servidor= "localhost";
        private SmtpClient cliente;
        private Attachment archivo_abjunto;
        private MailAddress remitente =null;
        public Form1()
        {
            InitializeComponent();
        }

        private void botEnvia_Click(object sender, EventArgs e)
        {
            if (!(lbxPara.Items.Count <=0 && lbxCC.Items.Count<=0))
            {
                if (remitente != null)
                {
                    try
                    {
                        envio_mensaje = new MailMessage();
                        cliente = new SmtpClient();
                        cliente.Host = servidor;
                        envio_mensaje.From = remitente;
                        envio_mensaje.Subject = txtAsunto.Text;
                        envio_mensaje.Body = txtCuerpo.Text;
                        if (chkContenido.Checked)
                        {
                            envio_mensaje.IsBodyHtml = true;
                        }
                        foreach (MailAddress receptor in lbxPara.Items)
                        {
                            envio_mensaje.To.Add(receptor);
                        }
                        foreach (MailAddress replica in lbxCC.Items)
                        {
                            envio_mensaje.CC.Add(replica);
                        }
                        foreach (MailAddress oculto in lbxAgregaVIP.Items)
                        {
                            envio_mensaje.Bcc.Add(oculto);
                        }
                        foreach (string ruta in lbxAgregaAbjunto.Items)
                        {
                            archivo_abjunto = new Attachment(ruta);
                            envio_mensaje.Attachments.Add(archivo_abjunto);
                        }
                        cliente.Send(envio_mensaje);
                        MessageBox.Show("El correo se envio con exito ¡Perfecto!");
                    }
                    catch (Exception exc)
                    {

                        MessageBox.Show("Error del contenido¡Verificalo"+ exc.ToString());
                    }

                }
                else
                {
                    MessageBox.Show("Verificalo le falta un remitente ¡Vamos tu puedes!");
                }

            }
            else
            {
                MessageBox.Show("Verificalo no tienes remitente ¡Busca alguien!");
            }
           
        }

        private void botAgregarRemitente_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombre.TextLength <= 0 || txtCorreo.TextLength <= 0)
                {
                    MessageBox.Show("Introduzca el nombre y correo");
                }
                else
                {
                    remitente = new MailAddress(txtCorreo.Text, txtNombre.Text);
                    txtAgregarRemitente.Text = txtNombre.Text;
                    txtAgregarRemitente.Text = txtCorreo.Text;
                    MessageBox.Show("Se guardo con exito el remitente ¡Buen trabajo!");
                    txtNombre.Clear();
                    txtCorreo.Clear();
                }
            }
            
            catch (Exception)
            {
                MessageBox.Show("Fallo el remitente ¡Corrigelo y sigue con el!");
       
            }
        }

        private void botAgregaPara_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombre.TextLength <= 0 || txtCorreo.TextLength <= 0)
                {
                    MessageBox.Show("Introduzca el nombre y correo");
                }
                else
                {
                    agrega_correo = new MailAddress(txtCorreo.Text, txtNombre.Text);
                    MessageBox.Show("Se agrego con exito la dirección ¡Buen trabajo!");
                    lbxPara.Items.Add(agrega_correo);
                    txtNombre.Clear();
                    txtCorreo.Clear();
                }
            }

            catch (Exception)
            {
                MessageBox.Show("Fallo la direccion del correo ¡Corrigelo y sigue con el!");

            }
        }

        private void botAgregaCC_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombre.TextLength <= 0 || txtCorreo.TextLength <= 0)
                {
                    MessageBox.Show("Introduzca el nombre y correo");
                }
                else
                {
                    agrega_correo = new MailAddress(txtCorreo.Text, txtNombre.Text);
                    MessageBox.Show("Se agrego con exito la copia ¡Buen trabajo!");
                    lbxCC.Items.Add(agrega_correo);
                    txtNombre.Clear();
                    txtCorreo.Clear();
                }
            }

            catch (Exception)
            {
                MessageBox.Show("Error al agregar ¡Corrigelo y sigue con el!");

            }
        }

        private void botAgregarVip_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombre.TextLength <= 0 || txtCorreo.TextLength <= 0)
                {
                    MessageBox.Show("Introduzca el nombre y correo");
                }
                else
                {
                    agrega_correo = new MailAddress(txtCorreo.Text, txtNombre.Text);
                    MessageBox.Show("Se agrego con exito el correo oculto ¡Buen trabajo!");
                    lbxAgregaVIP.Items.Add(agrega_correo);
                    txtNombre.Clear();
                    txtCorreo.Clear();
                }
            }

            catch (Exception)
            {
                MessageBox.Show("Error al agregar el correo oculto ¡Corrigelo y sigue con el!");

            }
        }

        private void botAgregaAbjunto_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog biblioteca_dialogo = new OpenFileDialog();
                if (biblioteca_dialogo.ShowDialog() == DialogResult.OK)
                {
                    string camino_agrega = biblioteca_dialogo.FileName.ToString();
                    if (biblioteca_dialogo.FileName.Length != 0)
                    {
                        lbxAgregaAbjunto.Items.Add(camino_agrega);
                        MessageBox.Show("Se adjunto el archivo seleccionado ¡Buen trabajo!");
                    }

                }

            }
            catch (Exception exc)
            {
                MessageBox.Show("Ocurrio un error al abjuntar ¡Corrigelo!" + exc.ToString());
            }
        }

        private void lbxPara_DoubleClick(object sender, EventArgs e)
        {
            if (lbxPara.SelectedItems.Count ==1)
            {
                lbxPara.Items.RemoveAt(lbxPara.SelectedIndex);
                MessageBox.Show("Se elimino con exito ¡Adios destinatario!");
            }
        }

        private void lbxCC_DoubleClick(object sender, EventArgs e)
        {
            if (lbxCC.SelectedItems.Count == 1)
            {
                lbxCC.Items.RemoveAt(lbxCC.SelectedIndex);
                MessageBox.Show("Se elimino con exito ¡Adios COPIA!");
            }
        }

        private void lbxAgregaVIP_DoubleClick(object sender, EventArgs e)
        {
            if (lbxAgregaVIP.SelectedItems.Count == 1)
            {
                lbxAgregaVIP.Items.RemoveAt(lbxAgregaVIP.SelectedIndex);
                MessageBox.Show("Se elimino con exito ¡Adios VIP!");
            }
        }

        private void lbxAgregaAbjunto_DoubleClick(object sender, EventArgs e)
        {
            if (lbxAgregaAbjunto.SelectedItems.Count == 1)
            {
                lbxAgregaAbjunto.Items.RemoveAt(lbxAgregaAbjunto.SelectedIndex);
                MessageBox.Show("Se elimino con exito ¡Adios Archivo Adjunto!");
            }
        }
    }
}
