using System;
using System.Collections.Generic;

namespace BrainConsoleApp.OOP
{
    public class Gadget
    {
        public const string DescriptionFormat = "D: {0}, M: {1}";

        public string Title { set; get; }

        public VideoPortsCollection VideoPorts
        {
            get { return _videoPorts; }
        }

        private readonly string _model;

        private readonly VideoPortsCollection _videoPorts; 

        /// <summary>
        /// Constructor with default params
        /// </summary>
        public Gadget() : this("Noname", new VideoPort[0])
        {
        }

        /// <summary>
        /// More customized constructor
        /// </summary>
        /// <param name="model"></param>
        /// <param name="videoPorts"></param>
        public Gadget(string model, VideoPort[] videoPorts)
        {
            _videoPorts = new VideoPortsCollection(videoPorts);
            _model = model;
        }

        public string GetModel()
        {
            return _model;
        }

        public string GetDescription(string format)
        {
            return String.Format(format, Title, GetModel());
        }

        public string GetDescription()
        {
            return GetDescription(DescriptionFormat);
        }
    }
}
