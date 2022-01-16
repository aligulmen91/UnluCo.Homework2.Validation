using System.Linq;

namespace UnluCo.ExtensionMethods
{
    public class IsLower : Condition
    {
        public override bool Cnd(string str)
        {
            return str.Any(x => char.IsLower(x));
        }
    }

}
