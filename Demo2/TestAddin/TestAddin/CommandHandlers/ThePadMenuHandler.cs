using MonoDevelop.Components.Commands;
using MonoDevelop.Ide;
using TestAddin.gtk;

namespace TestAddin.CommandHandlers
{
    public class ThePadMenuHandler : CommandHandler
    {
        protected override void Run()
        {
            var pad = IdeApp.Workbench.GetPad<ThePad>();
            if (pad != null)
            {
                pad.Visible = true;
                pad.IsOpenedAutomatically = true;
                pad.BringToFront(true);
            }
        }

        protected override void Update(CommandInfo info)
        {
            info.Enabled = true;
        }
    }
}
