public class TypeCheckAndCast {
    void Test(object obj)
    {
        if (obj is string)
        {
            string str = (string) obj;
            // do something
        }
    }
}