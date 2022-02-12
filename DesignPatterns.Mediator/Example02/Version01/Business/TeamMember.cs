namespace DesignPatterns.Mediator.Example02.Version01.Business;

public abstract class TeamMember
{
    private Chatroom chatroom;

    public TeamMember(string name)
    {
        Name = name;
    }

    public string Name { get; }

    internal void SetChatroom(Chatroom chatroom)
    {
        this.chatroom = chatroom;
    }

    public void Send(string message)
    {
        chatroom.Send(Name, message);
    }

    public virtual void Receive(string from, string message)
    {
        Console.WriteLine($"from {from}: '{message}'");
    }

    public void SendTo<T>(string message) where T : TeamMember
    {
        chatroom.SendTo<T>(Name, message);
    }
}