using System.Threading;
using System.Threading.Tasks;
using Kernel.Extensions;
using UnityEngine;

namespace Kernel.Services
{
    public class AudioPlayer : IAudioPlayer
    {
        private readonly IResourcesLoader _resourcesLoader;

        public AudioPlayer(IResourcesLoader resourcesLoader)
        {
            _resourcesLoader = resourcesLoader;
        }
        
        public void PlayFromResource(string resourceName)
        {
            var audioClip = _resourcesLoader.Load<AudioClip>(resourceName);

            PlayFromClip(audioClip);
        }

        public async void PlayFromClip(AudioClip clip)
        {
            var audioSource = CreateAudioSource();
            
            var clipLength = clip.length;
            audioSource.clip = clip;
            audioSource.Play();
            
            await Task.Delay(clipLength.InMilliseconds());

            if (audioSource.Exists())
                audioSource.DestroyGameObject();
            
        }

        private AudioSource CreateAudioSource() => new GameObject("Audio Source").AddComponent<AudioSource>();
    }
}