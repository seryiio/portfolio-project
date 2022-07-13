
namespace CapaPresentacion
{
    partial class FormVRegistrados
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
            this.dgvRegistrados = new System.Windows.Forms.DataGridView();
            this.dgvclientes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistrados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvclientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRegistrados
            // 
            this.dgvRegistrados.AllowUserToAddRows = false;
            this.dgvRegistrados.AllowUserToDeleteRows = false;
            this.dgvRegistrados.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvRegistrados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRegistrados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistrados.Location = new System.Drawing.Point(117, 0);
            this.dgvRegistrados.Name = "dgvRegistrados";
            this.dgvRegistrados.ReadOnly = true;
            this.dgvRegistrados.Size = new System.Drawing.Size(943, 631);
            this.dgvRegistrados.TabIndex = 0;
            // 
            // dgvclientes
            // 
            this.dgvclientes.AllowUserToAddRows = false;
            this.dgvclientes.AllowUserToDeleteRows = false;
            this.dgvclientes.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvclientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvclientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvclientes.Location = new System.Drawing.Point(0, 0);
            this.dgvclientes.Name = "dgvclientes";
            this.dgvclientes.ReadOnly = true;
            this.dgvclientes.Size = new System.Drawing.Size(118, 631);
            this.dgvclientes.TabIndex = 1;
            // 
            // FormVRegistrados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1072, 643);
            this.Controls.Add(this.dgvclientes);
            this.Controls.Add(this.dgvRegistrados);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormVRegistrados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormVRegistrados";
            this.Load += new System.EventHandler(this.FormVRegistrados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistrados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvclientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvRegistrados;
        private System.Windows.Forms.DataGridView dgvclientes;
    }
}