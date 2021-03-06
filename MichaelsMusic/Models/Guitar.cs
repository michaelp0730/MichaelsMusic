namespace MichaelsMusic.Models
{
    public class Guitar : Item
    {
        public string Binding { get; set; }
        public string BodyMaterial { get; set; }
        public string BodyStyle { get; set; }
        public string Bridge { get; set; }
        public string BridgePickup { get; set; }
        public string Capacitors { get; set; }
        public bool CarvedTop { get; set; }
        public string Case { get; set; }
        public bool CoilTap { get; set; }
        public string Controls { get; set; }
        public string FingerboardRadius { get; set; }
        public string Finish { get; set; }
        public string Fretboard { get; set; }
        public int? Frets { get; set; }
        public string Fretwire { get; set; }
        public string Headstock { get; set; }
        public string InlayMaterial { get; set; }
        public string InlayShape { get; set; }
        public bool IsHardtail { get; set; }
        public string Knobs { get; set; }
        public string MiddlePickup { get; set; }
        public string NeckBinding { get; set; }
        public string NeckFinish { get; set; }
        public string NeckJoint { get; set; }
        public string NeckMaterial { get; set; }
        public string NeckPickup { get; set; }
        public string NeckShape { get; set; }
        public string Nut { get; set; }
        public string Pickguard { get; set; }
        public string PickupSelector { get; set; }
        public string ScaleLength { get; set; }
        public int? Strings { get; set; }
        public string Tuners { get; set; }
    }
}