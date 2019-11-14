using System;
using CalcDaAlegria.Model;

namespace CalcDaAlegria.Div
{

    public class divisao
    {
        modelinho Modelinho = new modelinho();


        public divisao(decimal v1, decimal v2)
        {

            Modelinho.valor1 = v1;
            Modelinho.valor2 = v2;


        }

        public decimal result()
        {
            decimal res = Modelinho.valor1 / Modelinho.valor2;
            return res;


        }

    }
}
