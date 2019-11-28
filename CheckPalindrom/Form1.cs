using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckPalindrom
{
	public partial class Form1 : Form
	{
		String input;
		String inputnospaces;
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			input = textBox1.Text;
			
			foreach(char a in input)
				{
					if(a != ' ')
					{
						inputnospaces += a;
					}
				}
			
				
				

			if (CheckPalindrom(inputnospaces) == true)
				lblOutput.Text = "its a palindrom";
			else
				lblOutput.Text = "Sorry it isnt";
		}





		private bool CheckPalindrom(String input)
		{
			String temp = "";
			for(int x = input.Length-1; x >= 0; x--)
			{
				temp += input.Substring(x, 1);
			}
			if (input.Equals(temp))
				return true;
			else
				return false;
		}
	}
}
