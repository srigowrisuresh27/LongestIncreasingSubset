using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestIncreasingService
{
    public interface ILongestIncreasingService
    {
        IReadOnlyList<int> GetLongestIncreasingSubsequence(string input);
    }
}
