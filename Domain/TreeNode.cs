namespace console_app.Domain
{
    public class TreeNode
    {
        public int Data { get; set; }
        public TreeNode LeftChild { get; set; }
        public TreeNode RightChild { get; set; }

        public bool IsDeleted { get; set; } = false;

        public TreeNode(int data)
        {
            this.Data = data;
        }

        public void Delete() {
            this.IsDeleted = true;
        }

        public TreeNode Find(int data) {
            if (data  == this.Data && !this.IsDeleted) {
                return this;
            }

            if (data < this.Data && this.LeftChild != null) {
                return this.LeftChild.Find(data);
            }

            if (this.RightChild != null) {
                return this.RightChild.Find(data);
            }

            return null;
        }

        public void Insert(int data) {
            if (data >= this.Data) {
                if (this.RightChild == null) {
                    this.RightChild = new TreeNode(data);
                }
                else {
                    this.RightChild.Insert(data);
                }
            }
            else {
                if (this.LeftChild == null) {
                    this.LeftChild = new TreeNode(data);
                } else {
                    this.LeftChild.Insert(data);
                }
            }
        }

        public int Smallest() {
            if (this.LeftChild == null) {
                return this.Data;
            }

            return this.LeftChild.Smallest();
        }

        public int Largest() {
            if (this.RightChild == null) {
                return this.Data;
            }

            return this.RightChild.Largest();
        }

        public int LeafCount() {
            int count = 0;
            if (this.LeftChild != null) {
                count+=this.LeftChild.LeafCount();
            } else {
                count++;
            }

            if (this.RightChild != null) {
                count+=this.RightChild.LeafCount();
            } else {
                count++;
            }

            return count;
        }

        public int GetHeight() {
            int height = 0;
            if (this.RightChild != null || this.LeftChild != null) {
                height++;
                if (this.RightChild != null) {
                    height+= this.RightChild.GetHeight();
                }

                if (this.LeftChild != null) {
                    height += this.LeftChild.GetHeight();
                }
            }

            return height;
            
        }

        public void TraverseInOrder() {
            if (this.LeftChild != null) {
                this.LeftChild.TraverseInOrder();
            }

            System.Console.WriteLine(this.Data);

            if (this.RightChild != null) {
                this.RightChild.TraverseInOrder();
            }
        }
    }
}