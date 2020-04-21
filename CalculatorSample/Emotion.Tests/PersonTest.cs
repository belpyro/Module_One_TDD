using EmotionSample.Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EmotionSample.Tests
{
    [TestClass]
    public class PersonTest
    {
        [TestMethod]
        public void Person_Has_Recievied_Awesome_Knowledge_Test()
        {
            //Arrange
            var person = new Person(new EmotionFactory());
            //Act
            person.ReceiveKnowledge();
            //Assert
            Assert.IsTrue(person.HasEmotion);
            Assert.AreEqual(new Self_Confidence(), person.Emotion);
        }

        [TestMethod]
        public void Person_Has_Recievied_Full_Nonchalant_Test()
        {
            //Arrange
            var person = new Person(new EmotionFactory());
            //Act
            person.ReceiveNonchalant();
            //Assert
            Assert.IsTrue(person.HasEmotion);
            Assert.AreEqual(new Calm(), person.Emotion);
        }
    }
}
