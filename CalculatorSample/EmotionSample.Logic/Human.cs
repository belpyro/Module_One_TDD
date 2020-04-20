namespace EmotionSample.Logic
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
    }
}
