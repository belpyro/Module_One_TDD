using EmotionSample.Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EmotionSample.Tests
{
    [TestClass]
    public class HumanTest
    {
        [TestMethod]
        public void Human_Has_Recievied_Awesome_Gift_Test()
        {
            //Arrange
            var human = new Human(new EmotionFactory());
            //Act
            human.RecieveGift();
            //Assert
            // все хорошо если человек испытывает эмоцию И эмоция это радость -> человек улыбается
            Assert.IsTrue(human.HasEmotion);
            Assert.AreEqual(new Happiness(), human.Emotion);
        }

        [TestMethod]
        public void Human_Has_Got_A_Lot_Of_Smart_Test()
        {
            //Arrange
            var human = new Human(new EmotionFactory());
            //Act
            human.AddSmart();
            //Assert            
            Assert.IsTrue(human.HasEmotion);
            Assert.AreEqual(new Love(), human.Emotion);
        }
    }
}
