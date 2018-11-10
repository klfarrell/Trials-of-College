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

        }

        public void SetDisplayContext(DisplayableContext context) {
            _context = context;
            //Update(); TODO: uncomment
        }

        public void SetForm(Form1 form)
        {
            _form = form;
        }

        public void Update() {
            DisplayContent content = null;
            if (_context is Game) {
                content = DisplayContentGenerator.GenerateGameContent(_context as Game);
            }

            if (_context is Menu)
            {
                content = DisplayContentGenerator.GenerateMenuContent(_context as Menu);
            }

            // TODO: Clear the form, take the display content (the buttons, the text boxes, the pictures etc) 
            // and insert them directly into the form
            //lol gonna try
            if (content != null)
            {
                _form.Controls.Clear();
                foreach (System.Windows.Forms.Control c in content.Controls)
                    _form.Controls.Add(c);
            }
        }
    }
}
