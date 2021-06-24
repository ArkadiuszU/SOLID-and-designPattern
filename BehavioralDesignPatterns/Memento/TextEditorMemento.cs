using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    class TextEditorMemento
    {
        private TextEditorConfiguration source;
        private int fontSize;
        private string fontStyle;
        private bool bold;
        private bool underline;
        private bool italic;

        public TextEditorMemento(TextEditorConfiguration source, int fontSize, string fontStyle, bool bold, bool underline, bool italic)
        {
            this.source = source;
            this.fontSize = fontSize;
            this.fontStyle = fontStyle;
            this.bold = bold;
            this.underline = underline;
            this.italic = italic;
        }

        public void Restore()
        {
            source.FontSize = this.fontSize;
            source.FontStyle = this.fontStyle;
            source.Bold = this.bold;
            source.Underline = this.underline;
            source.Italic = this.italic;
        }
    }
}
