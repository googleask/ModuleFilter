﻿using Silkroad.Framework.Common;

namespace Silkroad.Plugin.Download
{
    public class Plugin : PluginBase
    {
        public override void Register(string name, Service service)
        {
            base.Register(name, service);

            //Add plugin related packet handlers here...
        }
    }
}