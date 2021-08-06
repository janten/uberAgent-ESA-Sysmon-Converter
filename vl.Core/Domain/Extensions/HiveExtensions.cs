﻿using System;
using vl.Core.Domain.Activity;

namespace vl.Core.Domain.Extensions
{
   public static class HiveExtensions
   {
      public static string ToActivityMonitoringHive(this Hive hive)
      {
         return hive switch
         {
            Hive.All => "*",
            Hive.Unknown => "*",
            Hive.HKLM => "HKLM",
            Hive.HKU => "HKU",
            _ => throw new ArgumentOutOfRangeException(nameof(hive), hive, null)
         };
      }

      public static Hive FromString(this string hive)
      {
         return hive switch
         {
            "hklm" => Hive.HKLM,
            "hku" => Hive.HKU,
            _ => Hive.Unknown
         };
      }
   }
}
