
public class StuffService
{
    static List<Post> _stuff = [];

    public StuffService()
    {
        if (_stuff.Count > 0)
            return;

        _stuff.Add(new Post
        {
            Id = 1,
            User = new User { Username = "Rat" },
            PostName = "En blog sida för råttor",
            Content = "Rat"
        });
        _stuff.Add(new Post
        {
            Id = 2,
            User = new User { Username = "Rat?" },
            PostName = "The physiolgy of the universe",
            Content = "Rat!"
        });
        _stuff.Add(new Post
        {
            Id = 3,
            User = new User { Username = "rattatouille" },
            PostName = "A recipy",
            Content = "Rat and tatouille"
        });
    }

    public async Task<List<Post>> GetStuffAsync()
    {
        await Task.Delay(100);
        return _stuff;
    }

    public async Task AddStuffAsync(Post post)
    {
        await Task.Delay(100);
        post.Id = _stuff.Max(s => s.Id) + 1;
        _stuff.Add(post);
    }

    public async Task DeleteStuffAsync(int id)
    {
        await Task.Delay(100);
        Post? post = _stuff.Find(s => s.Id == id);
        if (post != null)
            _stuff.Remove(post);
    }
}
