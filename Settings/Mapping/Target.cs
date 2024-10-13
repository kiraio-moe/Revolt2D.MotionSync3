namespace Revolt2D.MotionSync.Settings.Mapping.Json
{
    public class Target
    {
        public string Id;
        public double Value;

        public override string ToString()
        {
            return $"            Id: {Id}\n            Value: {Value}";
        }
    }
}
