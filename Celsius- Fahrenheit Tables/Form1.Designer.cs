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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBuild
            // 
            this.btnBuild.Location = new System.Drawing.Point(347, 107);
            this.btnBuild.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuild.Name = "btnBuild";
            this.btnBuild.Size = new System.Drawing.Size(185, 58);
            this.btnBuild.TabIndex = 0;
            this.btnBuild.Text = "Build Table";
            this.btnBuild.UseVisualStyleBackColor = true;
            this.btnBuild.Click += new System.EventHandler(this.btnBuild_Click);
            // 
            // lblLowTemp
            // 
            this.lblLowTemp.AutoSize = true;
            this.lblLowTemp.Location = new System.Drawing.Point(40, 87);
            this.lblLowTemp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLowTemp.Name = "lblLowTemp";
            this.lblLowTemp.Size = new System.Drawing.Size(172, 17);
            this.lblLowTemp.TabIndex = 1;
            this.lblLowTemp.Text = "Low Celsius Temperature:";
            // 
            // lblHighTemp
            // 
            this.lblHighTemp.AutoSize = true;
            this.lblHighTemp.Location = new System.Drawing.Point(40, 128);
            this.lblHighTemp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHighTemp.Name = "lblHighTemp";
            this.lblHighTemp.Size = new System.Drawing.Size(176, 17);
            this.lblHighTemp.TabIndex = 2;
            this.lblHighTemp.Text = "High Celsius Temperature:";
            // 
            // lblIncrements
            // 
            this.lblIncrements.AutoSize = true;
            this.lblIncrements.Location = new System.Drawing.Point(133, 166);
            this.lblIncrements.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIncrements.Name = "lblIncrements";
            this.lblIncrements.Size = new System.Drawing.Size(81, 17);
            this.lblIncrements.TabIndex = 3;
            this.lblIncrements.Text = "Increments:";
            // 
            // txtLowTemp
            // 
            this.txtLowTemp.Location = new System.Drawing.Point(220, 84);
            this.txtLowTemp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLowTemp.Name = "txtLowTemp";
            this.txtLowTemp.Size = new System.Drawing.Size(91, 22);
            this.txtLowTemp.TabIndex = 4;
            // 
            // txtHighTemp
            // 
            this.txtHighTemp.Location = new System.Drawing.Point(220, 124);
            this.txtHighTemp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtHighTemp.Name = "txtHighTemp";
            this.txtHighTemp.Size = new System.Drawing.Size(91, 22);
            this.txtHighTemp.TabIndex = 5;
            // 
            // txtIncrement
            // 
            this.txtIncrement.Location = new System.Drawing.Point(220, 162);
            this.txtIncrement.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIncrement.Name = "txtIncrement";
            this.txtIncrement.Size = new System.Drawing.Size(91, 22);
            this.txtIncrement.TabIndex = 6;
            // 
            // lstConverter
            // 
            this.lstConverter.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstConverter.FormattingEnabled = true;
            this.lstConverter.ItemHeight = 18;
            this.lstConverter.Location = new System.Drawing.Point(44, 241);
            this.lstConverter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstConverter.Name = "lstConverter";
            this.lstConverter.Size = new System.Drawing.Size(403, 364);
            this.lstConverter.TabIndex = 7;
            this.lstConverter.SelectedIndexChanged += new System.EventHandler(this.lstConverter_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Celsius";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(296, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Fahrenheit";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 674);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstConverter);
            this.Controls.Add(this.txtIncrement);
            this.Controls.Add(this.txtHighTemp);
            this.Controls.Add(this.txtLowTemp);
            this.Controls.Add(this.lblIncrements);
            this.Controls.Add(this.lblHighTemp);
            this.Controls.Add(this.lblLowTemp);
            this.Controls.Add(this.btnBuild);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

