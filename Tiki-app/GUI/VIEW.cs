using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tiki_app.GUI
{
    public class VIEW
    {
        public object obj { get;set ;}

        public int Tag { get; set; }

        public interface OnClickListener
        {
            void onClick(VIEW view);
        }

        public interface OnChangeListener
        {
            void onChange(VIEW view);
        }

        public int getID()
        {
            return Tag;
        }
     
    }
}
