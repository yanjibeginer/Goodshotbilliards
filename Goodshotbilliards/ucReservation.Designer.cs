namespace Goodshotbilliards
{
    partial class ucReservation
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label4 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.dgvReservations = new System.Windows.Forms.DataGridView();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlUpcomingResborder = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlBookReserveborder = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel18 = new System.Windows.Forms.Panel();
            this.panel19 = new System.Windows.Forms.Panel();
            this.masktime = new System.Windows.Forms.MaskedTextBox();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel17 = new System.Windows.Forms.Panel();
            this.btnBookReservations = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtCustomerReservation = new System.Windows.Forms.TextBox();
            this.panel16 = new System.Windows.Forms.Panel();
            this.timedecoy = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabledecoy = new System.Windows.Forms.Label();
            this.panel15 = new System.Windows.Forms.Panel();
            this.dtpResDate = new System.Windows.Forms.DateTimePicker();
            this.lblResDate = new System.Windows.Forms.Label();
            this.cmbResTable = new System.Windows.Forms.ComboBox();
            this.cbAmPm = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservations)).BeginInit();
            this.pnlUpcomingResborder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnlBookReserveborder.SuspendLayout();
            this.panel19.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel15.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe MDL2 Assets", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(226)))), ((int)(((byte)(107)))));
            this.label4.Location = new System.Drawing.Point(26, 29);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(68, 48);
            this.label4.TabIndex = 17;
            this.label4.Text = "";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.BackColor = System.Drawing.Color.Transparent;
            this.label28.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.Color.White;
            this.label28.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label28.Location = new System.Drawing.Point(97, 28);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(187, 32);
            this.label28.TabIndex = 18;
            this.label28.Text = "RESERVATIONS";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(163)))), ((int)(((byte)(175)))));
            this.label29.Location = new System.Drawing.Point(100, 63);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(185, 17);
            this.label29.TabIndex = 19;
            this.label29.Text = "Manage future table bookings";
            // 
            // dgvReservations
            // 
            this.dgvReservations.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            this.dgvReservations.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvReservations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReservations.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.dgvReservations.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvReservations.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvReservations.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(30)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReservations.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvReservations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.colTable,
            this.colDate,
            this.colTime});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReservations.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvReservations.EnableHeadersVisualStyles = false;
            this.dgvReservations.Location = new System.Drawing.Point(0, 48);
            this.dgvReservations.Name = "dgvReservations";
            this.dgvReservations.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.dgvReservations.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvReservations.RowTemplate.Height = 35;
            this.dgvReservations.Size = new System.Drawing.Size(923, 186);
            this.dgvReservations.TabIndex = 23;
            this.dgvReservations.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReservations_CellDoubleClick);
            // 
            // colName
            // 
            this.colName.HeaderText = "NAME";
            this.colName.Name = "colName";
            // 
            // colTable
            // 
            this.colTable.HeaderText = "TABLE";
            this.colTable.Name = "colTable";
            // 
            // colDate
            // 
            this.colDate.HeaderText = "DATE";
            this.colDate.Name = "colDate";
            // 
            // colTime
            // 
            this.colTime.HeaderText = "TIME";
            this.colTime.Name = "colTime";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe MDL2 Assets", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(226)))), ((int)(((byte)(107)))));
            this.label1.Location = new System.Drawing.Point(20, 12);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(34, 24);
            this.label1.TabIndex = 21;
            this.label1.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(226)))), ((int)(((byte)(107)))));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label2.Location = new System.Drawing.Point(56, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 21);
            this.label2.TabIndex = 22;
            this.label2.Text = "UPCOMING RESERVATIONS\r\n";
            // 
            // pnlUpcomingResborder
            // 
            this.pnlUpcomingResborder.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlUpcomingResborder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.pnlUpcomingResborder.Controls.Add(this.dgvReservations);
            this.pnlUpcomingResborder.Controls.Add(this.label2);
            this.pnlUpcomingResborder.Controls.Add(this.label1);
            this.pnlUpcomingResborder.Location = new System.Drawing.Point(16, 110);
            this.pnlUpcomingResborder.Name = "pnlUpcomingResborder";
            this.pnlUpcomingResborder.Size = new System.Drawing.Size(923, 234);
            this.pnlUpcomingResborder.TabIndex = 23;
            this.pnlUpcomingResborder.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlUpcomingResborder_Paint_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImage = global::Goodshotbilliards.Properties.Resources._5683f6bb_c312_422f_90f9_041c2b06f9b0;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(753, -20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(245, 164);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Goodshotbilliards.Properties.Resources.icons8_add_user_male_50;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.pictureBox2.Location = new System.Drawing.Point(19, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(37, 31);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(226)))), ((int)(((byte)(107)))));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label3.Location = new System.Drawing.Point(56, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(310, 21);
            this.label3.TabIndex = 23;
            this.label3.Text = "BOOK A NEW CUSTOMER RESERVATION";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(163)))), ((int)(((byte)(175)))));
            this.label5.Location = new System.Drawing.Point(41, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 18);
            this.label5.TabIndex = 24;
            this.label5.Text = "Customer";
            // 
            // pnlBookReserveborder
            // 
            this.pnlBookReserveborder.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlBookReserveborder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(17)))), ((int)(((byte)(21)))), ((int)(((byte)(39)))));
            this.pnlBookReserveborder.Controls.Add(this.panel2);
            this.pnlBookReserveborder.Controls.Add(this.panel3);
            this.pnlBookReserveborder.Controls.Add(this.panel18);
            this.pnlBookReserveborder.Controls.Add(this.panel19);
            this.pnlBookReserveborder.Controls.Add(this.panel11);
            this.pnlBookReserveborder.Controls.Add(this.panel9);
            this.pnlBookReserveborder.Controls.Add(this.panel7);
            this.pnlBookReserveborder.Controls.Add(this.panel8);
            this.pnlBookReserveborder.Controls.Add(this.panel10);
            this.pnlBookReserveborder.Controls.Add(this.panel12);
            this.pnlBookReserveborder.Controls.Add(this.panel14);
            this.pnlBookReserveborder.Controls.Add(this.panel17);
            this.pnlBookReserveborder.Controls.Add(this.btnBookReservations);
            this.pnlBookReserveborder.Controls.Add(this.panel4);
            this.pnlBookReserveborder.Controls.Add(this.panel5);
            this.pnlBookReserveborder.Controls.Add(this.timedecoy);
            this.pnlBookReserveborder.Controls.Add(this.label7);
            this.pnlBookReserveborder.Controls.Add(this.tabledecoy);
            this.pnlBookReserveborder.Controls.Add(this.label5);
            this.pnlBookReserveborder.Controls.Add(this.label3);
            this.pnlBookReserveborder.Controls.Add(this.pictureBox2);
            this.pnlBookReserveborder.Controls.Add(this.panel15);
            this.pnlBookReserveborder.Controls.Add(this.cmbResTable);
            this.pnlBookReserveborder.Controls.Add(this.cbAmPm);
            this.pnlBookReserveborder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(48)))));
            this.pnlBookReserveborder.Location = new System.Drawing.Point(16, 377);
            this.pnlBookReserveborder.Name = "pnlBookReserveborder";
            this.pnlBookReserveborder.Size = new System.Drawing.Size(920, 270);
            this.pnlBookReserveborder.TabIndex = 24;
            this.pnlBookReserveborder.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlBookReserveborder_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(197)))), ((int)(((byte)(94)))));
            this.panel2.Location = new System.Drawing.Point(481, 146);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(405, 1);
            this.panel2.TabIndex = 52;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(197)))), ((int)(((byte)(94)))));
            this.panel3.Location = new System.Drawing.Point(481, 178);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(405, 1);
            this.panel3.TabIndex = 50;
            // 
            // panel18
            // 
            this.panel18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(197)))), ((int)(((byte)(94)))));
            this.panel18.Location = new System.Drawing.Point(481, 146);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(1, 33);
            this.panel18.TabIndex = 51;
            // 
            // panel19
            // 
            this.panel19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(11)))), ((int)(((byte)(24)))));
            this.panel19.Controls.Add(this.masktime);
            this.panel19.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.panel19.Location = new System.Drawing.Point(488, 145);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(160, 35);
            this.panel19.TabIndex = 54;
            // 
            // masktime
            // 
            this.masktime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(11)))), ((int)(((byte)(24)))));
            this.masktime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.masktime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.masktime.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.masktime.Location = new System.Drawing.Point(3, 7);
            this.masktime.Mask = "00:00";
            this.masktime.Name = "masktime";
            this.masktime.Size = new System.Drawing.Size(78, 22);
            this.masktime.TabIndex = 0;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(197)))), ((int)(((byte)(94)))));
            this.panel11.Location = new System.Drawing.Point(448, 146);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(1, 35);
            this.panel11.TabIndex = 47;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(197)))), ((int)(((byte)(94)))));
            this.panel9.Location = new System.Drawing.Point(44, 146);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(405, 1);
            this.panel9.TabIndex = 46;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(197)))), ((int)(((byte)(94)))));
            this.panel7.Location = new System.Drawing.Point(44, 180);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(405, 1);
            this.panel7.TabIndex = 43;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(197)))), ((int)(((byte)(94)))));
            this.panel8.Location = new System.Drawing.Point(44, 146);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1, 35);
            this.panel8.TabIndex = 45;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(197)))), ((int)(((byte)(94)))));
            this.panel10.Location = new System.Drawing.Point(481, 77);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(405, 1);
            this.panel10.TabIndex = 40;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(197)))), ((int)(((byte)(94)))));
            this.panel12.Controls.Add(this.panel13);
            this.panel12.Location = new System.Drawing.Point(481, 77);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(1, 33);
            this.panel12.TabIndex = 41;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(197)))), ((int)(((byte)(94)))));
            this.panel13.Location = new System.Drawing.Point(0, 2);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(310, 1);
            this.panel13.TabIndex = 17;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(197)))), ((int)(((byte)(94)))));
            this.panel14.Location = new System.Drawing.Point(481, 109);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(405, 1);
            this.panel14.TabIndex = 39;
            // 
            // panel17
            // 
            this.panel17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(197)))), ((int)(((byte)(94)))));
            this.panel17.Location = new System.Drawing.Point(44, 111);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(405, 1);
            this.panel17.TabIndex = 22;
            // 
            // btnBookReservations
            // 
            this.btnBookReservations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(226)))), ((int)(((byte)(107)))));
            this.btnBookReservations.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnBookReservations.FlatAppearance.BorderSize = 0;
            this.btnBookReservations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookReservations.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookReservations.ForeColor = System.Drawing.Color.Black;
            this.btnBookReservations.Location = new System.Drawing.Point(70, 204);
            this.btnBookReservations.Name = "btnBookReservations";
            this.btnBookReservations.Size = new System.Drawing.Size(787, 44);
            this.btnBookReservations.TabIndex = 31;
            this.btnBookReservations.Text = "BOOK RESERVATION";
            this.btnBookReservations.UseVisualStyleBackColor = false;
            this.btnBookReservations.Click += new System.EventHandler(this.btnBookReservations_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(197)))), ((int)(((byte)(94)))));
            this.panel4.Location = new System.Drawing.Point(44, 77);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1, 35);
            this.panel4.TabIndex = 30;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(11)))), ((int)(((byte)(24)))));
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.txtCustomerReservation);
            this.panel5.Controls.Add(this.panel16);
            this.panel5.Location = new System.Drawing.Point(44, 77);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(405, 35);
            this.panel5.TabIndex = 28;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(197)))), ((int)(((byte)(94)))));
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(408, 1);
            this.panel6.TabIndex = 23;
            // 
            // txtCustomerReservation
            // 
            this.txtCustomerReservation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(23)))));
            this.txtCustomerReservation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCustomerReservation.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerReservation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(163)))), ((int)(((byte)(175)))));
            this.txtCustomerReservation.Location = new System.Drawing.Point(5, 8);
            this.txtCustomerReservation.Name = "txtCustomerReservation";
            this.txtCustomerReservation.Size = new System.Drawing.Size(383, 20);
            this.txtCustomerReservation.TabIndex = 32;
            this.txtCustomerReservation.Text = "Enter customer name....";
            this.txtCustomerReservation.Enter += new System.EventHandler(this.txtCustomerReservation_Enter);
            this.txtCustomerReservation.Leave += new System.EventHandler(this.txtCustomerReservation_Leave);
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(197)))), ((int)(((byte)(94)))));
            this.panel16.Location = new System.Drawing.Point(404, 2);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(1, 33);
            this.panel16.TabIndex = 29;
            // 
            // timedecoy
            // 
            this.timedecoy.AutoSize = true;
            this.timedecoy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timedecoy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(163)))), ((int)(((byte)(175)))));
            this.timedecoy.Location = new System.Drawing.Point(478, 125);
            this.timedecoy.Name = "timedecoy";
            this.timedecoy.Size = new System.Drawing.Size(41, 18);
            this.timedecoy.TabIndex = 27;
            this.timedecoy.Text = "Time";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(163)))), ((int)(((byte)(175)))));
            this.label7.Location = new System.Drawing.Point(41, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 18);
            this.label7.TabIndex = 26;
            this.label7.Text = "Date";
            // 
            // tabledecoy
            // 
            this.tabledecoy.AutoSize = true;
            this.tabledecoy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabledecoy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(163)))), ((int)(((byte)(175)))));
            this.tabledecoy.Location = new System.Drawing.Point(478, 56);
            this.tabledecoy.Name = "tabledecoy";
            this.tabledecoy.Size = new System.Drawing.Size(44, 18);
            this.tabledecoy.TabIndex = 25;
            this.tabledecoy.Text = "Table";
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.dtpResDate);
            this.panel15.Controls.Add(this.lblResDate);
            this.panel15.Location = new System.Drawing.Point(43, 146);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(406, 35);
            this.panel15.TabIndex = 49;
            // 
            // dtpResDate
            // 
            this.dtpResDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpResDate.Dock = System.Windows.Forms.DockStyle.Right;
            this.dtpResDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpResDate.Location = new System.Drawing.Point(396, 0);
            this.dtpResDate.Name = "dtpResDate";
            this.dtpResDate.Size = new System.Drawing.Size(10, 20);
            this.dtpResDate.TabIndex = 42;
            this.dtpResDate.ValueChanged += new System.EventHandler(this.dtpResDate_ValueChanged);
            // 
            // lblResDate
            // 
            this.lblResDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(11)))), ((int)(((byte)(24)))));
            this.lblResDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblResDate.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResDate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblResDate.Location = new System.Drawing.Point(0, 0);
            this.lblResDate.Name = "lblResDate";
            this.lblResDate.Size = new System.Drawing.Size(406, 35);
            this.lblResDate.TabIndex = 48;
            this.lblResDate.Text = "6/10/2026";
            this.lblResDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblResDate.Click += new System.EventHandler(this.lblResDate_Click);
            // 
            // cmbResTable
            // 
            this.cmbResTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(11)))), ((int)(((byte)(24)))));
            this.cmbResTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbResTable.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbResTable.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbResTable.ForeColor = System.Drawing.Color.Silver;
            this.cmbResTable.FormattingEnabled = true;
            this.cmbResTable.Items.AddRange(new object[] {
            "Table 1"});
            this.cmbResTable.Location = new System.Drawing.Point(481, 77);
            this.cmbResTable.Name = "cmbResTable";
            this.cmbResTable.Size = new System.Drawing.Size(405, 33);
            this.cmbResTable.TabIndex = 38;
            this.cmbResTable.SelectedIndexChanged += new System.EventHandler(this.cmbResTable_SelectedIndexChanged);
            // 
            // cbAmPm
            // 
            this.cbAmPm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(11)))), ((int)(((byte)(24)))));
            this.cbAmPm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAmPm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbAmPm.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAmPm.ForeColor = System.Drawing.Color.Silver;
            this.cbAmPm.FormattingEnabled = true;
            this.cbAmPm.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.cbAmPm.Location = new System.Drawing.Point(824, 146);
            this.cbAmPm.Name = "cbAmPm";
            this.cbAmPm.Size = new System.Drawing.Size(62, 33);
            this.cbAmPm.TabIndex = 55;
            this.cbAmPm.SelectedIndexChanged += new System.EventHandler(this.cbAmPm_SelectedIndexChanged);
            // 
            // ucReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(11)))), ((int)(((byte)(24)))));
            this.Controls.Add(this.pnlBookReserveborder);
            this.Controls.Add(this.pnlUpcomingResborder);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ucReservation";
            this.Size = new System.Drawing.Size(953, 669);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservations)).EndInit();
            this.pnlUpcomingResborder.ResumeLayout(false);
            this.pnlUpcomingResborder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnlBookReserveborder.ResumeLayout(false);
            this.pnlBookReserveborder.PerformLayout();
            this.panel19.ResumeLayout(false);
            this.panel19.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel15.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvReservations;
        private System.Windows.Forms.Panel pnlUpcomingResborder;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnlBookReserveborder;
        private System.Windows.Forms.Label timedecoy;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label tabledecoy;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.TextBox txtCustomerReservation;
        private System.Windows.Forms.Button btnBookReservations;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.ComboBox cmbResTable;
        private System.Windows.Forms.DateTimePicker dtpResDate;
        private System.Windows.Forms.Label lblResDate;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.MaskedTextBox masktime;
        private System.Windows.Forms.ComboBox cbAmPm;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTime;
    }
}
