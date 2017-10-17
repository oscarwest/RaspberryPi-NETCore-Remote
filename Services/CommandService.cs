using System;
using System.Linq;
using System.Threading.Tasks;
using WestPi.Remote.Helpers;
using WestPi.Remote.Models;

namespace WestPi.Remote
{
    public class CommandService : ICommandService
    {
        public async Task<VolumeStatus> GetVolumeAsync()
        {
            var cmd = "amixer get PCM|grep -o [0-9]*%";
            var result = new VolumeStatus() {
                Volume = await cmd.Bash().StripNewlineCharacters()
            };
            return result;
        }

        public Task<VolumeStatus> SetVolumeAsync(int percent)
        {
            if (percent < 0 || percent > 100)
                throw new ArgumentException("Percent integer must be between 0 and 100");

            var cmd = $"sudo amixer set PCM -- {percent.ToString()}% | grep -o [0-9]*%";
            var output = cmd.Bash();

            var res = new VolumeStatus() {
                Volume = output
            };

            return Task.FromResult(res);
        }

    }
}
