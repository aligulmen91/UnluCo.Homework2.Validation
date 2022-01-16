namespace UnluCo.ExtensionMethods
{


    public static class Solution 
    {
        //By using the "params" keyword, you can specify a method parameter that takes a variable number of arguments.
        //take all condition results and check them one by one
        public static bool CheckConditions(this string str, params Condition[] conds) 

        {
        
            bool result = true;
            foreach (var cond in conds)
            {
                result = result && cond.Cnd(str);
            }
            return result;
        }

      
    }

}
