﻿namespace EmotionSample.Logic
{
    public class Love : IEmotion
    {
        public override bool Equals(object obj)
        {
            if (object.ReferenceEquals(obj, this))
            {
                return true;
            }

            return this.ToString().Equals(obj.ToString(), System.StringComparison.OrdinalIgnoreCase);
        }

        public override string ToString()
        {
            return "<3";
        }
    }
}
