using FivePD.API;
using System;

namespace ToggleFivePD
{
    public class Main : Plugin
    {
        internal Main()
        {
            EventHandlers.Add("fivepd::toggleMod", new Action<bool>((toggle) => ToggleMod(toggle)));
        }

        private void ToggleMod(bool toggle)
        {
            if (toggle)
            {
                Utilities.EnableMod();
            } else
            {
                Utilities.DisableMod();
            }
        }
    }
}
