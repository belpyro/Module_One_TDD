using HumanEmotions.Emotions.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanEmotions.Factory
{
    public interface IEmotionFactory
    {
        IEmotion Get(EmotionTypes emotionTypes);
    }
}
