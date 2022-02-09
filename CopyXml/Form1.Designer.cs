
namespace CopyXml
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Btndestino = new System.Windows.Forms.Button();
            this.Btnorigem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtdestino = new System.Windows.Forms.TextBox();
            this.txtorigem = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ListBoxStatus = new System.Windows.Forms.ListBox();
            this.Btncancelar = new System.Windows.Forms.Button();
            this.Btniniciar = new System.Windows.Forms.Button();
            this.abrirdialog = new System.Windows.Forms.FolderBrowserDialog();
            this.labeltemp = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Btndestino);
            this.groupBox1.Controls.Add(this.Btnorigem);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtdestino);
            this.groupBox1.Controls.Add(this.txtorigem);
            this.groupBox1.Location = new System.Drawing.Point(6, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(438, 142);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informe os caminhos";
            // 
            // Btndestino
            // 
            this.Btndestino.FlatAppearance.BorderSize = 0;
            this.Btndestino.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Btndestino.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.Btndestino.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btndestino.ForeColor = System.Drawing.Color.Transparent;
            this.Btndestino.Image = ((System.Drawing.Image)(resources.GetObject("Btndestino.Image")));
            this.Btndestino.Location = new System.Drawing.Point(385, 101);
            this.Btndestino.Name = "Btndestino";
            this.Btndestino.Size = new System.Drawing.Size(47, 23);
            this.Btndestino.TabIndex = 5;
            this.Btndestino.UseVisualStyleBackColor = true;
            this.Btndestino.Click += new System.EventHandler(this.Btndestino_Click);
            // 
            // Btnorigem
            // 
            this.Btnorigem.FlatAppearance.BorderSize = 0;
            this.Btnorigem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Btnorigem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.Btnorigem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btnorigem.ForeColor = System.Drawing.Color.Transparent;
            this.Btnorigem.Image = ((System.Drawing.Image)(resources.GetObject("Btnorigem.Image")));
            this.Btnorigem.Location = new System.Drawing.Point(385, 44);
            this.Btnorigem.Name = "Btnorigem";
            this.Btnorigem.Size = new System.Drawing.Size(47, 22);
            this.Btnorigem.TabIndex = 4;
            this.Btnorigem.UseVisualStyleBackColor = true;
            this.Btnorigem.Click += new System.EventHandler(this.Btnorigem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Destino";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Origem";
            // 
            // txtdestino
            // 
            this.txtdestino.BackColor = System.Drawing.SystemColors.Info;
            this.txtdestino.Location = new System.Drawing.Point(6, 101);
            this.txtdestino.Name = "txtdestino";
            this.txtdestino.Size = new System.Drawing.Size(426, 20);
            this.txtdestino.TabIndex = 1;
            // 
            // txtorigem
            // 
            this.txtorigem.BackColor = System.Drawing.SystemColors.Info;
            this.txtorigem.Location = new System.Drawing.Point(6, 46);
            this.txtorigem.Name = "txtorigem";
            this.txtorigem.Size = new System.Drawing.Size(426, 20);
            this.txtorigem.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Copiando arquivos...";
            this.label3.Visible = false;
            // 
            // ListBoxStatus
            // 
            this.ListBoxStatus.BackColor = System.Drawing.SystemColors.Info;
            this.ListBoxStatus.FormattingEnabled = true;
            this.ListBoxStatus.Location = new System.Drawing.Point(6, 192);
            this.ListBoxStatus.Name = "ListBoxStatus";
            this.ListBoxStatus.Size = new System.Drawing.Size(438, 212);
            this.ListBoxStatus.TabIndex = 10;
            // 
            // Btncancelar
            // 
            this.Btncancelar.Enabled = false;
            this.Btncancelar.Location = new System.Drawing.Point(225, 432);
            this.Btncancelar.Name = "Btncancelar";
            this.Btncancelar.Size = new System.Drawing.Size(219, 47);
            this.Btncancelar.TabIndex = 9;
            this.Btncancelar.Text = "Cancelar";
            this.Btncancelar.UseVisualStyleBackColor = true;
            this.Btncancelar.Click += new System.EventHandler(this.Btncancelar_Click);
            // 
            // Btniniciar
            // 
            this.Btniniciar.Location = new System.Drawing.Point(6, 432);
            this.Btniniciar.Name = "Btniniciar";
            this.Btniniciar.Size = new System.Drawing.Size(213, 47);
            this.Btniniciar.TabIndex = 8;
            this.Btniniciar.Text = "Fazer Processamento";
            this.Btniniciar.UseVisualStyleBackColor = true;
            this.Btniniciar.Click += new System.EventHandler(this.Btniniciar_Click);
            // 
            // abrirdialog
            // 
            this.abrirdialog.HelpRequest += new System.EventHandler(this.abrirdialog_HelpRequest);
            // 
            // labeltemp
            // 
            this.labeltemp.AutoSize = true;
            this.labeltemp.Location = new System.Drawing.Point(7, 412);
            this.labeltemp.Name = "labeltemp";
            this.labeltemp.Size = new System.Drawing.Size(0, 13);
            this.labeltemp.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 491);
            this.Controls.Add(this.labeltemp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ListBoxStatus);
            this.Controls.Add(this.Btncancelar);
            this.Controls.Add(this.Btniniciar);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CopyXml";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Btndestino;
        private System.Windows.Forms.Button Btnorigem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtdestino;
        private System.Windows.Forms.TextBox txtorigem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox ListBoxStatus;
        private System.Windows.Forms.Button Btncancelar;
        private System.Windows.Forms.Button Btniniciar;
        private System.Windows.Forms.FolderBrowserDialog abrirdialog;
        private System.Windows.Forms.Label labeltemp;
    }
}

