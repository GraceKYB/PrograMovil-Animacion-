using Android.Media;
using animacion.Droid;
using Xamarin.Forms;

[assembly: Dependency(typeof(AudioPlayerService))]

namespace animacion.Droid
{
    public class AudioPlayerService : IAudioPlayer
    {
        private MediaPlayer _player;

        public void PlayAudio(string audioFileName)
        {
            var context = Android.App.Application.Context;
            int resourceId = context.Resources.GetIdentifier(audioFileName, "raw", context.PackageName);

            if (resourceId != 0)
            {
                // Liberar recursos existentes si ya se está reproduciendo audio
                StopAndReleasePlayer();

                _player = new MediaPlayer();
                var fd = context.Resources.OpenRawResourceFd(resourceId);
                _player.SetDataSource(fd.FileDescriptor, fd.StartOffset, fd.Length);
                fd.Close();

                _player.Prepare();
                _player.Start();
            }
        }

        public void PauseAudio()
        {
            if (_player != null && _player.IsPlaying)
            {
                _player.Pause();
            }
        }

        public void ResumeAudio()
        {
            if (_player != null && !_player.IsPlaying)
            {
                _player.Start();
            }
        }

        private void StopAndReleasePlayer()
        {
            if (_player != null)
            {
                if (_player.IsPlaying)
                {
                    _player.Stop();
                }
                _player.Release();
                _player = null;
            }
        }
    }
}
