using System.Linq;

namespace UnluCo.ExtensionMethods
{
    public class IsDigit : Condition
    {
        public override bool Cnd(string str)
        {
            return str.Any(x => char.IsDigit(x));
        }
    }

}
