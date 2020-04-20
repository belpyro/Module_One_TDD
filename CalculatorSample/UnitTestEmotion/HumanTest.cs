using System;
using HumanEmotions;
using HumanEmotions.Emotions;
using HumanEmotions.Factory;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestEmotion.Interface;

namespace UnitTestEmotion
{
    [TestClass]
    public class HumanTest
    {
        [TestMethod]
        public void Human_Has_Recieving_Awesome_Gift_Test()
        {
            //Arange
            var human = new Human(new EmotionFactory());
            //Act
            human.RecieveGift();
            //Asert
            Assert.IsTrue(human.HasEmotion);
            Assert.AreEqual(new Happiness(), human.Emotion);
        }
        [TestMethod]
        public void Human_Has_Got_A_Lot_Of_Smart_Test()
        {

            var human = new Human(new EmotionFactory());
            human.AddSmart();
            Assert.IsTrue(human.HasEmotion);
            Assert.AreEqual(new Love(), human.Emotion);
        }
        [TestMethod]
        public void Human_Makes_SelfIsolation()
        { 
            var human = new Human(new EmotionFactory());
            human.StayAtHome();
            Assert.IsTrue(human.HasEmotion);
            Assert.AreEqual(new Security (), human.Emotion);
        }

    }
}
