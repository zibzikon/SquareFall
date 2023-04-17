using System;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Kernel.Extensions
{
    public static class TaskExtensions
    {
        public static Task<T> AsTask<T>(this ResourceRequest request, CancellationToken cancellationToken = default) where T : Object
        {
            var assetType = request.asset.GetType();

            if (assetType.IsAssignableFrom(typeof(T)))
                throw new InvalidCastException(
                    @$"The request resource with type: ({assetType}) is not assignable to generic type: ({typeof(T)})");

            var tcs = new TaskCompletionSource<T>();

            request.completed += _ =>
            {
                if (cancellationToken.IsCancellationRequested) 
                    tcs.SetCanceled();
                else 
                    tcs.SetResult((T)request.asset);
            };

            return tcs.Task;
        }
    }
}