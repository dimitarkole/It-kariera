using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASD_4._2
{
    class SortMatrix
    {
        class Matrix
        {
            private int sortNumber;
            private List<int> allNumber;

            public Matrix(int sortNumber, List<int> allNumber)
            {
                this.SortNumber = sortNumber;
                this.AllNumber = allNumber;
            }

            public List<int> AllNumber { get => allNumber; set => allNumber = value; }
            public int SortNumber { get => sortNumber; set => sortNumber = value; }

            public override string ToString()
            {
                return string.Join(" ", allNumber);
            }
        }
        private List<Matrix> myMatrix;

        public SortMatrix()
        {
            this.MyMatrix = new List<Matrix>();
        }

        private List<Matrix> MyMatrix { get => myMatrix; set => myMatrix = value; }

        public void AddRow(int number, List<int> row)
        {
            Matrix newRow = new Matrix(number, row);
            this.MyMatrix.Add(newRow);
        }

        public void SortDown()
        {
            List<Matrix> matrix = this.MyMatrix;
            bool flag = true;
            while (flag)
            {
                flag = false;
                for (int index = 0; index < matrix.Count - 1; index++)
                {
                    for (int curr = matrix.Count - 1; curr > 0; curr--)
                    {

                        if (Less(matrix[curr - 1].SortNumber, matrix[curr].SortNumber)==false)
                        {
                            Swap(matrix, curr - 1, curr);
                            flag = true;
                        }
                    }
                }
            }

        }

        static void Swap(List<Matrix> collection, int from, int to)
        {
            Matrix a = collection[to];
            collection[to] = collection[from];
            collection[from] = a;
        }

        static bool Less(int first, int second)
        {
            return first.CompareTo(second) < 0;
        }

        public override string ToString()
        {
            string result = "";
            foreach (var item in this.MyMatrix)
            {
                result += "\n" + item.ToString();
            }
            return result;
        }
    }
}
