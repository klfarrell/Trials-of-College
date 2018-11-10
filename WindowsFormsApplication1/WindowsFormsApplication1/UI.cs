using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class UI
    {
        private static UI _instance;

        private DisplayableContext _context;
        private Form1 _form;

        // TODO variable the represents the form to communicate with

        public static UI Instance
        {
            get
            {
                if (_instance == null) {
                    _instance = new UI();
                }
                return _instance;
            }
        }
        public UI() {
            _form = null;
        }

        public void SetDisplayContext(DisplayableContext context) {
            _context = context;
            Update();
        }

        public void SetForm(Form1 form)
        {
            _form = form;
        }

        public void Update() {
            DisplayContent content = null;
            System.Drawing.Color color = new System.Drawing.Color();
            if (_context is Game) {
                content = DisplayContentGenerator.GenerateGameContent(_context as Game, ref color);
            }

            if (_context is Menu)
            {
                content = DisplayContentGenerator.GenerateMenuContent(_context as Menu, ref color);
            }

            if (content != null && _form != null)
            {
                _form.Controls.Clear();
                foreach (System.Windows.Forms.Control c in content.Controls)
                    _form.Controls.Add(c);
            }

            if (!color.IsEmpty)
                _form.BackColor = color;
        }
    }
}
