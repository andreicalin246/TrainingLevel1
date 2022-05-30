
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
			this.SongDetailsGroupBox.SuspendLayout();
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
			this.SongDetailsGroupBox.Location = new System.Drawing.Point(57, 97);
			this.SongDetailsGroupBox.Name = "SongDetailsGroupBox";
			this.SongDetailsGroupBox.Size = new System.Drawing.Size(336, 194);
			this.SongDetailsGroupBox.TabIndex = 3;
			this.SongDetailsGroupBox.TabStop = false;
			// 
			// BtnSave
			// 
			this.BtnSave.BackColor = System.Drawing.Color.Gold;
			this.BtnSave.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.BtnSave.Location = new System.Drawing.Point(118, 141);
			this.BtnSave.Name = "BtnSave";
			this.BtnSave.Size = new System.Drawing.Size(116, 34);
			this.BtnSave.TabIndex = 8;
			this.BtnSave.Text = "Save";
			this.BtnSave.UseVisualStyleBackColor = false;
			this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
			// 
			// AddedSongYear
			// 
			this.AddedSongYear.Location = new System.Drawing.Point(118, 95);
			this.AddedSongYear.Name = "AddedSongYear";
			this.AddedSongYear.Size = new System.Drawing.Size(145, 23);
			this.AddedSongYear.TabIndex = 7;
			// 
			// AddYear
			// 
			this.AddYear.AutoSize = true;
			this.AddYear.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.AddYear.Location = new System.Drawing.Point(15, 98);
			this.AddYear.Name = "AddYear";
			this.AddYear.Size = new System.Drawing.Size(60, 25);
			this.AddYear.TabIndex = 4;
			this.AddYear.Text = "Year";
			// 
			// AddedBandName
			// 
			this.AddedBandName.Location = new System.Drawing.Point(118, 61);
			this.AddedBandName.Name = "AddedBandName";
			this.AddedBandName.Size = new System.Drawing.Size(145, 23);
			this.AddedBandName.TabIndex = 3;
			// 
			// AddedSongName
			// 
			this.AddedSongName.Location = new System.Drawing.Point(118, 26);
			this.AddedSongName.Name = "AddedSongName";
			this.AddedSongName.Size = new System.Drawing.Size(145, 23);
			this.AddedSongName.TabIndex = 2;
			// 
			// AddBand
			// 
			this.AddBand.AutoSize = true;
			this.AddBand.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.AddBand.Location = new System.Drawing.Point(15, 61);
			this.AddBand.Name = "AddBand";
			this.AddBand.Size = new System.Drawing.Size(65, 25);
			this.AddBand.TabIndex = 1;
			this.AddBand.Text = "Band";
			// 
			// AddName
			// 
			this.AddName.AutoSize = true;
			this.AddName.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.AddName.Location = new System.Drawing.Point(15, 29);
			this.AddName.Name = "AddName";
			this.AddName.Size = new System.Drawing.Size(73, 25);
			this.AddName.TabIndex = 0;
			this.AddName.Text = "Name";
			// 
			// AddForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(466, 382);
			this.Controls.Add(this.SongDetailsGroupBox);
			this.Name = "AddForm";
			this.Text = "AddForm";
			this.Load += new System.EventHandler(this.AddForm_Load);
			this.SongDetailsGroupBox.ResumeLayout(false);
			this.SongDetailsGroupBox.PerformLayout();
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
	}
}