﻿using System;

namespace Api.Cielo.Lio.Domain.Extensions
{
    internal static class DecimalExtensions
    {
        public static int OnlyNumbers(this decimal source)
        {
            return Convert.ToInt32(source.ToString("N2").OnlyNumbers());
        }
    }
}
