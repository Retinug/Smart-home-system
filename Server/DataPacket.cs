using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class DataPacket
    {
        public byte type { get; private set; }
        public byte[] data { get; private set; }

        public DataPacket(byte type)
        {
            this.type = type;
        }

        public byte[] ToPacket()
        {
            MemoryStream packet = new MemoryStream();

            packet.Write(new byte[] { type }, 0, 1);

            packet.Write(data, 0, data.Length);

            return packet.ToArray();
        }
    }
}
