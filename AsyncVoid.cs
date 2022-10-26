public class AsyncVoid {
  void Method()
  {
      RunThisAction(async () =>
      {
          await Task.Delay(1000);
          throw new NotImplementedException();
      });
      RunThisAction(async () => await Task.Delay(1000));
      // or
      RunThisAction(async delegate { await Task.Delay(1000); });
  }

  public String RunThisAction(Action doSomething)
  {
      doSomething();
      return "OK";
  }
}