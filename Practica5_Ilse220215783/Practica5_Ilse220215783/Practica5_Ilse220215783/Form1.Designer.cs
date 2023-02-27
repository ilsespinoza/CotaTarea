
namespace Practica5_Ilse220215783
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbxPara = new System.Windows.Forms.ListBox();
            this.lbxAgregaAbjunto = new System.Windows.Forms.ListBox();
            this.botEnvia = new System.Windows.Forms.Button();
            this.botAgregaPara = new System.Windows.Forms.Button();
            this.botAgregaCC = new System.Windows.Forms.Button();
            this.botAgregaAbjunto = new System.Windows.Forms.Button();
            this.botAgregarRemitente = new System.Windows.Forms.Button();
            this.botAgregarVip = new System.Windows.Forms.Button();
            this.chkContenido = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbxAgregaVIP = new System.Windows.Forms.ListBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtAgregarRemitente = new System.Windows.Forms.TextBox();
            this.lbxCC = new System.Windows.Forms.ListBox();
            this.txtCuerpo = new System.Windows.Forms.TextBox();
            this.txtAsunto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbxPara
            // 
            this.lbxPara.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lbxPara.FormattingEnabled = true;
            this.lbxPara.Location = new System.Drawing.Point(12, 74);
            this.lbxPara.Name = "lbxPara";
            this.lbxPara.Size = new System.Drawing.Size(246, 108);
            this.lbxPara.TabIndex = 0;
            this.lbxPara.DoubleClick += new System.EventHandler(this.lbxPara_DoubleClick);
            // 
            // lbxAgregaAbjunto
            // 
            this.lbxAgregaAbjunto.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lbxAgregaAbjunto.FormattingEnabled = true;
            this.lbxAgregaAbjunto.Location = new System.Drawing.Point(434, 12);
            this.lbxAgregaAbjunto.Name = "lbxAgregaAbjunto";
            this.lbxAgregaAbjunto.Size = new System.Drawing.Size(357, 43);
            this.lbxAgregaAbjunto.TabIndex = 4;
            this.lbxAgregaAbjunto.DoubleClick += new System.EventHandler(this.lbxAgregaAbjunto_DoubleClick);
            // 
            // botEnvia
            // 
            this.botEnvia.BackColor = System.Drawing.Color.Silver;
            this.botEnvia.Location = new System.Drawing.Point(12, 12);
            this.botEnvia.Name = "botEnvia";
            this.botEnvia.Size = new System.Drawing.Size(110, 30);
            this.botEnvia.TabIndex = 7;
            this.botEnvia.Text = "Envía Correo";
            this.botEnvia.UseVisualStyleBackColor = false;
            this.botEnvia.Click += new System.EventHandler(this.botEnvia_Click);
            // 
            // botAgregaPara
            // 
            this.botAgregaPara.BackColor = System.Drawing.Color.Silver;
            this.botAgregaPara.Location = new System.Drawing.Point(12, 326);
            this.botAgregaPara.Name = "botAgregaPara";
            this.botAgregaPara.Size = new System.Drawing.Size(124, 29);
            this.botAgregaPara.TabIndex = 8;
            this.botAgregaPara.Text = "Agrega Para";
            this.botAgregaPara.UseVisualStyleBackColor = false;
            this.botAgregaPara.Click += new System.EventHandler(this.botAgregaPara_Click);
            // 
            // botAgregaCC
            // 
            this.botAgregaCC.BackColor = System.Drawing.Color.Silver;
            this.botAgregaCC.Location = new System.Drawing.Point(158, 326);
            this.botAgregaCC.Name = "botAgregaCC";
            this.botAgregaCC.Size = new System.Drawing.Size(120, 29);
            this.botAgregaCC.TabIndex = 9;
            this.botAgregaCC.Text = "Agrega CC";
            this.botAgregaCC.UseVisualStyleBackColor = false;
            this.botAgregaCC.Click += new System.EventHandler(this.botAgregaCC_Click);
            // 
            // botAgregaAbjunto
            // 
            this.botAgregaAbjunto.BackColor = System.Drawing.Color.Silver;
            this.botAgregaAbjunto.Location = new System.Drawing.Point(298, 12);
            this.botAgregaAbjunto.Name = "botAgregaAbjunto";
            this.botAgregaAbjunto.Size = new System.Drawing.Size(118, 33);
            this.botAgregaAbjunto.TabIndex = 10;
            this.botAgregaAbjunto.Text = "Agrega Abjunto";
            this.botAgregaAbjunto.UseVisualStyleBackColor = false;
            this.botAgregaAbjunto.Click += new System.EventHandler(this.botAgregaAbjunto_Click);
            // 
            // botAgregarRemitente
            // 
            this.botAgregarRemitente.BackColor = System.Drawing.Color.Silver;
            this.botAgregarRemitente.Location = new System.Drawing.Point(376, 349);
            this.botAgregarRemitente.Name = "botAgregarRemitente";
            this.botAgregarRemitente.Size = new System.Drawing.Size(117, 26);
            this.botAgregarRemitente.TabIndex = 11;
            this.botAgregarRemitente.Text = "Agregar Remitente";
            this.botAgregarRemitente.UseVisualStyleBackColor = false;
            this.botAgregarRemitente.Click += new System.EventHandler(this.botAgregarRemitente_Click);
            // 
            // botAgregarVip
            // 
            this.botAgregarVip.BackColor = System.Drawing.Color.Silver;
            this.botAgregarVip.Location = new System.Drawing.Point(376, 416);
            this.botAgregarVip.Name = "botAgregarVip";
            this.botAgregarVip.Size = new System.Drawing.Size(117, 22);
            this.botAgregarVip.TabIndex = 12;
            this.botAgregarVip.Text = "Agregar VIP";
            this.botAgregarVip.UseVisualStyleBackColor = false;
            this.botAgregarVip.Click += new System.EventHandler(this.botAgregarVip_Click);
            // 
            // chkContenido
            // 
            this.chkContenido.AutoSize = true;
            this.chkContenido.Location = new System.Drawing.Point(145, 20);
            this.chkContenido.Name = "chkContenido";
            this.chkContenido.Size = new System.Drawing.Size(113, 17);
            this.chkContenido.TabIndex = 13;
            this.chkContenido.Text = "Contenido HTML?";
            this.chkContenido.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "PARA:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "CC:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 362);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 403);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Correo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(319, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Asunto:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(329, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Cuerpo:";
            // 
            // lbxAgregaVIP
            // 
            this.lbxAgregaVIP.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lbxAgregaVIP.FormattingEnabled = true;
            this.lbxAgregaVIP.Location = new System.Drawing.Point(512, 390);
            this.lbxAgregaVIP.Name = "lbxAgregaVIP";
            this.lbxAgregaVIP.Size = new System.Drawing.Size(279, 95);
            this.lbxAgregaVIP.TabIndex = 20;
            this.lbxAgregaVIP.DoubleClick += new System.EventHandler(this.lbxAgregaVIP_DoubleClick);
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtNombre.Location = new System.Drawing.Point(66, 362);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(212, 20);
            this.txtNombre.TabIndex = 22;
            // 
            // txtCorreo
            // 
            this.txtCorreo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtCorreo.Location = new System.Drawing.Point(63, 400);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(215, 20);
            this.txtCorreo.TabIndex = 23;
            // 
            // txtAgregarRemitente
            // 
            this.txtAgregarRemitente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtAgregarRemitente.Location = new System.Drawing.Point(512, 353);
            this.txtAgregarRemitente.Name = "txtAgregarRemitente";
            this.txtAgregarRemitente.ReadOnly = true;
            this.txtAgregarRemitente.Size = new System.Drawing.Size(228, 20);
            this.txtAgregarRemitente.TabIndex = 24;
            // 
            // lbxCC
            // 
            this.lbxCC.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lbxCC.FormattingEnabled = true;
            this.lbxCC.Location = new System.Drawing.Point(12, 208);
            this.lbxCC.Name = "lbxCC";
            this.lbxCC.Size = new System.Drawing.Size(246, 108);
            this.lbxCC.TabIndex = 25;
            this.lbxCC.DoubleClick += new System.EventHandler(this.lbxCC_DoubleClick);
            // 
            // txtCuerpo
            // 
            this.txtCuerpo.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtCuerpo.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtCuerpo.Location = new System.Drawing.Point(418, 135);
            this.txtCuerpo.Multiline = true;
            this.txtCuerpo.Name = "txtCuerpo";
            this.txtCuerpo.Size = new System.Drawing.Size(416, 195);
            this.txtCuerpo.TabIndex = 26;
            // 
            // txtAsunto
            // 
            this.txtAsunto.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtAsunto.Location = new System.Drawing.Point(426, 71);
            this.txtAsunto.Multiline = true;
            this.txtAsunto.Name = "txtAsunto";
            this.txtAsunto.Size = new System.Drawing.Size(365, 34);
            this.txtAsunto.TabIndex = 27;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(884, 497);
            this.Controls.Add(this.txtAsunto);
            this.Controls.Add(this.txtCuerpo);
            this.Controls.Add(this.lbxCC);
            this.Controls.Add(this.txtAgregarRemitente);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lbxAgregaVIP);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkContenido);
            this.Controls.Add(this.botAgregarVip);
            this.Controls.Add(this.botAgregarRemitente);
            this.Controls.Add(this.botAgregaAbjunto);
            this.Controls.Add(this.botAgregaCC);
            this.Controls.Add(this.botAgregaPara);
            this.Controls.Add(this.botEnvia);
            this.Controls.Add(this.lbxAgregaAbjunto);
            this.Controls.Add(this.lbxPara);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "ENVÍO DE CORREOS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxPara;
       // private System.Windows.Forms.ListBox lbxCC;
        private System.Windows.Forms.ListBox lbxAgregaAbjunto;
        private System.Windows.Forms.Button botEnvia;
        private System.Windows.Forms.Button botAgregaPara;
        private System.Windows.Forms.Button botAgregaCC;
        private System.Windows.Forms.Button botAgregaAbjunto;
        private System.Windows.Forms.Button botAgregarRemitente;
        private System.Windows.Forms.Button botAgregarVip;
        private System.Windows.Forms.CheckBox chkContenido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lbxAgregaVIP;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtAgregarRemitente;
        private System.Windows.Forms.ListBox lbxCC;
        private System.Windows.Forms.TextBox txtCuerpo;
        private System.Windows.Forms.TextBox txtAsunto;
    }
}

