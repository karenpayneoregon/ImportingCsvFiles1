using System;

namespace ForumQuestionTabbed.Classes
{
    public class LineDataArgs : EventArgs
    {
        protected string[] Line;

        public LineDataArgs(string[] sender)
        {
            Line = sender;
        }
        public string[] LineArray => Line;
    }
}