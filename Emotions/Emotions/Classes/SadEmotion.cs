using System;
using System.Collections.Generic;
using System.Text;

namespace Emotions.Classes
{
    public sealed class SadEmotion : Emotion
    {
        public override string EmotionalSpeech(string text)
        {
            return "Upset: " + text.ToLower() + "(((";
        }

        public override string FaceExpression()
        {
            return "(-__-)";
        }
    }
}
