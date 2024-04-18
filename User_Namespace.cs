
public namespace ArrayX
{
    class MyArray 
    {
        public int[] Arr;

        public MyArray(int size)
        {
            this.Arr = new int[size];
        }

        public void Accept()
        {
            System.Console.WriteLine("Enter the elements of the array :");

            for(int iCnt = 0; iCnt < Arr.Length; iCnt++)
            {
                this.Arr[iCnt] = int.Parse(System.Console.ReadLine());
            }
        }

        public void Display()
        {
            System.Console.WriteLine("Elements of the array are :");

            foreach(int iCnt in Arr)
            {
                System.Console.Write(iCnt+"\t");
            }
            System.Console.WriteLine();
        }
    }
}