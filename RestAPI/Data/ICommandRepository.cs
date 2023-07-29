using RestAPI.Models;

namespace RestAPI.Data
{
    public interface ICommandRepository
    {
        bool SaveChanges();
        IEnumerable<Command> GetCommands();
        Command GetCommandById(int id);
        void CreateCommand(Command command);
        void UpdateCommand(Command command);
        void DeleteCommand(Command command);
    }
}
