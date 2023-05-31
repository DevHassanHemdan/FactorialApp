using IRepositories;

namespace Repositories
{
    public class Repository : IRepository
    {
        public long CalculateFactorial(int number)
        {
            if (number == 1)
                return 1;
             return number * CalculateFactorial(number - 1);
        }
    }
}
