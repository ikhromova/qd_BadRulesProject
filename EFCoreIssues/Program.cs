using var db = new BloggingContext();

await foreach (var blog in db.Blogs.AsAsyncEnumerable())
{
    // do something
    foreach (var account in blog.Posts)
    {
        // ...
    }
}