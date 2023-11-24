using System;
    public class Calcular
    {
        public float Num1;
        public float Num2;

        public float Soma()
        {            
            return Num1 + Num2;
        }
        public float Subtracao()
        {            
            return Num1 - Num2;
        }
        public float Multiplicacao()
        {            
            return Num1 * Num2;
        }
        public float Divisao()
        {            
            if(Num2 != 0)
            {
                return Num1 / Num2;
            }else
            {
                Console.WriteLine("Não foi possível divisão por 0");
                return 0;
            }
            
            
        }

    }
