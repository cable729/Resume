using System.Runtime.InteropServices;
using EnvDTE;

namespace Resume
{
    class Class1
    {
        public static void Main(string[] args)
        {
            var dte = (DTE) Marshal.GetActiveObject("VisualStudio.DTE.11.0");
            dte.ExecuteCommand("File.Print");
        }
    }
}
