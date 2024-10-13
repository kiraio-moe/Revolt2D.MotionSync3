namespace Revolt2D.MotionSync.Settings.Json
{
    public class PostProcessing
    {
        public double BlendRatio;
        public int Smoothing;
        public double SampleRate;

        public override string ToString()
        {
            return $"      Blend Ration: {BlendRatio}\n      Smoothing: {Smoothing}\n      Sample Rate: {SampleRate}";
        }
    }
}
