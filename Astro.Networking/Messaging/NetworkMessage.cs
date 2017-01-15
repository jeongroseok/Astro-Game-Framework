using System;
using System.IO;

namespace Astro.Networking
{
    public class NetworkMessage
    {
        private byte[] buffer;

        public short OwnerId { get; private set; }
        public Stream Stream
        {
            get
            {
                return new MemoryStream(buffer);
            }
        }

        internal NetworkMessage(byte[] buffer)
        {
            this.buffer = buffer;
        }

        public byte[] ToArray()
        {
            byte[] copy = new byte[buffer.Length];
            Buffer.BlockCopy(buffer, 0, copy, 0, buffer.Length);
            return copy;
        }
    }
}
