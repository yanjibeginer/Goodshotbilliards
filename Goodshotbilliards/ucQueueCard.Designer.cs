namespace Goodshotbilliards
{
    partial class ucQueueCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlqueueholder = new System.Windows.Forms.Panel();
            this.btnAssigntable = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lblArrival = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblQueueNumber = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.pnlqueueholder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlqueueholder
            // 
            this.pnlqueueholder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlqueueholder.AutoScroll = true;
            this.pnlqueueholder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(17)))), ((int)(((byte)(21)))), ((int)(((byte)(39)))));
            this.pnlqueueholder.Controls.Add(this.btnAssigntable);
            this.pnlqueueholder.Controls.Add(this.label6);
            this.pnlqueueholder.Controls.Add(this.lblArrival);
            this.pnlqueueholder.Controls.Add(this.lblCustomerName);
            this.pnlqueueholder.Controls.Add(this.pictureBox3);
            this.pnlqueueholder.Controls.Add(this.lblQueueNumber);
            this.pnlqueueholder.Controls.Add(this.panel8);
            this.pnlqueueholder.Controls.Add(this.label16);
            this.pnlqueueholder.Location = new System.Drawing.Point(18, 12);
            this.pnlqueueholder.Name = "pnlqueueholder";
            this.pnlqueueholder.Size = new System.Drawing.Size(928, 91);
            this.pnlqueueholder.TabIndex = 12;
            this.pnlqueueholder.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // btnAssigntable
            // 
            this.btnAssigntable.AutoEllipsis = true;
            this.btnAssigntable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(11)))), ((int)(((byte)(24)))));
            this.btnAssigntable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAssigntable.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(197)))), ((int)(((byte)(94)))));
            this.btnAssigntable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssigntable.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssigntable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(197)))), ((int)(((byte)(94)))));
            this.btnAssigntable.Location = new System.Drawing.Point(715, 22);
            this.btnAssigntable.Name = "btnAssigntable";
            this.btnAssigntable.Size = new System.Drawing.Size(145, 45);
            this.btnAssigntable.TabIndex = 20;
            this.btnAssigntable.Text = "ASSIGN TABLE";
            this.btnAssigntable.UseVisualStyleBackColor = false;
            this.btnAssigntable.Click += new System.EventHandler(this.btnAssigntable_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(163)))), ((int)(((byte)(175)))));
            this.label6.Location = new System.Drawing.Point(192, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Arrived";
            // 
            // lblArrival
            // 
            this.lblArrival.AutoSize = true;
            this.lblArrival.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArrival.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(189)))), ((int)(((byte)(248)))));
            this.lblArrival.Location = new System.Drawing.Point(234, 53);
            this.lblArrival.Name = "lblArrival";
            this.lblArrival.Size = new System.Drawing.Size(52, 15);
            this.lblArrival.TabIndex = 22;
            this.lblArrival.Text = "4:30 PM";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.BackColor = System.Drawing.Color.Transparent;
            this.lblCustomerName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.ForeColor = System.Drawing.Color.White;
            this.lblCustomerName.Location = new System.Drawing.Point(163, 12);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(128, 30);
            this.lblCustomerName.TabIndex = 21;
            this.lblCustomerName.Text = "USERNAME";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::Goodshotbilliards.Properties.Resources.icons8_user_30;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(113, 29);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 33);
            this.pictureBox3.TabIndex = 20;
            this.pictureBox3.TabStop = false;
            // 
            // lblQueueNumber
            // 
            this.lblQueueNumber.AutoSize = true;
            this.lblQueueNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblQueueNumber.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQueueNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(197)))), ((int)(((byte)(94)))));
            this.lblQueueNumber.Location = new System.Drawing.Point(19, 22);
            this.lblQueueNumber.Name = "lblQueueNumber";
            this.lblQueueNumber.Size = new System.Drawing.Size(57, 45);
            this.lblQueueNumber.TabIndex = 19;
            this.lblQueueNumber.Text = "#1";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.PaleGreen;
            this.panel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(5, 89);
            this.panel8.TabIndex = 18;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(183)))), ((int)(((byte)(255)))));
            this.label16.Location = new System.Drawing.Point(163, 45);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(32, 25);
            this.label16.TabIndex = 20;
            this.label16.Text = "⏱";
            // 
            // ucQueueCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(11)))), ((int)(((byte)(24)))));
            this.Controls.Add(this.pnlqueueholder);
            this.Name = "ucQueueCard";
            this.Size = new System.Drawing.Size(1086, 108);
            this.pnlqueueholder.ResumeLayout(false);
            this.pnlqueueholder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlqueueholder;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label lblQueueNumber;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblArrival;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnAssigntable;
    }
}
