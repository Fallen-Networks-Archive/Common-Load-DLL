using System;
using CitizenFX.Core;

namespace Commons.Client
{
    public class Events : BaseScript
    {
        [EventHandler("fn:Client:DebugLog")]
        internal void OnClientDebugLog(string msg)
        {
        }

        [EventHandler("fn:Client:Log")]
        internal void OnClientLog(string msg)
        {
            Debug.WriteLine("[FN]: " + msg);
        }
    }
}
