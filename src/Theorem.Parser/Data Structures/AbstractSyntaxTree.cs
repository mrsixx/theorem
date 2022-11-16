using Theorem.Parser.Interfaces;

namespace Theorem.Parser.Data_Structures
{
    public class AbstractSyntaxTree : IAbstractSyntaxTree
    {
        public TreeNode Root { get; set; }

        public bool Add(string value)
        {
            throw new System.NotImplementedException();
        }

        public int GetDepth()
        {
            throw new System.NotImplementedException();
        }

        public void InOrder()
        {
            throw new System.NotImplementedException();
        }

        public void PosOrder()
        {
            throw new System.NotImplementedException();
        }

        public void PreOrder()
        {
            throw new System.NotImplementedException();
        }
    }
}
