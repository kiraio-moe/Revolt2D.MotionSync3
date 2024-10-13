using Revolt2D.MotionSync.Settings.Mapping.Json;

namespace Revolt2D.MotionSync.Settings.Json
{
    public class Mapping
    {
        public string Type;
        public string Id;
        public List<Target> Targets;

        public override string ToString()
        {
            string targetsString = string.Join(
                "\n",
                Targets.Select((t, i) => $"          Target[{i}:\n{t}]")
            );
            return $"        Type: {Type}\n        Id: {Id}\n        Targets:\n{targetsString}";
        }
    }
}
