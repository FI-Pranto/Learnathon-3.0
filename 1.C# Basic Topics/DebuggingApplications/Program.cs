namespace DebuggingApplications
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var list = new List<int>() { 1, 10, 3, 4, 8, 6, 2};

            var smallestNums = GetSmallestNums(list, 3);
            Console.WriteLine("{0} {1} {2}", smallestNums[0], smallestNums[1], smallestNums[2]);
            
        }
        public static List<int> GetSmallestNums(List<int> list, int num)
        {

            var ans = new List<int>();

            for (int i = 0; i < num; i++)
            {
                var val = GetSmallest(list);
                ans.Add(val);
                list.Remove(val);
            }
            return ans;
        }
        public static int GetSmallest(List<int> list)
        {
            var min = list[0];
            for (int i = 1; i < list.Count; i++)
            {
                if (list[i] < min)
                {
                    min= list[i];
                }
            }
            return min;


        }

    }
}
