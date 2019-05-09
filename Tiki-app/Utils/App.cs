using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tiki_app.Utils
{
    public class App
    {
        public static string mkdir(string file)
        {
            return System.IO.Directory.GetCurrentDirectory() + "\\Assets\\" + file.Trim() + ".png";

        }
    }
}
