using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of rows: ");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the number of columns: ");
            int columns = Convert.ToInt32(Console.ReadLine());

            if (rows < 0 || columns < 0)
            {
                Console.WriteLine("Please enter the correct number of rows and columns");
            }

            Matrix matrix = new Matrix(rows, columns);
            Matrix newMatrix = new Matrix(rows, columns);

            matrix.addition(newMatrix);
            matrix.printMatrix();
            
        }

    }
}
