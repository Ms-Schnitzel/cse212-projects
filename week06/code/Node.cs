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

        if (value < Data)
        {
            // Insert to the left
            if (Data == value)
                return;
            else if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        else
        {
            // Insert to the right
            if (Data == value)
                return;
            else if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
    }

    public bool Contains(int value)
    {
        // TODO Start Problem 2
        if (Data == value)
            return true;

        if (value < Data)
        {
            return Left != null && Left.Contains(value);
        }
        else
        {
            return Right != null && Right.Contains(value);
        }
    }

    public int GetHeight()
    {
        // TODO Start Problem 4

        if (Left == null && Right == null)
            return 1;
        else
        {
            if (Left == null)
                return Right.GetHeight() + 1;
            if (Right == null)
                return Left.GetHeight() + 1;
            var leftHeight = Left.GetHeight() + 1;
            var rightHeight = Right.GetHeight() + 1;

            if (leftHeight > rightHeight)
                return leftHeight;
            else
                return rightHeight;
        }
        // return 0; // Replace this line with the correct return statement(s)
    }
}