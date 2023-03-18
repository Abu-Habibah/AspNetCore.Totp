using System;
using System.Collections.Generic;
using System.Text;

namespace AspNetCore.Totp.Models
{
    /// <summary>
    /// Jangka waktu validitas TOTP
    /// </summary>
    public enum  TimeTolerance
    {
        Strict = 30,
        Moderate= 45,
        Default=60

    }
}
