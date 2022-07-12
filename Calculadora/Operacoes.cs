using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Operacoes
    {
        /*
         * 
        private string expressao;
        private decimal calculo;

        public string Expressao
        {
            get { return expressao; }
            set { expressao = value; }
        }

        public Operacoes(string expressao)
        {
            Expressao = expressao;
        }

        public decimal Calcular()
        {
            string Resultado = "";
            decimal resultado = 0;

            for(int i = 0; i < expressao.Length; i++)
            {
                if(expressao[i] == ' ')
                {
                    for (int k = 0; k < i; k++)
                        Resultado += expressao[k];

                    resultado = Convert.ToDecimal(Resultado);

                    if(expressao[i + 1] == '+')
                    {
                        for(int j = i; j < expressao.Length; j++)
                        {
                            

                            Resultado = "";
                            Resultado += expressao[j];

                            if (expressao[j] == ' ')
                                break;

                        }

                        resultado += Convert.ToDecimal(Resultado);

                    }

                }

            }

            return resultado;
        }

        */

        private int operacao;
        private decimal n1;
        private decimal n2;

        public Operacoes (int operacao, decimal n1, decimal n2)
        {
            this.operacao = operacao;
            this.n1 = n1;

            if (n2 != 0) this.n2 = n2;
            else {}
        }

        public decimal calculo()
        {
            if (operacao == 1)
                return n1 + n2;
            else if (operacao == 2)
                return n1 - n2;
            else if (operacao == 3)
                return n1 * n2;
            else if (operacao == 4)
                return n1 / n2;
            else
                return 0;
        }

    }
}
