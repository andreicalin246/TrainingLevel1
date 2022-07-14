
namespace MusicLibrary.DesktopApp
{
	partial class EditForm
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
			this.SongYear = new System.Windows.Forms.TextBox();
			this.EditYear = new System.Windows.Forms.Label();
			this.BandName = new System.Windows.Forms.TextBox();
			this.SongName = new System.Windows.Forms.TextBox();
			this.EditBand = new System.Windows.Forms.Label();
			this.EditName = new System.Windows.Forms.Label();
			this.EditSongPanel = new System.Windows.Forms.Panel();
			this.EditSongDetailsLabel = new System.Windows.Forms.Label();
			this.SongDetailsGroupBox.SuspendLayout();
			this.EditSongPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// SongDetailsGroupBox
			// 
			this.SongDetailsGroupBox.Controls.Add(this.BtnSave);
			this.SongDetailsGroupBox.Controls.Add(this.SongYear);
			this.SongDetailsGroupBox.Controls.Add(this.EditYear);
			this.SongDetailsGroupBox.Controls.Add(this.BandName);
			this.SongDetailsGroupBox.Controls.Add(this.SongName);
			this.SongDetailsGroupBox.Controls.Add(this.EditBand);
			this.SongDetailsGroupBox.Controls.Add(this.EditName);
			this.SongDetailsGroupBox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.SongDetailsGroupBox.Location = new System.Drawing.Point(34, 68);
			this.SongDetailsGroupBox.Name = "SongDetailsGroupBox";
			this.SongDetailsGroupBox.Size = new System.Drawing.Size(336, 181);
			this.SongDetailsGroupBox.TabIndex = 2;
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
			// SongYear
			// 
			this.SongYear.Location = new System.Drawing.Point(118, 95);
			this.SongYear.Name = "SongYear";
			this.SongYear.Size = new System.Drawing.Size(145, 23);
			this.SongYear.TabIndex = 7;
			// 
			// EditYear
			// 
			this.EditYear.AutoSize = true;
			this.EditYear.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.EditYear.Location = new System.Drawing.Point(15, 98);
			this.EditYear.Name = "EditYear";
			this.EditYear.Size = new System.Drawing.Size(60, 25);
			this.EditYear.TabIndex = 4;
			this.EditYear.Text = "Year";
			// 
			// BandName
			// 
			this.BandName.Location = new System.Drawing.Point(118, 61);
			this.BandName.Name = "BandName";
			this.BandName.Size = new System.Drawing.Size(145, 23);
			this.BandName.TabIndex = 3;
			// 
			// SongName
			// 
			this.SongName.Location = new System.Drawing.Point(118, 26);
			this.SongName.Name = "SongName";
			this.SongName.Size = new System.Drawing.Size(145, 23);
			this.SongName.TabIndex = 2;
			// 
			// EditBand
			// 
			this.EditBand.AutoSize = true;
			this.EditBand.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.EditBand.Location = new System.Drawing.Point(15, 61);
			this.EditBand.Name = "EditBand";
			this.EditBand.Size = new System.Drawing.Size(65, 25);
			this.EditBand.TabIndex = 1;
			this.EditBand.Text = "Band";
			// 
			// EditName
			// 
			this.EditName.AutoSize = true;
			this.EditName.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.EditName.Location = new System.Drawing.Point(15, 29);
			this.EditName.Name = "EditName";
			this.EditName.Size = new System.Drawing.Size(73, 25);
			this.EditName.TabIndex = 0;
			this.EditName.Text = "Name";
			// 
			// EditSongPanel
			// 
			this.EditSongPanel.BackColor = System.Drawing.Color.PeachPuff;
			this.EditSongPanel.Controls.Add(this.EditSongDetailsLabel);
			this.EditSongPanel.Location = new System.Drawing.Point(91, 12);
			this.EditSongPanel.Name = "EditSongPanel";
			this.EditSongPanel.Size = new System.Drawing.Size(230, 41);
			this.EditSongPanel.TabIndex = 4;
			// 
			// EditSongDetailsLabel
			// 
			this.EditSongDetailsLabel.AutoSize = true;
			this.EditSongDetailsLabel.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.EditSongDetailsLabel.Location = new System.Drawing.Point(23, 6);
			this.EditSongDetailsLabel.Name = "EditSongDetailsLabel";
			this.EditSongDetailsLabel.Size = new System.Drawing.Size(190, 25);
			this.EditSongDetailsLabel.TabIndex = 3;
			this.EditSongDetailsLabel.Text = "Edit Song Details";
			// 
			// EditForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.MediumTurquoise;
			this.ClientSize = new System.Drawing.Size(422, 316);
			this.Controls.Add(this.EditSongPanel);
			this.Controls.Add(this.SongDetailsGroupBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
			this.Name = "EditForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "EditForm";
			this.Load += new System.EventHandler(this.EditForm_Load);
			this.SongDetailsGroupBox.ResumeLayout(false);
			this.SongDetailsGroupBox.PerformLayout();
			this.EditSongPanel.ResumeLayout(false);
			this.EditSongPanel.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox SongDetailsGroupBox;
		private System.Windows.Forms.TextBox BandName;
		private System.Windows.Forms.TextBox SongName;
		private System.Windows.Forms.Label EditBand;
		private System.Windows.Forms.Label EditName;
		private System.Windows.Forms.TextBox SongYear;
		private System.Windows.Forms.Label EditYear;
		private System.Windows.Forms.Button BtnSave;
		private System.Windows.Forms.Panel EditSongPanel;
		private System.Windows.Forms.Label EditSongDetailsLabel;
	}
}