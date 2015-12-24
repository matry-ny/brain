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

        public string Serial
        {
            get { return _serial; }
        }

        private readonly string _model;
        private readonly string _serial;

        private VideoPortsCollection _videoPorts; 

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
        public Gadget(string model, VideoPort[] videoPorts, string serial = "000-00-00")
        {
            _videoPorts = new VideoPortsCollection(videoPorts);
            _model = model;
            _serial = serial;
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

        protected bool Equals(Gadget other)
        {
            return string.Equals(_serial, other._serial);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Gadget) obj);
        }

        public override int GetHashCode()
        {
            return (_serial != null ? _serial.GetHashCode() : 0);
        }

        public static bool operator ==(Gadget left, Gadget right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Gadget left, Gadget right)
        {
            return !Equals(left, right);
        }

        public Gadget Clone()
        {
            var copy = (Gadget)MemberwiseClone();
            copy._videoPorts = this._videoPorts.Clone();

            return copy;
        }
    }
}
