using CommonModels;
using System.Threading.Tasks;

namespace DeviceModule.Services
{
    public interface IDeviceService
    {
        string DeviceId { get; }
        Task<bool> InitializeAsync();
        Task<DeviceStatus> GetStatusAsync();
        Task<bool> RunCommandAsync(string cmd, object param);
    }
}