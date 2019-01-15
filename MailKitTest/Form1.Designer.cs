namespace MailKitTest
{
    partial class Form1
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
            this.txtDestinatario = new System.Windows.Forms.TextBox();
            this.txtAsunto = new System.Windows.Forms.TextBox();
            this.txtMensaje = new System.Windows.Forms.TextBox();
            this.lblDestinatario = new System.Windows.Forms.Label();
            this.lblAsunto = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDestinatario
            // 
            this.txtDestinatario.Location = new System.Drawing.Point(140, 83);
            this.txtDestinatario.Name = "txtDestinatario";
            this.txtDestinatario.Size = new System.Drawing.Size(291, 20);
            this.txtDestinatario.TabIndex = 0;
            // 
            // txtAsunto
            // 
            this.txtAsunto.Location = new System.Drawing.Point(140, 120);
            this.txtAsunto.Name = "txtAsunto";
            this.txtAsunto.Size = new System.Drawing.Size(291, 20);
            this.txtAsunto.TabIndex = 1;
            // 
            // txtMensaje
            // 
            this.txtMensaje.Location = new System.Drawing.Point(68, 159);
            this.txtMensaje.Multiline = true;
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.Size = new System.Drawing.Size(669, 150);
            this.txtMensaje.TabIndex = 2;
            // 
            // lblDestinatario
            // 
            this.lblDestinatario.AutoSize = true;
            this.lblDestinatario.Location = new System.Drawing.Point(65, 86);
            this.lblDestinatario.Name = "lblDestinatario";
            this.lblDestinatario.Size = new System.Drawing.Size(63, 13);
            this.lblDestinatario.TabIndex = 3;
            this.lblDestinatario.Text = "Destinatario";
            // 
            // lblAsunto
            // 
            this.lblAsunto.AutoSize = true;
            this.lblAsunto.Location = new System.Drawing.Point(65, 123);
            this.lblAsunto.Name = "lblAsunto";
            this.lblAsunto.Size = new System.Drawing.Size(40, 13);
            this.lblAsunto.TabIndex = 4;
            this.lblAsunto.Text = "Asunto";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(661, 325);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 5;
            this.btnSend.Text = "Enviar";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_ClickAsync);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.lblAsunto);
            this.Controls.Add(this.lblDestinatario);
            this.Controls.Add(this.txtMensaje);
            this.Controls.Add(this.txtAsunto);
            this.Controls.Add(this.txtDestinatario);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDestinatario;
        private System.Windows.Forms.TextBox txtAsunto;
        private System.Windows.Forms.TextBox txtMensaje;
        private System.Windows.Forms.Label lblDestinatario;
        private System.Windows.Forms.Label lblAsunto;
        private System.Windows.Forms.Button btnSend;
    }
}

