namespace Server.Services;

public interface IPlayerService
{
    public void DoSomething();
}

public class PlayerService : IPlayerService
{
    public void DoSomething()
    {
        Console.WriteLine("hey!");
    }
}

public class MockPlayerService : IPlayerService
{
    public void DoSomething()
    {
        Console.WriteLine("hey! from the mock service");
    }
}
