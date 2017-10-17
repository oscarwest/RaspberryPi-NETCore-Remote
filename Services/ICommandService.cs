using System.Threading.Tasks;
using WestPi.Remote.Models;

namespace WestPi.Remote
{
    public interface ICommandService
    {
        Task<VolumeStatus> GetVolumeAsync();
        Task<VolumeStatus> SetVolumeAsync(int percent);
    }
}
