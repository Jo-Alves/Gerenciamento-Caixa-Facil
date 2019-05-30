namespace sistemaControleVendas
{
    partial class FrmSerial
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
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.txtSerial = new System.Windows.Forms.TextBox();
            this.lblFechar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Enabled = false;
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConfirmar.Location = new System.Drawing.Point(335, 40);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(98, 30);
            this.btnConfirmar.TabIndex = 0;
            this.btnConfirmar.Text = "OK";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // txtSerial
            // 
            this.txtSerial.BackColor = System.Drawing.Color.White;
            this.txtSerial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSerial.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSerial.Location = new System.Drawing.Point(12, 38);
            this.txtSerial.MaxLength = 23;
            this.txtSerial.Name = "txtSerial";
            this.txtSerial.Size = new System.Drawing.Size(317, 32);
            this.txtSerial.TabIndex = 1;
            this.txtSerial.TextChanged += new System.EventHandler(this.txtSerial_TextChanged);
            // 
            // lblFechar
            // 
            this.lblFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFechar.AutoSize = true;
            this.lblFechar.BackColor = System.Drawing.Color.White;
            this.lblFechar.Location = new System.Drawing.Point(442, 0);
            this.lblFechar.Name = "lblFechar";
            this.lblFechar.Size = new System.Drawing.Size(20, 19);
            this.lblFechar.TabIndex = 2;
            this.lblFechar.Text = "X";
            this.lblFechar.Click += new System.EventHandler(this.lblFechar_Click);
            this.lblFechar.MouseEnter += new System.EventHandler(this.lblFechar_MouseEnter);
            this.lblFechar.MouseLeave += new System.EventHandler(this.lblFechar_MouseLeave);
            // 
            // FrmSerial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(461, 91);
            this.Controls.Add(this.lblFechar);
            this.Controls.Add(this.txtSerial);
            this.Controls.Add(this.btnConfirmar);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmSerial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSerial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.TextBox txtSerial;
        private System.Windows.Forms.Label lblFechar;
    }
}