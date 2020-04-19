using System;
using System.Collections.Generic;
using System.Text;

namespace Emotions.Classes
{
    public sealed class  AngryEmotion : Emotion
    {
        public override string EmotionalSpeech(string text)
        {         
            return "Shout: " + text.ToUpper() + "!!!";
        }

        public override string FaceExpression()
        {
            return "(!>_<!)";
        }
    }
}
