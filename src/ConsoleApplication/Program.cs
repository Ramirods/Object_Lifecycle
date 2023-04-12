//--------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;
using ClassLibrary;

namespace ConsoleApplication
{
    /// <summary>
    /// Programa de consola de demostración.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Punto de entrada al programa principal.
        /// </summary>
        public static void Main()
        {
            Train Tren1 = new Train("Last Train To London");
            Train Tren2 = new Train("Last Train To London");
            Train Tren3 = new Train("Runaway Train");

            Console.WriteLine(Tren1 == Tren2);
            Console.WriteLine(Tren3 == Tren2);

            // Son objetos distintos, por lo tanto la comparacion es falsa.
        }
    }
}