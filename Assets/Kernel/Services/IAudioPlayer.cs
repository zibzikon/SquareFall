using System.Threading;
using System.Threading.Tasks;
using UnityEngine;

namespace Kernel.Services
{
    public interface IAudioPlayer
    {
        void PlayFromResource(string resourceName);
        void PlayFromClip(AudioClip clip);
    }
}