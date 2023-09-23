using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New1.Day8
{
    internal class By
    {
        public static byte[] GetLogo()
        {
            byte[] _logoBytes = null;
            if (_logoBytes == null)
            {
                _logoBytes = File.ReadAllBytes(@"c:\temp\Html_Logo.png");
            }
            return _logoBytes;
        }

        internal static object Logo
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}
