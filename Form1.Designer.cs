namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtresultado = new TextBox();
            btnsete = new Button();
            btnoito = new Button();
            btnsoma = new Button();
            btnnove = new Button();
            btnquatro = new Button();
            bntum = new Button();
            btnvirgula = new Button();
            btncinco = new Button();
            btnseis = new Button();
            btnsub = new Button();
            btndois = new Button();
            btntres = new Button();
            btndiv = new Button();
            zero = new Button();
            btnigual = new Button();
            btnmult = new Button();
            btnclean = new Button();
            lbloperacao = new Label();
            SuspendLayout();
            // 
            // txtresultado
            // 
            txtresultado.Location = new Point(22, 28);
            txtresultado.Name = "txtresultado";
            txtresultado.ReadOnly = true;
            txtresultado.Size = new Size(282, 31);
            txtresultado.TabIndex = 0;
            txtresultado.TextAlign = HorizontalAlignment.Right;
            // 
            // btnsete
            // 
            btnsete.Location = new Point(22, 128);
            btnsete.Name = "btnsete";
            btnsete.Size = new Size(66, 62);
            btnsete.TabIndex = 1;
            btnsete.Text = "7";
            btnsete.UseVisualStyleBackColor = true;
            btnsete.Click += btnsete_Click;
            // 
            // btnoito
            // 
            btnoito.Location = new Point(94, 128);
            btnoito.Name = "btnoito";
            btnoito.Size = new Size(66, 62);
            btnoito.TabIndex = 2;
            btnoito.Text = "8";
            btnoito.UseVisualStyleBackColor = true;
            btnoito.Click += btnoito_Click;
            // 
            // btnsoma
            // 
            btnsoma.BackColor = Color.Teal;
            btnsoma.Location = new Point(236, 128);
            btnsoma.Name = "btnsoma";
            btnsoma.Size = new Size(66, 62);
            btnsoma.TabIndex = 3;
            btnsoma.Text = "+";
            btnsoma.UseVisualStyleBackColor = false;
            btnsoma.Click += btnsoma_Click;
            // 
            // btnnove
            // 
            btnnove.Location = new Point(164, 128);
            btnnove.Name = "btnnove";
            btnnove.Size = new Size(66, 62);
            btnnove.TabIndex = 4;
            btnnove.Text = "9";
            btnnove.UseVisualStyleBackColor = true;
            btnnove.Click += btnnove_Click;
            // 
            // btnquatro
            // 
            btnquatro.Location = new Point(22, 196);
            btnquatro.Name = "btnquatro";
            btnquatro.Size = new Size(66, 62);
            btnquatro.TabIndex = 5;
            btnquatro.Text = "4";
            btnquatro.UseVisualStyleBackColor = true;
            btnquatro.Click += btnquatro_Click;
            // 
            // bntum
            // 
            bntum.BackColor = SystemColors.ControlLight;
            bntum.Location = new Point(22, 264);
            bntum.Name = "bntum";
            bntum.Size = new Size(66, 62);
            bntum.TabIndex = 6;
            bntum.Text = "1";
            bntum.UseVisualStyleBackColor = false;
            bntum.Click += bntum_Click;
            // 
            // btnvirgula
            // 
            btnvirgula.Location = new Point(22, 332);
            btnvirgula.Name = "btnvirgula";
            btnvirgula.Size = new Size(66, 62);
            btnvirgula.TabIndex = 7;
            btnvirgula.Text = ",";
            btnvirgula.UseVisualStyleBackColor = true;
            btnvirgula.Click += btnvirgula_Click;
            // 
            // btncinco
            // 
            btncinco.Location = new Point(94, 196);
            btncinco.Name = "btncinco";
            btncinco.Size = new Size(66, 62);
            btncinco.TabIndex = 8;
            btncinco.Text = "5";
            btncinco.UseVisualStyleBackColor = true;
            btncinco.Click += btncinco_Click;
            // 
            // btnseis
            // 
            btnseis.Location = new Point(166, 196);
            btnseis.Name = "btnseis";
            btnseis.Size = new Size(66, 62);
            btnseis.TabIndex = 9;
            btnseis.Text = "6";
            btnseis.UseVisualStyleBackColor = true;
            btnseis.Click += btnseis_Click;
            // 
            // btnsub
            // 
            btnsub.BackColor = Color.Teal;
            btnsub.Location = new Point(236, 196);
            btnsub.Name = "btnsub";
            btnsub.Size = new Size(66, 62);
            btnsub.TabIndex = 10;
            btnsub.Text = "-";
            btnsub.UseVisualStyleBackColor = false;
            btnsub.Click += btnsub_Click;
            // 
            // btndois
            // 
            btndois.Location = new Point(94, 264);
            btndois.Name = "btndois";
            btndois.Size = new Size(66, 62);
            btndois.TabIndex = 11;
            btndois.Text = "2";
            btndois.UseVisualStyleBackColor = true;
            btndois.Click += btndois_Click;
            // 
            // btntres
            // 
            btntres.Location = new Point(166, 264);
            btntres.Name = "btntres";
            btntres.Size = new Size(66, 62);
            btntres.TabIndex = 12;
            btntres.Text = "3";
            btntres.UseVisualStyleBackColor = true;
            btntres.Click += btntres_Click;
            // 
            // btndiv
            // 
            btndiv.BackColor = Color.Teal;
            btndiv.Location = new Point(238, 264);
            btndiv.Name = "btndiv";
            btndiv.Size = new Size(66, 62);
            btndiv.TabIndex = 13;
            btndiv.Text = "÷";
            btndiv.UseVisualStyleBackColor = false;
            btndiv.Click += btndiv_Click;
            // 
            // zero
            // 
            zero.Location = new Point(94, 332);
            zero.Name = "zero";
            zero.Size = new Size(66, 62);
            zero.TabIndex = 14;
            zero.Text = "0";
            zero.UseVisualStyleBackColor = true;
            zero.Click += zero_Click;
            // 
            // btnigual
            // 
            btnigual.Location = new Point(166, 332);
            btnigual.Name = "btnigual";
            btnigual.Size = new Size(66, 62);
            btnigual.TabIndex = 15;
            btnigual.Text = "=";
            btnigual.UseVisualStyleBackColor = true;
            btnigual.Click += btnigual_Click;
            // 
            // btnmult
            // 
            btnmult.BackColor = Color.Teal;
            btnmult.Location = new Point(236, 332);
            btnmult.Name = "btnmult";
            btnmult.Size = new Size(66, 62);
            btnmult.TabIndex = 16;
            btnmult.Text = "x";
            btnmult.UseVisualStyleBackColor = false;
            btnmult.Click += btnmult_Click;
            // 
            // btnclean
            // 
            btnclean.BackColor = Color.Teal;
            btnclean.Location = new Point(236, 87);
            btnclean.Name = "btnclean";
            btnclean.Size = new Size(66, 35);
            btnclean.TabIndex = 18;
            btnclean.Text = "C";
            btnclean.UseVisualStyleBackColor = false;
            btnclean.Click += btnclean_Click;
            // 
            // lbloperacao
            // 
            lbloperacao.AutoSize = true;
            lbloperacao.Location = new Point(33, 32);
            lbloperacao.Name = "lbloperacao";
            lbloperacao.Size = new Size(0, 25);
            lbloperacao.TabIndex = 19;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(333, 414);
            Controls.Add(lbloperacao);
            Controls.Add(btnclean);
            Controls.Add(btnmult);
            Controls.Add(btnigual);
            Controls.Add(zero);
            Controls.Add(btndiv);
            Controls.Add(btntres);
            Controls.Add(btndois);
            Controls.Add(btnsub);
            Controls.Add(btnseis);
            Controls.Add(btncinco);
            Controls.Add(btnvirgula);
            Controls.Add(bntum);
            Controls.Add(btnquatro);
            Controls.Add(btnnove);
            Controls.Add(btnsoma);
            Controls.Add(btnoito);
            Controls.Add(btnsete);
            Controls.Add(txtresultado);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculator 💮";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtresultado;
        private Button btnsete;
        private Button btnoito;
        private Button btnsoma;
        private Button btnnove;
        private Button btnquatro;
        private Button bntum;
        private Button btnvirgula;
        private Button btncinco;
        private Button btnseis;
        private Button btnsub;
        private Button btndois;
        private Button btntres;
        private Button btndiv;
        private Button zero;
        private Button btnigual;
        private Button btnmult;
        private Button btnclean;
        private Label lbloperacao;
    }
}
