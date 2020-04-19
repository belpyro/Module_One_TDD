
using Emotions.Classes;
using System;

namespace Emotions
{
    class Program
    {
        static void Main(string[] args)
        {
            EmotionalMan angryMan = new EmotionalMan(new AngryEmotion());
            EmotionalMan confusedMan = new EmotionalMan(new ConfusedEmotion());
            EmotionalMan happyMan = new EmotionalMan(new HappyEmotion());
            EmotionalMan nervousMan = new EmotionalMan(new NervousEmotion());
            EmotionalMan neutralMan = new EmotionalMan(new NeutralEmotion());
            EmotionalMan sadMan = new EmotionalMan(new SadEmotion());
            Console.WriteLine(angryMan.EmotionalSpeech("I hate everybody in the world"));
            Console.WriteLine(confusedMan.EmotionalSpeech("What the hell is going on"));
            Console.WriteLine(happyMan.EmotionalSpeech("I love this game"));
            Console.WriteLine(nervousMan.EmotionalSpeech("Don't touch me I'm learning SOLID principies"));
            Console.WriteLine(neutralMan.EmotionalSpeech("Everything is ok. Like usual")) ;
            Console.WriteLine(sadMan.EmotionalSpeech("I'm not going to swim at the sea this summer"));


        }
    }
}
