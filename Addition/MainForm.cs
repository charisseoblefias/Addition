/*
 * Created by SharpDevelop.
 * User: Charisse Oblefias
 * Date: 4/24/2021
 * Time: 5:49 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Addition
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void CalculateButtonClick(object sender, EventArgs e)
		{
			int x = Convert.ToInt16(xtextBox1.Text);
			int y = Convert.ToInt16(ytextBox2.Text);
			
			int result = x + y;
			resultlabel.Text=result.ToString();
		}
		void ClearButtonClick(object sender, EventArgs e)
		{
			xtextBox1.Clear();
			ytextBox2.Clear();
			resultlabel.Text=" ";
		}
		void ExitButtonClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
