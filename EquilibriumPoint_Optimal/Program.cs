using System;

namespace EquilibriumPoint_Optimal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Equilibrium Point in array - optimal!");
            Console.WriteLine("-------------------------------------");

            try
            {
                int[] array = GetArrayFromInput();
                int equilibriumPoint = GetEquilibriumPoint(array);
                if (equilibriumPoint != -1)
                {
                    Console.WriteLine("The equilibrium point is "+equilibriumPoint);
                }
                else {
                    Console.WriteLine("There is no equilibrium point in the array");
                }
            }
            catch (Exception exception) {
                Console.WriteLine("Main(): Thrown exception is "+exception.Message);
            }



            Console.ReadLine();
        }

        private static int[] GetArrayFromInput() {
            int[] array = null;

            Console.WriteLine("Enter the number of elements in the array");
            try
            {
                int noElements = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the elements separated by space");
                string[] elements = Console.ReadLine().Split(' ');
                array = new int[noElements];
                for (int index = 0; index < noElements; index++) {
                    array[index] = int.Parse(elements[index]);
                }
            }
            catch (Exception exception) {
                Console.WriteLine("GetArrayFromInput(): Thrown Exception is "+exception.Message);
            }


            return array;
        }

        static int GetEquilibriumPoint(int[] array) {
            int result = -1;

            int leftSum = 0;
            int Sum = 0;

            for (int index = 0; index < array.Length; index++) {
                Sum += array[index];
            }

            for (int index = 0; index < array.Length; index++) {
                int rightSum = (Sum - array[index]); 
                Sum = (Sum - array[index]);
                if (leftSum == rightSum) {
                    return index;
                }

                leftSum += array[index];
            }

            return result;
        }
    }
}
