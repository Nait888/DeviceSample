using DeviceModule.Services;
using System.Collections.Concurrent;

namespace DeviceModule.Factories
{
    public class DeviceServiceFactory
    {
        private readonly ConcurrentDictionary<string, IDeviceService> _instances = new(); 

        public IDeviceService CreateOrGet(string deviceId)
        {
            return _instances.GetOrAdd(deviceId, id => new DeviceService(id));
        }
    }
}