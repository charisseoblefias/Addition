/*
 * Created by SharpDevelop.
 * User: Charisse Oblefias
 * Date: 4/24/2021
 * Time: 5:49 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Addition
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox xtextBox1;
		private System.Windows.Forms.TextBox ytextBox2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button CalculateButton;
		private System.Windows.Forms.Button ClearButton;
		private System.Windows.Forms.Button ExitButton;
		private System.Windows.Forms.Label resultlabel;
		
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.xtextBox1 = new System.Windows.Forms.TextBox();
			this.ytextBox2 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.CalculateButton = new System.Windows.Forms.Button();
			this.ClearButton = new System.Windows.Forms.Button();
			this.ExitButton = new System.Windows.Forms.Button();
			this.resultlabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 69);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(157, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "First number:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(216, 69);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(150, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Second number:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// xtextBox1
			// 
			this.xtextBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.xtextBox1.Location = new System.Drawing.Point(44, 111);
			this.xtextBox1.Name = "xtextBox1";
			this.xtextBox1.Size = new System.Drawing.Size(97, 32);
			this.xtextBox1.TabIndex = 2;
			this.xtextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// ytextBox2
			// 
			this.ytextBox2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ytextBox2.Location = new System.Drawing.Point(241, 111);
			this.ytextBox2.Name = "ytextBox2";
			this.ytextBox2.Size = new System.Drawing.Size(97, 32);
			this.ytextBox2.TabIndex = 3;
			this.ytextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(175, 96);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(40, 41);
			this.label3.TabIndex = 4;
			this.label3.Text = "+";
			this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// CalculateButton
			// 
			this.CalculateButton.Location = new System.Drawing.Point(99, 210);
			this.CalculateButton.Name = "CalculateButton";
			this.CalculateButton.Size = new System.Drawing.Size(170, 41);
			this.CalculateButton.TabIndex = 5;
			this.CalculateButton.Text = "Calculate";
			this.CalculateButton.UseVisualStyleBackColor = true;
			this.CalculateButton.Click += new System.EventHandler(this.CalculateButtonClick);
			// 
			// ClearButton
			// 
			this.ClearButton.Location = new System.Drawing.Point(119, 257);
			this.ClearButton.Name = "ClearButton";
			this.ClearButton.Size = new System.Drawing.Size(136, 40);
			this.ClearButton.TabIndex = 6;
			this.ClearButton.Text = "Clear";
			this.ClearButton.UseVisualStyleBackColor = true;
			this.ClearButton.Click += new System.EventHandler(this.ClearButtonClick);
			// 
			// ExitButton
			// 
			this.ExitButton.BackColor = System.Drawing.Color.Brown;
			this.ExitButton.Location = new System.Drawing.Point(142, 323);
			this.ExitButton.Name = "ExitButton";
			this.ExitButton.Size = new System.Drawing.Size(96, 36);
			this.ExitButton.TabIndex = 7;
			this.ExitButton.Text = "Exit";
			this.ExitButton.UseVisualStyleBackColor = false;
			this.ExitButton.Click += new System.EventHandler(this.ExitButtonClick);
			// 
			// resultlabel
			// 
			this.resultlabel.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.resultlabel.Location = new System.Drawing.Point(138, 158);
			this.resultlabel.Name = "resultlabel";
			this.resultlabel.Size = new System.Drawing.Size(100, 34);
			this.resultlabel.TabIndex = 8;
			this.resultlabel.Text = "label4";
			this.resultlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Tan;
			this.ClientSize = new System.Drawing.Size(378, 382);
			this.Controls.Add(this.resultlabel);
			this.Controls.Add(this.ExitButton);
			this.Controls.Add(this.ClearButton);
			this.Controls.Add(this.CalculateButton);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.ytextBox2);
			this.Controls.Add(this.xtextBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "MainForm";
			this.Text = "Addition";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
