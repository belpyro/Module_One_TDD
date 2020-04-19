using System;
using System.Collections.Generic;
using System.Text;

namespace Emotions.Classes
{
    public sealed class HappyEmotion : Emotion
    {
        public override string EmotionalSpeech(string text)
        {
            return "Smilling: " + text.ToUpper() + ")))))";
        }

        public override string FaceExpression()
        {
            return "('o')";
        }
    }
}
