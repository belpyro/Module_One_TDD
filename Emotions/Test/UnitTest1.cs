using NUnit.Framework;
using System;
using Emotions.Classes;
using Moq;
using System.Linq.Expressions;

namespace Test
{
    [TestFixture]
    public class Tests
    {


        [Test]
        public void Angry_Emotion_Test ()
        {
            Assert.AreEqual(expected: "Shout: TEST TEXT!!!(!>_<!)"  , new EmotionalMan(new AngryEmotion()).EmotionalSpeech("Test text"));
        }

        [Test]
        public void Confused_Emotion_Test()
        {
            Assert.AreEqual(expected: "Murmuring: Test text???....(*_*)", new EmotionalMan(new ConfusedEmotion()).EmotionalSpeech("Test text"));
        }

        [Test]
        public void Happy_Emotion_Test()
        {
            Assert.AreEqual(expected: "Smilling: TEST TEXT)))))('o')", new EmotionalMan(new HappyEmotion()).EmotionalSpeech("Test text"));
        }

        [Test]
        public void Nervous_Emotion_Test()
        {
            Assert.AreEqual(expected: "Emotionaly shout: !!!TEST TEXT!!!(!>o<!)", new EmotionalMan(new NervousEmotion()).EmotionalSpeech("Test text"));
        }

        [Test]
        public void Neutral_Emotion_Test()
        {
            Assert.AreEqual(expected: "PokerFace: Test text('__')", new EmotionalMan(new NeutralEmotion()).EmotionalSpeech("Test text"));
        }

        [Test]
        public void Sad_Emotion_Test()
        {
            Assert.AreEqual(expected: "Upset: test text((((-__-)", new EmotionalMan(new SadEmotion()).EmotionalSpeech("Test text"));
        }
    }
}