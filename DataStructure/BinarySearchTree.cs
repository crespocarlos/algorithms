using console_app.Domain;

namespace console_app.DataStructure
{
    public class BinarySearchTree
    {
        private TreeNode root;

        public void Insert(int data) {
            if (this.root == null) {
                this.root = new TreeNode(data);
            }
            else {
                this.root.Insert(data);
            }
        }

        public TreeNode Find(int data) {
            if (root != null) {
                return root.Find(data);
            }

            return null;
        }

        public void Delete(int data) {
            TreeNode toDelete = Find(data);
            toDelete.Delete();
        }

        public int? Smallest() {
            if (this.root != null) {
                return this.root.Smallest();
            }

            return null;
        }

        public int? Largest() {
            if (this.root != null) {
                return this.root.Largest();
            }

            return null;
        }

        public int LeafCount() {
            if (this.root == null) {
                return 0;
            }

            return this.root.LeafCount();
        }

        public int GetHeight() {
            if (this.root == null) {
                return 0;
            }

            return this.root.GetHeight();
        }

        public void TraverseInOrder() {
            if (this.root == null) {
                return;
            }

            this.root.TraverseInOrder();
        }
    }
}