using SharpKit.JavaScript;
//AutoGenerated

namespace org.w3c.dom.webgl
{

    public interface WebGLShortArray : WebGLArray
    {
        // WebGLShortArray
//TODO: Interfaces cannot contain fields in .NET:
//        public static final int BYTES_PER_ELEMENT = 2;
        short get(int index);
        void set(int index, short value);
        void set(WebGLShortArray array);
        void set(WebGLShortArray array, int offset);
        void set(short[] array);
        void set(short[] array, int offset);
    }

}
