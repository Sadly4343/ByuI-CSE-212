using System.Reflection.Metadata.Ecma335;
using System.Windows.Markup;

public class Node
{
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data)
    {
        this.Data = data;
    }

    public void Insert(int value)
    {
        // TODO Start Problem 1



        if (value < Data && value != Data)
        {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        else
        {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else if (Right.Data != value)
                Right.Insert(value);
        }
    }

    public bool Contains(int value)
    {
        if (Data == value)
        {
            return true;
        }
        else
        {

            if (Left is not null && Left.Data == value)
            {
                return true;
            }
            else if (Right is not null && Right.Data == value)
            {
                return true;
            }
            else if (Right is not null)
            {
                return Right.Contains(value);
            }
            return false;


        }

    }

    public int GetHeight()
    {
        if (Left is null && Right is null)
        {
            return 0;
        }
        return 0;
    }
}
