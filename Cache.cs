using JetBrains.Annotations;
class Cache
{
  private Dictionary<string, int> _cache = new();

  public int GetData(string key, [RequireStaticDelegate] Func<string, int> calculator)
  {
    if (!_cache.TryGetValue(key, out var value))
    {
      value = _cache[key] = calculator(key);
    }

    return value;
  }
}

class CacheTest
{
    public CacheTest()
    {
        var cache = new Cache();
        var key = "abc";
        // Warning: anonymous function
        // should not have captures of the containing context
        var a = cache.GetData(key, calculator: x => key.Length);
    }
}