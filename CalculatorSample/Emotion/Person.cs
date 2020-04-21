
namespace EmotionSample.Logic
{
    public class Person
    {
        private readonly IEmotionFactory _factory;
        public Person(IEmotionFactory factory)
        {
            _factory = factory;
        }
        public bool HasEmotion => Emotion != null;
        public IEmotion Emotion { get; protected set; }

        public void ReceiveKnowledge()
        {
            Emotion = _factory.Get(EmotionTypes.Self_Confidence);
        }

        public void ReceiveNonchalant()
        {
            Emotion = _factory.Get(EmotionTypes.Calm);
        }
    }
}
