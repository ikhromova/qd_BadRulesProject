namespace BadRulesProject;
class MultiThreadedComponent
{
  private List<string> _resource1 = new();
  private List<string> _resource2 = new();

  public void PublicApi01()
  {
    lock (_resource1)
    lock (_resource2)
    {
      // do work
    }
  }

  public void PublicApi02()
  {
    lock (_resource2)
    {
      // do work
      HelperMethod02();
      // do work
    }
  }

  private void HelperMethod02()
  {
    // The expression is used in several lock statements with inconsistent execution order,
    // forming a cycle. This might lead to a possible deadlock if methods (properties)
    // of this type are executed concurrently by multiple threads.
    // Lock objects involved in the cycle: '_resource1', '_resource2'
    // Example of the deadlock situation:
    //  - Thread #1 executes 'PublicApi01', takes locks '_resource1' -> '_resource2'
    //  - Thread #2 executes 'PublicApi02', takes locks '_resource2' -> '_resource1'
    lock (_resource1)
    {
      // do work
    }
  }
}