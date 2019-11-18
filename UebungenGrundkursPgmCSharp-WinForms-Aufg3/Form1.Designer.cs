namespace UebungenGrundkursPgmCSharp_WinForms_Aufg3
{
    partial class Form_calcu
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.Btn_calcu = new System.Windows.Forms.Button();
            this.Tbx_op = new System.Windows.Forms.TextBox();
            this.TBx_second = new System.Windows.Forms.TextBox();
            this.TBx_first = new System.Windows.Forms.TextBox();
            this.TBx_result = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Btn_calcu
            // 
            this.Btn_calcu.Location = new System.Drawing.Point(32, 124);
            this.Btn_calcu.Name = "Btn_calcu";
            this.Btn_calcu.Size = new System.Drawing.Size(202, 23);
            this.Btn_calcu.TabIndex = 0;
            this.Btn_calcu.Text = "=";
            this.Btn_calcu.UseVisualStyleBackColor = true;
            this.Btn_calcu.Click += new System.EventHandler(this.Btn_calcu_Click);
            // 
            // Tbx_op
            // 
            this.Tbx_op.Location = new System.Drawing.Point(117, 82);
            this.Tbx_op.Name = "Tbx_op";
            this.Tbx_op.Size = new System.Drawing.Size(36, 20);
            this.Tbx_op.TabIndex = 1;
            // 
            // TBx_second
            // 
            this.TBx_second.Location = new System.Drawing.Point(171, 82);
            this.TBx_second.Name = "TBx_second";
            this.TBx_second.Size = new System.Drawing.Size(63, 20);
            this.TBx_second.TabIndex = 2;
            // 
            // TBx_first
            // 
            this.TBx_first.Location = new System.Drawing.Point(32, 82);
            this.TBx_first.Name = "TBx_first";
            this.TBx_first.Size = new System.Drawing.Size(63, 20);
            this.TBx_first.TabIndex = 3;
            // 
            // TBx_result
            // 
            this.TBx_result.Enabled = false;
            this.TBx_result.Location = new System.Drawing.Point(32, 34);
            this.TBx_result.Name = "TBx_result";
            this.TBx_result.Size = new System.Drawing.Size(202, 20);
            this.TBx_result.TabIndex = 4;
            // 
            // Form_calcu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 180);
            this.Controls.Add(this.TBx_result);
            this.Controls.Add(this.TBx_first);
            this.Controls.Add(this.TBx_second);
            this.Controls.Add(this.Tbx_op);
            this.Controls.Add(this.Btn_calcu);
            this.Name = "Form_calcu";
            this.Text = "CalculatorLight";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_calcu;
        private System.Windows.Forms.TextBox Tbx_op;
        private System.Windows.Forms.TextBox TBx_second;
        private System.Windows.Forms.TextBox TBx_first;
        private System.Windows.Forms.TextBox TBx_result;
    }
}

