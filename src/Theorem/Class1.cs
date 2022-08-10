using System;

namespace Theorem
{
    public class Class1
    {
        const char OPERADOR_ADICAO = '+';
        const char OPERADOR_MULTIPLICACAO = '*';
        public int Resolve(string exp)
        {
            if (exp.Contains(OPERADOR_ADICAO))
            {
                var termos = exp.Split(OPERADOR_ADICAO);
                var operando1 = Convert.ToInt32(termos[0]);
                var operando2 = Convert.ToInt32(termos[1]);
                return operando1 + operando2;
            }
            else if (exp.Contains(OPERADOR_MULTIPLICACAO))
            {
                var termos = exp.Split(OPERADOR_MULTIPLICACAO);
                var operando1 = Convert.ToInt32(termos[0]);
                var operando2 = Convert.ToInt32(termos[1]);
                return operando1 * operando2;
            }

            return 0;
        }
    }
}
