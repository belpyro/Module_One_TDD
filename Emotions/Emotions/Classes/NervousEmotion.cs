using System;
using System.Collections.Generic;
using System.Text;

namespace Emotions.Classes
{
    public sealed class NervousEmotion : Emotion
    {
        public override string EmotionalSpeech(string text)
        {
            return "Emotionaly shout: " + "!!!" + text.ToUpper() + "!!!"; 
        }

        public override string FaceExpression()
        {
            return "(!>o<!)";
        }
    }
}
