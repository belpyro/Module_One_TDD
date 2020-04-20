namespace EmotionSample.Logic
{
    public interface IEmotionFactory
    {
        IEmotion Get(EmotionTypes emotionTypes);
    }
}