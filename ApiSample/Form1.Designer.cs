namespace ApiSample
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
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.listBoxUser = new System.Windows.Forms.ListBox();
            this.listBoxOrder = new System.Windows.Forms.ListBox();
            this.dgwOrder = new System.Windows.Forms.DataGridView();
            this.buttonAtvetel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxUser
            // 
            this.textBoxUser.Location = new System.Drawing.Point(12, 46);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(282, 22);
            this.textBoxUser.TabIndex = 0;
            this.textBoxUser.TextChanged += new System.EventHandler(this.textBoxUser_TextChanged);
            // 
            // listBoxUser
            // 
            this.listBoxUser.FormattingEnabled = true;
            this.listBoxUser.ItemHeight = 16;
            this.listBoxUser.Location = new System.Drawing.Point(12, 92);
            this.listBoxUser.Name = "listBoxUser";
            this.listBoxUser.Size = new System.Drawing.Size(282, 244);
            this.listBoxUser.TabIndex = 1;
            this.listBoxUser.SelectedIndexChanged += new System.EventHandler(this.listBoxUser_SelectedIndexChanged);
            // 
            // listBoxOrder
            // 
            this.listBoxOrder.FormattingEnabled = true;
            this.listBoxOrder.ItemHeight = 16;
            this.listBoxOrder.Location = new System.Drawing.Point(316, 44);
            this.listBoxOrder.Name = "listBoxOrder";
            this.listBoxOrder.Size = new System.Drawing.Size(308, 292);
            this.listBoxOrder.TabIndex = 2;
            this.listBoxOrder.SelectedIndexChanged += new System.EventHandler(this.listBoxOrder_SelectedIndexChanged);
            // 
            // dgwOrder
            // 
            this.dgwOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwOrder.Location = new System.Drawing.Point(12, 373);
            this.dgwOrder.Name = "dgwOrder";
            this.dgwOrder.RowHeadersWidth = 51;
            this.dgwOrder.RowTemplate.Height = 24;
            this.dgwOrder.Size = new System.Drawing.Size(1064, 130);
            this.dgwOrder.TabIndex = 3;
            // 
            // buttonAtvetel
            // 
            this.buttonAtvetel.Location = new System.Drawing.Point(761, 282);
            this.buttonAtvetel.Name = "buttonAtvetel";
            this.buttonAtvetel.Size = new System.Drawing.Size(315, 54);
            this.buttonAtvetel.TabIndex = 4;
            this.buttonAtvetel.Text = "Kiválasztott rendelés átadása";
            this.buttonAtvetel.UseVisualStyleBackColor = true;
            this.buttonAtvetel.Click += new System.EventHandler(this.buttonAtvetel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 519);
            this.Controls.Add(this.buttonAtvetel);
            this.Controls.Add(this.dgwOrder);
            this.Controls.Add(this.listBoxOrder);
            this.Controls.Add(this.listBoxUser);
            this.Controls.Add(this.textBoxUser);
            this.Name = "Form1";
            this.Text = "Rendelés kezelés";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgwOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.ListBox listBoxUser;
        private System.Windows.Forms.ListBox listBoxOrder;
        private System.Windows.Forms.DataGridView dgwOrder;
        private System.Windows.Forms.Button buttonAtvetel;
    }
}