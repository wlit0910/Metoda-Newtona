namespace Metoda_Newtona
{
	partial class Interpolator
	{
		/// <summary>
		/// Wymagana zmienna projektanta.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Wyczyść wszystkie używane zasoby.
		/// </summary>
		/// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Kod generowany przez Projektanta formularzy systemu Windows

		/// <summary>
		/// Metoda wymagana do obsługi projektanta — nie należy modyfikować
		/// jej zawartości w edytorze kodu.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Interpolator));
			this.label6 = new System.Windows.Forms.Label();
			this.IsCorrectButton = new System.Windows.Forms.Button();
			this.zeroPlaceTextBox = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.resetButton = new System.Windows.Forms.Button();
			this.iterationsTextBox = new System.Windows.Forms.TextBox();
			this.deltaTextBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.calculateButton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.epsilonTextBox = new System.Windows.Forms.TextBox();
			this.pointXTextBox = new System.Windows.Forms.TextBox();
			this.label1PodajPunktStartowy = new System.Windows.Forms.Label();
			this.labelPodajWielomian = new System.Windows.Forms.Label();
			this.parametersTextBox = new System.Windows.Forms.TextBox();
			this.saveButton = new System.Windows.Forms.Button();
			this.logRichTextBox = new System.Windows.Forms.RichTextBox();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.schematWprowadzaniaDanychToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.autorzyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.oProgramieToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.pictureBox6 = new System.Windows.Forms.PictureBox();
			this.button1 = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
			this.SuspendLayout();
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label6.Location = new System.Drawing.Point(291, 159);
			this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(17, 18);
			this.label6.TabIndex = 38;
			this.label6.Text = "ẟ";
			// 
			// IsCorrectButton
			// 
			this.IsCorrectButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.IsCorrectButton.Location = new System.Drawing.Point(432, 273);
			this.IsCorrectButton.Margin = new System.Windows.Forms.Padding(2);
			this.IsCorrectButton.Name = "IsCorrectButton";
			this.IsCorrectButton.Size = new System.Drawing.Size(72, 51);
			this.IsCorrectButton.TabIndex = 36;
			this.IsCorrectButton.Text = "Sprawdź\r\nmiejsce zerowe";
			this.IsCorrectButton.UseVisualStyleBackColor = false;
			this.IsCorrectButton.Click += new System.EventHandler(this.IsCorrectButton_Click);
			// 
			// zeroPlaceTextBox
			// 
			this.zeroPlaceTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.zeroPlaceTextBox.Location = new System.Drawing.Point(523, 236);
			this.zeroPlaceTextBox.Margin = new System.Windows.Forms.Padding(2);
			this.zeroPlaceTextBox.Name = "zeroPlaceTextBox";
			this.zeroPlaceTextBox.ReadOnly = true;
			this.zeroPlaceTextBox.Size = new System.Drawing.Size(156, 20);
			this.zeroPlaceTextBox.TabIndex = 35;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(324, 236);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(83, 13);
			this.label4.TabIndex = 34;
			this.label4.Text = "Miejsce zerowe:";
			// 
			// resetButton
			// 
			this.resetButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.resetButton.Location = new System.Drawing.Point(538, 273);
			this.resetButton.Margin = new System.Windows.Forms.Padding(2);
			this.resetButton.Name = "resetButton";
			this.resetButton.Size = new System.Drawing.Size(72, 51);
			this.resetButton.TabIndex = 33;
			this.resetButton.Text = "Resetuj\r\nwszystko";
			this.resetButton.UseVisualStyleBackColor = false;
			this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
			// 
			// iterationsTextBox
			// 
			this.iterationsTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.iterationsTextBox.Location = new System.Drawing.Point(523, 202);
			this.iterationsTextBox.Margin = new System.Windows.Forms.Padding(2);
			this.iterationsTextBox.Name = "iterationsTextBox";
			this.iterationsTextBox.Size = new System.Drawing.Size(156, 20);
			this.iterationsTextBox.TabIndex = 32;
			this.iterationsTextBox.Text = "100";
			// 
			// deltaTextBox
			// 
			this.deltaTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.deltaTextBox.Location = new System.Drawing.Point(523, 161);
			this.deltaTextBox.Margin = new System.Windows.Forms.Padding(2);
			this.deltaTextBox.Name = "deltaTextBox";
			this.deltaTextBox.Size = new System.Drawing.Size(156, 20);
			this.deltaTextBox.TabIndex = 31;
			this.deltaTextBox.Text = "0,001";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(324, 202);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(132, 13);
			this.label3.TabIndex = 30;
			this.label3.Text = "Maksymalna liczba iteracji:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(324, 164);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(189, 13);
			this.label2.TabIndex = 29;
			this.label2.Text = "Dokładność wyznaczania pierwiastka:";
			// 
			// calculateButton
			// 
			this.calculateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.calculateButton.Location = new System.Drawing.Point(327, 273);
			this.calculateButton.Margin = new System.Windows.Forms.Padding(2);
			this.calculateButton.Name = "calculateButton";
			this.calculateButton.Size = new System.Drawing.Size(72, 51);
			this.calculateButton.TabIndex = 28;
			this.calculateButton.Text = "Oblicz\r\nmiejsce zerowe";
			this.calculateButton.UseVisualStyleBackColor = false;
			this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(324, 130);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(166, 13);
			this.label1.TabIndex = 27;
			this.label1.Text = "Dokładność porównania z zerem:";
			// 
			// epsilonTextBox
			// 
			this.epsilonTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.epsilonTextBox.Location = new System.Drawing.Point(523, 123);
			this.epsilonTextBox.Margin = new System.Windows.Forms.Padding(2);
			this.epsilonTextBox.Name = "epsilonTextBox";
			this.epsilonTextBox.Size = new System.Drawing.Size(156, 20);
			this.epsilonTextBox.TabIndex = 26;
			this.epsilonTextBox.Text = "0,001";
			// 
			// pointXTextBox
			// 
			this.pointXTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.pointXTextBox.Location = new System.Drawing.Point(523, 87);
			this.pointXTextBox.Margin = new System.Windows.Forms.Padding(2);
			this.pointXTextBox.Name = "pointXTextBox";
			this.pointXTextBox.Size = new System.Drawing.Size(156, 20);
			this.pointXTextBox.TabIndex = 25;
			this.pointXTextBox.Text = "9";
			// 
			// label1PodajPunktStartowy
			// 
			this.label1PodajPunktStartowy.AutoSize = true;
			this.label1PodajPunktStartowy.Location = new System.Drawing.Point(324, 94);
			this.label1PodajPunktStartowy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1PodajPunktStartowy.Name = "label1PodajPunktStartowy";
			this.label1PodajPunktStartowy.Size = new System.Drawing.Size(123, 13);
			this.label1PodajPunktStartowy.TabIndex = 24;
			this.label1PodajPunktStartowy.Text = "Podaj punkt startowy x0:";
			// 
			// labelPodajWielomian
			// 
			this.labelPodajWielomian.AutoSize = true;
			this.labelPodajWielomian.Location = new System.Drawing.Point(324, 43);
			this.labelPodajWielomian.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelPodajWielomian.Name = "labelPodajWielomian";
			this.labelPodajWielomian.Size = new System.Drawing.Size(110, 26);
			this.labelPodajWielomian.TabIndex = 23;
			this.labelPodajWielomian.Text = "Podaj wzór funkcji\r\nw postaci wielomianu:";
			// 
			// parametersTextBox
			// 
			this.parametersTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.parametersTextBox.Location = new System.Drawing.Point(523, 49);
			this.parametersTextBox.Margin = new System.Windows.Forms.Padding(2);
			this.parametersTextBox.Name = "parametersTextBox";
			this.parametersTextBox.Size = new System.Drawing.Size(156, 20);
			this.parametersTextBox.TabIndex = 22;
			this.parametersTextBox.Text = "9;8;7;6";
			// 
			// saveButton
			// 
			this.saveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.saveButton.Location = new System.Drawing.Point(523, 736);
			this.saveButton.Margin = new System.Windows.Forms.Padding(2);
			this.saveButton.Name = "saveButton";
			this.saveButton.Size = new System.Drawing.Size(92, 44);
			this.saveButton.TabIndex = 40;
			this.saveButton.Text = "Zapisz dane\r\n do pliku";
			this.saveButton.UseVisualStyleBackColor = false;
			this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
			// 
			// logRichTextBox
			// 
			this.logRichTextBox.Location = new System.Drawing.Point(220, 337);
			this.logRichTextBox.Margin = new System.Windows.Forms.Padding(2);
			this.logRichTextBox.Name = "logRichTextBox";
			this.logRichTextBox.ReadOnly = true;
			this.logRichTextBox.Size = new System.Drawing.Size(484, 394);
			this.logRichTextBox.TabIndex = 39;
			this.logRichTextBox.Text = "";
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.autorzyToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
			this.menuStrip1.Size = new System.Drawing.Size(924, 24);
			this.menuStrip1.TabIndex = 41;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.schematWprowadzaniaDanychToolStripMenuItem});
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(50, 20);
			this.toolStripMenuItem1.Text = "Opcje";
			// 
			// schematWprowadzaniaDanychToolStripMenuItem
			// 
			this.schematWprowadzaniaDanychToolStripMenuItem.Name = "schematWprowadzaniaDanychToolStripMenuItem";
			this.schematWprowadzaniaDanychToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
			this.schematWprowadzaniaDanychToolStripMenuItem.Text = "Pomoc";
			this.schematWprowadzaniaDanychToolStripMenuItem.Click += new System.EventHandler(this.schematWprowadzaniaDanychToolStripMenuItem_Click);
			// 
			// autorzyToolStripMenuItem
			// 
			this.autorzyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oProgramieToolStripMenuItem1});
			this.autorzyToolStripMenuItem.Name = "autorzyToolStripMenuItem";
			this.autorzyToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
			this.autorzyToolStripMenuItem.Text = "Autorzy";
			// 
			// oProgramieToolStripMenuItem1
			// 
			this.oProgramieToolStripMenuItem1.Name = "oProgramieToolStripMenuItem1";
			this.oProgramieToolStripMenuItem1.Size = new System.Drawing.Size(141, 22);
			this.oProgramieToolStripMenuItem1.Text = "O programie";
			this.oProgramieToolStripMenuItem1.Click += new System.EventHandler(this.oProgramieToolStripMenuItem1_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::Metoda_Newtona.Properties.Resources.mathBackground;
			this.pictureBox1.Location = new System.Drawing.Point(728, 31);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(184, 282);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 42;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = global::Metoda_Newtona.Properties.Resources.mathBackground;
			this.pictureBox2.Location = new System.Drawing.Point(728, 310);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(184, 282);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 43;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = global::Metoda_Newtona.Properties.Resources.mathBackground;
			this.pictureBox3.Location = new System.Drawing.Point(728, 590);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(184, 189);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox3.TabIndex = 44;
			this.pictureBox3.TabStop = false;
			// 
			// pictureBox4
			// 
			this.pictureBox4.Image = global::Metoda_Newtona.Properties.Resources.mathBackground;
			this.pictureBox4.Location = new System.Drawing.Point(12, 590);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(184, 189);
			this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox4.TabIndex = 47;
			this.pictureBox4.TabStop = false;
			// 
			// pictureBox5
			// 
			this.pictureBox5.Image = global::Metoda_Newtona.Properties.Resources.mathBackground;
			this.pictureBox5.Location = new System.Drawing.Point(12, 310);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(184, 282);
			this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox5.TabIndex = 46;
			this.pictureBox5.TabStop = false;
			// 
			// pictureBox6
			// 
			this.pictureBox6.Image = global::Metoda_Newtona.Properties.Resources.mathBackground;
			this.pictureBox6.Location = new System.Drawing.Point(12, 31);
			this.pictureBox6.Name = "pictureBox6";
			this.pictureBox6.Size = new System.Drawing.Size(184, 282);
			this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox6.TabIndex = 45;
			this.pictureBox6.TabStop = false;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.button1.Location = new System.Drawing.Point(629, 736);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 44);
			this.button1.TabIndex = 48;
			this.button1.Text = "Zamknij";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label7.Location = new System.Drawing.Point(290, 125);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(18, 20);
			this.label7.TabIndex = 49;
			this.label7.Text = "ε";
			// 
			// Interpolator
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(924, 787);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.pictureBox4);
			this.Controls.Add(this.pictureBox5);
			this.Controls.Add(this.pictureBox6);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.saveButton);
			this.Controls.Add(this.logRichTextBox);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.IsCorrectButton);
			this.Controls.Add(this.zeroPlaceTextBox);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.resetButton);
			this.Controls.Add(this.iterationsTextBox);
			this.Controls.Add(this.deltaTextBox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.calculateButton);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.epsilonTextBox);
			this.Controls.Add(this.pointXTextBox);
			this.Controls.Add(this.label1PodajPunktStartowy);
			this.Controls.Add(this.labelPodajWielomian);
			this.Controls.Add(this.parametersTextBox);
			this.Controls.Add(this.menuStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.Margin = new System.Windows.Forms.Padding(2);
			this.MaximizeBox = false;
			this.Name = "Interpolator";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Kalkulator miesca zerowego";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button IsCorrectButton;
		private System.Windows.Forms.TextBox zeroPlaceTextBox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button resetButton;
		private System.Windows.Forms.TextBox iterationsTextBox;
		private System.Windows.Forms.TextBox deltaTextBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button calculateButton;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox epsilonTextBox;
		private System.Windows.Forms.TextBox pointXTextBox;
		private System.Windows.Forms.Label label1PodajPunktStartowy;
		private System.Windows.Forms.Label labelPodajWielomian;
		private System.Windows.Forms.TextBox parametersTextBox;
		private System.Windows.Forms.Button saveButton;
		private System.Windows.Forms.RichTextBox logRichTextBox;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem schematWprowadzaniaDanychToolStripMenuItem;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.PictureBox pictureBox5;
		private System.Windows.Forms.PictureBox pictureBox6;
		private System.Windows.Forms.ToolStripMenuItem autorzyToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem oProgramieToolStripMenuItem1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label7;
	}
}

