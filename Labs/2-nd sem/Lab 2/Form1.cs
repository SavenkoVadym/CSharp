using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_2
{
	public partial class Form1 : Form
	{
		Mutex mutexObj = new Mutex();
		int range = 40;
		int sp = 2;
		Int64 none_count = 0;
		bool empty = true;
		int counter = 0;
		public Form1()
		{
			InitializeComponent();
			timer1.Interval = 1000;
			this.timer1.Start();
			timer1.Tick += timer1_Tick;
			this.button1.MouseEnter += Button1_MouseEnter;
			this.MouseMove += Form_MouseMove;

			this.textBox1.Visible = false;
			this.button1.TabStop = false;
			this.button1.GotFocus += Button1_GotFocus;

			this.button1.Click += button2_Click;


		}

		private void Button1_GotFocus(object sender, EventArgs e)
		{
			button2.Focus();
		}

		private void Button1_MouseEnter(object sender, EventArgs e)
		{
			Random rand = new Random();
			int rndX = button1.Location.X * (1 / rand.Next(2, 5));
			int rndY = button1.Location.Y * (1 / rand.Next(2, 5));


			button1.Location = new Point(rndX, rndY);
		}

		string text = "Press 'OK' button";
		private void timer1_Tick(object sender, EventArgs e)
		{
			if (empty)
			{
				this.Text = "";
			}
			else
			{
				this.Text = text;
			}

			empty = !empty;
			counter++;

			if (counter == 8)
			{
				this.timer1.Tick -= timer1_Tick;
				this.timer1.Stop();
			}

		}

		private void End_Tick_tak(object sender, EventArgs e)
		{
			if (empty)
			{
				this.Text = "";
			}
			else
			{
				this.Text = "Button 'OK' cannot be pressed anymore";
			}

			empty = !empty;
			counter++;

			if (counter == 8)
			{
				this.timer1.Tick -= End_Tick_tak;
				this.timer1.Stop();
			}
		}

		private void Form_MouseMove(object sender, MouseEventArgs e)
		{

			int bX = this.button1.Location.X;
			int bY = this.button1.Location.Y;
			int bW = this.button1.Width;
			int bH = this.button1.Height;



			if (e.X >= bX - range && e.X < bX                        // 1я зона
			&& e.Y >= bY - range && e.Y < bY)
			{
				this.button1.Location = new Point(bX + sp, bY + sp);
				none_count++;
				if (none_count % 35 == 0)
					Size_minus(3);

			}

			else if (e.X > bX && e.X < bX + bW                       // 2я зона
					&& e.Y >= bY - range && e.Y < bY)
			{
				this.button1.Location = new Point(bX, bY + sp);
				none_count++;
				if (none_count % 35 == 0)
					Size_minus(2);
			}

			else if (e.X > bX + bW && e.X < bX + bW + range          // 3я зона
					&& e.Y >= bY - range && e.Y < bY)
			{
				this.button1.Location = new Point(bX - sp, bY + sp);
				none_count++;
				if (none_count % 35 == 0)
					Size_minus(3);
			}

			else if (e.X > bX + bW && e.X < bX + bW + range          // 4я зона
					&& e.Y >= bY && e.Y < bY + bH)
			{
				this.button1.Location = new Point(bX - sp, bY);
				none_count++;
				if (none_count % 35 == 0)
					Size_minus(1);
			}

			else if (e.X > bX + bW && e.X < bX + bW + range          // 5я зона
					&& e.Y >= bY + bH && e.Y < bY + bH + range)
			{
				this.button1.Location = new Point(bX - sp, bY - sp);
				none_count++;
				if (none_count % 35 == 0)
					Size_minus(3);
			}

			else if (e.X > bX && e.X < bX + bW                       // 6я зона
					&& e.Y >= bY + bH && e.Y < bY + bH + range)
			{
				this.button1.Location = new Point(bX, bY - sp);
				none_count++;
				if (none_count % 35 == 0)
					Size_minus(2);
			}

			else if (e.X > bX - range && e.X < bX                    // 7я зона
					&& e.Y >= bY + bH && e.Y < bY + bH + range)
			{
				this.button1.Location = new Point(bX + sp, bY - sp);
				none_count++;
				if (none_count % 35 == 0)
					Size_minus(3);
			}

			else if (e.X > bX - range && e.X < bX                    // 8я зона
					&& e.Y >= bY && e.Y < bY + bH)
			{
				this.button1.Location = new Point(bX + sp, bY);
				none_count++;
				if (none_count % 35 == 0)
					Size_minus(1);
			}

			else if (bX >= button2.Location.X && bY >= button2.Location.Y
					&& bX <= button2.Location.X + bW && bY <= button2.Location.Y + bH)
			{
				this.button1.Location = new Point(bX / 2, bY / 2);
			}

			if (button1.Width <= 0 || button1.Height <= 0)
			{
				button1.Dispose();
				counter = 0;
				this.timer1.Tick += End_Tick_tak;
				this.timer1.Start();


				empty = true;
				counter = 0;
				this.MouseMove -= Form_MouseMove;
			}

			if (bX <= 0)
			{
				this.button1.Location = new Point(bX + e.X + range, bY);
			}

			else if (bY <= 0)
			{
				this.button1.Location = new Point(bX, bY + e.Y + range);
			}

			else if (bX + bW >= this.ClientRectangle.Width)
			{
				this.button1.Location = new Point(bX - bH - range - range, bY);
			}

			else if (bY + bH >= this.ClientRectangle.Height)
			{
				this.button1.Location = new Point(bX, bY - bH - range - range);

			}

			void Size_minus(int i)
			{
				switch (i)
				{
					case 1:
						this.button1.Width -= 3;
						break;
					case 2:
						this.button1.Height -= 1;
						break;
					case 3:
						this.button1.Width -= 3;
						this.button1.Height -= 1;
						break;
				}

			}

			this.textBox2.Text = $"X = {e.X} XX = {this.button1.Location.X}  none_count = {none_count}";
			this.textBox3.Text = $"Y = {e.Y} YY = {this.button1.Location.Y}";

		}

		private void button2_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Hello");
		}
	}
}