using CommandsService.Models;

namespace CommandsService.Data;

public interface ICommandRepo
{
    bool SaveChanges();

    // Platforms
    IEnumerable<Platform> GetAllPlatforms();

    void CreatePlatforms(Platform platform);

    bool PlatformExists(int platformId);

    // Commands
    IEnumerable<Command> GetCommandsPlatform(int platformId);
    
    Command GetCommand(int platformId, int commandId);

    void CreateCommand(int platformId, Command command);

}
