//AutoGenerated

namespace org.w3c.dom.ranges
{

    public class RangeException : Exception
    {
        public RangeException(short code, string message) : base(message)
        {
            this.code = code;
        }
        public const short BAD_BOUNDARYPOINTS_ERR = 1;
        public const short INVALID_NODE_TYPE_ERR = 2;
        public short code;
    }

}