using MailKit.Net.Smtp;
using MimeKit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MailKitTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnSend_ClickAsync(object sender, EventArgs e)
        {
            try
            {
                var mimeMessage = new MimeMessage();
                mimeMessage.From.Add(new MailboxAddress
                                        ("Notificación",
                                         "noreply@pugui.com"
                                         ));
                mimeMessage.To.Add(new MailboxAddress
                                         ("ToTitle",
                                         txtDestinatario.Text
                                         ));
                mimeMessage.Subject = txtAsunto.Text; //Subject  
                mimeMessage.Body = new TextPart("plain")
                {
                    Text = txtMensaje.Text
                };

                using (var client = new SmtpClient())
                {
                    client.Connect("smtp.gmail.com", 587, false);
                    // Esto funciona teniendo habilitada la opcion de aplicaciones menos seguras en gmail, si no hay que conseguir un token OAuth 2.0
                    client.Authenticate(
                        "pugui10@gmail.com",
                        "XXXXXXXXX"
                        );
                    await client.SendAsync(mimeMessage);
                    MessageBox.Show("Email enviado correctamente.");
                    await client.DisconnectAsync(true);
                }
                txtDestinatario.Text = string.Empty;
                txtAsunto.Text = string.Empty;
                txtMensaje.Text = string.Empty;
            }
            catch(Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
        }
    }
}
