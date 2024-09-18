namespace Evaluacion_3
{
    partial class FormEdit
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
            this.numUDEdit = new System.Windows.Forms.NumericUpDown();
            this.btnEditAceptar = new System.Windows.Forms.Button();
            this.btnEditCancelar = new System.Windows.Forms.Button();
            this.lblEdit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numUDEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // numUDEdit
            // 
            this.numUDEdit.Location = new System.Drawing.Point(130, 85);
            this.numUDEdit.Name = "numUDEdit";
            this.numUDEdit.Size = new System.Drawing.Size(98, 20);
            this.numUDEdit.TabIndex = 0;
            // 
            // btnEditAceptar
            // 
            this.btnEditAceptar.Location = new System.Drawing.Point(130, 121);
            this.btnEditAceptar.Name = "btnEditAceptar";
            this.btnEditAceptar.Size = new System.Drawing.Size(98, 26);
            this.btnEditAceptar.TabIndex = 1;
            this.btnEditAceptar.Text = "Aceptar edición";
            this.btnEditAceptar.UseVisualStyleBackColor = true;
            this.btnEditAceptar.Click += new System.EventHandler(this.btnEditAceptar_Click);
            // 
            // btnEditCancelar
            // 
            this.btnEditCancelar.Location = new System.Drawing.Point(130, 165);
            this.btnEditCancelar.Name = "btnEditCancelar";
            this.btnEditCancelar.Size = new System.Drawing.Size(98, 26);
            this.btnEditCancelar.TabIndex = 2;
            this.btnEditCancelar.Text = "Cancelar edición";
            this.btnEditCancelar.UseVisualStyleBackColor = true;
            this.btnEditCancelar.Click += new System.EventHandler(this.btnEditCancelar_Click);
            // 
            // lblEdit
            // 
            this.lblEdit.AutoSize = true;
            this.lblEdit.Location = new System.Drawing.Point(127, 59);
            this.lblEdit.Name = "lblEdit";
            this.lblEdit.Size = new System.Drawing.Size(35, 13);
            this.lblEdit.TabIndex = 3;
            this.lblEdit.Text = "label1";
            // 
            // FormEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 307);
            this.Controls.Add(this.lblEdit);
            this.Controls.Add(this.btnEditCancelar);
            this.Controls.Add(this.btnEditAceptar);
            this.Controls.Add(this.numUDEdit);
            this.Name = "FormEdit";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.FormEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numUDEdit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numUDEdit;
        private System.Windows.Forms.Button btnEditAceptar;
        private System.Windows.Forms.Button btnEditCancelar;
        private System.Windows.Forms.Label lblEdit;
    }
}