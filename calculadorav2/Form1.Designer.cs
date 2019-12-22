namespace calculadorav2
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblCalc = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnBusca = new System.Windows.Forms.Button();
            this.lblRegraTres = new System.Windows.Forms.Label();
            this.btninversamenteProporcional = new System.Windows.Forms.Button();
            this.btnDiretamenteProporcional = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblResultado2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCalc
            // 
            this.lblCalc.AutoSize = true;
            this.lblCalc.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalc.ForeColor = System.Drawing.Color.Silver;
            this.lblCalc.Location = new System.Drawing.Point(12, 9);
            this.lblCalc.Name = "lblCalc";
            this.lblCalc.Size = new System.Drawing.Size(232, 42);
            this.lblCalc.TabIndex = 0;
            this.lblCalc.Text = "Calculadora";
            this.lblCalc.MouseLeave += new System.EventHandler(this.lblCalc_MouseLeave);
            this.lblCalc.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblCalc_MouseMove);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(16, 51);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(612, 13);
            this.lblInfo.TabIndex = 4;
            this.lblInfo.Text = "Esta calculadora realiza expressões numéricas, equações, sistemas e qualquer  out" +
    "ra conta que eu tiver conseguido me lembrar.";
            // 
            // txtBusca
            // 
            this.txtBusca.AutoCompleteCustomSource.AddRange(new string[] {
            "Equação de segundo grau",
            "Equação de primeiro grau",
            "Regra de três",
            "Progressão aritimética",
            "Progessão geométrica",
            "Cálculo de juros",
            "Cálculo de juros compostos",
            "Juros",
            "Juros Compostos",
            ""});
            this.txtBusca.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtBusca.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtBusca.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBusca.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusca.HideSelection = false;
            this.txtBusca.Location = new System.Drawing.Point(12, 107);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(585, 23);
            this.txtBusca.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(725, 428);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "H.Cendrethe 2019";
            // 
            // textBox1
            // 
            this.textBox1.AutoCompleteCustomSource.AddRange(new string[] {
            "Equação de segundo grau",
            "Equação de primeiro grau",
            "Regra de três"});
            this.textBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 107);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(585, 23);
            this.textBox1.TabIndex = 9;
            this.textBox1.Text = "Digite o nome do cálculo que deseja fazer.";
            this.textBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseMove_1);
            // 
            // btnBusca
            // 
            this.btnBusca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBusca.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBusca.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBusca.Location = new System.Drawing.Point(603, 99);
            this.btnBusca.Name = "btnBusca";
            this.btnBusca.Size = new System.Drawing.Size(33, 37);
            this.btnBusca.TabIndex = 10;
            this.btnBusca.Text = "➤";
            this.btnBusca.UseVisualStyleBackColor = true;
            this.btnBusca.Click += new System.EventHandler(this.btnBusca_Click);
            // 
            // lblRegraTres
            // 
            this.lblRegraTres.AutoSize = true;
            this.lblRegraTres.Location = new System.Drawing.Point(16, 165);
            this.lblRegraTres.Name = "lblRegraTres";
            this.lblRegraTres.Size = new System.Drawing.Size(148, 13);
            this.lblRegraTres.TabIndex = 12;
            this.lblRegraTres.Text = "Você escolheu Regra de três!";
            // 
            // btninversamenteProporcional
            // 
            this.btninversamenteProporcional.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btninversamenteProporcional.Location = new System.Drawing.Point(19, 200);
            this.btninversamenteProporcional.Name = "btninversamenteProporcional";
            this.btninversamenteProporcional.Size = new System.Drawing.Size(145, 24);
            this.btninversamenteProporcional.TabIndex = 13;
            this.btninversamenteProporcional.Text = "Inversamente Proporcional";
            this.btninversamenteProporcional.UseVisualStyleBackColor = true;
            this.btninversamenteProporcional.Click += new System.EventHandler(this.inversamenteProporcional_Click);
            // 
            // btnDiretamenteProporcional
            // 
            this.btnDiretamenteProporcional.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDiretamenteProporcional.Location = new System.Drawing.Point(19, 230);
            this.btnDiretamenteProporcional.Name = "btnDiretamenteProporcional";
            this.btnDiretamenteProporcional.Size = new System.Drawing.Size(145, 24);
            this.btnDiretamenteProporcional.TabIndex = 14;
            this.btnDiretamenteProporcional.Text = "Diretamente Proporcional";
            this.btnDiretamenteProporcional.UseVisualStyleBackColor = true;
            this.btnDiretamenteProporcional.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::calculadorav2.Properties.Resources.botao_sair_png2;
            this.pictureBox4.Location = new System.Drawing.Point(785, 9);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(34, 31);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click_1);
            this.pictureBox4.MouseLeave += new System.EventHandler(this.pictureBox4_MouseLeave);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::calculadorav2.Properties.Resources.PngItem_17322961;
            this.pictureBox3.Location = new System.Drawing.Point(785, 46);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(34, 33);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            this.pictureBox3.MouseLeave += new System.EventHandler(this.pictureBox3_MouseLeave);
            this.pictureBox3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox3_MouseMove);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::calculadorav2.Properties.Resources.botao_sair_png1;
            this.pictureBox1.Location = new System.Drawing.Point(785, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(355, 343);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(159, 24);
            this.lblResultado.TabIndex = 15;
            this.lblResultado.Text = "O seu resultado é";
            // 
            // lblResultado2
            // 
            this.lblResultado2.AutoSize = true;
            this.lblResultado2.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado2.ForeColor = System.Drawing.Color.GreenYellow;
            this.lblResultado2.Location = new System.Drawing.Point(512, 327);
            this.lblResultado2.Name = "lblResultado2";
            this.lblResultado2.Size = new System.Drawing.Size(124, 42);
            this.lblResultado2.TabIndex = 16;
            this.lblResultado2.Text = "label1";
            // 
            // Form1
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(826, 450);
            this.Controls.Add(this.lblResultado2);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnDiretamenteProporcional);
            this.Controls.Add(this.btninversamenteProporcional);
            this.Controls.Add(this.lblRegraTres);
            this.Controls.Add(this.btnBusca);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBusca);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblCalc);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseLeave += new System.EventHandler(this.Form1_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCalc;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnBusca;
        private System.Windows.Forms.Label lblRegraTres;
        private System.Windows.Forms.Button btninversamenteProporcional;
        private System.Windows.Forms.Button btnDiretamenteProporcional;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblResultado2;
    }
}

