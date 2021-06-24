using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    class TextEditorConfiguration
    {
        public int FontSize { get; set; }
        public string FontStyle { get; set; }
        public bool Bold { get; set; }
        public bool Underline { get; set; }
        public bool Italic { get; set; }

        private TextEditorMemento memento;

        public void CreateSnapshot()
        {
            memento =  new TextEditorMemento(this, FontSize, FontStyle, Bold, Underline, Italic);
        }

        public void Restore()
        {
            if(memento is not null)
            {
                memento.Restore();
            }
        }
        public void Summarize()
        {
            Console.WriteLine($"font {FontStyle} {FontSize}, B:{Bold} U:{Underline}, I:{Italic}");
        }
    }
}
