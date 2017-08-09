using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Somex.Roburst.Integration.Sockets.Utilities
{
    internal class StringWriterWithEncoding : StringWriter
    {

        private Encoding _Encoding;

        internal StringWriterWithEncoding(StringBuilder stringbuilder, Encoding encoding)
            : base(stringbuilder)
        {
            _Encoding = encoding;
        }

        public override Encoding Encoding
        {
            get { return _Encoding; }
        }

    }
}
