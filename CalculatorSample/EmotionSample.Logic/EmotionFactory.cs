namespace EmotionSample.Logic
{

    public class EmotionFactory : IEmotionFactory
    {
        public IEmotion Get(EmotionTypes emotionTypes)
        {
            switch (emotionTypes)
            {
                case EmotionTypes.Happiness:
                    return new Happiness();
                case EmotionTypes.Love:
                    return new Love();
                default:
                    throw new System.Exception();
            }
        }
    }
}
