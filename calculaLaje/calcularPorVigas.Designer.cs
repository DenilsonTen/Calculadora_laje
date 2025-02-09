namespace CalculaLaje
{
    partial class calcularPorVigas
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.qtdVigas = new System.Windows.Forms.TextBox();
            this.metragemVigas = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lajotaIsopor = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.resultados = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(347, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calcular Laje por Vigas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quantas vigas?";
            // 
            // qtdVigas
            // 
            this.qtdVigas.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qtdVigas.Location = new System.Drawing.Point(35, 135);
            this.qtdVigas.Name = "qtdVigas";
            this.qtdVigas.Size = new System.Drawing.Size(329, 39);
            this.qtdVigas.TabIndex = 2;
            // 
            // metragemVigas
            // 
            this.metragemVigas.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metragemVigas.Location = new System.Drawing.Point(35, 254);
            this.metragemVigas.Name = "metragemVigas";
            this.metragemVigas.Size = new System.Drawing.Size(329, 39);
            this.metragemVigas.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(334, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "Quantos Metros cada viga tem?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 320);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 26);
            this.label4.TabIndex = 5;
            this.label4.Text = "Vai usar";
            // 
            // lajotaIsopor
            // 
            this.lajotaIsopor.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lajotaIsopor.FormattingEnabled = true;
            this.lajotaIsopor.ItemHeight = 26;
            this.lajotaIsopor.Items.AddRange(new object[] {
            "Lajota 25",
            "Lajota 30",
            "Isopor"});
            this.lajotaIsopor.Location = new System.Drawing.Point(35, 373);
            this.lajotaIsopor.Name = "lajotaIsopor";
            this.lajotaIsopor.Size = new System.Drawing.Size(329, 30);
            this.lajotaIsopor.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(35, 430);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(329, 80);
            this.button1.TabIndex = 7;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // resultados
            // 
            this.resultados.BackColor = System.Drawing.Color.Silver;
            this.resultados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultados.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultados.ForeColor = System.Drawing.Color.Black;
            this.resultados.Location = new System.Drawing.Point(444, 135);
            this.resultados.Name = "resultados";
            this.resultados.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.resultados.Size = new System.Drawing.Size(522, 306);
            this.resultados.TabIndex = 12;
            this.resultados.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(656, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 23);
            this.label5.TabIndex = 11;
            this.label5.Text = "Resultado";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(35, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 47);
            this.button2.TabIndex = 13;
            this.button2.Text = "Voltar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // calcularPorVigas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 517);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.resultados);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lajotaIsopor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.metragemVigas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.qtdVigas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.Name = "calcularPorVigas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "calcularPorVigas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox qtdVigas;
        private System.Windows.Forms.TextBox metragemVigas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lajotaIsopor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox resultados;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
    }
}