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
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
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
			this.oProgramieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.schematWprowadzaniaDanychToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(84, 150);
			this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(30, 13);
			this.label6.TabIndex = 38;
			this.label6.Text = "delta";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(84, 115);
			this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(40, 13);
			this.label5.TabIndex = 37;
			this.label5.Text = "epsilon";
			// 
			// IsCorrectButton
			// 
			this.IsCorrectButton.Location = new System.Drawing.Point(378, 226);
			this.IsCorrectButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.IsCorrectButton.Name = "IsCorrectButton";
			this.IsCorrectButton.Size = new System.Drawing.Size(56, 28);
			this.IsCorrectButton.TabIndex = 36;
			this.IsCorrectButton.Text = "Sprawdź";
			this.IsCorrectButton.UseVisualStyleBackColor = true;
			this.IsCorrectButton.Click += new System.EventHandler(this.IsCorrectButton_Click);
			// 
			// zeroPlaceTextBox
			// 
			this.zeroPlaceTextBox.Location = new System.Drawing.Point(210, 231);
			this.zeroPlaceTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.zeroPlaceTextBox.Name = "zeroPlaceTextBox";
			this.zeroPlaceTextBox.ReadOnly = true;
			this.zeroPlaceTextBox.Size = new System.Drawing.Size(87, 20);
			this.zeroPlaceTextBox.TabIndex = 35;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(109, 233);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(83, 13);
			this.label4.TabIndex = 34;
			this.label4.Text = "Miejsce zerowe:";
			// 
			// resetButton
			// 
			this.resetButton.Location = new System.Drawing.Point(438, 226);
			this.resetButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.resetButton.Name = "resetButton";
			this.resetButton.Size = new System.Drawing.Size(56, 28);
			this.resetButton.TabIndex = 33;
			this.resetButton.Text = "Resetuj";
			this.resetButton.UseVisualStyleBackColor = true;
			this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
			// 
			// iterationsTextBox
			// 
			this.iterationsTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.iterationsTextBox.Location = new System.Drawing.Point(210, 194);
			this.iterationsTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.iterationsTextBox.Name = "iterationsTextBox";
			this.iterationsTextBox.Size = new System.Drawing.Size(87, 20);
			this.iterationsTextBox.TabIndex = 32;
			this.iterationsTextBox.Text = "100";
			// 
			// deltaTextBox
			// 
			this.deltaTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.deltaTextBox.Location = new System.Drawing.Point(210, 159);
			this.deltaTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.deltaTextBox.Name = "deltaTextBox";
			this.deltaTextBox.Size = new System.Drawing.Size(87, 20);
			this.deltaTextBox.TabIndex = 31;
			this.deltaTextBox.Text = "0,000001";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(58, 197);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(132, 13);
			this.label3.TabIndex = 30;
			this.label3.Text = "Maksymalna liczba iteracji:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(7, 163);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(189, 13);
			this.label2.TabIndex = 29;
			this.label2.Text = "Dokładność wyznaczania pierwiastka:";
			// 
			// calculateButton
			// 
			this.calculateButton.Location = new System.Drawing.Point(318, 226);
			this.calculateButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.calculateButton.Name = "calculateButton";
			this.calculateButton.Size = new System.Drawing.Size(56, 28);
			this.calculateButton.TabIndex = 28;
			this.calculateButton.Text = "Oblicz";
			this.calculateButton.UseVisualStyleBackColor = true;
			this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(27, 128);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(166, 13);
			this.label1.TabIndex = 27;
			this.label1.Text = "Dokładność porównania z zerem:";
			// 
			// epsilonTextBox
			// 
			this.epsilonTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.epsilonTextBox.Location = new System.Drawing.Point(210, 125);
			this.epsilonTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.epsilonTextBox.Name = "epsilonTextBox";
			this.epsilonTextBox.Size = new System.Drawing.Size(87, 20);
			this.epsilonTextBox.TabIndex = 26;
			this.epsilonTextBox.Text = "0,000001";
			// 
			// pointXTextBox
			// 
			this.pointXTextBox.Location = new System.Drawing.Point(210, 89);
			this.pointXTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.pointXTextBox.Name = "pointXTextBox";
			this.pointXTextBox.Size = new System.Drawing.Size(87, 20);
			this.pointXTextBox.TabIndex = 25;
			// 
			// label1PodajPunktStartowy
			// 
			this.label1PodajPunktStartowy.AutoSize = true;
			this.label1PodajPunktStartowy.Location = new System.Drawing.Point(69, 89);
			this.label1PodajPunktStartowy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1PodajPunktStartowy.Name = "label1PodajPunktStartowy";
			this.label1PodajPunktStartowy.Size = new System.Drawing.Size(123, 13);
			this.label1PodajPunktStartowy.TabIndex = 24;
			this.label1PodajPunktStartowy.Text = "Podaj punkt startowy x0:";
			// 
			// labelPodajWielomian
			// 
			this.labelPodajWielomian.AutoSize = true;
			this.labelPodajWielomian.Location = new System.Drawing.Point(117, 51);
			this.labelPodajWielomian.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelPodajWielomian.Name = "labelPodajWielomian";
			this.labelPodajWielomian.Size = new System.Drawing.Size(75, 13);
			this.labelPodajWielomian.TabIndex = 23;
			this.labelPodajWielomian.Text = "Podaj funkcje:";
			// 
			// parametersTextBox
			// 
			this.parametersTextBox.Location = new System.Drawing.Point(210, 51);
			this.parametersTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.parametersTextBox.Name = "parametersTextBox";
			this.parametersTextBox.Size = new System.Drawing.Size(87, 20);
			this.parametersTextBox.TabIndex = 22;
			// 
			// saveButton
			// 
			this.saveButton.Location = new System.Drawing.Point(353, 653);
			this.saveButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.saveButton.Name = "saveButton";
			this.saveButton.Size = new System.Drawing.Size(67, 44);
			this.saveButton.TabIndex = 40;
			this.saveButton.Text = "Zapisz\r\n do pliku";
			this.saveButton.UseVisualStyleBackColor = true;
			this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
			// 
			// logRichTextBox
			// 
			this.logRichTextBox.Location = new System.Drawing.Point(10, 268);
			this.logRichTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.logRichTextBox.Name = "logRichTextBox";
			this.logRichTextBox.Size = new System.Drawing.Size(484, 381);
			this.logRichTextBox.TabIndex = 39;
			this.logRichTextBox.Text = "";
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
			this.menuStrip1.Size = new System.Drawing.Size(505, 24);
			this.menuStrip1.TabIndex = 41;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oProgramieToolStripMenuItem,
            this.schematWprowadzaniaDanychToolStripMenuItem});
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(57, 20);
			this.toolStripMenuItem1.Text = "Pomoc";
			// 
			// oProgramieToolStripMenuItem
			// 
			this.oProgramieToolStripMenuItem.Name = "oProgramieToolStripMenuItem";
			this.oProgramieToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
			this.oProgramieToolStripMenuItem.Text = "O programie";
			this.oProgramieToolStripMenuItem.Click += new System.EventHandler(this.oProgramieToolStripMenuItem_Click);
			// 
			// schematWprowadzaniaDanychToolStripMenuItem
			// 
			this.schematWprowadzaniaDanychToolStripMenuItem.Name = "schematWprowadzaniaDanychToolStripMenuItem";
			this.schematWprowadzaniaDanychToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
			this.schematWprowadzaniaDanychToolStripMenuItem.Text = "Schemat wprowadzania danych";
			this.schematWprowadzaniaDanychToolStripMenuItem.Click += new System.EventHandler(this.schematWprowadzaniaDanychToolStripMenuItem_Click);
			// 
			// Interpolator
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(505, 721);
			this.Controls.Add(this.saveButton);
			this.Controls.Add(this.logRichTextBox);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
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
			this.MainMenuStrip = this.menuStrip1;
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "Interpolator";
			this.Text = "Interpolator";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
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
		private System.Windows.Forms.ToolStripMenuItem oProgramieToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem schematWprowadzaniaDanychToolStripMenuItem;
	}
}

