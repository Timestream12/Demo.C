using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AdamsIO
{
    public class Reader : BaseIO
    {
        /// <summary>
        /// Create a reader to read a file
        /// </summary>
        /// <param name="path">The path to the file to read.</param>
        public Reader(string path)
        {
            br = new BinaryReader(File.OpenRead(path));
            this.byteOrder = ByteOrder.BigEndian;
        }
        /// <summary>
        /// Create a reader to read a file
        /// </summary>
        /// <param name="path">The path to the file to read.</param>
        /// <param name="bo">The order of the bytes to read.</param>
        public Reader(string path, ByteOrder bo)
        {
            br = new BinaryReader(File.OpenRead(path));
            this.byteOrder = bo;
        }

        BinaryReader br;

        /// <summary>
        /// The position to read at.
        /// </summary>
        public long Position
        {
            get { return br.BaseStream.Position; }
            set { br.BaseStream.Position = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public byte ReadByte()
        {
            return br.ReadByte();
        }

        public sbyte ReadSByte()
        {
            return (sbyte)br.ReadByte();
        }

        public short ReadInt16()
        {
            short myShort = br.ReadInt16();
            if (byteOrder == ByteOrder.BigEndian)
            {
                byte[] buff = BitConverter.GetBytes(myShort);
                Array.Reverse(buff);
                myShort = BitConverter.ToInt16(buff, 0);
            }
            return myShort;
        }

        public short ReadUInt16()
        {
            short myUShort = br.ReadUInt16();
            if (byteOrder == ByteOrder.BigEndian)
            {
                byte[] buff = BitConverter.GetBytes(myShort);
                Array.Reverse(buff);
                myUShort = BitConverter.ToInt16(buff, 0);
            }
            return myUShort;
        }


    }

    public abstract class BaseIO
    {
        /// <summary>
        /// The order of the bytes both read and write
        /// </summary>
        public enum ByteOrder
        {
            BigEndian,
            LittleEndian
        }

        protected ByteOrder byteOrder;

    }
}
