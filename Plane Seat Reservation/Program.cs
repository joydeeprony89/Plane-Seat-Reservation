using System.Collections.Generic;
using System.Linq;

namespace Plane_Seat_Reservation
{
    class Program
    {
        static void Main(string[] args)
        {
        }


        // https://dev.to/ricardojvtorres/plane-seat-reservation-807
        public int solution(int N, string S)
        {
            int number = 1;
            int counter = 0;
            var listReserved = new List<string>();
            listReserved = S.Split(' ').ToList();
            while (number <= N)
            {
                if (listReserved.Where(x => x.Contains(number + "B") || x.Contains(number + "C") || x.Contains(number + "D") || x.Contains(number + "E")).FirstOrDefault() == null)
                {
                    listReserved.AddRange(new List<string> { number + "B", number + "C", number + "D", number + "E" });
                    counter++;
                }

                if (listReserved.Where(x => x.Contains(number + "F") || x.Contains(number + "G") || x.Contains(number + "H") || x.Contains(number + "J")).FirstOrDefault() == null)
                {
                    listReserved.AddRange(new List<string> { number + "F", number + "G", number + "H", number + "J" });
                    counter++;
                }

                if (listReserved.Where(x => x.Contains(number + "D") || x.Contains(number + "E") || x.Contains(number + "F") || x.Contains(number + "G")).FirstOrDefault() == null)
                {
                    listReserved.AddRange(new List<string> { number + "D", number + "E", number + "F", number + "G" });
                    counter++;
                }

                number++;
            }

            return counter;
        }
    }
}
