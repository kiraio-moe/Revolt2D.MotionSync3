using System.Text.Json;

namespace Revolt2D.MotionSync.Json
{
    public class MotionSync3Loader
    {
        private MotionSync3 _motionsync;

        public MotionSync3Loader(string filePath)
        {
            _motionsync = LoadFromFile(filePath);
        }

        public MotionSync3 GetMotionSync()
        {
            return _motionsync;
        }

        public MotionSync3? LoadFromFile(string filePath)
        {
            if (string.IsNullOrEmpty(filePath) || !File.Exists(filePath))
                throw new Exception($"Invalid path! {filePath}");

            string? jsonData = File.ReadAllText(filePath);
            return LoadJson(jsonData);
        }

        public MotionSync3? LoadJson(string jsonData)
        {
            try
            {
                if (string.IsNullOrEmpty(jsonData))
                    throw new Exception("JSON data empty!");

                JsonSerializerOptions options = new JsonSerializerOptions { IncludeFields = true };
                return JsonSerializer.Deserialize<MotionSync3>(jsonData, options);
            }
            catch (Exception ex)
            {
                throw new Exception($"{ex.Message}");
            }
        }
    }
}
