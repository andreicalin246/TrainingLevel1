
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
            this.songDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.songYear = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bandName = new System.Windows.Forms.TextBox();
            this.songName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.songDetailsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // songDetailsGroupBox
            // 
            this.songDetailsGroupBox.Controls.Add(this.btnSave);
            this.songDetailsGroupBox.Controls.Add(this.songYear);
            this.songDetailsGroupBox.Controls.Add(this.label1);
            this.songDetailsGroupBox.Controls.Add(this.bandName);
            this.songDetailsGroupBox.Controls.Add(this.songName);
            this.songDetailsGroupBox.Controls.Add(this.label3);
            this.songDetailsGroupBox.Controls.Add(this.label2);
            this.songDetailsGroupBox.Location = new System.Drawing.Point(34, 68);
            this.songDetailsGroupBox.Name = "songDetailsGroupBox";
            this.songDetailsGroupBox.Size = new System.Drawing.Size(336, 181);
            this.songDetailsGroupBox.TabIndex = 2;
            this.songDetailsGroupBox.TabStop = false;
            this.songDetailsGroupBox.Text = "Song Details";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(118, 141);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // songYear
            // 
            this.songYear.Location = new System.Drawing.Point(118, 95);
            this.songYear.Name = "songYear";
            this.songYear.Size = new System.Drawing.Size(145, 23);
            this.songYear.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Year";
            // 
            // bandName
            // 
            this.bandName.Location = new System.Drawing.Point(118, 61);
            this.bandName.Name = "bandName";
            this.bandName.Size = new System.Drawing.Size(145, 23);
            this.bandName.TabIndex = 3;
            // 
            // songName
            // 
            this.songName.Location = new System.Drawing.Point(118, 26);
            this.songName.Name = "songName";
            this.songName.Size = new System.Drawing.Size(145, 23);
            this.songName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Band";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name";
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 316);
            this.Controls.Add(this.songDetailsGroupBox);
            this.Name = "EditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EditForm";
            this.Load += new System.EventHandler(this.EditForm_Load);
            this.songDetailsGroupBox.ResumeLayout(false);
            this.songDetailsGroupBox.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox songDetailsGroupBox;
		private System.Windows.Forms.TextBox bandName;
		private System.Windows.Forms.TextBox songName;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox songYear;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnSave;
	}
}