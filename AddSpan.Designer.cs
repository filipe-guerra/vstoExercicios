﻿namespace Exercício1
{
    partial class AddSpan
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
            this.buttonSpanOK = new System.Windows.Forms.Button();
            this.textBoxSpan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCancelSpan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonSpanOK
            // 
            this.buttonSpanOK.Location = new System.Drawing.Point(123, 87);
            this.buttonSpanOK.Name = "buttonSpanOK";
            this.buttonSpanOK.Size = new System.Drawing.Size(75, 23);
            this.buttonSpanOK.TabIndex = 0;
            this.buttonSpanOK.Text = "OK";
            this.buttonSpanOK.UseVisualStyleBackColor = true;
            this.buttonSpanOK.Click += new System.EventHandler(this.buttonSpanOK_Click);
            // 
            // textBoxSpan
            // 
            this.textBoxSpan.Location = new System.Drawing.Point(35, 54);
            this.textBoxSpan.Name = "textBoxSpan";
            this.textBoxSpan.Size = new System.Drawing.Size(163, 20);
            this.textBoxSpan.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Span:";
            // 
            // buttonCancelSpan
            // 
            this.buttonCancelSpan.Location = new System.Drawing.Point(35, 87);
            this.buttonCancelSpan.Name = "buttonCancelSpan";
            this.buttonCancelSpan.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelSpan.TabIndex = 4;
            this.buttonCancelSpan.Text = "Cancelar";
            this.buttonCancelSpan.UseVisualStyleBackColor = true;
            this.buttonCancelSpan.Click += new System.EventHandler(this.buttonCancelSpan_Click);
            // 
            // AddSpan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 146);
            this.Controls.Add(this.buttonCancelSpan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSpan);
            this.Controls.Add(this.buttonSpanOK);
            this.Name = "AddSpan";
            this.Text = "Adicionar Span";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSpanOK;
        private System.Windows.Forms.TextBox textBoxSpan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCancelSpan;
    }
}