using CMDOS;
using static CMDOS.Machine;

session.LoadSession();

while (session.Running)
{
    while (session.User == null && session.Login() != ReturnCode.Login.Success)
    {
        Console.WriteLine("Invalid Credentials.");
    }
    while (session.User != null)
    {
        Console.Write("{0}> ", session.User.Username);
        CommandReturn result = session.InputCommand(session.User.Privilege);
        
        if (result.Return == ReturnCode.Command.Success)
        {
            Console.WriteLine(result.Output);
        }
    }
}