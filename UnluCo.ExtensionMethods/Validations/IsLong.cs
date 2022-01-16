namespace UnluCo.ExtensionMethods
{
    public class IsLong : Condition
    {
        public override bool Cnd(string str)
        {
           
            return str.Length > 10;
        }
    }

}
