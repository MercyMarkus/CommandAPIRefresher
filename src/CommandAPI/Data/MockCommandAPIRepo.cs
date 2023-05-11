using CommandAPI.Models;

namespace CommandAPI.Data
{
    public class MockCommandAPIRepo : ICommandAPIRepo
    {
        public void CreateCommand(Command cmd)
        {
            throw new NotImplementedException();
        }

        public void DeleteCommand(Command cmd)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
                new Command(0, "How to generate a migration", "dotnet ef migrations add <Name of Migration>", ".Net Core EF"),
                new Command(1, "Run migrations", "dotnet ef database update", ".Net Core EF"),
                new Command(2, "List active migrations", "dotnet ef migrations list", ".Net Core EF"),
            };

            return commands;
        }

        public Command GetCommandById(int id)
        {
            return GetAllCommands().ElementAtOrDefault(id);
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void UpdateCommand(Command cmd)
        {
            throw new NotImplementedException();
        }
    }
}