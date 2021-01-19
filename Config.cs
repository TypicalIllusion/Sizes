using Synapse.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Sizes
{
     public class Config : AbstractConfigSection
    {

        public bool isEnabled = true;

        public float minimumSize = 0.85f;

        public float maximumSize = 1.05f;

        public float minimumVolume = 0.8f;

        public float maximumVolume = 1.15f;
    }
}
