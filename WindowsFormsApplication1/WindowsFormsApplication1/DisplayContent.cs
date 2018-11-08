using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public class DisplayContent
    {
        private List<Control> _controls;

        public DisplayContent() {
            _controls = new List<Control>();
        }

        public void AddControl(Control control)
        {
            _controls.Add(control);
        }

        public List<Control> Controls
        {
            get
            {
                return _controls;
            }
        }
    }
}
