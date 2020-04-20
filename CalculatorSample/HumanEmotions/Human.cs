using HumanEmotions.Emotions;
using HumanEmotions.Emotions.Interface;
using HumanEmotions.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HumanEmotions
{
    public class Human
    {
        private readonly IEmotionFactory _factory;

        public Human(IEmotionFactory factory)
        {
            _factory = factory;
        }

        public bool HasEmotion => Emotion != null;

        public IEmotion Emotion { get; protected set; }

        public void RecieveGift()
        {
            Emotion = _factory.Get(EmotionTypes.Happiness);
        }

        public void AddSmart()
        {
            Emotion = _factory.Get(EmotionTypes.Love);
        }

        public void StayAtHome()
        {
            Emotion = _factory.Get(EmotionTypes.Security);
        }
    }
}
