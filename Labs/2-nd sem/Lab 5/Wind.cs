using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
	[Serializable]
	public class Wind
	{
		public Point Pos { get; set; }
		public Size Wind_Size { get; set; }
		public bool[] CheckBox { get; set; }
		public string TextBox { get; set; }

		public Wind() { }

		public Wind(Point position, Size size, bool[] checks, string text)
		{
			Pos = position;
			Wind_Size = size;
			CheckBox = checks;
			TextBox = text;
		}

	}
}