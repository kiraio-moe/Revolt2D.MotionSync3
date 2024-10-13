using Revolt2D.MotionSync.Settings.Json;

namespace Revolt2D.MotionSync.Json
{
    public class Setting
    {
        public string Id;
        public string AnalysisType;
        public string UseCase;
        public List<CubismParameter> CubismParameters;
        public List<AudioParameter> AudioParameters;
        public List<Mapping> Mappings;
        public PostProcessing PostProcessing;

        public override string ToString()
        {
            string cubismParametersString = string.Join(
                "\n",
                CubismParameters.Select((c, i) => $"      Cubism Parameter[{i}]:\n{c}")
            );
            string audioParametersString = string.Join(
                "\n",
                AudioParameters.Select((a, i) => $"      Audio Parameter[{i}]:\n{a}")
            );
            string mappingsString = string.Join(
                "\n",
                Mappings.Select((m, i) => $"      Mapping[{i}]:\n{m}")
            );

            return $"    Id: {Id}\n    Analysis Type: {AnalysisType}\n    Use Case: {UseCase}\n    Cubism Parameters:\n{cubismParametersString}\n    Audio Parameters:\n{audioParametersString}\n    Mappings:\n{mappingsString}\n    Post Processing:\n{PostProcessing}";
        }
    }
}
