using AssymetricCryptoApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecryptionTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            var key = @"<RSAKeyValue><Modulus>s1qUChU+O1od+qeJruzWRzHoUVONGicRwhokICt/13FDXBNOA8JIQs0YChYgffdrnjK2d6YEDzAVlQSp65Unk6pf7WeIuG6TwSb+UIQkooZdtmVGVvZUciNZbXGIRsvmSGi0P7BWfX1kXPmhmoZZNalRsL1bhXpaiTK0TlMp9jM=</Modulus><Exponent>AQAB</Exponent><P>2N8K6PlroFC22/FM1kF2RXFsW1do9MaGpwm5xvU0wjM1fwACZgy8d64Ar3PgDhV67A6lWz10rmSJWG3mdB5NhQ==</P><Q>07apXVOU4V+105bkvA0DUiK+sVeCVzu8V8Qtoq4Q3GeZxjp/WLCGJdRtz8GR3rklll5Q3ht+NUpEyJ3uNEKGVw==</Q><DP>RW+MN7F8AxU0ptDoUAUfj/ZTwh8HbK+PdzXG9GuX28G3lBT1r6TORudAMuy/xOKdu6yoxsCzdg6cZuKxEWaOXQ==</DP><DQ>D52vjGS33I/Ut5CvunczQYGykx4jTQ/o6ohb3V39fGRf4VE7R21t16h9mQ9sFQOPFDJMwLVCb+fUfv+3LD+j7Q==</DQ><InverseQ>RyNsNClJq7g42MMarpzf8SOkYzdmCkSKTwGlmnZzIlnZBTjQxD5lH6IADGK1Al1MHTamhpCY/CUibFGfUFn7DA==</InverseQ><D>AEmMcpt1Zj4VKRZhduPl1RQbNOflbHP1TVCIqZ0tZ8C+ZiVZlITHxaIsn8nfvg9XvGsDrHDW9o7sGmKimnl//uh0IOcqgZ5gEVMmybdeWguFDuueS4sMBrZfcgsSDSKmfxI8zOpNMrJ6iqNvWvT9OgDByN55NXBLh5hkuOBLjOk=</D></RSAKeyValue>";
            var ctext = "xoT4EVmG2C9Rj7tR8EOsSuxeP0AxsObU0sPS9Hr6A7/xX63riRFl50unmvKbPA5uCwUFXrmyP4XLfydDzEQMbx/Y4ITfnnnY+KCsDcmwOD6Lxuncrq2YkBhsem1rTQbITTbf324qp2NouPLc2DykClB1dIJzyKCwIhMOXzPkZUkTBM047neCi7+hWbN21B+2wsnR1XzcB3w=$gehmMDPSl6b4vdn826yYC7cT+LR+gnLzTLLdM8IV+E+SyFO32Ks5OqxBx5b+Vx367m/3jYWy/l9oXhJCq8xA/xobiRrxFtqSDKMkZ6XdPps7NI1To3qLwnBJqJ7B7dV0LdUUpogqUMM/OFbHtI4dSfQFo5nNUR8fZh6hlRyXcOM=$ATylbVV1EO3myMXK21zUt0vLs4USGM1aYg5upr1sHdwPhTOhPKb6/xHJsuys6vxzGyaghEueA4qlpTQ6fALkt/8xgR6G1qhE8Wj9V2sZZx+2EPYQNrrdqgYKUzpHl3WOmwmlUoxivyrAnrNlDamubvlRZUEK8YtzXzwg1Sh+IMI=";
            var crypto = new Crypto(key);
            var text  = crypto.DecryptText(ctext);
            Console.WriteLine(text);
            Console.Read();
        }
    }
}
