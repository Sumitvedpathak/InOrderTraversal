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
}
