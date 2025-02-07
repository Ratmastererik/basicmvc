
public class StuffService
{
    static List<Stuff> _stuff = [];

    public StuffService()
    {
        if (_stuff.Count > 0)
            return;

        _stuff.Add(new Stuff
        {
            Id = 1,
            Name = "Apple",
            Description = "A fruit that is red and delicious",
            Price = 1,
            Amount = 10,
            Category = "Fruit"
        });
        _stuff.Add(new Stuff
        {
            Id = 2,
            Name = "Banana",
            Description = "A fruit that is yellow and delicious",
            Price = 2,
            Amount = 10,
            Category = "Fruit"
        });
        _stuff.Add(new Stuff
        {
            Id = 3,
            Name = "Carrot",
            Description = "A vegetable that is orange and delicious",
            Price = 3,
            Amount = 10,
            Category = "Vegetable"
        });
    }

    public async Task<List<Stuff>> GetStuffAsync()
    {
        await Task.Delay(100);
        return _stuff;
    }

    public async Task AddStuffAsync(Stuff stuff)
    {
        await Task.Delay(100);
        stuff.Id = _stuff.Max(s => s.Id) + 1;
        _stuff.Add(stuff);
    }

    public async Task DeleteStuffAsync(int id)
    {
        await Task.Delay(100);
        Stuff? stuff = _stuff.Find(s => s.Id == id);
        if (stuff != null)
            _stuff.Remove(stuff);
    }
}
