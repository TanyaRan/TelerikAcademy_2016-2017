namespace School
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text; 

    public interface ICommentable
    {
        List<string> Comments { get;}

        void AddComments(string newComment);
    }
}
