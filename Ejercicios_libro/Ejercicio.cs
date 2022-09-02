using System;

 // Funciones de ejecucion del programa

namespace Ejercicios_Libro
{
    class Ejercicio
    {
        public void Capitulo_1_ejercicio_1_5() // Capitulo #1 - Ejercicio #1 y 5
        {
            Console.Out.WriteLine("Jose angel Vargas Polanco");

            Console.Out.WriteLine("Bendiciones y mucha prosperidad");
        }

        public void Capitulo_2_ejercicio_1() // Capitulo #2 - Ejercicio #1
        {
            int dato1 = 0, dato2 = 0, resultado = 0;

            Console.WriteLine("Calculo de Perimetro\n");
            Console.Write("Dijite la cantidad de lados: ");
            dato1 = Int32.Parse(Console.ReadLine());

            Console.Write("Dijite el tamaño de un lado: ");
            dato2 = Int32.Parse(Console.ReadLine());

            resultado = dato1 * dato2;
            Console.WriteLine("Su resultado es:"+resultado);
        }


        public void Capitulo_2_ejercicio_3() // Capitulo #2 - Ejercicio #2
        {
            double radianes = 0, grados = 0;
            Console.Write("Dijite los Grado: ");
            grados = double.Parse(Console.ReadLine());

            radianes = grados*(3.1416/180);

            Console.Write($"La canidad {grados} en radianes es "+ radianes +"\n \n");

        }

        public void Capitulo_2_ejercicio_5() // Capitulo #2 - Ejercicio #5
        {

            float euros = 0, dolar = 0, resultado = 0;
            Console.WriteLine("\n \n Convercion de Divisa\n");

            Console.Write("Dijite el valor del Euro contra el Dolar: ");
            euros = float.Parse(Console.ReadLine());

            Console.Write("Dijite la cantidad de Dolares: ");
            dolar = float.Parse(Console.ReadLine());

            resultado = euros * dolar;

            Console.WriteLine("El resultado es: "+ resultado);

        }

        public void Capitulo_3_ejercicio_1() // Capitulo #3 - Ejercicio #1 
        {
            
			int dijito = 0;

			Console.WriteLine("Ingrece el numero que desee evaluar: ");
			dijito = Int16.Parse(Console.ReadLine());

			if (dijito % 2 == 0)
			{
				Console.WriteLine($"El numero {dijito} es par.");
			}
			else
			{
				Console.WriteLine($"El numero {dijito} no es par.");
			}
        }

        public void Capitulo_3_ejercicio_4() // Capitulo #3 - Ejercicio #4
        {
            
			int dijito = 0;

			Console.WriteLine("Ingrece el numero que desee evaluar: ");
			dijito = Int16.Parse(Console.ReadLine());

            switch(dijito)
            {
                case 1:
                    Console.WriteLine("Lunes");
                    break;
                case 2:
                    Console.WriteLine("Martes");
                    break;
                case 3:
                    Console.WriteLine("Miercles");
                    break;
                case 4:
                    Console.WriteLine("Jueves");
                    break;
                case 5:
                    Console.WriteLine("Viernes");
                    break;
                case 6:
                    Console.WriteLine("Savado");
                    break;
                case 7:
                    Console.WriteLine("Domingo");
                    break;
                default:
                    break;
            }
        }

        public void Capitulo_3_ejercicio_5() // Capitulo #3 - Ejercicio #5
        {
            int canidad = 0;
            float lados = 0, perimetro = 0, apotema = 0, area = 0;

            Console.WriteLine("Ingrese la cantida de lados del poligono: ");
            canidad = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la medida de un lado del poligono");
            lados = Single.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la medida de un lado del poligono");
            lados = Single.Parse(Console.ReadLine());

            perimetro = canidad * lados;
            area = perimetro * apotema / 2;
            Console.WriteLine("El perimetro es: "+ perimetro);
            Console.WriteLine("El area es: "+ area);
        }


        public void Capitulo_4_ejercicio_1() // Capitulo #4 - Ejercicio #1
        {
            string linea;
            Console.Write("Ingrese el numero que desea saber su tabala de multiplicacion: ");
            linea = Console.ReadLine();
            int numero = int.Parse(linea);
            for (int i = 1; i <= 10; i++)
            {
                Console.Write(numero + " x " + i + " = " + i * numero + "\n");
            }

        }

        public void Capitulo_4_ejercicio_2() // Capitulo #4 - Ejercicio #2
        {
            int numeno = 0, potencia = 0;
            double resultado = 0;
            Console.WriteLine("Digite el numero que desea saber su elevado: ");
            numeno = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite la potencia para el numero que ingreso: ");
            potencia = int.Parse(Console.ReadLine());

            resultado = Math.Pow(numeno,potencia);
            Console.WriteLine($"El resultado es: {resultado}");

        }

        public void Capitulo_4_ejercicio_5() // Capitulo #4 - Ejercicio #5
        {
            int Personas = 0, Acumulado = 0, edad = 0;
            double resultado = 0;

            Console.WriteLine("Ingrese la cantidad de personas que se encuentran en el grupo: ");
            Personas = Convert.ToInt32(Console.ReadLine());
        
            for (int i = 0; i < Personas; i++)
            {
                Console.WriteLine("Ingrese la edad de la persona: ");
                edad = Convert.ToInt32(Console.ReadLine());
                Acumulado += edad;
            }

            resultado = Acumulado / Personas;
            Console.WriteLine("EL Promedio de la edades es:"+ resultado);

        }

        public void menu2() // Sub-menu para los ejercicios del capitulo #2 (1, 3 y 5)
        {
           int operador1 = 0;

            do{
                Console.Write("\n\n-----------MENU--Capitulo #2-----------\n\n\t   1-(Ejercicios 1)\n\n\t   2-(Ejercicio 3)\n\n\t   3-(Ejercicio 5)\n\n\t   4-(Salir)\n\n ---Selecciona una opcion: ");
                operador1 = Int16.Parse(Console.ReadLine());

                switch(operador1)
                {
                    case 1:
                        Console.Clear();
                        Capitulo_2_ejercicio_1();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        Console.Clear();
                        Capitulo_2_ejercicio_3();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        Console.Clear();
                        Capitulo_2_ejercicio_5();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 4:
                        break;
                }

            }while(operador1 != 4);
        }
    }
}