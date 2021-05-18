
namespace SCMB
{
    partial class RecibodePago
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecibodePago));
            this.btnVender = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtPuestoEmp = new System.Windows.Forms.TextBox();
            this.lblPrecioTotal = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTelEmp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSueldoEmp = new System.Windows.Forms.TextBox();
            this.txtDirEmp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomEmp = new System.Windows.Forms.TextBox();
            this.btnInicio = new System.Windows.Forms.PictureBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnInicio)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVender
            // 
            this.btnVender.BackColor = System.Drawing.Color.ForestGreen;
            this.btnVender.FlatAppearance.BorderSize = 0;
            this.btnVender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVender.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVender.ForeColor = System.Drawing.Color.White;
            this.btnVender.Location = new System.Drawing.Point(889, 486);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(145, 75);
            this.btnVender.TabIndex = 48;
            this.btnVender.Text = "Pagar";
            this.btnVender.UseVisualStyleBackColor = false;
            this.btnVender.Click += new System.EventHandler(this.btnVender_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnInicio);
            this.groupBox2.Controls.Add(this.txtNomEmp);
            this.groupBox2.Controls.Add(this.txtPuestoEmp);
            this.groupBox2.Controls.Add(this.lblPrecioTotal);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtTelEmp);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtSueldoEmp);
            this.groupBox2.Controls.Add(this.txtDirEmp);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(37, 136);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(997, 315);
            this.groupBox2.TabIndex = 45;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos del empleado";
            // 
            // txtPuestoEmp
            // 
            this.txtPuestoEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(94)))), ((int)(((byte)(129)))));
            this.txtPuestoEmp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPuestoEmp.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPuestoEmp.ForeColor = System.Drawing.Color.White;
            this.txtPuestoEmp.Location = new System.Drawing.Point(122, 190);
            this.txtPuestoEmp.Multiline = true;
            this.txtPuestoEmp.Name = "txtPuestoEmp";
            this.txtPuestoEmp.Size = new System.Drawing.Size(390, 30);
            this.txtPuestoEmp.TabIndex = 35;
            // 
            // lblPrecioTotal
            // 
            this.lblPrecioTotal.AutoSize = true;
            this.lblPrecioTotal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPrecioTotal.ForeColor = System.Drawing.Color.Black;
            this.lblPrecioTotal.Location = new System.Drawing.Point(19, 198);
            this.lblPrecioTotal.Name = "lblPrecioTotal";
            this.lblPrecioTotal.Size = new System.Drawing.Size(66, 21);
            this.lblPrecioTotal.TabIndex = 34;
            this.lblPrecioTotal.Text = "Puesto:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(19, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 21);
            this.label9.TabIndex = 32;
            this.label9.Text = "Nombre:";
            // 
            // txtTelEmp
            // 
            this.txtTelEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(94)))), ((int)(((byte)(129)))));
            this.txtTelEmp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelEmp.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTelEmp.ForeColor = System.Drawing.Color.White;
            this.txtTelEmp.Location = new System.Drawing.Point(122, 81);
            this.txtTelEmp.Multiline = true;
            this.txtTelEmp.Name = "txtTelEmp";
            this.txtTelEmp.Size = new System.Drawing.Size(390, 30);
            this.txtTelEmp.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(19, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 21);
            this.label4.TabIndex = 22;
            this.label4.Text = "Teléfono:";
            // 
            // txtSueldoEmp
            // 
            this.txtSueldoEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(94)))), ((int)(((byte)(129)))));
            this.txtSueldoEmp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSueldoEmp.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSueldoEmp.ForeColor = System.Drawing.Color.White;
            this.txtSueldoEmp.Location = new System.Drawing.Point(122, 242);
            this.txtSueldoEmp.Multiline = true;
            this.txtSueldoEmp.Name = "txtSueldoEmp";
            this.txtSueldoEmp.Size = new System.Drawing.Size(390, 30);
            this.txtSueldoEmp.TabIndex = 21;
            // 
            // txtDirEmp
            // 
            this.txtDirEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(94)))), ((int)(((byte)(129)))));
            this.txtDirEmp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDirEmp.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDirEmp.ForeColor = System.Drawing.Color.White;
            this.txtDirEmp.Location = new System.Drawing.Point(122, 130);
            this.txtDirEmp.Multiline = true;
            this.txtDirEmp.Name = "txtDirEmp";
            this.txtDirEmp.Size = new System.Drawing.Size(390, 30);
            this.txtDirEmp.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(19, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 21);
            this.label5.TabIndex = 20;
            this.label5.Text = "Sueldo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(19, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Dirección:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(337, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 30);
            this.label1.TabIndex = 44;
            this.label1.Text = "Comprobante de pago a empleado";
            // 
            // txtNomEmp
            // 
            this.txtNomEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(94)))), ((int)(((byte)(129)))));
            this.txtNomEmp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNomEmp.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNomEmp.ForeColor = System.Drawing.Color.White;
            this.txtNomEmp.Location = new System.Drawing.Point(122, 33);
            this.txtNomEmp.Multiline = true;
            this.txtNomEmp.Name = "txtNomEmp";
            this.txtNomEmp.Size = new System.Drawing.Size(390, 30);
            this.txtNomEmp.TabIndex = 36;
            // 
            // btnInicio
            // 
            this.btnInicio.Image = ((System.Drawing.Image)(resources.GetObject("btnInicio.Image")));
            this.btnInicio.Location = new System.Drawing.Point(562, 34);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(418, 239);
            this.btnInicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnInicio.TabIndex = 37;
            this.btnInicio.TabStop = false;
            // 
            // RecibodePago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1064, 576);
            this.Controls.Add(this.btnVender);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RecibodePago";
            this.Text = "RecibodePago";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnInicio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnVender;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtPuestoEmp;
        private System.Windows.Forms.Label lblPrecioTotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTelEmp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSueldoEmp;
        private System.Windows.Forms.TextBox txtDirEmp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomEmp;
        private System.Windows.Forms.PictureBox btnInicio;
    }
}