using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace Lab_5
{ 
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void SaveXML()
		{
			Wind window = new Wind(Location, Size, new bool[] { checkBox1.Checked, checkBox2.Checked }, textBox1.Text);

			XmlSerializer xmlSerializer = new XmlSerializer(typeof(Wind));

			//if(!File.Exists("Save.xml"))
			//{
			//	File.Create("Save.xml");
			//}
			using (FileStream fs = new FileStream("Wind.xml", FileMode.OpenOrCreate))
			{
				xmlSerializer.Serialize(fs, window);
			}

		}

		private void LoadXML()
		{
			XmlSerializer xmlSerializer = new XmlSerializer(typeof(Wind));
			if (File.Exists("Wind.xml"))
			{
				using (FileStream fs = new FileStream("Wind.xml", FileMode.Open))
				{
					Wind window = (Wind)xmlSerializer.Deserialize(fs);
					Location = window.Pos;
					Size = window.Wind_Size;
					checkBox1.Checked = window.CheckBox[0];
					checkBox2.Checked = window.CheckBox[1];
					textBox1.Text = window.TextBox;
				}
			}
		}

		private void SaveTXT()
		{
			if (!File.Exists("Wind.txt"))
			{
				File.Create("Wind.txt");
			}

			using (StreamWriter sw = new StreamWriter("Wind.txt", false, System.Text.Encoding.Default))
			{
				sw.WriteLine(Location.X);
				sw.WriteLine(Location.Y);
				sw.WriteLine(Size.Width);
				sw.WriteLine(Size.Height);
				sw.WriteLine(checkBox1.Checked);
				sw.WriteLine(checkBox2.Checked);
				sw.WriteLine(textBox1.Text);
			}
		}

		private void LoadTXT()
		{
			if (File.Exists("Wind.txt"))
			{
				using (StreamReader sr = new StreamReader("Wind.txt"))
				{
					Location = new Point(Convert.ToInt32(sr.ReadLine()), Convert.ToInt32(sr.ReadLine()));
					Size = new Size(Convert.ToInt32(sr.ReadLine()), Convert.ToInt32(sr.ReadLine()));
					checkBox1.Checked = Convert.ToBoolean(sr.ReadLine());
					checkBox2.Checked = Convert.ToBoolean(sr.ReadLine());
					textBox1.Text = sr.ReadLine();
				}
			}
		}

		private void SaveBIN()
		{

			using (FileStream fs = new FileStream("Bin.txt", FileMode.OpenOrCreate))
			{
				BinaryWriter bw = new BinaryWriter(fs);
				bw.Write(Location.X);
				bw.Write(Location.Y);
				bw.Write(Size.Width);
				bw.Write(Size.Height);
				bw.Write(checkBox1.Checked);
				bw.Write(checkBox2.Checked);
				bw.Write(textBox1.Text);
				bw.Close();
			}

		}

		private void LoadBIN()
		{
			if (File.Exists("Bin.txt"))
			{
				using (FileStream fs = new FileStream("Bin.txt", FileMode.Open))
				{
					BinaryReader br = new BinaryReader(fs);
					Location = new Point(br.ReadInt32(), br.ReadInt32());
					Size = new Size(br.ReadInt32(), br.ReadInt32());
					checkBox1.Checked = br.ReadBoolean();
					checkBox2.Checked = br.ReadBoolean();
					textBox1.Text = br.ReadString();
					br.Close();
				}
			}
		}

		private void SaveREG()
		{
			RegistryKey registryKey = null;
			try
			{
				registryKey = Registry.CurrentUser.OpenSubKey($"Software\\Ostiary\\Lab_5\\", writable: true);
			}
			catch (Exception e)
			{

			}
			try
			{
				registryKey.SetValue("Pos_x", base.Location.X, RegistryValueKind.DWord);
				registryKey.SetValue("Pos_y", base.Location.Y, RegistryValueKind.DWord);
				registryKey.SetValue("Width", base.Width, RegistryValueKind.DWord);
				registryKey.SetValue("Height", base.Height, RegistryValueKind.DWord);
				registryKey.SetValue("Text", textBox1.Text, RegistryValueKind.String);
				registryKey.SetValue("Check 1", checkBox1.Checked.ToString(), RegistryValueKind.String);
				registryKey.SetValue("Check 2", checkBox2.Checked.ToString(), RegistryValueKind.String);
			}
			catch (Exception e)
			{
			}
		}

		private void LoadREG()
		{
			try
			{
				RegistryKey registryKey = Registry.CurrentUser.OpenSubKey($"Software\\Ostiary\\Lab_5\\");
				base.Location = new Point((int)registryKey.GetValue("Pos_x"), (int)registryKey.GetValue("Pos_y"));
				base.Size = new Size((int)registryKey.GetValue("Width"), (int)registryKey.GetValue("Height"));
				textBox1.Text = (string)registryKey.GetValue("Text");
				checkBox1.Checked = bool.Parse((string)registryKey.GetValue("Check 1"));
				checkBox2.Checked = bool.Parse((string)registryKey.GetValue("Check 2"));
			}
			catch (Exception e)
			{
			}
		}


		private void Form1_Load(object sender, EventArgs e)
		{
			//LoadXML();
			//LoadTXT();
			//LoadBIN();
			LoadREG();
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			//SaveXML();
			//SaveTXT();
			//SaveBIN();
			SaveREG();
		}
	}
}