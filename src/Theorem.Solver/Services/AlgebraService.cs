using Theorem.Solver.Interfaces;

namespace Theorem.Solver.Services
{
    public class AlgebraService : IAlgebraService
    {
        public decimal Multiplicar(decimal operando1, decimal operando2) => operando1 * operando2;

        public decimal Somar(decimal operando1, decimal operando2) => operando1 + operando2;
    }
}
