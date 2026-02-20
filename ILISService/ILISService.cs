using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILISService
{
    public interface ILISService
    {
        IReadOnlyList<int> GetLongestIncreasingSubsequence(string input);
    }
}
