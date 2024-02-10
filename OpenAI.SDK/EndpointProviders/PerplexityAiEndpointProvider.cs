using OpenAI.ObjectModels.RequestModels;

namespace OpenAI.EndpointProviders;

internal class PerplexityAiEndpointProvider : IOpenAiEndpointProvider
{
    public PerplexityAiEndpointProvider()
    {
    }

    public string ChatCompletionCreate()
    {
        return $"chat/completions";
    }

    public string ModelRetrieve(string model) => throw new NotSupportedException(nameof(ModelRetrieve) + "  is not supported with PerplexityAi provider type");
    public string FileDelete(string fileId) => throw new NotSupportedException(nameof(FileDelete) + " is not supported with PerplexityAi provider type");
    public string CompletionCreate() => throw new NotSupportedException(nameof(CompletionCreate) + " is not supported with PerplexityAi provider type");
    public string EditCreate() => throw new NotSupportedException(nameof(EditCreate) + " is not supported with PerplexityAi provider type");
    public string ModelsList() => throw new NotSupportedException(nameof(ModelsList) + " is not supported with PerplexityAi provider type");
    public string FilesList() => throw new NotSupportedException(nameof(FilesList) + " is not supported with PerplexityAi provider type");
    public string FilesUpload() => throw new NotSupportedException(nameof(FilesUpload) + " is not supported with PerplexityAi provider type");
    public string FileRetrieve(string fileId) => throw new NotSupportedException(nameof(FileRetrieve) + " is not supported with PerplexityAi provider type");
    public string FileRetrieveContent(string fileId) => throw new NotSupportedException(nameof(FileRetrieveContent) + " is not supported with PerplexityAi provider type");
    public string FineTuneCreate() => throw new NotSupportedException(nameof(FineTuneCreate) + " is not supported with PerplexityAi provider type");
    public string FineTuneList() => throw new NotSupportedException(nameof(FineTuneList) + " is not supported with PerplexityAi provider type");
    public string FineTuneRetrieve(string fineTuneId) => throw new NotSupportedException(nameof(FineTuneRetrieve) + " is not supported with PerplexityAi provider type");
    public string FineTuneCancel(string fineTuneId) => throw new NotSupportedException(nameof(FineTuneCancel) + " is not supported with PerplexityAi provider type");
    public string FineTuneListEvents(string fineTuneId) => throw new NotSupportedException(nameof(FineTuneListEvents) + " is not supported with PerplexityAi provider type");
    public string FineTuneDelete(string fineTuneId) => throw new NotSupportedException(nameof(FineTuneDelete) + " is not supported with PerplexityAi provider type");
    public string FineTuningJobCreate() => throw new NotSupportedException(nameof(FineTuningJobCreate) + " is not supported with PerplexityAi provider type");
    public string FineTuningJobList(FineTuningJobListRequest? fineTuningJobListRequest) => throw new NotSupportedException(nameof(FineTuningJobList) + " is not supported with PerplexityAi provider type");
    public string FineTuningJobList() => throw new NotSupportedException(nameof(FineTuningJobList) + " is not supported with PerplexityAi provider type");
    public string FineTuningJobRetrieve(string fineTuningJobId) => throw new NotSupportedException(nameof(FineTuningJobRetrieve) + " is not supported with PerplexityAi provider type");
    public string FineTuningJobCancel(string fineTuningJobId) => throw new NotSupportedException(nameof(FineTuningJobCancel) + " is not supported with PerplexityAi provider type");
    public string FineTuningJobListEvents(string fineTuningJobId) => throw new NotSupportedException(nameof(FineTuningJobListEvents) + " is not supported with PerplexityAi provider type");
    public string ModelsDelete(string modelId) => throw new NotSupportedException(nameof(ModelsDelete) + " is not supported with PerplexityAi provider type");
    public string EmbeddingCreate() => throw new NotSupportedException(nameof(EmbeddingCreate) + " is not supported with PerplexityAi provider type");
    public string ModerationCreate() => throw new NotSupportedException(nameof(ModerationCreate) + " is not supported with PerplexityAi provider type");
    public string ImageCreate() => throw new NotSupportedException(nameof(ImageCreate) + " is not supported with PerplexityAi provider type");
    public string ImageEditCreate() => throw new NotSupportedException(nameof(ImageEditCreate) + " is not supported with PerplexityAi provider type");
    public string ImageVariationCreate() => throw new NotSupportedException(nameof(ImageVariationCreate) + " is not supported with PerplexityAi provider type");
    public string AudioCreateTranscription() => throw new NotSupportedException(nameof(AudioCreateTranscription) + " is not supported with PerplexityAi provider type");
    public string AudioCreateTranslation() => throw new NotSupportedException(nameof(AudioCreateTranslation) + " is not supported with PerplexityAi provider type");
    public string AudioCreateSpeech() => throw new NotSupportedException(nameof(AudioCreateSpeech) + " is not supported with PerplexityAi provider type");
}