namespace Metoda_Newtona
{
	partial class ObslugaBledow
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
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.OkButton = new System.Windows.Forms.Button();
			this.SchemeButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(13, 54);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(209, 16);
			this.label3.TabIndex = 15;
			this.label3.Text = "Wprowadzono niepoprawne dane";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(13, 73);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(174, 16);
			this.label2.TabIndex = 14;
			this.label2.Text = "Wprowadź dane jeszcze raz";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label1.ForeColor = System.Drawing.Color.Red;
			this.label1.Location = new System.Drawing.Point(13, 22);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(112, 16);
			this.label1.TabIndex = 13;
			this.label1.Text = "Wystąpił błąd!";
			// 
			// OkButton
			// 
			this.OkButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.OkButton.Location = new System.Drawing.Point(154, 115);
			this.OkButton.Margin = new System.Windows.Forms.Padding(4);
			this.OkButton.Name = "OkButton";
			this.OkButton.Size = new System.Drawing.Size(133, 28);
			this.OkButton.TabIndex = 12;
			this.OkButton.Text = "OK";
			this.OkButton.UseVisualStyleBackColor = true;
			this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
			// 
			// SchemeButton
			// 
			this.SchemeButton.Location = new System.Drawing.Point(13, 115);
			this.SchemeButton.Margin = new System.Windows.Forms.Padding(4);
			this.SchemeButton.Name = "SchemeButton";
			this.SchemeButton.Size = new System.Drawing.Size(133, 28);
			this.SchemeButton.TabIndex = 11;
			this.SchemeButton.Text = "Zobacz schemat";
			this.SchemeButton.UseVisualStyleBackColor = true;
			this.SchemeButton.Click += new System.EventHandler(this.SchemeButton_Click);
			// 
			// ObslugaBledow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(315, 161);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.OkButton);
			this.Controls.Add(this.SchemeButton);
			this.Name = "ObslugaBledow";
			this.Text = "Wystąpił błąd!";
			this.Load += new System.EventHandler(this.ObslugaBledow_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button OkButton;
		private System.Windows.Forms.Button SchemeButton;
	}
}