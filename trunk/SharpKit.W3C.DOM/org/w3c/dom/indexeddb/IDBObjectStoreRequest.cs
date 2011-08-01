//AutoGenerated

namespace org.w3c.dom.indexeddb
{

    public interface IDBObjectStoreRequest : IDBObjectStore
    {
        // IDBObjectStoreRequest
        IDBRequest request {get;}
        void put(object value);
        void put(object value, object key);
        void put(object value, object key, bool noOverwrite);
        void remove(object key);
        void get(object key);
        void openCursor();
        void openCursor(IDBKeyRange range);
        void openCursor(IDBKeyRange range, short direction);
    }

}