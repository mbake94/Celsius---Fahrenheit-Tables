namespace Celsius__Fahrenheit_Tables
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
			this.btnBuild = new System.Windows.Forms.Button();
			this.lblLowTemp = new System.Windows.Forms.Label();
			this.lblHighTemp = new System.Windows.Forms.Label();
			this.lblIncrements = new System.Windows.Forms.Label();
			this.txtLowTemp = new System.Windows.Forms.TextBox();
			this.txtHighTemp = new System.Windows.Forms.TextBox();
			this.txtIncrement = new System.Windows.Forms.TextBox();
			this.lstConverter = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// btnBuild
			// 
			this.btnBuild.Location = new System.Drawing.Point(260, 87);
			this.btnBuild.Name = "btnBuild";
			this.btnBuild.Size = new System.Drawing.Size(139, 47);
			this.btnBuild.TabIndex = 0;
			this.btnBuild.Text = "Build Table";
			this.btnBuild.UseVisualStyleBackColor = true;
			this.btnBuild.Click += new System.EventHandler(this.btnBuild_Click);
			// 
			// lblLowTemp
			// 
			this.lblLowTemp.AutoSize = true;
			this.lblLowTemp.Location = new System.Drawing.Point(30, 71);
			this.lblLowTemp.Name = "lblLowTemp";
			this.lblLowTemp.Size = new System.Drawing.Size(129, 13);
			this.lblLowTemp.TabIndex = 1;
			this.lblLowTemp.Text = "Low Celsius Temperature:";
			// 
			// lblHighTemp
			// 
			this.lblHighTemp.AutoSize = true;
			this.lblHighTemp.Location = new System.Drawing.Point(30, 104);
			this.lblHighTemp.Name = "lblHighTemp";
			this.lblHighTemp.Size = new System.Drawing.Size(131, 13);
			this.lblHighTemp.TabIndex = 2;
			this.lblHighTemp.Text = "High Celsius Temperature:";
			// 
			// lblIncrements
			// 
			this.lblIncrements.AutoSize = true;
			this.lblIncrements.Location = new System.Drawing.Point(100, 135);
			this.lblIncrements.Name = "lblIncrements";
			this.lblIncrements.Size = new System.Drawing.Size(62, 13);
			this.lblIncrements.TabIndex = 3;
			this.lblIncrements.Text = "Increments:";
			// 
			// txtLowTemp
			// 
			this.txtLowTemp.Location = new System.Drawing.Point(165, 68);
			this.txtLowTemp.Name = "txtLowTemp";
			this.txtLowTemp.Size = new System.Drawing.Size(69, 20);
			this.txtLowTemp.TabIndex = 4;
			// 
			// txtHighTemp
			// 
			this.txtHighTemp.Location = new System.Drawing.Point(165, 101);
			this.txtHighTemp.Name = "txtHighTemp";
			this.txtHighTemp.Size = new System.Drawing.Size(69, 20);
			this.txtHighTemp.TabIndex = 5;
			// 
			// txtIncrement
			// 
			this.txtIncrement.Location = new System.Drawing.Point(165, 132);
			this.txtIncrement.Name = "txtIncrement";
			this.txtIncrement.Size = new System.Drawing.Size(69, 20);
			this.txtIncrement.TabIndex = 6;
			// 
			// lstConverter
			// 
			this.lstConverter.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lstConverter.FormattingEnabled = true;
			this.lstConverter.ItemHeight = 16;
			this.lstConverter.Location = new System.Drawing.Point(33, 196);
			this.lstConverter.Name = "lstConverter";
			this.lstConverter.Size = new System.Drawing.Size(303, 308);
			this.lstConverter.TabIndex = 7;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(455, 548);
			this.Controls.Add(this.lstConverter);
			this.Controls.Add(this.txtIncrement);
			this.Controls.Add(this.txtHighTemp);
			this.Controls.Add(this.txtLowTemp);
			this.Controls.Add(this.lblIncrements);
			this.Controls.Add(this.lblHighTemp);
			this.Controls.Add(this.lblLowTemp);
			this.Controls.Add(this.btnBuild);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnBuild;
		private System.Windows.Forms.Label lblLowTemp;
		private System.Windows.Forms.Label lblHighTemp;
		private System.Windows.Forms.Label lblIncrements;
		private System.Windows.Forms.TextBox txtLowTemp;
		private System.Windows.Forms.TextBox txtHighTemp;
		private System.Windows.Forms.TextBox txtIncrement;
		private System.Windows.Forms.ListBox lstConverter;
	}
}

