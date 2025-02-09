namespace CalculaLaje
{
    partial class Calculadora
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
            this.label = new System.Windows.Forms.Label();
            this.lado1 = new System.Windows.Forms.TextBox();
            this.lado2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ladoViga = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.calcular = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.resultados = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.qual = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(330, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vamos Calcular a Laje";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(44, 109);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(127, 23);
            this.label.TabIndex = 1;
            this.label.Text = "Comprimento";
            // 
            // lado1
            // 
            this.lado1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lado1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lado1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lado1.Location = new System.Drawing.Point(48, 150);
            this.lado1.Name = "lado1";
            this.lado1.Size = new System.Drawing.Size(404, 30);
            this.lado1.TabIndex = 2;
            // 
            // lado2
            // 
            this.lado2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lado2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lado2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lado2.Location = new System.Drawing.Point(48, 239);
            this.lado2.Name = "lado2";
            this.lado2.Size = new System.Drawing.Size(404, 30);
            this.lado2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Largura";
            // 
            // ladoViga
            // 
            this.ladoViga.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ladoViga.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ladoViga.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ladoViga.Location = new System.Drawing.Point(48, 332);
            this.ladoViga.Name = "ladoViga";
            this.ladoViga.Size = new System.Drawing.Size(404, 30);
            this.ladoViga.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 291);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Qual a viga?";
            // 
            // calcular
            // 
            this.calcular.BackColor = System.Drawing.Color.Green;
            this.calcular.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.calcular.FlatAppearance.BorderSize = 2;
            this.calcular.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.calcular.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcular.ForeColor = System.Drawing.Color.White;
            this.calcular.Location = new System.Drawing.Point(55, 470);
            this.calcular.Name = "calcular";
            this.calcular.Size = new System.Drawing.Size(285, 54);
            this.calcular.TabIndex = 7;
            this.calcular.Text = "Calcular";
            this.calcular.UseCompatibleTextRendering = true;
            this.calcular.UseMnemonic = false;
            this.calcular.UseVisualStyleBackColor = false;
            this.calcular.Click += new System.EventHandler(this.Calcular_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(699, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Resultado";
            // 
            // resultados
            // 
            this.resultados.BackColor = System.Drawing.Color.Silver;
            this.resultados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultados.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultados.ForeColor = System.Drawing.Color.Black;
            this.resultados.Location = new System.Drawing.Point(487, 150);
            this.resultados.Name = "resultados";
            this.resultados.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.resultados.Size = new System.Drawing.Size(522, 306);
            this.resultados.TabIndex = 10;
            this.resultados.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(44, 370);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 23);
            this.label5.TabIndex = 11;
            this.label5.Text = "Lajotas ou isopor?";
            // 
            // qual
            // 
            this.qual.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qual.FormattingEnabled = true;
            this.qual.ItemHeight = 23;
            this.qual.Items.AddRange(new object[] {
            "Lajota 25",
            "Lajota 30",
            "Isopor"});
            this.qual.Location = new System.Drawing.Point(48, 406);
            this.qual.Name = "qual";
            this.qual.Size = new System.Drawing.Size(404, 50);
            this.qual.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(393, 470);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(285, 54);
            this.button1.TabIndex = 13;
            this.button1.Text = "Calcular por Vigas";
            this.button1.UseCompatibleTextRendering = true;
            this.button1.UseMnemonic = false;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Green;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.button2.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(731, 470);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(285, 54);
            this.button2.TabIndex = 14;
            this.button2.Text = "Calcular Por M²";
            this.button2.UseCompatibleTextRendering = true;
            this.button2.UseMnemonic = false;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 536);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.qual);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.resultados);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.calcular);
            this.Controls.Add(this.ladoViga);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lado2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lado1);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1055, 583);
            this.Name = "Calculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora Laje";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox lado1;
        private System.Windows.Forms.TextBox lado2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ladoViga;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button calcular;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox resultados;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox qual;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

