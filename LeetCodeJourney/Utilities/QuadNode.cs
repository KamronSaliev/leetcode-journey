namespace LeetCode.Utilities
{
    public class QuadNode
    {
        public bool val;
        public bool isLeaf;
        public QuadNode topLeft;
        public QuadNode topRight;
        public QuadNode bottomLeft;
        public QuadNode bottomRight;

        public QuadNode()
        {
            val = false;
            isLeaf = false;
            topLeft = null;
            topRight = null;
            bottomLeft = null;
            bottomRight = null;
        }

        public QuadNode(bool _val, bool _isLeaf)
        {
            val = _val;
            isLeaf = _isLeaf;
            topLeft = null;
            topRight = null;
            bottomLeft = null;
            bottomRight = null;
        }

        public QuadNode(bool _val, bool _isLeaf, QuadNode _topLeft, QuadNode _topRight, QuadNode _bottomLeft,
            QuadNode _bottomRight)
        {
            val = _val;
            isLeaf = _isLeaf;
            topLeft = _topLeft;
            topRight = _topRight;
            bottomLeft = _bottomLeft;
            bottomRight = _bottomRight;
        }
    }
}