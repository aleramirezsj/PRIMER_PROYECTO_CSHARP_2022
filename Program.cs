using System;
//clase Program, es la clase predeterminada que se crea cuando 
//iniciamos un proyecto
namespace PrimerProyecto
{
    class Program
    {
        static void Main(string[] args)
        {
            //PrimeraPruebaConVariables();

            //PruebaConIngresoPorTeclado();

            //EjercicioDiasDeVida();

            //int kilowats = 230;
            //Console.WriteLine(CalculoDeBoletaDeLuz(kilowats));

            //ProbandoNuestraCalculadora();

            for (int i = 0; i < 10; i++)
            {
                ProbamosElSwitchEscribiendoNotas();
            }
            
        }

        /// <summary>
        /// Este método pide al usuario que ingrese una nota y muestra por consola la calificación correspondiente a esa nota
        /// </summary>
        private static void ProbamosElSwitchEscribiendoNotas()
        {
            int nota = Consola.CapturarNumero("Ingrese la nota:");
            switch (nota)
            {
                case 10:
                    Consola.Escribir("Excelente");
                    break;
                case >= 8:
                    Consola.Escribir("Distinguido");
                    break;
                case >= 6:
                    Consola.Escribir("Aprobado");
                    break;
                case >= 4:
                    Consola.Escribir("No aprobado");
                    break;
                case >= 0:
                    Consola.Escribir("Aplazado");
                    break;
                default:
                    Consola.Escribir("Nota no válida");
                    break;
            }
        }

        private static void ProbandoNuestraCalculadora()
        {
            Calculadora calculadora = new Calculadora();
            
            
            int numero1 = Consola.CapturarNumero("Ingrese un número por favor=");
            int numero2 = Consola.CapturarNumero("Ingrese otro número por favor=");

            Consola.Escribir($"Mostramos la resta de {numero1} y {numero2}=");
            Consola.Escribir(calculadora.Restar(numero1, numero2));
        }

        private static string CalculoDeBoletaDeLuz(int kw)
        {
            float costoFactura=kw*30.98f;
            return "El costo de la factura es " + costoFactura;
        }

        static void EjercicioDiasDeVida()
        {
            //ejercicio días de vida
            //Necesitamos un programa que muestre la cantidad de días aproximados de vida
            //que tiene una empleado.
            Console.Write("Ingrese la edad del empleado: ");
            //int edadEmpleado=Convert.ToInt32(Console.ReadLine());
            int edadEmpleado;
            int.TryParse(Console.ReadLine(), out edadEmpleado);
            int diasDeVida = edadEmpleado * 365;
            Console.WriteLine($"Los días aproximados de vida del empleado son:{diasDeVida}");
        }

        private static void PruebaConIngresoPorTeclado()
        {
            string localidad; // inicio una variable del tipo string
            Console.Write("Ingrese de que localidad es: ");
            localidad = Console.ReadLine(); //pido al usuario que coloque un valor
            Console.WriteLine($"La localidad ingresada es: {localidad}"); //muestro en la consola,
                                                                        //el valor que pedí anteriormente
        }

        private static void PrimeraPruebaConVariables()
        {
            string nombre = "Alejandro"; //este sirve para colocar  caracteres
            int edad = 45; //este sirve para colocar nùmeros enteros
            float edad2 = 43.03f; //esto sirve para colocar un nùmero decimal (43.5).
            bool activo = true; //los booleanos sirven para definir un estado (V/F)
            Console.WriteLine("probando, editar el código");
            Console.WriteLine($"Hola soy {nombre.ToUpper()} y tengo {edad2} años");
        }
    }
    class Calculadora
    {
        public int Sumar(int numero1, int numero2)
        { 
            return numero1 + numero2;
        }
        public int Restar(int numero1, int numero2)
        {
            if (numero1 > numero2)
                return numero1 - numero2;
            else
                return numero2 - numero1;
        }
    }
    class Consola
    {
        public static void Escribir(string texto)
        {
            Console.Write(texto);
        }
        public static void Escribir(int numero)
        {
            Console.Write(numero);
        }

        internal static int CapturarNumero(string texto)
        {
            Console.Write(texto);
            int numero = int.Parse(Console.ReadLine());
            return numero;
        }
    }
    
}