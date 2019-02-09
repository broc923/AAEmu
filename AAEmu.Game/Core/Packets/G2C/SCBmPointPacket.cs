using AAEmu.Commons.Network;
using AAEmu.Game.Core.Network.Game;

namespace AAEmu.Game.Core.Packets.G2C
{
    public class SCBmPointPacket : GamePacket
    {
        private readonly long _bmPoint;

        public SCBmPointPacket(long bmPoint) : base(0x041, 1)
        {
            _bmPoint = bmPoint;
        }

        public override PacketStream Write(PacketStream stream)
        {
            stream.Write(_bmPoint);
            return stream;
        }
    }
}