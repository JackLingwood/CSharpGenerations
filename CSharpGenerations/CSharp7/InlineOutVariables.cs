using System;

namespace CSharp7
{

    public class InlineOutVariables
    {
        public void Before()
        {
            int numericResult;
            int.TryParse("45", out numericResult);
        }

        public void Now1()
        {
            int.TryParse("45", out int numericResult);
        }

        public void Now2()
        {
            int.TryParse("45", out var numericResult);
        }
    }
}
