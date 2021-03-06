 // Definition for a binary tree node.
 // Time and Space Complexity O(n)
using System.Linq;
using System.Collections.Generic;
using System;

namespace BST{
//  public class TreeNode {
//      public int val;
//      public TreeNode left;
//      public TreeNode right;
//      public TreeNode(int x) { val = x; }
//  }
public class Solution_PostOrderTraversal {
    public IList<int> PostOrderTraversal(TreeNode root) {
        IList<int> res = new List<int>();
        if(root == null) return res;

        Stack<TreeNode> st = new Stack<TreeNode>();
        TreeNode curr = root;
        while(curr != null || st.Any()){
            if(curr != null){
            st.Push(curr);
            res.Insert(0,curr.val);
            curr = curr.right;
            }
            else{
                curr = st.Pop();
                curr = curr.left;
            }
        }
        return res;
    }

        /// <summary>
        /// Post Order Traversal Recursive
        /// 1. Traverse the left subtree.
        /// 2. Traverse the right subtree.
        //  3. Visit the root.
        /// </summary>
        /// <param name="rootNode"></param>
        public void PostOrder(TreeNode rootNode)
        {
            if (rootNode.left != null)
            {
                PostOrder(rootNode.left);
            }
            if (rootNode.right != null)
            {
                PostOrder(rootNode.right);
            }
            Console.WriteLine(rootNode.val.ToString());
        }
    }
}