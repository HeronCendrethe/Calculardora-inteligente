namespace calculadorav2
{
    partial class FormInversoProporcional
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
            this.txtFator2Inverso = new System.Windows.Forms.TextBox();
            this.txtFator1Inverso = new System.Windows.Forms.TextBox();
            this.txtFator3Inverso = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtFator2Inverso
            // 
            this.txtFator2Inverso.Location = new System.Drawing.Point(168, 79);
            this.txtFator2Inverso.Name = "txtFator2Inverso";
            this.txtFator2Inverso.Size = new System.Drawing.Size(65, 20);
            this.txtFator2Inverso.TabIndex = 0;
            // 
            // txtFator1Inverso
            // 
            this.txtFator1Inverso.Location = new System.Drawing.Point(13, 79);
            this.txtFator1Inverso.Name = "txtFator1Inverso";
            this.txtFator1Inverso.Size = new System.Drawing.Size(64, 20);
            this.txtFator1Inverso.TabIndex = 1;
            // 
            // txtFator3Inverso
            // 
            this.txtFator3Inverso.Location = new System.Drawing.Point(168, 153);
            this.txtFator3Inverso.Name = "txtFator3Inverso";
            this.txtFator3Inverso.Size = new System.Drawing.Size(65, 20);
            this.txtFator3Inverso.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Variável 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(165, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Variável 1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(85, 193);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Concluído";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormInversoProporcional
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(245, 228);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFator3Inverso);
            this.Controls.Add(this.txtFator1Inverso);
            this.Controls.Add(this.txtFator2Inverso);
            this.Name = "FormInversoProporcional";
            this.Text = "FormInversoProporcional";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFator2Inverso;
        private System.Windows.Forms.TextBox txtFator1Inverso;
        private System.Windows.Forms.TextBox txtFator3Inverso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}