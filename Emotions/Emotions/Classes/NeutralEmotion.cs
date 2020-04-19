using System;
using System.Collections.Generic;
using System.Text;

namespace Emotions.Classes
{
    public sealed class NeutralEmotion : Emotion
    {
        public override string EmotionalSpeech(string text)
        {
            return "PokerFace: " + text;
        }

        public override string FaceExpression()
        {
            return "('__')";
        }
    }
}
