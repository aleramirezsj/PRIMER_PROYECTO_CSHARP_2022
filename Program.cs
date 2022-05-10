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

            ProbandoNuestraCalculadora();
        }

        private static void ProbandoNuestraCalculadora()
        {
            Calculadora calculadora = new Calculadora();
            Consola consola = new Consola();

            int numero1 = consola.CapturarNumero("Ingrese un número por favor=");
            int numero2 = consola.CapturarNumero("Ingrese otro número por favor=");

            consola.Escribir($"Mostramos la suma de {numero1} más {numero2}=");
            consola.Escribir(calculadora.Sumar(numero1, numero2));
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
            return numero1 - numero2;
        }
    }
    class Consola
    {
        public void Escribir(string texto)
        {
            Console.Write(texto);
        }
        public void Escribir(int numero)
        {
            Console.Write(numero);
        }

        internal int CapturarNumero(string texto)
        {
            Console.Write(texto);
            int numero = int.Parse(Console.ReadLine());
            return numero;
        }
    }
}