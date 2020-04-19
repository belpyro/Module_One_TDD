using System;
using System.Collections.Generic;
using System.Text;
using Emotions.Interfaces;

namespace Emotions.Classes
{
    public abstract class Emotion : IVoiceExpressoin,  IFacialExpression
    {
        public abstract string EmotionalSpeech(string text);

        public abstract string FaceExpression();
  
    }
}
