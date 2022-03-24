using StructureDepthCalculator.Entities;
using System;

namespace StructureDepthCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree tree = new BinaryTree();

            #region Init objects
            tree.AddNode(50);
            tree.AddNode(15);
            tree.AddNode(9);
            tree.AddNode(45);
            tree.AddNode(15);
            tree.AddNode(7);
            tree.AddNode(3);
            tree.AddNode(78);
            tree.AddNode(65);
            tree.AddNode(75);
            #endregion

            Console.WriteLine(tree.GetDepth());
        }
    }
}
