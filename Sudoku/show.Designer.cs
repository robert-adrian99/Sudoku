namespace WindowsFormsApplication6
{
    partial class show
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
            this.dataGridShow = new System.Windows.Forms.DataGridView();
            this.restart = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridShow)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridShow
            // 
            this.dataGridShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridShow.Location = new System.Drawing.Point(2, 64);
            this.dataGridShow.Name = "dataGridShow";
            this.dataGridShow.RowTemplate.Height = 24;
            this.dataGridShow.Size = new System.Drawing.Size(979, 594);
            this.dataGridShow.TabIndex = 4;
            // 
            // restart
            // 
            this.restart.Location = new System.Drawing.Point(12, 8);
            this.restart.Name = "restart";
            this.restart.Size = new System.Drawing.Size(130, 50);
            this.restart.TabIndex = 5;
            this.restart.Text = "Restart";
            this.restart.UseVisualStyleBackColor = true;
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(836, 8);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(130, 50);
            this.exit.TabIndex = 6;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // show
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 658);
            this.ControlBox = false;
            this.Controls.Add(this.exit);
            this.Controls.Add(this.restart);
            this.Controls.Add(this.dataGridShow);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "show";
            this.Text = "show";
            this.Load += new System.EventHandler(this.show_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridShow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridShow;
        private System.Windows.Forms.Button restart;
        private System.Windows.Forms.Button exit;
    }
}