using HumanEmotions.Emotions;
using HumanEmotions.Emotions.Interface;
using HumanEmotions.Logger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestEmotion.Interface;

namespace HumanEmotions.Factory
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
                case EmotionTypes.Security:
                    return new Security();
                default:
                    throw new Exception();
            }
        }
    }
}
