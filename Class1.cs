namespace BadRulesProject;
public class Class1 {

    public void Method() {
        var myActions = new List<Action>();
        var myStrings = new List<string>() { "one", "two", "three" };

        for (var i = 0; i < myStrings.Count; i++)
        {
            Action print = () => { Console.WriteLine(myStrings[i]); };
            myActions.Add(print);
        }

        myActions[0]();
    }
}