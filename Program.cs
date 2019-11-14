using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InOrderTraverse
{
    class Program
    {
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { val = x; }
        }
        public class Solution
        {
            public IList<int> InorderTraversal(TreeNode root)
            {
                IList<int> list = new List<int>();
                if (root == null)
                    return list;

                Stack<TreeNode> stk = new Stack<TreeNode>();
                TreeNode curr = root;

                while (curr != null || stk.Count() > 0)
                {
                    while (curr != null)
                    {
                        stk.Push(curr);
                        curr = curr.left;
                    }
                    curr = stk.Pop();
                    list.Add(curr.val);
                    curr = curr.right;
                }
                return list;
            }
        }
        static void Main(string[] args)
        {
            TreeNode tree = new TreeNode(1);
            tree.left = new TreeNode(2);
            tree.right = new TreeNode(3);
            tree.left.left = new TreeNode(4);
            tree.left.right = new TreeNode(5);
            Solution s = new Solution();
            s.InorderTraversal(tree);
        }
    }
}
