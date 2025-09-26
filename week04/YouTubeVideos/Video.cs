using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Transactions;

public class Video
{
    public string _trackTitle;
    public string _trackAuthor;
    public int _trackLength;
    public List<Comment> _commentList = new List<Comment>();

    public int NumberOfComments()
    {
        int numberOfComments = _commentList.Count;
        return numberOfComments;
    }
}
