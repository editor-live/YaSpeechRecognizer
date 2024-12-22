using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    internal class SoundPlayer
    {


        public MemoryStream GetCopyStream(MemoryStream stream)
        {
            return new MemoryStream(stream.ToArray());
        }

        public void PlaySound(MemoryStream stream)
        {
            var reader = new WaveFileReader(stream);
            var output = new WaveOutEvent();
            output.Init(reader);
            output.Play();
        }

        public void PlaySound(MemoryStream stream, float volume)
        {
            var reader = new WaveFileReader(stream);
            var output = new WaveOutEvent();
            output.Volume = volume;
            output.Init(reader);
            output.Play();
        }


    }
}
