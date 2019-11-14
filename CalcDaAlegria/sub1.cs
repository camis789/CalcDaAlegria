using System;
using CalcDaAlegria.Model;

namespace CalcDaAlegria.Sub
{

    public class sub
    {
        modelinho Modelinho = new modelinho();


        public sub(decimal v1, decimal v2)
        {

            Modelinho.valor1 = v1;
            Modelinho.valor2 = v2;


        }

        public decimal result()
        {
            decimal res = Modelinho.valor1 - Modelinho.valor2;
            return res;


        }

    }
}
