using System;
using CalcDaAlegria.Model;

namespace CalcDaAlegria.Soma
{

    public class soma
    {

        modelinho Modelinho = new modelinho();
        public soma(decimal v1, decimal v2)
        {
            
            Modelinho.valor1 = v1;
            Modelinho.valor2 = v2;


        }

        public decimal result()
        {
            decimal res = Modelinho.valor1 * Modelinho.valor2;
            return res;


        }

    }
}
