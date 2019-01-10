namespace Exercício1
{
    partial class AddField
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
            this.buttonCancelField = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxExpressao = new System.Windows.Forms.TextBox();
            this.buttonFieldOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCancelField
            // 
            this.buttonCancelField.Location = new System.Drawing.Point(39, 97);
            this.buttonCancelField.Name = "buttonCancelField";
            this.buttonCancelField.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelField.TabIndex = 8;
            this.buttonCancelField.Text = "Cancelar";
            this.buttonCancelField.UseVisualStyleBackColor = true;
            this.buttonCancelField.Click += new System.EventHandler(this.buttonCancelSpan_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Expressão:";
            // 
            // textBoxExpressao
            // 
            this.textBoxExpressao.Location = new System.Drawing.Point(39, 64);
            this.textBoxExpressao.Name = "textBoxExpressao";
            this.textBoxExpressao.Size = new System.Drawing.Size(163, 20);
            this.textBoxExpressao.TabIndex = 6;
            // 
            // buttonFieldOK
            // 
            this.buttonFieldOK.Location = new System.Drawing.Point(127, 97);
            this.buttonFieldOK.Name = "buttonFieldOK";
            this.buttonFieldOK.Size = new System.Drawing.Size(75, 23);
            this.buttonFieldOK.TabIndex = 5;
            this.buttonFieldOK.Text = "OK";
            this.buttonFieldOK.UseVisualStyleBackColor = true;
            this.buttonFieldOK.Click += new System.EventHandler(this.buttonSpanOK_Click);
            // 
            // AddField
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 161);
            this.Controls.Add(this.buttonCancelField);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxExpressao);
            this.Controls.Add(this.buttonFieldOK);
            this.Name = "AddField";
            this.Text = "Adicionar Expressão";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancelField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxExpressao;
        private System.Windows.Forms.Button buttonFieldOK;
    }
}