namespace UnluCo.ExtensionMethods
{
    //we define an abstract class to be sure that user get boolean result when they override method
    public abstract class Condition
    {
        public abstract bool Cnd(string str);

    }

}
