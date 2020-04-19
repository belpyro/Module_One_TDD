using System;
using System.Collections.Generic;
using System.Text;

namespace Emotions.Classes
{
    public sealed class ConfusedEmotion : Emotion
    {
        public override string EmotionalSpeech(string text)
        {
            return "Murmuring: " + text + "???....";
        }

        public override string FaceExpression()
        {
            return "(*_*)";
        }
    }
}
