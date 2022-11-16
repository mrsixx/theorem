namespace Theorem.Parser.Interfaces
{
    public interface IAbstractSyntaxTree
    {
        bool Add(string value);
        int GetDepth();
        void PreOrder();
        void InOrder();
        void PosOrder();
    }
}
