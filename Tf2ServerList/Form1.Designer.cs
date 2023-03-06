
namespace Tf2ServerList
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Exit = new System.Windows.Forms.PictureBox();
            this.StartTesting = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Rank = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ServerName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PlayersCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IpAdress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CopyIndicator = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartTesting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CopyIndicator)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(203)))), ((int)(((byte)(220)))));
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Edit Undo BRK", 8.25F);
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(105)))), ((int)(((byte)(136)))));
            this.textBox1.Location = new System.Drawing.Point(36, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(749, 17);
            this.textBox1.TabIndex = 80;
            this.textBox1.Text = "Server is ONLINE.";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(155)))), ((int)(((byte)(180)))));
            this.Exit.BackgroundImage = global::Tf2ServerList.Properties.Resources.Exit;
            this.Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Exit.Location = new System.Drawing.Point(815, 9);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(16, 16);
            this.Exit.TabIndex = 81;
            this.Exit.TabStop = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // StartTesting
            // 
            this.StartTesting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(155)))), ((int)(((byte)(180)))));
            this.StartTesting.BackgroundImage = global::Tf2ServerList.Properties.Resources.Minimise;
            this.StartTesting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.StartTesting.Location = new System.Drawing.Point(790, 9);
            this.StartTesting.Name = "StartTesting";
            this.StartTesting.Size = new System.Drawing.Size(16, 16);
            this.StartTesting.TabIndex = 85;
            this.StartTesting.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(24, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(799, 265);
            this.pictureBox1.TabIndex = 86;
            this.pictureBox1.TabStop = false;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Rank,
            this.ServerName,
            this.PlayersCount,
            this.Status,
            this.IpAdress});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(31, 48);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(786, 252);
            this.listView1.TabIndex = 87;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDown);
            // 
            // Rank
            // 
            this.Rank.Text = "Rank";
            this.Rank.Width = 89;
            // 
            // ServerName
            // 
            this.ServerName.Text = "Server Name";
            this.ServerName.Width = 251;
            // 
            // PlayersCount
            // 
            this.PlayersCount.Text = "PlayersCount";
            this.PlayersCount.Width = 91;
            // 
            // Status
            // 
            this.Status.Text = "Status";
            this.Status.Width = 82;
            // 
            // IpAdress
            // 
            this.IpAdress.Text = "IpAdress";
            this.IpAdress.Width = 171;
            // 
            // CopyIndicator
            // 
            this.CopyIndicator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(155)))), ((int)(((byte)(180)))));
            this.CopyIndicator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CopyIndicator.Location = new System.Drawing.Point(16, 10);
            this.CopyIndicator.Name = "CopyIndicator";
            this.CopyIndicator.Size = new System.Drawing.Size(16, 16);
            this.CopyIndicator.TabIndex = 88;
            this.CopyIndicator.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BackgroundImage = global::Tf2ServerList.Properties.Resources.Back;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(847, 330);
            this.Controls.Add(this.CopyIndicator);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.StartTesting);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.textBox1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartTesting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CopyIndicator)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox Exit;
        private System.Windows.Forms.PictureBox StartTesting;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Rank;
        private System.Windows.Forms.ColumnHeader ServerName;
        private System.Windows.Forms.ColumnHeader PlayersCount;
        private System.Windows.Forms.ColumnHeader Status;
        private System.Windows.Forms.ColumnHeader IpAdress;
        private System.Windows.Forms.PictureBox CopyIndicator;
        private System.Windows.Forms.Timer timer1;
    }
}

