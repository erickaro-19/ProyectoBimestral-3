using System;



namespace ProyectoBimlll
{
    class Program
    {
        static void Main(string[] args)
        {
            int peso;
            double altura;
            double imc;
            double preimc;



            Console.WriteLine("Calculadora de IMC (Indice de Masa Corporal\n");
            Console.WriteLine("Oprima cualquier letra para continuar");
            Console.ReadKey();
            Console.Clear();



            /* ----------------- entrada de datos ----------------- */
            Console.WriteLine("Ingrese su altura en metros \"Ejemplo: 1.65\"");
            try
            {
                altura = Convert.ToDouble(Console.ReadLine());
                Console.Clear();
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
                Console.WriteLine("Ingrese su altura en metros \"Ejemplo: 1.65\"");
                altura = Convert.ToDouble(Console.ReadLine());
                Console.Clear();
            }




            Console.WriteLine("Ingrese su peso en kg");
            try
            {
                peso = Convert.ToInt16(Console.ReadLine());
                Console.Clear();
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
                Console.WriteLine("Ingrese su peso en kg");
                peso = Convert.ToInt16(Console.ReadLine());
                Console.Clear();
            }



            /* -------------------- proceso ------------------------*/
            preimc = Convert.ToDouble(altura * altura);
            imc = Convert.ToDouble(peso / preimc);




            /*----------------- salida de datos ---------------------*/



            if (imc > 40 && imc < 50)
            {
                Console.WriteLine("Cuidado! Padeces de obesidad morbida, el riesgo de su salud es demasiado alto");
                Console.WriteLine("Gracias por usar la calculadora de IMC. Cuida tu alimentación");
                Console.WriteLine("Presiona cualquier letra para salir");
                Console.ReadKey();
            }



            else if (imc > 35 && imc < 40)
            {
                Console.WriteLine("Cuidado! Padeces de obesidad nivel 2, el riesgo de su salud es muy alto ");
                Console.WriteLine("Gracias por usar la calculadora de IMC. Cuida tu alimentación");
                Console.WriteLine("Presiona cualquier letra para salir");
                Console.ReadKey();
            }



            else if (imc > 30 && imc < 35)
            {
                Console.WriteLine("Cuidado! Padeces de obesidad nivel 1, el riesgo de su salud es alto");
                Console.WriteLine("Gracias por utilizar la calculadora de IMC. Cuida tu alimentación");
                Console.WriteLine("Presiona cualquier letra para salir");
                Console.ReadKey();
            }



            else if (imc > 25 && imc < 30)
            {
                Console.WriteLine("Padeces de sobrepeso, el riesgo de su salud es moderado");
                Console.WriteLine("Gracias por utilizar la calculadora de IMC. Cuida tu alimentación");
                Console.WriteLine("Presiona cualquier letra para salir");
                Console.ReadKey();
            }



            else if (imc > 20 && imc < 25)
            {
                Console.WriteLine("Buena noticia! Tu peso es muy bueno, tu salud no corre ningún riesgo");
                Console.WriteLine("Gracias por utilizar la calculadora de IMC. Cuida tu alimentación");
                Console.WriteLine("Presiona cualquier letra para salir");
                Console.ReadKey();
            }



            else if (imc > 5 && imc < 20)
            {
                Console.WriteLine("Mala Noticia! Tu peso es muy bajo, tu salud corre riesgo");
                Console.WriteLine("Gracias por utilizar la calculadora de IMC. Cuida tu alimentación");
                Console.WriteLine("Presiona cualquier letra para salir");
                Console.ReadKey();
            }





            Console.ReadKey();
        }
    }
}