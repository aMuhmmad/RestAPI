using RestAPI.Models;

namespace RestAPI.Data
{
    public class SqlCommadRepository : ICommandRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public SqlCommadRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void CreateCommand(Command command)
        {
            if (command == null)
            {
                throw new ArgumentNullException(nameof(command));
            }

            _dbContext.Commands.Add(command);
        }

        public void DeleteCommand(Command command)
        {

            _dbContext.Commands.Remove(command);
        }

        public Command GetCommandById(int id)
        {
            return _dbContext.Commands.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Command> GetCommands()
        {
          return _dbContext.Commands.ToList();
        }

        public bool SaveChanges()
        {
            var x = (_dbContext.SaveChanges() >= 0);
            return x;
        }

        public void UpdateCommand(Command command)
        {
            //Nothing
        }
    }
}
