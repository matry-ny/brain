using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace BrainConsoleApp.OOP
{
    public class VideoPortsCollection 
    {
        private readonly VideoPort[] _videoPorts;

        public VideoPortsCollection(VideoPort[] videoPorts)
        {
            _videoPorts = videoPorts;
        }

        public int Count
        {
            get { return _videoPorts.Length; }
        }

        public VideoPort this[int index]
        {
            get { return _videoPorts[index]; }
        }

        public VideoPortsCollection Clone()
        {
            return new VideoPortsCollection(_videoPorts.ToArray());
        }
    }
}
