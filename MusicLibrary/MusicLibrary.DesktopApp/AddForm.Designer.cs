
namespace MusicLibrary.DesktopApp
{
	partial class AddForm
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
			this.SongDetailsGroupBox = new System.Windows.Forms.GroupBox();
			this.BtnSave = new System.Windows.Forms.Button();
			this.AddedSongYear = new System.Windows.Forms.TextBox();
			this.AddYear = new System.Windows.Forms.Label();
			this.AddedBandName = new System.Windows.Forms.TextBox();
			this.AddedSongName = new System.Windows.Forms.TextBox();
			this.AddBand = new System.Windows.Forms.Label();
			this.AddName = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.SongDetailsGroupBox.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// SongDetailsGroupBox
			// 
			this.SongDetailsGroupBox.Controls.Add(this.BtnSave);
			this.SongDetailsGroupBox.Controls.Add(this.AddedSongYear);
			this.SongDetailsGroupBox.Controls.Add(this.AddYear);
			this.SongDetailsGroupBox.Controls.Add(this.AddedBandName);
			this.SongDetailsGroupBox.Controls.Add(this.AddedSongName);
			this.SongDetailsGroupBox.Controls.Add(this.AddBand);
			this.SongDetailsGroupBox.Controls.Add(this.AddName);
			this.SongDetailsGroupBox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.SongDetailsGroupBox.Location = new System.Drawing.Point(49, 104);
			this.SongDetailsGroupBox.Name = "SongDetailsGroupBox";
			this.SongDetailsGroupBox.Size = new System.Drawing.Size(384, 207);
			this.SongDetailsGroupBox.TabIndex = 3;
			this.SongDetailsGroupBox.TabStop = false;
			// 
			// BtnSave
			// 
			this.BtnSave.BackColor = System.Drawing.Color.Gold;
			this.BtnSave.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.BtnSave.Location = new System.Drawing.Point(135, 150);
			this.BtnSave.Name = "BtnSave";
			this.BtnSave.Size = new System.Drawing.Size(133, 36);
			this.BtnSave.TabIndex = 8;
			this.BtnSave.Text = "Save";
			this.BtnSave.UseVisualStyleBackColor = false;
			this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
			// 
			// AddedSongYear
			// 
			this.AddedSongYear.Location = new System.Drawing.Point(135, 101);
			this.AddedSongYear.Name = "AddedSongYear";
			this.AddedSongYear.Size = new System.Drawing.Size(165, 23);
			this.AddedSongYear.TabIndex = 7;
			// 
			// AddYear
			// 
			this.AddYear.AutoSize = true;
			this.AddYear.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.AddYear.Location = new System.Drawing.Point(17, 105);
			this.AddYear.Name = "AddYear";
			this.AddYear.Size = new System.Drawing.Size(60, 25);
			this.AddYear.TabIndex = 4;
			this.AddYear.Text = "Year";
			// 
			// AddedBandName
			// 
			this.AddedBandName.Location = new System.Drawing.Point(135, 65);
			this.AddedBandName.Name = "AddedBandName";
			this.AddedBandName.Size = new System.Drawing.Size(165, 23);
			this.AddedBandName.TabIndex = 3;
			// 
			// AddedSongName
			// 
			this.AddedSongName.Location = new System.Drawing.Point(135, 28);
			this.AddedSongName.Name = "AddedSongName";
			this.AddedSongName.Size = new System.Drawing.Size(165, 23);
			this.AddedSongName.TabIndex = 2;
			// 
			// AddBand
			// 
			this.AddBand.AutoSize = true;
			this.AddBand.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.AddBand.Location = new System.Drawing.Point(17, 65);
			this.AddBand.Name = "AddBand";
			this.AddBand.Size = new System.Drawing.Size(65, 25);
			this.AddBand.TabIndex = 1;
			this.AddBand.Text = "Band";
			// 
			// AddName
			// 
			this.AddName.AutoSize = true;
			this.AddName.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.AddName.Location = new System.Drawing.Point(17, 31);
			this.AddName.Name = "AddName";
			this.AddName.Size = new System.Drawing.Size(73, 25);
			this.AddName.TabIndex = 0;
			this.AddName.Text = "Name";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label1.Location = new System.Drawing.Point(35, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(189, 25);
			this.label1.TabIndex = 3;
			this.label1.Text = "Add Song Details";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.PeachPuff;
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(124, 31);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(263, 44);
			this.panel1.TabIndex = 4;
			// 
			// AddForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.MediumTurquoise;
			this.ClientSize = new System.Drawing.Size(480, 357);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.SongDetailsGroupBox);
			this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
			this.Name = "AddForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "AddForm";
			this.Load += new System.EventHandler(this.AddForm_Load);
			this.SongDetailsGroupBox.ResumeLayout(false);
			this.SongDetailsGroupBox.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox SongDetailsGroupBox;
		private System.Windows.Forms.Button BtnSave;
		private System.Windows.Forms.TextBox AddedSongYear;
		private System.Windows.Forms.Label AddYear;
		private System.Windows.Forms.TextBox AddedBandName;
		private System.Windows.Forms.TextBox AddedSongName;
		private System.Windows.Forms.Label AddBand;
		private System.Windows.Forms.Label AddName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
	}
}