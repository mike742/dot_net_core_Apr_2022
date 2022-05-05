using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dot_net_core_Apr_2022
{
    public class SerializeFile : IComparable<SerializeFile>
    {
        public string FileName { get; set; }
        public long FileSize { get; set; }

        public int CompareTo(SerializeFile other)
        {
            return FileSize.CompareTo(other.FileSize);
        }
    }
}
