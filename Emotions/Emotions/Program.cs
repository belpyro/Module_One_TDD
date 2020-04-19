
using Emotions.Classes;
using System;

namespace Emotions
{
    class Program
    {
        static void Main(string[] args)
        {
            EmotionalMan man = new EmotionalMan();
         
            Console.WriteLine(man.AngrySpeech("I hate everybody in the world"));
            Console.WriteLine(man.ConfusedSpeech("What the hell is going on"));
            Console.WriteLine(man.HappySpeech("I love this game"));
            Console.WriteLine(man.NervousSpeech("Don't touch me I'm learning SOLID principies"));
            Console.WriteLine(man.NeutralSpeech("Everything is ok. Like usual")) ;
            Console.WriteLine(man.SadSpeech("I'm not going to swim at the sea this summer"));


        }
    }
}
