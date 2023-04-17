using System.Threading;
using System.Threading.Tasks;
using UnityEngine;

namespace Kernel.Services
{
    public interface IResourcesLoader
    {
        T Load<T>(string resourceName) where T : Object;
        Task<T> LoadAsync<T>(string resourceName, CancellationToken cancellationToken = default) where T : Object;
    }
}