using Revolt2D.MotionSync.Meta.Json;

namespace Revolt2D.MotionSync.Json
{
    public class Meta
    {
        public int SettingCount;
        public List<Dictionary> Dictionary;

        public override string ToString()
        {
            string dictionaryString = string.Join(
                "\n",
                Dictionary.Select((d, i) => $"    Dictionary[{i}]:\n{d}")
            );
            return $"  Setting Count: {SettingCount}\n  Dictionary:\n{dictionaryString}";
        }
    }
}
