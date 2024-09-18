namespace Evaluacion_3
{
    partial class FormSalida
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
            this.listBoxSalida = new System.Windows.Forms.ListBox();
            this.lblSalidaTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "PRODUCTOS CARGADOS";
            // 
            // listBoxSalida
            // 
            this.listBoxSalida.FormattingEnabled = true;
            this.listBoxSalida.Location = new System.Drawing.Point(19, 119);
            this.listBoxSalida.Name = "listBoxSalida";
            this.listBoxSalida.Size = new System.Drawing.Size(369, 173);
            this.listBoxSalida.TabIndex = 1;
            // 
            // lblSalidaTotal
            // 
            this.lblSalidaTotal.AutoSize = true;
            this.lblSalidaTotal.Location = new System.Drawing.Point(21, 301);
            this.lblSalidaTotal.Name = "lblSalidaTotal";
            this.lblSalidaTotal.Size = new System.Drawing.Size(35, 13);
            this.lblSalidaTotal.TabIndex = 2;
            this.lblSalidaTotal.Text = "label2";
            // 
            // FormSalida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSalidaTotal);
            this.Controls.Add(this.listBoxSalida);
            this.Controls.Add(this.label1);
            this.Name = "FormSalida";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxSalida;
        private System.Windows.Forms.Label lblSalidaTotal;
    }
}