//AutoGenerated

namespace org.w3c.dom.html
{

    public interface UndoManager
    {
        // UndoManager
        int length {get;}
        object item(int index);
        int position {get;}
        int add(object data, string title);
        void remove(int index);
        void clearUndo();
        void clearRedo();
    }

}