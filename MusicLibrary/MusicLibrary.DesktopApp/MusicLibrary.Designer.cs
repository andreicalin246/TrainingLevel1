namespace MusicLibrary.DesktopApp
{
    partial class MusicLibrary
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusicLibrary));
			this.SongList = new System.Windows.Forms.ListBox();
			this.BtnList = new System.Windows.Forms.Button();
			this.BtnRemove = new System.Windows.Forms.Button();
			this.BtnEdit = new System.Windows.Forms.Button();
			this.PictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.BtnAdd = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// SongList
			// 
			this.SongList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.SongList.BackColor = System.Drawing.Color.Linen;
			this.SongList.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.SongList.FormattingEnabled = true;
			this.SongList.ItemHeight = 16;
			this.SongList.Location = new System.Drawing.Point(12, 263);
			this.SongList.Name = "SongList";
			this.SongList.Size = new System.Drawing.Size(529, 180);
			this.SongList.TabIndex = 0;
			// 
			// BtnList
			// 
			this.BtnList.BackColor = System.Drawing.Color.GreenYellow;
			this.BtnList.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.BtnList.Location = new System.Drawing.Point(12, 223);
			this.BtnList.Name = "BtnList";
			this.BtnList.Size = new System.Drawing.Size(128, 34);
			this.BtnList.TabIndex = 1;
			this.BtnList.Text = "List Songs";
			this.BtnList.UseVisualStyleBackColor = false;
			this.BtnList.Click += new System.EventHandler(this.BtnList_Click);
			// 
			// BtnRemove
			// 
			this.BtnRemove.BackColor = System.Drawing.Color.Tomato;
			this.BtnRemove.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.BtnRemove.Location = new System.Drawing.Point(414, 223);
			this.BtnRemove.Name = "BtnRemove";
			this.BtnRemove.Size = new System.Drawing.Size(128, 34);
			this.BtnRemove.TabIndex = 2;
			this.BtnRemove.Text = "Remove Song";
			this.BtnRemove.UseVisualStyleBackColor = false;
			this.BtnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
			// 
			// BtnEdit
			// 
			this.BtnEdit.BackColor = System.Drawing.Color.Turquoise;
			this.BtnEdit.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.BtnEdit.Location = new System.Drawing.Point(280, 223);
			this.BtnEdit.Name = "BtnEdit";
			this.BtnEdit.Size = new System.Drawing.Size(128, 34);
			this.BtnEdit.TabIndex = 3;
			this.BtnEdit.Text = "Edit Song";
			this.BtnEdit.UseVisualStyleBackColor = false;
			this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
			// 
			// PictureBox1
			// 
			this.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
			this.PictureBox1.Location = new System.Drawing.Point(126, 39);
			this.PictureBox1.Name = "PictureBox1";
			this.PictureBox1.Size = new System.Drawing.Size(278, 129);
			this.PictureBox1.TabIndex = 4;
			this.PictureBox1.TabStop = false;
			// 
			// panel1
			// 
			this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.panel1.BackColor = System.Drawing.SystemColors.Window;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(126, 4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(278, 34);
			this.panel1.TabIndex = 6;
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
			this.label1.Location = new System.Drawing.Point(-1, -1);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(275, 30);
			this.label1.TabIndex = 0;
			this.label1.Text = "Welcome to Music Library!";
			// 
			// BtnAdd
			// 
			this.BtnAdd.BackColor = System.Drawing.Color.GreenYellow;
			this.BtnAdd.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.BtnAdd.Location = new System.Drawing.Point(146, 223);
			this.BtnAdd.Name = "BtnAdd";
			this.BtnAdd.Size = new System.Drawing.Size(128, 34);
			this.BtnAdd.TabIndex = 7;
			this.BtnAdd.Text = "Add Song";
			this.BtnAdd.UseVisualStyleBackColor = false;
			//this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
			// 
			// MusicLibrary
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(553, 443);
			this.Controls.Add(this.BtnAdd);
			this.Controls.Add(this.SongList);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.PictureBox1);
			this.Controls.Add(this.BtnEdit);
			this.Controls.Add(this.BtnRemove);
			this.Controls.Add(this.BtnList);
			this.Name = "MusicLibrary";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Music Library";
			((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox SongList;
        private System.Windows.Forms.Button BtnList;
		private System.Windows.Forms.Button BtnRemove;
		private System.Windows.Forms.Button BtnEdit;
		private System.Windows.Forms.PictureBox PictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button BtnAdd;
	}
}
