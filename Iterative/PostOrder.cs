using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InOrderTraverse.Iterative
{
    public class InOrder
    {
        public IList<int> Traversal(TreeNode root)
        {
            IList<int> list = new List<int>();
            if (root == null)
                return list;
            Stack<TreeNode> stk = new Stack<TreeNode>();

            TreeNode currNode, prevNode;
            currNode = prevNode = root;
            stk.Push(currNode);
            while (stk.Count() > 0)
            {
                while (currNode.left != null)
                {
                    stk.Push(currNode.left);
                    prevNode = currNode;
                    currNode = currNode.left;
                }
            }
            return list;
        }
    }
}
