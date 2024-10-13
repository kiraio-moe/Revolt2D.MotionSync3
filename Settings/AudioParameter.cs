namespace Revolt2D.MotionSync.Settings.Json
{
    public class AudioParameter
    {
        public string Name;
        public string Id;
        public double Min;
        public double Max;
        public double Scale;
        public bool Enabled;

        public override string ToString()
        {
            return $"        Name: {Name}\n        Id: {Id}\n        Min: {Min}\n        Max: {Max}\n        Scale: {Scale}\n        Enabled: {Enabled}";
        }
    }
}
