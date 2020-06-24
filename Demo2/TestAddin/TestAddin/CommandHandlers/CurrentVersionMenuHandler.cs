using System;
using MonoDevelop.Components.Commands;

namespace TestAddin.CommandHandlers
{
    public class CurrentVersionMenuHandler : CommandHandler
    {
        protected override void Update(CommandInfo info)
        {
            info.Enabled = false;
            info.Text = $"Test Addin (1.7.4)";
        }

        protected override void Run()
        {
            base.Run();
        }
    }
}
