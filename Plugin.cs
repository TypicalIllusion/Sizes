using Sizes.Handlers;
using Synapse.Api.Plugin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sizes
{
    [PluginInformation(
        Author = "TheVoidNebula",
        Description = "Random Sizes when spawning.",
        LoadPriority = 0,
        Name = "Sizes",
        SynapseMajor = 2,
        SynapseMinor = 4,
        SynapsePatch = 2,
        Version = "b1.0"
        )]
    public class Plugin : AbstractPlugin
    {
        [Synapse.Api.Plugin.Config(section = "Sizes")]
        public static Config Config;
        public override void Load()
        {
            SynapseController.Server.Logger.Info("Sizes loaded!");

            new EventHandlers();
        }

        public override void ReloadConfigs()
        {

        }
    }
}
