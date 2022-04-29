/*
 * Created by SharpDevelop.
 * User: 23mvandehey
 * Date: 11/6/2019
 * Time: 1:01 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace combinationHacker
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		private Random rand = new Random();
		int firstNumber, secondNumber, thirdNumber, their1, their2, their3, guesses;
		bool equal = false;
		
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
		
		void HackCodeButton_Click(object sender, EventArgs e)
		{
			while (!equal)
			{
				their1 = int.Parse(firstTextBox.Text);
				their2 = int.Parse(secondTextBox.Text);
				their3 = int.Parse(thirdTextBox.Text);
				firstNumber = rand.Next(1,10);
				secondNumber = rand.Next(1,10);
				thirdNumber = rand.Next(1,10);
				codesListBox.Items.Add(firstNumber + " " + secondNumber + " " + thirdNumber);
				guesses ++;
				if (their1 == firstNumber && their2 == secondNumber && their3 == thirdNumber)
				{
					equal = true;
					MessageBox.Show ("I guessed your combination in " + guesses + " guesses.");
				}
			}
		}
		
		void ResetButton_Click(object sender, EventArgs e)
		{
			firstTextBox.Text = "";
			secondTextBox.Text = "";
			thirdTextBox.Text = "";
			guesses = 0;
			codesListBox.Items.Clear();
			equal = false;
		}
	}
}
