namespace Revolt2D.MotionSync.Settings.Json
{
    public class CubismParameter
    {
        public string Name;
        public string Id;
        public double Min;
        public double Max;
        public double Damper;
        public int Smooth;

        public override string ToString()
        {
            return $"        Name: {Name}\n        Id: {Id}\n        Min: {Min}\n        Max: {Max}\n        Damper: {Damper}\n        Smooth: {Smooth}";
        }
    }
}
