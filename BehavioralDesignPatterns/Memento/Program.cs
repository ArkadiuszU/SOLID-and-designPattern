using System;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            TextEditorConfiguration textEditorConfiguration = new TextEditorConfiguration
            {
                FontSize = 12,
                FontStyle = "Courier",
                Bold = true,
                Italic = false,
                Underline = false
            };

            textEditorConfiguration.Summarize();
            textEditorConfiguration.CreateSnapshot();
            textEditorConfiguration.FontSize = 20;
            textEditorConfiguration.Bold = false;
            textEditorConfiguration.Summarize();
            textEditorConfiguration.Restore(); 
            textEditorConfiguration.Summarize();


        }
    }
}
