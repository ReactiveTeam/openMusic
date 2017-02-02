using PluginCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace openMusic
{
    public class openMusic : IPlugin
    {
        public string navItem
        {
            get
            {
                return "music";
            }
        }

        public string pluginAuthor
        {
            get
            {
                return "Reactive Team";
            }
        }

        public string pluginDescription
        {
            get
            {
                return "The default music player on Reactive";
            }
        }

        public string pluginName
        {
            get
            {
                return "Open Music";
            }
        }

        public string pluginVersion
        {
            get
            {
                return "1.0";
            }
        }

        public void Start()
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }

        public void Tick()
        {
            throw new NotImplementedException();
        }
    }
}
