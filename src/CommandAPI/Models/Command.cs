using System.ComponentModel.DataAnnotations;

namespace CommandAPI.Models
{
    public class Command
    {
        public Command(int id, string howTo, string platform, string commandLine)
        {
            Id = id;
            HowTo = howTo;
            Platform = platform;
            CommandLine = commandLine;
        }

        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        [MaxLength(250)]
        public string HowTo { get; set; }

        [Required]
        public string Platform { get; set; }

        [Required]
        public string CommandLine { get; set; }
    }
}