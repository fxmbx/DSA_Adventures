using System.Security;
using System.Security.Cryptography.X509Certificates;

namespace Intro.ADT.Search.BinarySearch
{
    public class BinarySearchTree
    {
        public TreeNode Root { get; set; } = null;

        public void Insert(int key, string value){
            Root = InsertItem(Root, key, value);
        }

        private TreeNode InsertItem(TreeNode node, int key, string value){
            var newNode = new TreeNode(key, value);
            if(node == null){
                node = newNode;
                return node;
            }
            if(key < node.Key){
                node.LeftChild = InsertItem(node.LeftChild, key, value);
            }else{
                node.RightChild = InsertItem(node.RightChild, key, value);
            }
            return node;

        }

        public string Find(int key){
            TreeNode node = Find(Root, key);
            return node == null? null : node.Value;
        }

        private TreeNode? Find(TreeNode node, int  key){
            if(node == null || node.Key == key ){
                return node;
            }else if(key < node.Key){
                return Find(node.LeftChild, key);
            }else if(key > node.Key){
                return Find(node.RightChild, key);
            }
            return null;
        }
    }
}