namespace Revolt2D.MotionSync.Json
{
    public class MotionSync3
    {
        public int Version;
        public Meta Meta;
        public List<Setting> Settings;

        public override string ToString()
        {
            string settingsString = string.Join(
                "\n",
                Settings.Select((s, i) => $"  Setting[{i}]:\n{s}")
            );
            return $"Version: {Version}\nMeta:\n{Meta}\nSettings:\n{settingsString}";
        }
    }
}
