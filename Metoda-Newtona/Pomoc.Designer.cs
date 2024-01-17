namespace Metoda_Newtona
{
	partial class Pomoc
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pomoc));
			this.wspolczynnikiWielomianu = new System.Windows.Forms.TextBox();
			this.pointXTextBox = new System.Windows.Forms.TextBox();
			this.iterationsTextBox = new System.Windows.Forms.TextBox();
			this.epsilonTextBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.deltaTextBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label1PodajPunktStartowy = new System.Windows.Forms.Label();
			this.labelPodajWielomian = new System.Windows.Forms.Label();
			this.OkButton = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// wspolczynnikiWielomianu
			// 
			this.wspolczynnikiWielomianu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.wspolczynnikiWielomianu.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.wspolczynnikiWielomianu.Location = new System.Drawing.Point(220, 93);
			this.wspolczynnikiWielomianu.Margin = new System.Windows.Forms.Padding(2);
			this.wspolczynnikiWielomianu.Name = "wspolczynnikiWielomianu";
			this.wspolczynnikiWielomianu.ReadOnly = true;
			this.wspolczynnikiWielomianu.Size = new System.Drawing.Size(105, 21);
			this.wspolczynnikiWielomianu.TabIndex = 51;
			this.wspolczynnikiWielomianu.Text = "8;6;5;4;3;2;1";
			this.wspolczynnikiWielomianu.WordWrap = false;
			// 
			// pointXTextBox
			// 
			this.pointXTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.pointXTextBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.pointXTextBox.Location = new System.Drawing.Point(220, 162);
			this.pointXTextBox.Margin = new System.Windows.Forms.Padding(2);
			this.pointXTextBox.Name = "pointXTextBox";
			this.pointXTextBox.ReadOnly = true;
			this.pointXTextBox.Size = new System.Drawing.Size(105, 21);
			this.pointXTextBox.TabIndex = 54;
			this.pointXTextBox.Text = "-9";
			this.pointXTextBox.WordWrap = false;
			// 
			// iterationsTextBox
			// 
			this.iterationsTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.iterationsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.iterationsTextBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.iterationsTextBox.Location = new System.Drawing.Point(220, 376);
			this.iterationsTextBox.Margin = new System.Windows.Forms.Padding(2);
			this.iterationsTextBox.Name = "iterationsTextBox";
			this.iterationsTextBox.ReadOnly = true;
			this.iterationsTextBox.Size = new System.Drawing.Size(105, 21);
			this.iterationsTextBox.TabIndex = 60;
			this.iterationsTextBox.Text = "97";
			this.iterationsTextBox.WordWrap = false;
			// 
			// epsilonTextBox
			// 
			this.epsilonTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.epsilonTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.epsilonTextBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.epsilonTextBox.Location = new System.Drawing.Point(220, 224);
			this.epsilonTextBox.Margin = new System.Windows.Forms.Padding(2);
			this.epsilonTextBox.Name = "epsilonTextBox";
			this.epsilonTextBox.ReadOnly = true;
			this.epsilonTextBox.Size = new System.Drawing.Size(105, 21);
			this.epsilonTextBox.TabIndex = 55;
			this.epsilonTextBox.Text = "0,000001";
			this.epsilonTextBox.WordWrap = false;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(37, 366);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(136, 39);
			this.label3.TabIndex = 58;
			this.label3.Text = "Maksymalna liczba iteracji\r\nmusi być liczbą całkowitą i \r\ndodatnią\r\n";
			// 
			// deltaTextBox
			// 
			this.deltaTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.deltaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.deltaTextBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.deltaTextBox.Location = new System.Drawing.Point(220, 296);
			this.deltaTextBox.Margin = new System.Windows.Forms.Padding(2);
			this.deltaTextBox.Name = "deltaTextBox";
			this.deltaTextBox.ReadOnly = true;
			this.deltaTextBox.Size = new System.Drawing.Size(105, 21);
			this.deltaTextBox.TabIndex = 59;
			this.deltaTextBox.Text = "0,000001";
			this.deltaTextBox.WordWrap = false;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(37, 287);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(146, 39);
			this.label2.TabIndex = 57;
			this.label2.Text = "Dokładność wyznaczania\r\npierwiastka - liczba dziesiętna\r\nz przedziału 0,1 - 0,000" +
    "001";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(37, 218);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(136, 39);
			this.label1.TabIndex = 56;
			this.label1.Text = "Dokładność porównania\r\nz zerem - liczba dziesiętna\r\nz przedziału 0,1 - 0,000001";
			// 
			// label1PodajPunktStartowy
			// 
			this.label1PodajPunktStartowy.AutoSize = true;
			this.label1PodajPunktStartowy.Location = new System.Drawing.Point(37, 162);
			this.label1PodajPunktStartowy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1PodajPunktStartowy.Name = "label1PodajPunktStartowy";
			this.label1PodajPunktStartowy.Size = new System.Drawing.Size(99, 26);
			this.label1PodajPunktStartowy.TabIndex = 53;
			this.label1PodajPunktStartowy.Text = "Punkt startowy X0 -\r\ndowolna liczba";
			// 
			// labelPodajWielomian
			// 
			this.labelPodajWielomian.AutoSize = true;
			this.labelPodajWielomian.Location = new System.Drawing.Point(37, 75);
			this.labelPodajWielomian.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelPodajWielomian.Name = "labelPodajWielomian";
			this.labelPodajWielomian.Size = new System.Drawing.Size(152, 26);
			this.labelPodajWielomian.TabIndex = 52;
			this.labelPodajWielomian.Text = "Wzór funkcji podawany\r\njako współczynniki wielomianu";
			// 
			// OkButton
			// 
			this.OkButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.OkButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.OkButton.Location = new System.Drawing.Point(238, 443);
			this.OkButton.Name = "OkButton";
			this.OkButton.Size = new System.Drawing.Size(87, 45);
			this.OkButton.TabIndex = 69;
			this.OkButton.Text = "Rozumiem";
			this.OkButton.UseVisualStyleBackColor = false;
			this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label4.Location = new System.Drawing.Point(37, 101);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(139, 13);
			this.label4.TabIndex = 70;
			this.label4.Text = "oddzielany średnikami ;";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label5.Location = new System.Drawing.Point(16, 224);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(18, 20);
			this.label5.TabIndex = 72;
			this.label5.Text = "ε";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label6.Location = new System.Drawing.Point(17, 298);
			this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(17, 18);
			this.label6.TabIndex = 71;
			this.label6.Text = "ẟ";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label7.Location = new System.Drawing.Point(83, 9);
			this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(194, 30);
			this.label7.TabIndex = 73;
			this.label7.Text = "Jak poprawnie wpisywać dane\r\ndo kalkulatora miejsca zerowego?";
			// 
			// Pomoc
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(355, 500);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.OkButton);
			this.Controls.Add(this.wspolczynnikiWielomianu);
			this.Controls.Add(this.pointXTextBox);
			this.Controls.Add(this.iterationsTextBox);
			this.Controls.Add(this.epsilonTextBox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.deltaTextBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label1PodajPunktStartowy);
			this.Controls.Add(this.labelPodajWielomian);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(2);
			this.MaximizeBox = false;
			this.Name = "Pomoc";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Pomoc";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.TextBox wspolczynnikiWielomianu;
		private System.Windows.Forms.TextBox pointXTextBox;
		private System.Windows.Forms.TextBox iterationsTextBox;
		private System.Windows.Forms.TextBox epsilonTextBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox deltaTextBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label1PodajPunktStartowy;
		private System.Windows.Forms.Label labelPodajWielomian;
		private System.Windows.Forms.Button OkButton;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
	}
}