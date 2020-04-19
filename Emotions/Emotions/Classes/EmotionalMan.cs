using System;
using System.Collections.Generic;
using System.Text;

namespace Emotions.Classes
{
    public class EmotionalMan
    {
        public string AngrySpeech(string speech)
        {
            return $"Shout: {speech.ToUpper()}!!!(!>_<!)";
        }

        public string ConfusedSpeech(string speech)
        {
            return $"Murmuring: {speech}???....(*_*)";
        }

        public string HappySpeech(string speech)
        {
            return $"Smilling: {speech.ToUpper()})))))('o')";
        }

        public string NervousSpeech(string speech)
        {
            return $"Emotionaly shout: !!!{speech.ToUpper()}!!!(!>o<!)";
        }

        public string NeutralSpeech(string speech)
        {
            return $"PokerFace: {speech}('__')";
        }

        public string SadSpeech(string speech)
        {
            return $"Upset: {speech.ToLower()}((((-__-)";
        }
    }
}
