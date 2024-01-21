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
			this.sprawdzWynik_button = new System.Windows.Forms.Button();
			this.miejsceZerowe_TextBox = new System.Windows.Forms.TextBox();
			this.label_6 = new System.Windows.Forms.Label();
			this.resetuj_button = new System.Windows.Forms.Button();
			this.iteracje_TextBox = new System.Windows.Forms.TextBox();
			this.delta_TextBox = new System.Windows.Forms.TextBox();
			this.label_5 = new System.Windows.Forms.Label();
			this.label_4 = new System.Windows.Forms.Label();
			this.Oblicz_button = new System.Windows.Forms.Button();
			this.label_3 = new System.Windows.Forms.Label();
			this.epsilon_TextBox = new System.Windows.Forms.TextBox();
			this.punktStartowy_TextBox = new System.Windows.Forms.TextBox();
			this.label_2 = new System.Windows.Forms.Label();
			this.label_1 = new System.Windows.Forms.Label();
			this.wspolczynniki_textbox1 = new System.Windows.Forms.TextBox();
			this.saveButton = new System.Windows.Forms.Button();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.PomocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.autorzyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.oProgramieToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.pictureBox6 = new System.Windows.Forms.PictureBox();
			this.button1 = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
			this.SuspendLayout();
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label6.Location = new System.Drawing.Point(289, 273);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(22, 24);
			this.label6.TabIndex = 38;
			this.label6.Text = "ẟ";
			// 
			// sprawdzWynik_button
			// 
			this.sprawdzWynik_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.sprawdzWynik_button.Location = new System.Drawing.Point(736, 169);
			this.sprawdzWynik_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.sprawdzWynik_button.Name = "sprawdzWynik_button";
			this.sprawdzWynik_button.Size = new System.Drawing.Size(96, 63);
			this.sprawdzWynik_button.TabIndex = 36;
			this.sprawdzWynik_button.Text = "Sprawdź\r\nmiejsce zerowe";
			this.sprawdzWynik_button.UseVisualStyleBackColor = false;
			this.sprawdzWynik_button.Click += new System.EventHandler(this.sprawdzWynik_button_Click);
			// 
			// miejsceZerowe_TextBox
			// 
			this.miejsceZerowe_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.miejsceZerowe_TextBox.Location = new System.Drawing.Point(695, 130);
			this.miejsceZerowe_TextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.miejsceZerowe_TextBox.Name = "miejsceZerowe_TextBox";
			this.miejsceZerowe_TextBox.ReadOnly = true;
			this.miejsceZerowe_TextBox.Size = new System.Drawing.Size(237, 22);
			this.miejsceZerowe_TextBox.TabIndex = 35;
			// 
			// label_6
			// 
			this.label_6.AutoSize = true;
			this.label_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label_6.Location = new System.Drawing.Point(693, 96);
			this.label_6.Name = "label_6";
			this.label_6.Size = new System.Drawing.Size(200, 17);
			this.label_6.TabIndex = 34;
			this.label_6.Text = "Obliczone miejsce zerowe:";
			// 
			// resetuj_button
			// 
			this.resetuj_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.resetuj_button.Location = new System.Drawing.Point(837, 169);
			this.resetuj_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.resetuj_button.Name = "resetuj_button";
			this.resetuj_button.Size = new System.Drawing.Size(96, 63);
			this.resetuj_button.TabIndex = 33;
			this.resetuj_button.Text = "Resetuj\r\nwszystko";
			this.resetuj_button.UseVisualStyleBackColor = false;
			this.resetuj_button.Click += new System.EventHandler(this.resetuj_button_Click);
			// 
			// iteracje_TextBox
			// 
			this.iteracje_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.iteracje_TextBox.Location = new System.Drawing.Point(476, 356);
			this.iteracje_TextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.iteracje_TextBox.Name = "iteracje_TextBox";
			this.iteracje_TextBox.Size = new System.Drawing.Size(143, 22);
			this.iteracje_TextBox.TabIndex = 32;
			this.iteracje_TextBox.Text = "100";
			// 
			// delta_TextBox
			// 
			this.delta_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.delta_TextBox.Location = new System.Drawing.Point(476, 274);
			this.delta_TextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.delta_TextBox.Name = "delta_TextBox";
			this.delta_TextBox.Size = new System.Drawing.Size(143, 22);
			this.delta_TextBox.TabIndex = 31;
			this.delta_TextBox.Text = "0,0001";
			// 
			// label_5
			// 
			this.label_5.AutoSize = true;
			this.label_5.Location = new System.Drawing.Point(289, 359);
			this.label_5.Name = "label_5";
			this.label_5.Size = new System.Drawing.Size(122, 32);
			this.label_5.TabIndex = 30;
			this.label_5.Text = "Maksymalna liczba\r\niteracji:";
			// 
			// label_4
			// 
			this.label_4.AutoSize = true;
			this.label_4.Location = new System.Drawing.Point(319, 267);
			this.label_4.Name = "label_4";
			this.label_4.Size = new System.Drawing.Size(83, 48);
			this.label_4.TabIndex = 29;
			this.label_4.Text = "Dokładność\r\nwyznaczania\r\npierwiastka:";
			// 
			// Oblicz_button
			// 
			this.Oblicz_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.Oblicz_button.Location = new System.Drawing.Point(635, 322);
			this.Oblicz_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Oblicz_button.Name = "Oblicz_button";
			this.Oblicz_button.Size = new System.Drawing.Size(96, 63);
			this.Oblicz_button.TabIndex = 28;
			this.Oblicz_button.Text = "Oblicz\r\nmiejsce zerowe";
			this.Oblicz_button.UseVisualStyleBackColor = false;
			this.Oblicz_button.Click += new System.EventHandler(this.Oblicz_button_Click);
			// 
			// label_3
			// 
			this.label_3.AutoSize = true;
			this.label_3.Location = new System.Drawing.Point(319, 199);
			this.label_3.Name = "label_3";
			this.label_3.Size = new System.Drawing.Size(129, 32);
			this.label_3.TabIndex = 27;
			this.label_3.Text = "Dokładność\r\nporównania z zerem:";
			// 
			// epsilon_TextBox
			// 
			this.epsilon_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.epsilon_TextBox.Location = new System.Drawing.Point(476, 207);
			this.epsilon_TextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.epsilon_TextBox.Name = "epsilon_TextBox";
			this.epsilon_TextBox.Size = new System.Drawing.Size(143, 22);
			this.epsilon_TextBox.TabIndex = 26;
			this.epsilon_TextBox.Text = "0,0001";
			// 
			// punktStartowy_TextBox
			// 
			this.punktStartowy_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.punktStartowy_TextBox.Location = new System.Drawing.Point(476, 112);
			this.punktStartowy_TextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.punktStartowy_TextBox.Name = "punktStartowy_TextBox";
			this.punktStartowy_TextBox.Size = new System.Drawing.Size(143, 22);
			this.punktStartowy_TextBox.TabIndex = 25;
			this.punktStartowy_TextBox.Text = "3";
			// 
			// label_2
			// 
			this.label_2.AutoSize = true;
			this.label_2.Location = new System.Drawing.Point(289, 116);
			this.label_2.Name = "label_2";
			this.label_2.Size = new System.Drawing.Size(113, 16);
			this.label_2.TabIndex = 24;
			this.label_2.Text = "Punkt startowy X0:";
			// 
			// label_1
			// 
			this.label_1.AutoSize = true;
			this.label_1.Location = new System.Drawing.Point(289, 53);
			this.label_1.Name = "label_1";
			this.label_1.Size = new System.Drawing.Size(144, 32);
			this.label_1.TabIndex = 23;
			this.label_1.Text = "Wzór funkcji\r\n(w postaci wielomianu):";
			// 
			// wspolczynniki_textbox1
			// 
			this.wspolczynniki_textbox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.wspolczynniki_textbox1.Location = new System.Drawing.Point(476, 53);
			this.wspolczynniki_textbox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.wspolczynniki_textbox1.Name = "wspolczynniki_textbox1";
			this.wspolczynniki_textbox1.Size = new System.Drawing.Size(143, 22);
			this.wspolczynniki_textbox1.TabIndex = 22;
			this.wspolczynniki_textbox1.Text = "7 8 1 2";
			// 
			// saveButton
			// 
			this.saveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.saveButton.Location = new System.Drawing.Point(709, 745);
			this.saveButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.saveButton.Name = "saveButton";
			this.saveButton.Size = new System.Drawing.Size(123, 54);
			this.saveButton.TabIndex = 40;
			this.saveButton.Text = "Zapisz dane\r\n do pliku";
			this.saveButton.UseVisualStyleBackColor = false;
			this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(293, 415);
			this.richTextBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.ReadOnly = true;
			this.richTextBox1.Size = new System.Drawing.Size(644, 313);
			this.richTextBox1.TabIndex = 39;
			this.richTextBox1.Text = "";
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
			this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
			this.menuStrip1.Size = new System.Drawing.Size(1232, 28);
			this.menuStrip1.TabIndex = 41;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PomocToolStripMenuItem});
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(62, 24);
			this.toolStripMenuItem1.Text = "Opcje";
			// 
			// PomocToolStripMenuItem
			// 
			this.PomocToolStripMenuItem.Name = "PomocToolStripMenuItem";
			this.PomocToolStripMenuItem.Size = new System.Drawing.Size(137, 26);
			this.PomocToolStripMenuItem.Text = "Pomoc";
			this.PomocToolStripMenuItem.Click += new System.EventHandler(this.PomocToolStripMenuItem_Click);
			// 
			// autorzyToolStripMenuItem
			// 
			this.autorzyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oProgramieToolStripMenuItem1});
			this.autorzyToolStripMenuItem.Name = "autorzyToolStripMenuItem";
			this.autorzyToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
			this.autorzyToolStripMenuItem.Text = "Autorzy";
			// 
			// oProgramieToolStripMenuItem1
			// 
			this.oProgramieToolStripMenuItem1.Name = "oProgramieToolStripMenuItem1";
			this.oProgramieToolStripMenuItem1.Size = new System.Drawing.Size(177, 26);
			this.oProgramieToolStripMenuItem1.Text = "O programie";
			this.oProgramieToolStripMenuItem1.Click += new System.EventHandler(this.oProgramieToolStripMenuItem1_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::Metoda_Newtona.Properties.Resources.mathBackground;
			this.pictureBox1.Location = new System.Drawing.Point(971, 38);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(245, 347);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 42;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = global::Metoda_Newtona.Properties.Resources.mathBackground;
			this.pictureBox2.Location = new System.Drawing.Point(971, 382);
			this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(245, 417);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 43;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox5
			// 
			this.pictureBox5.Image = global::Metoda_Newtona.Properties.Resources.mathBackground;
			this.pictureBox5.Location = new System.Drawing.Point(16, 382);
			this.pictureBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(245, 417);
			this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox5.TabIndex = 46;
			this.pictureBox5.TabStop = false;
			// 
			// pictureBox6
			// 
			this.pictureBox6.Image = global::Metoda_Newtona.Properties.Resources.mathBackground;
			this.pictureBox6.Location = new System.Drawing.Point(16, 38);
			this.pictureBox6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.pictureBox6.Name = "pictureBox6";
			this.pictureBox6.Size = new System.Drawing.Size(245, 347);
			this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox6.TabIndex = 45;
			this.pictureBox6.TabStop = false;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.button1.Location = new System.Drawing.Point(839, 745);
			this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(100, 54);
			this.button1.TabIndex = 48;
			this.button1.Text = "Zamknij";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label7.Location = new System.Drawing.Point(288, 193);
			this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(24, 25);
			this.label7.TabIndex = 49;
			this.label7.Text = "ε";
			// 
			// Interpolator
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1232, 812);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.pictureBox5);
			this.Controls.Add(this.pictureBox6);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.saveButton);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.sprawdzWynik_button);
			this.Controls.Add(this.miejsceZerowe_TextBox);
			this.Controls.Add(this.label_6);
			this.Controls.Add(this.resetuj_button);
			this.Controls.Add(this.iteracje_TextBox);
			this.Controls.Add(this.delta_TextBox);
			this.Controls.Add(this.label_5);
			this.Controls.Add(this.label_4);
			this.Controls.Add(this.Oblicz_button);
			this.Controls.Add(this.label_3);
			this.Controls.Add(this.epsilon_TextBox);
			this.Controls.Add(this.punktStartowy_TextBox);
			this.Controls.Add(this.label_2);
			this.Controls.Add(this.label_1);
			this.Controls.Add(this.wspolczynniki_textbox1);
			this.Controls.Add(this.menuStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.MaximizeBox = false;
			this.Name = "Interpolator";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Kalkulator miesca zerowego";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button sprawdzWynik_button;
		private System.Windows.Forms.TextBox miejsceZerowe_TextBox;
		private System.Windows.Forms.Label label_6;
		private System.Windows.Forms.Button resetuj_button;
		private System.Windows.Forms.TextBox iteracje_TextBox;
		private System.Windows.Forms.TextBox delta_TextBox;
		private System.Windows.Forms.Label label_5;
		private System.Windows.Forms.Label label_4;
		private System.Windows.Forms.Button Oblicz_button;
		private System.Windows.Forms.Label label_3;
		private System.Windows.Forms.TextBox epsilon_TextBox;
		private System.Windows.Forms.TextBox punktStartowy_TextBox;
		private System.Windows.Forms.Label label_2;
		private System.Windows.Forms.Label label_1;
		private System.Windows.Forms.TextBox wspolczynniki_textbox1;
		private System.Windows.Forms.Button saveButton;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem PomocToolStripMenuItem;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox5;
		private System.Windows.Forms.PictureBox pictureBox6;
		private System.Windows.Forms.ToolStripMenuItem autorzyToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem oProgramieToolStripMenuItem1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label7;
	}
}

