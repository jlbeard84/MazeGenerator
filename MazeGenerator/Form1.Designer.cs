namespace MazeGenerator
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
		protected override void Dispose (bool disposing)
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
		private void InitializeComponent ()
		{
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sizeTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cellSizeTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Generate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(161, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(675, 628);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // sizeTextBox
            // 
            this.sizeTextBox.Location = new System.Drawing.Point(12, 109);
            this.sizeTextBox.Name = "sizeTextBox";
            this.sizeTextBox.Size = new System.Drawing.Size(143, 20);
            this.sizeTextBox.TabIndex = 3;
            this.sizeTextBox.Text = "10";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Grid Size";
            // 
            // cellSizeTextBox
            // 
            this.cellSizeTextBox.Location = new System.Drawing.Point(16, 210);
            this.cellSizeTextBox.Name = "cellSizeTextBox";
            this.cellSizeTextBox.Size = new System.Drawing.Size(139, 20);
            this.cellSizeTextBox.TabIndex = 5;
            this.cellSizeTextBox.Text = "10";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cell Size";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 661);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cellSizeTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sizeTextBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Maze Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.TextBox sizeTextBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox cellSizeTextBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;

		
	}
}

