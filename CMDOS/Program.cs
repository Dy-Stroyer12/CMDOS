using CMDOS;

Session session = new Session();
session.LoadSession();

while (session.Running)
{
    while (session.Login() != ReturnCode.Login.Success)
    {
        Console.WriteLine("Incorrect username or password.");
    }
    while (session.User != null)
    {

    }
}