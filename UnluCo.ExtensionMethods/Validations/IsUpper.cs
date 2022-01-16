using System.Linq;

namespace UnluCo.ExtensionMethods
{
    public class IsUpper : Condition
    {
        public override bool Cnd(string str)
        {
            return str.Any(x => char.IsUpper(x));
        }
    }

}
