namespace mobile
{
    partial class Form1
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
            this.gItems = new System.Windows.Forms.DataGridView();
            this.lcart = new System.Windows.Forms.Label();
            this.BCheckout = new System.Windows.Forms.Button();
            this.bdelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gItems)).BeginInit();
            this.SuspendLayout();
            // 
            // gItems
            // 
            this.gItems.BackgroundColor = System.Drawing.Color.White;
            this.gItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gItems.Location = new System.Drawing.Point(62, 116);
            this.gItems.Name = "gItems";
            this.gItems.Size = new System.Drawing.Size(496, 268);
            this.gItems.TabIndex = 0;
            // 
            // lcart
            // 
            this.lcart.AutoSize = true;
            this.lcart.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lcart.ForeColor = System.Drawing.Color.White;
            this.lcart.Location = new System.Drawing.Point(194, 71);
            this.lcart.Name = "lcart";
            this.lcart.Size = new System.Drawing.Size(160, 33);
            this.lcart.TabIndex = 1;
            this.lcart.Text = "Cart Items";
            // 
            // BCheckout
            // 
            this.BCheckout.BackColor = System.Drawing.Color.White;
            this.BCheckout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BCheckout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BCheckout.Location = new System.Drawing.Point(631, 144);
            this.BCheckout.Name = "BCheckout";
            this.BCheckout.Size = new System.Drawing.Size(109, 44);
            this.BCheckout.TabIndex = 2;
            this.BCheckout.Text = "Check Out";
            this.BCheckout.UseVisualStyleBackColor = false;
            this.BCheckout.Click += new System.EventHandler(this.BCheckout_Click);
            // 
            // bdelete
            // 
            this.bdelete.BackColor = System.Drawing.Color.White;
            this.bdelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bdelete.Location = new System.Drawing.Point(631, 262);
            this.bdelete.Name = "bdelete";
            this.bdelete.Size = new System.Drawing.Size(109, 44);
            this.bdelete.TabIndex = 4;
            this.bdelete.Text = "Delete All";
            this.bdelete.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bdelete);
            this.Controls.Add(this.BCheckout);
            this.Controls.Add(this.lcart);
            this.Controls.Add(this.gItems);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gItems;
        private System.Windows.Forms.Label lcart;
        private System.Windows.Forms.Button BCheckout;
        private System.Windows.Forms.Button bdelete;
    }
}

