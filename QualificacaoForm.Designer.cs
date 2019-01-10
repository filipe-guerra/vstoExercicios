namespace Exercício1
{
    partial class QualificacaoForm
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
            this.textBoxPJ = new System.Windows.Forms.TextBox();
            this.textBoxPF = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonQualOK = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxPJ
            // 
            this.textBoxPJ.Location = new System.Drawing.Point(151, 40);
            this.textBoxPJ.Name = "textBoxPJ";
            this.textBoxPJ.Size = new System.Drawing.Size(155, 20);
            this.textBoxPJ.TabIndex = 0;
            this.textBoxPJ.Text = "contatoPJ";
            // 
            // textBoxPF
            // 
            this.textBoxPF.Location = new System.Drawing.Point(151, 77);
            this.textBoxPF.Name = "textBoxPF";
            this.textBoxPF.Size = new System.Drawing.Size(155, 20);
            this.textBoxPF.TabIndex = 1;
            this.textBoxPF.Text = "contatoPF";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome do Contato PJ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome do Contato PF";
            // 
            // buttonQualOK
            // 
            this.buttonQualOK.Location = new System.Drawing.Point(231, 117);
            this.buttonQualOK.Name = "buttonQualOK";
            this.buttonQualOK.Size = new System.Drawing.Size(75, 23);
            this.buttonQualOK.TabIndex = 4;
            this.buttonQualOK.Text = "OK";
            this.buttonQualOK.UseVisualStyleBackColor = true;
            this.buttonQualOK.Click += new System.EventHandler(this.buttonQualOK_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(150, 117);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // QualificacaoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 176);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonQualOK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPF);
            this.Controls.Add(this.textBoxPJ);
            this.Name = "QualificacaoForm";
            this.Text = "Qualificação com Representante";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPJ;
        private System.Windows.Forms.TextBox textBoxPF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonQualOK;
        private System.Windows.Forms.Button button2;
    }
}