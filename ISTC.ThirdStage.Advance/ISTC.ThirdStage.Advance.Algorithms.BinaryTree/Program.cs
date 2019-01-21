using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISTC.ThirdStage.Advance.Algorithms.BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree binaryTree = new BinaryTree();
            binaryTree.Insert(41);
            binaryTree.Insert(413);
            binaryTree.Insert(11);
          
            binaryTree.Insert(61);


            var isExists = binaryTree.IsExists(10);

            var isEmpty = binaryTree.IsEmpty();

            var findByValue = binaryTree.FindByValue(61);
        }
    }
}
