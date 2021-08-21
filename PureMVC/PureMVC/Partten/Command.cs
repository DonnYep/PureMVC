/// <summary>
/// Controller代理类
/// </summary>
namespace PureMVC
{
    public abstract class Command
    {
        public abstract void ExecuteCommand (object sender,NotifyArgs notifyArgs);
    }
}
