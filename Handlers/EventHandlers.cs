
using MEC;
using Sizes;
using Synapse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Sizes.Handlers
{
    class EventHandlers
    {
        public EventHandlers()
        {
            Server.Get.Events.Player.PlayerSetClassEvent += onSetClass;
        }


        public void onSetClass(Synapse.Api.Events.SynapseEventArguments.PlayerSetClassEventArgs ev)
        {
            if (Plugin.Config.isEnabled == true)
            {
                float x = UnityEngine.Random.Range(Plugin.Config.minimumVolume, Plugin.Config.maximumVolume);
                float y = UnityEngine.Random.Range(Plugin.Config.minimumSize, Plugin.Config.maximumSize);
                float z = UnityEngine.Random.Range(Plugin.Config.minimumSize, Plugin.Config.maximumSize);
                Timing.CallDelayed(1f, () =>
                {
                    ev.Player.Position.Set(ev.Player.Position.x, ev.Player.Position.y + 1, ev.Player.Position.z);
                    ev.Player.Scale = new Vector3(x, y, z);
                });
            }
        }
    }
}
