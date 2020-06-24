using System;
namespace TestAddin.gtk
{
    [System.ComponentModel.ToolboxItem(true)]
    public partial class ThePadWidget : Gtk.Bin
    {
        public ThePadWidget()
        {
            this.Build();
            this.ShowAll();
        }
    }
}
