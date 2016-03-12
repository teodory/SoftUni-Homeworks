using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Problem4
{
    static void Main()
    {
        using (var file = new FileStream("../../../view.jpg", FileMode.Open))
        {
            using (var copyFile = new FileStream("../../CopyView.jpg", FileMode.Create))
            {
                while (file.Position < file.Length)
                {
                    copyFile.WriteByte((byte)file.ReadByte());
                }
            }
        }
    }
}

