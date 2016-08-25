namespace MichaelsMusic.Models
{
    public class Amp : Item
    {
        public bool EffectsLoop { get; set; }
        public bool IsCombo { get; set; }
        public bool NoTubes { get; set; }
        public bool OnboardEffects { get; set; }
        public bool Reverb { get; set; }
        public bool Tremolo { get; set; }
        public int NumChannels { get; set; }
        public int NumInputs { get; set; }
        public int NumSpeakers { get; set; }
        public int SpeakerSize { get; set; }
        public int Watts { get; set; }
        public string GrillCloth { get; set; }
        public string PowerampTubes { get; set; }
        public string PreampTubes { get; set; }
        public string Rectifier { get; set; }
        public string Speakers { get; set; }
    }
}