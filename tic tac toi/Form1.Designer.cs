namespace tic_tac_toi
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetCountsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playingHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playingHistoryToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.A1 = new System.Windows.Forms.Button();
            this.A2 = new System.Windows.Forms.Button();
            this.C1 = new System.Windows.Forms.Button();
            this.B3 = new System.Windows.Forms.Button();
            this.B2 = new System.Windows.Forms.Button();
            this.B1 = new System.Windows.Forms.Button();
            this.A3 = new System.Windows.Forms.Button();
            this.C3 = new System.Windows.Forms.Button();
            this.C2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.x_win_count = new System.Windows.Forms.Label();
            this.draw_count = new System.Windows.Forms.Label();
            this.o_win_count = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbmsg = new System.Windows.Forms.Label();
            this.pncont = new System.Windows.Forms.Panel();
            this.btend = new System.Windows.Forms.Button();
            this.btply = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.x_loos_count = new System.Windows.Forms.Label();
            this.o_loos_count = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tour_count = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.informationDataSet = new tic_tac_toi.InformationDataSet();
            this.historyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.historyTableAdapter = new tic_tac_toi.InformationDataSetTableAdapters.historyTableAdapter();
            this.tableAdapterManager = new tic_tac_toi.InformationDataSetTableAdapters.TableAdapterManager();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.pncont.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.informationDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.playingHistoryToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(285, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.resetCountsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // resetCountsToolStripMenuItem
            // 
            this.resetCountsToolStripMenuItem.Name = "resetCountsToolStripMenuItem";
            this.resetCountsToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.resetCountsToolStripMenuItem.Text = "Reset Counts";
            this.resetCountsToolStripMenuItem.Click += new System.EventHandler(this.resetCountsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // playingHistoryToolStripMenuItem
            // 
            this.playingHistoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playingHistoryToolStripMenuItem1});
            this.playingHistoryToolStripMenuItem.Name = "playingHistoryToolStripMenuItem";
            this.playingHistoryToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.playingHistoryToolStripMenuItem.Text = "PlayingHistory";
            this.playingHistoryToolStripMenuItem.Click += new System.EventHandler(this.playingHistoryToolStripMenuItem_Click);
            // 
            // playingHistoryToolStripMenuItem1
            // 
            this.playingHistoryToolStripMenuItem1.Name = "playingHistoryToolStripMenuItem1";
            this.playingHistoryToolStripMenuItem1.Size = new System.Drawing.Size(151, 22);
            this.playingHistoryToolStripMenuItem1.Text = "PlayingHistory";
            this.playingHistoryToolStripMenuItem1.Click += new System.EventHandler(this.playingHistoryToolStripMenuItem1_Click);
            // 
            // A1
            // 
            this.A1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.A1.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A1.Location = new System.Drawing.Point(18, 56);
            this.A1.Name = "A1";
            this.A1.Size = new System.Drawing.Size(75, 75);
            this.A1.TabIndex = 1;
            this.A1.UseVisualStyleBackColor = false;
            this.A1.Click += new System.EventHandler(this.butten_click);
            this.A1.MouseCaptureChanged += new System.EventHandler(this.A1_MouseCaptureChanged);
            this.A1.MouseEnter += new System.EventHandler(this.button_enter);
            this.A1.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // A2
            // 
            this.A2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.A2.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A2.Location = new System.Drawing.Point(99, 56);
            this.A2.Name = "A2";
            this.A2.Size = new System.Drawing.Size(75, 75);
            this.A2.TabIndex = 2;
            this.A2.UseVisualStyleBackColor = false;
            this.A2.Click += new System.EventHandler(this.butten_click);
            this.A2.MouseCaptureChanged += new System.EventHandler(this.A1_MouseCaptureChanged);
            this.A2.MouseEnter += new System.EventHandler(this.button_enter);
            this.A2.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // C1
            // 
            this.C1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.C1.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C1.Location = new System.Drawing.Point(18, 218);
            this.C1.Name = "C1";
            this.C1.Size = new System.Drawing.Size(75, 75);
            this.C1.TabIndex = 3;
            this.C1.UseVisualStyleBackColor = false;
            this.C1.Click += new System.EventHandler(this.butten_click);
            this.C1.MouseCaptureChanged += new System.EventHandler(this.A1_MouseCaptureChanged);
            this.C1.MouseEnter += new System.EventHandler(this.button_enter);
            this.C1.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // B3
            // 
            this.B3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.B3.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B3.Location = new System.Drawing.Point(180, 137);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(75, 75);
            this.B3.TabIndex = 4;
            this.B3.UseVisualStyleBackColor = false;
            this.B3.Click += new System.EventHandler(this.butten_click);
            this.B3.MouseCaptureChanged += new System.EventHandler(this.A1_MouseCaptureChanged);
            this.B3.MouseEnter += new System.EventHandler(this.button_enter);
            this.B3.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // B2
            // 
            this.B2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.B2.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B2.Location = new System.Drawing.Point(99, 137);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(75, 75);
            this.B2.TabIndex = 5;
            this.B2.UseVisualStyleBackColor = false;
            this.B2.Click += new System.EventHandler(this.butten_click);
            this.B2.MouseCaptureChanged += new System.EventHandler(this.A1_MouseCaptureChanged);
            this.B2.MouseEnter += new System.EventHandler(this.button_enter);
            this.B2.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // B1
            // 
            this.B1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.B1.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B1.Location = new System.Drawing.Point(18, 137);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(75, 75);
            this.B1.TabIndex = 6;
            this.B1.UseVisualStyleBackColor = false;
            this.B1.Click += new System.EventHandler(this.butten_click);
            this.B1.MouseCaptureChanged += new System.EventHandler(this.A1_MouseCaptureChanged);
            this.B1.MouseEnter += new System.EventHandler(this.button_enter);
            this.B1.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // A3
            // 
            this.A3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.A3.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A3.Location = new System.Drawing.Point(180, 56);
            this.A3.Name = "A3";
            this.A3.Size = new System.Drawing.Size(75, 75);
            this.A3.TabIndex = 7;
            this.A3.UseVisualStyleBackColor = false;
            this.A3.Click += new System.EventHandler(this.butten_click);
            this.A3.MouseCaptureChanged += new System.EventHandler(this.A1_MouseCaptureChanged);
            this.A3.MouseEnter += new System.EventHandler(this.button_enter);
            this.A3.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // C3
            // 
            this.C3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.C3.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C3.Location = new System.Drawing.Point(180, 218);
            this.C3.Name = "C3";
            this.C3.Size = new System.Drawing.Size(75, 75);
            this.C3.TabIndex = 8;
            this.C3.UseVisualStyleBackColor = false;
            this.C3.Click += new System.EventHandler(this.butten_click);
            this.C3.MouseCaptureChanged += new System.EventHandler(this.A1_MouseCaptureChanged);
            this.C3.MouseEnter += new System.EventHandler(this.button_enter);
            this.C3.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // C2
            // 
            this.C2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.C2.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C2.Location = new System.Drawing.Point(99, 218);
            this.C2.Name = "C2";
            this.C2.Size = new System.Drawing.Size(75, 75);
            this.C2.TabIndex = 9;
            this.C2.UseVisualStyleBackColor = false;
            this.C2.Click += new System.EventHandler(this.butten_click);
            this.C2.MouseCaptureChanged += new System.EventHandler(this.A1_MouseCaptureChanged);
            this.C2.MouseEnter += new System.EventHandler(this.button_enter);
            this.C2.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 309);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 14);
            this.label1.TabIndex = 10;
            this.label1.Text = "Player 1  ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 362);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Tie";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 336);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Player 2";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // x_win_count
            // 
            this.x_win_count.AutoSize = true;
            this.x_win_count.Location = new System.Drawing.Point(114, 310);
            this.x_win_count.Name = "x_win_count";
            this.x_win_count.Size = new System.Drawing.Size(13, 13);
            this.x_win_count.TabIndex = 13;
            this.x_win_count.Text = "0";
            this.x_win_count.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // draw_count
            // 
            this.draw_count.AutoSize = true;
            this.draw_count.Location = new System.Drawing.Point(114, 362);
            this.draw_count.Name = "draw_count";
            this.draw_count.Size = new System.Drawing.Size(13, 13);
            this.draw_count.TabIndex = 14;
            this.draw_count.Text = "0";
            this.draw_count.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // o_win_count
            // 
            this.o_win_count.AutoSize = true;
            this.o_win_count.Location = new System.Drawing.Point(114, 336);
            this.o_win_count.Name = "o_win_count";
            this.o_win_count.Size = new System.Drawing.Size(13, 13);
            this.o_win_count.TabIndex = 15;
            this.o_win_count.Text = "0";
            this.o_win_count.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(114, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 16;
            // 
            // lbmsg
            // 
            this.lbmsg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbmsg.AutoSize = true;
            this.lbmsg.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmsg.ForeColor = System.Drawing.Color.Red;
            this.lbmsg.Location = new System.Drawing.Point(31, 42);
            this.lbmsg.Name = "lbmsg";
            this.lbmsg.Size = new System.Drawing.Size(50, 23);
            this.lbmsg.TabIndex = 17;
            this.lbmsg.Text = "msg";
            this.lbmsg.Click += new System.EventHandler(this.lbmsg_Click);
            // 
            // pncont
            // 
            this.pncont.Controls.Add(this.btend);
            this.pncont.Controls.Add(this.btply);
            this.pncont.Controls.Add(this.lbmsg);
            this.pncont.Location = new System.Drawing.Point(18, 92);
            this.pncont.Name = "pncont";
            this.pncont.Size = new System.Drawing.Size(237, 165);
            this.pncont.TabIndex = 18;
            this.pncont.Visible = false;
            this.pncont.Paint += new System.Windows.Forms.PaintEventHandler(this.pncont_Paint);
            // 
            // btend
            // 
            this.btend.Location = new System.Drawing.Point(20, 126);
            this.btend.Name = "btend";
            this.btend.Size = new System.Drawing.Size(75, 23);
            this.btend.TabIndex = 19;
            this.btend.Text = "End Game";
            this.btend.UseVisualStyleBackColor = true;
            this.btend.Click += new System.EventHandler(this.btend_Click);
            // 
            // btply
            // 
            this.btply.Location = new System.Drawing.Point(152, 126);
            this.btply.Name = "btply";
            this.btply.Size = new System.Drawing.Size(75, 23);
            this.btply.TabIndex = 18;
            this.btply.Text = "Play Again";
            this.btply.UseVisualStyleBackColor = true;
            this.btply.Click += new System.EventHandler(this.btply_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(95, 388);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(79, 13);
            this.linkLabel1.TabIndex = 19;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "ahmad_fatemh";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // x_loos_count
            // 
            this.x_loos_count.AutoSize = true;
            this.x_loos_count.Location = new System.Drawing.Point(143, 309);
            this.x_loos_count.Name = "x_loos_count";
            this.x_loos_count.Size = new System.Drawing.Size(13, 13);
            this.x_loos_count.TabIndex = 20;
            this.x_loos_count.Text = "0";
            this.x_loos_count.Visible = false;
            // 
            // o_loos_count
            // 
            this.o_loos_count.AutoSize = true;
            this.o_loos_count.Location = new System.Drawing.Point(143, 336);
            this.o_loos_count.Name = "o_loos_count";
            this.o_loos_count.Size = new System.Drawing.Size(13, 13);
            this.o_loos_count.TabIndex = 21;
            this.o_loos_count.Text = "0";
            this.o_loos_count.Visible = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(139, 27);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(116, 20);
            this.dateTimePicker1.TabIndex = 22;
            // 
            // tour_count
            // 
            this.tour_count.AutoSize = true;
            this.tour_count.Location = new System.Drawing.Point(86, 34);
            this.tour_count.Name = "tour_count";
            this.tour_count.Size = new System.Drawing.Size(13, 13);
            this.tour_count.TabIndex = 23;
            this.tour_count.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Tour Count";
            // 
            // informationDataSet
            // 
            this.informationDataSet.DataSetName = "InformationDataSet";
            this.informationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // historyBindingSource
            // 
            this.historyBindingSource.DataMember = "history";
            this.historyBindingSource.DataSource = this.informationDataSet;
            // 
            // historyTableAdapter
            // 
            this.historyTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.historyTableAdapter = this.historyTableAdapter;
            this.tableAdapterManager.playersInfoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = tic_tac_toi.InformationDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 323);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "--------------------------------------";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 349);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "--------------------------------------";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(285, 410);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tour_count);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.o_loos_count);
            this.Controls.Add(this.x_loos_count);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.pncont);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.o_win_count);
            this.Controls.Add(this.draw_count);
            this.Controls.Add(this.x_win_count);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.C2);
            this.Controls.Add(this.C3);
            this.Controls.Add(this.A3);
            this.Controls.Add(this.B1);
            this.Controls.Add(this.B2);
            this.Controls.Add(this.B3);
            this.Controls.Add(this.C1);
            this.Controls.Add(this.A2);
            this.Controls.Add(this.A1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic Tac Toe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pncont.ResumeLayout(false);
            this.pncont.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.informationDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button A1;
        private System.Windows.Forms.Button A2;
        private System.Windows.Forms.Button C1;
        private System.Windows.Forms.Button B3;
        private System.Windows.Forms.Button B2;
        private System.Windows.Forms.Button B1;
        private System.Windows.Forms.Button A3;
        private System.Windows.Forms.Button C3;
        private System.Windows.Forms.Button C2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label x_win_count;
        private System.Windows.Forms.Label draw_count;
        private System.Windows.Forms.Label o_win_count;
        private System.Windows.Forms.ToolStripMenuItem resetCountsToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbmsg;
        private System.Windows.Forms.Panel pncont;
        private System.Windows.Forms.Button btend;
        private System.Windows.Forms.Button btply;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label x_loos_count;
        private System.Windows.Forms.Label o_loos_count;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label tour_count;
        private System.Windows.Forms.Label label5;
        private InformationDataSet informationDataSet;
        private System.Windows.Forms.BindingSource historyBindingSource;
        private InformationDataSetTableAdapters.historyTableAdapter historyTableAdapter;
        private InformationDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolStripMenuItem playingHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playingHistoryToolStripMenuItem1;

    }
}

