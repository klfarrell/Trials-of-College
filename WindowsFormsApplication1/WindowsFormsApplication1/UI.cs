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

        // TODO variable the represents the form to communicate with

        public UI Instance
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
            Update();
        }

        public void Update() {
            DisplayContent content;
            if (_context is Game) {
                content = DisplayContentGenerator.GenerateGameContent(_context as Game);
            }

            if (_context is Menu)
            {
                content = DisplayContentGenerator.GenerateMenuContent(_context as Menu);
            }

            // TODO: Clear the form, take the display content (the buttons, the text boxes, the pictures etc) 
            // and insert them directly into the form
        }
    }
}
