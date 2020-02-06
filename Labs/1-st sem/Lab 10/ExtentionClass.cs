using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_10
{
    static class ExtentionClass
    {
        public static void DisplayAray(this ListInts list)
        {
            for (int i = 0; i < list.Size; i++)
            {
                if (i % 2 == 0)
                {
                    list.DisplayElement(i);
                }
            }
            for (int i = 0; i < list.Size; i++)
            {
                if (i % 2 != 0)
                {
                    list.DisplayElement(i);
                }
            }
        }
    }
}
