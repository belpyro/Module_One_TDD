using System;

namespace EmotionSample.Logic
{
    public class EmotionFactory : IEmotionFactory
    {
        public IEmotion Get(EmotionTypes emotionTypes)
        {
            switch (emotionTypes)
            {
                case EmotionTypes.Self_Confidence:
                    return new Self_Confidence();

                case EmotionTypes.Calm:
                    return new Calm();
                default:
                    throw new ArgumentException();
            }
        }
    }
}
