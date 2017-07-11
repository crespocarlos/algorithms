namespace console_app.DataStructure
{
    public class HashTable
    {
        private static int TABLE_SIZE = 100;
        private Record[] tableData = new Record[TABLE_SIZE]; // say that we won't get more than 100 records
        
        public void Put(object key, object value) {
            int keyCode = key.GetHashCode();
            if (keyCode < 0) {
                keyCode = keyCode * -1;
            }
            
            int step = 0;
            int slot = Hash(keyCode, step);
            while (!isEmpty(slot)) {
                slot = Hash(keyCode, ++step);
            }
            tableData[slot] = new Record(key, value);
        }
        
        public bool KeyExists(object key) {
            int keyCode = key.GetHashCode();
            int step = 0;
            int slot = Hash(keyCode, step);
            while (tableData[slot] != null && !tableData[slot].GetKey().Equals(key)) {
                slot = Hash(keyCode, ++step);
            }
            if (tableData[slot] != null) return true;
            return false;
        }
        
        public object Get(object key) {
            int keyCode = key.GetHashCode();
            int step = 0;
            int slot = Hash(keyCode, step);
            while (tableData[slot] != null && !tableData[slot].GetKey().Equals(key)) {
                slot = Hash(keyCode, ++step);
            }
            if (tableData[slot] != null) return tableData[slot].getData();
            return null;
        }
        
        private int Hash(int key, int step) {
            if (step == 0)
                return key % TABLE_SIZE;
            return (key % TABLE_SIZE + step*step) % TABLE_SIZE;
        }
        
        private bool isEmpty(int slot) {
            return tableData[slot] == null;
        }
        
        private class Record {
            object key;
            object data;

            public Record(object key, object data) {
                this.key = key;
                this.data = data;
            }
            
            public object GetKey() {
                return this.key;
            }
            
            public object getData() {
                return this.data;
            }
        }
    }
}