/*
 * Created by SharpDevelop.
 * User: 23mvandehey
 * Date: 11/6/2019
 * Time: 1:01 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace combinationHacker
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.hackCodeButton = new System.Windows.Forms.Button();
			this.resetButton = new System.Windows.Forms.Button();
			this.codesListBox = new System.Windows.Forms.ListBox();
			this.firstTextBox = new System.Windows.Forms.TextBox();
			this.secondTextBox = new System.Windows.Forms.TextBox();
			this.thirdTextBox = new System.Windows.Forms.TextBox();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.thirdTextBox);
			this.groupBox1.Controls.Add(this.secondTextBox);
			this.groupBox1.Controls.Add(this.firstTextBox);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Location = new System.Drawing.Point(13, 27);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(319, 100);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Set Combo";
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(194, 35);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(37, 36);
			this.label6.TabIndex = 4;
			this.label6.Text = "3rd";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(98, 35);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(36, 36);
			this.label5.TabIndex = 4;
			this.label5.Text = "2nd";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(7, 35);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(31, 36);
			this.label4.TabIndex = 3;
			this.label4.Text = "1st";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// hackCodeButton
			// 
			this.hackCodeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.hackCodeButton.Location = new System.Drawing.Point(68, 142);
			this.hackCodeButton.Name = "hackCodeButton";
			this.hackCodeButton.Size = new System.Drawing.Size(113, 31);
			this.hackCodeButton.TabIndex = 1;
			this.hackCodeButton.Text = "Hack Code";
			this.hackCodeButton.UseVisualStyleBackColor = true;
			this.hackCodeButton.Click += new System.EventHandler(this.HackCodeButton_Click);
			// 
			// resetButton
			// 
			this.resetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.resetButton.Location = new System.Drawing.Point(187, 142);
			this.resetButton.Name = "resetButton";
			this.resetButton.Size = new System.Drawing.Size(75, 31);
			this.resetButton.TabIndex = 2;
			this.resetButton.Text = "Reset";
			this.resetButton.UseVisualStyleBackColor = true;
			this.resetButton.Click += new System.EventHandler(this.ResetButton_Click);
			// 
			// codesListBox
			// 
			this.codesListBox.FormattingEnabled = true;
			this.codesListBox.Location = new System.Drawing.Point(57, 189);
			this.codesListBox.Name = "codesListBox";
			this.codesListBox.Size = new System.Drawing.Size(225, 147);
			this.codesListBox.TabIndex = 3;
			// 
			// firstTextBox
			// 
			this.firstTextBox.Location = new System.Drawing.Point(45, 45);
			this.firstTextBox.Name = "firstTextBox";
			this.firstTextBox.Size = new System.Drawing.Size(47, 20);
			this.firstTextBox.TabIndex = 5;
			// 
			// secondTextBox
			// 
			this.secondTextBox.Location = new System.Drawing.Point(140, 45);
			this.secondTextBox.Name = "secondTextBox";
			this.secondTextBox.Size = new System.Drawing.Size(47, 20);
			this.secondTextBox.TabIndex = 6;
			// 
			// thirdTextBox
			// 
			this.thirdTextBox.Location = new System.Drawing.Point(237, 45);
			this.thirdTextBox.Name = "thirdTextBox";
			this.thirdTextBox.Size = new System.Drawing.Size(47, 20);
			this.thirdTextBox.TabIndex = 7;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(344, 350);
			this.Controls.Add(this.codesListBox);
			this.Controls.Add(this.resetButton);
			this.Controls.Add(this.hackCodeButton);
			this.Controls.Add(this.groupBox1);
			this.Name = "MainForm";
			this.Text = "combinationHacker";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.TextBox firstTextBox;
		private System.Windows.Forms.TextBox secondTextBox;
		private System.Windows.Forms.TextBox thirdTextBox;
		private System.Windows.Forms.ListBox codesListBox;
		private System.Windows.Forms.Button resetButton;
		private System.Windows.Forms.Button hackCodeButton;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.GroupBox groupBox1;
	}
}
