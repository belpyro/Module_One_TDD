using System;
using System.Collections.Generic;
using System.Text;

namespace Emotions.Classes
{
    public class EmotionalMan
    {
        Emotion emotion;
        public EmotionalMan(Emotion emotion)
        {
            this.emotion = emotion;
        }

        public string EmotionalSpeech(string speech)
        {
            return emotion.EmotionalSpeech(speech) + emotion.FaceExpression();
        }
    }
}
