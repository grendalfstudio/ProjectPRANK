namespace GoodsTransportation
{
    partial class Result
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
            this.dgridDistances = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgridDistances)).BeginInit();
            this.SuspendLayout();
            // 
            // dgridDistances
            // 
            this.dgridDistances.AllowUserToAddRows = false;
            this.dgridDistances.AllowUserToDeleteRows = false;
            this.dgridDistances.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridDistances.ColumnHeadersVisible = false;
            this.dgridDistances.Location = new System.Drawing.Point(13, 13);
            this.dgridDistances.Name = "dgridDistances";
            this.dgridDistances.ReadOnly = true;
            this.dgridDistances.RowHeadersWidth = 160;
            this.dgridDistances.Size = new System.Drawing.Size(775, 50);
            this.dgridDistances.TabIndex = 0;
            // 
            // Result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgridDistances);
            this.Name = "Result";
            this.Text = "Result";
            this.Load += new System.EventHandler(this.Result_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgridDistances)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgridDistances;
    }
}