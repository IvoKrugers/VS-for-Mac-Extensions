using MonoDevelop.Components;
using MonoDevelop.Ide.Gui;

namespace TestAddin.gtk
{
    public class ThePad : PadContent
    {
        private ThePadWidget control;
        public override Control Control => control ?? new ThePadWidget();
        public override string Id => "ThePadId";
    }
}
