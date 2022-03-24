using System;

namespace StructureDepthCalculator.Entities
{
    public class BinaryTree
    {
        public BinaryNode root;

        public BinaryTree()
        {
            root = null;
        }

        public void AddNode(int value)
        {
            BinaryNode before = null, after = root;

            while (after != null)
            {
                before = after;
                if (value < after.Value)
                {
                    after = after.LeftNode;
                }
                else if (value > after.Value)
                {
                    after = after.RightNode;
                }
                else
                {
                    return; // Case when the same value exists
                }
            }

            BinaryNode newNode = new BinaryNode();
            newNode.Value = value;

            if (root == null) // Case when tree is empty
            {
                root = newNode;
            }
            else
            {
                if (value < before.Value)
                {
                    before.LeftNode = newNode;
                }
                else
                {
                    before.RightNode = newNode;
                }
            }
        }

        public int GetDepth()
        {
            return GetDepth(root);
        }

        private int GetDepth(BinaryNode node)
        {
            return node == null ? 0 : Math.Max(GetDepth(node.LeftNode), GetDepth(node.RightNode)) + 1;
        }
    }
}
