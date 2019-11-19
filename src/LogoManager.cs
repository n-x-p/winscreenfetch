using System.Collections.Generic;

namespace WinScreenfetch
{
	internal class LogoManager
	{
        public static List<string[]> Windows()
        {
            // Decided to pick an unusual way to split up the logo parts for colors
            // Color order is Red, Blue, Green, Yellow
            List<string[]> m_list = new List<string[]>()
            {
                new string[]{ string.Empty, string.Empty, "                                       ```...--://+oo`", string.Empty },
                new string[]{ string.Empty, string.Empty, "                         ```...--://+oooossyyyyyyyyyy`", string.Empty },
                new string[]{ "           ```...--:/+-", string.Empty, " .osssyyyyyyyyyyyyyyyyyyyyyyyy`", string.Empty },
                new string[]{ " ..--:/++ooosssyyyyyyy:", string.Empty, " -yyyyyyyyyyyyyyyyyyyyyyyyyyyy`", string.Empty },
                new string[]{ "`yyyyyyyyyyyyyyyyyyyyy:", string.Empty, " -yyyyyyyyyyyyyyyyyyyyyyyyyyyy`", string.Empty },
                new string[]{ "`yyyyyyyyyyyyyyyyyyyyy:", string.Empty, " -yyyyyyyyyyyyyyyyyyyyyyyyyyyy`", string.Empty },
                new string[]{ "`yyyyyyyyyyyyyyyyyyyyy:", string.Empty, " -yyyyyyyyyyyyyyyyyyyyyyyyyyyy`", string.Empty },
                new string[]{ "`yyyyyyyyyyyyyyyyyyyyy:", string.Empty, " -yyyyyyyyyyyyyyyyyyyyyyyyyyyy`", string.Empty },
                new string[]{ "`yyyyyyyyyyyyyyyyyyyyy:", string.Empty, " -yyyyyyyyyyyyyyyyyyyyyyyyyyyy`", string.Empty },
                new string[]{ "`yyyyyyyyyyyyyyyyyyyyy:", string.Empty, " -yyyyyyyyyyyyyyyyyyyyyyyyyyyy`", string.Empty },
                new string[]{ "`yyyyyyyyyyyyyyyyyyyyy:", string.Empty, " -yyyyyyyyyyyyyyyyyyyyyyyyyyyy`", string.Empty },
                new string[]{ "`yyyyyyyyyyyyyyyyyyyyy:", string.Empty, " -yyyyyyyyyyyyyyyyyyyyyyyyyyyy`", string.Empty },
                new string[]{ "`yyyyyyyyyyyyyyyyyyyyy:", string.Empty, " -yyyyyyyyyyyyyyyyyyyyyyyyyyyy`", string.Empty },
                new string[]{ string.Empty, string.Empty, string.Empty, string.Empty },
                new string[]{ string.Empty, "`yyyyyyyyyyyyyyyyyyyyy:", string.Empty, " -yyyyyyyyyyyyyyyyyyyyyyyyyyyy`" },
                new string[]{ string.Empty, "`yyyyyyyyyyyyyyyyyyyyy:", string.Empty, " -yyyyyyyyyyyyyyyyyyyyyyyyyyyy`" },
                new string[]{ string.Empty, "`yyyyyyyyyyyyyyyyyyyyy:", string.Empty, " -yyyyyyyyyyyyyyyyyyyyyyyyyyyy`" },
                new string[]{ string.Empty, "`yyyyyyyyyyyyyyyyyyyyy:", string.Empty, " -yyyyyyyyyyyyyyyyyyyyyyyyyyyy`" },
                new string[]{ string.Empty, "`yyyyyyyyyyyyyyyyyyyyy:", string.Empty, " -yyyyyyyyyyyyyyyyyyyyyyyyyyyy`" },
                new string[]{ string.Empty, "`yyyyyyyyyyyyyyyyyyyyy:", string.Empty, " -yyyyyyyyyyyyyyyyyyyyyyyyyyyy`" },
                new string[]{ string.Empty, "`yyyyyyyyyyyyyyyyyyyyy:", string.Empty, " -yyyyyyyyyyyyyyyyyyyyyyyyyyyy`" },
                new string[]{ string.Empty, "`yyyyyyyyyyyyyyyyyyyyy:", string.Empty, " -yyyyyyyyyyyyyyyyyyyyyyyyyyyy`" },
                new string[]{ string.Empty, "`yyyyyyyyyyyyyyyyyyyyy:", string.Empty, " -yyyyyyyyyyyyyyyyyyyyyyyyyyyy`" },
                new string[]{ string.Empty, " ..--:/++ooosssyyyyyyy:", string.Empty, " -yyyyyyyyyyyyyyyyyyyyyyyyyyyy`" },
                new string[]{ string.Empty, "           ```...--:/+-", string.Empty, " .oossyyyyyyyyyyyyyyyyyyyyyyyy`" },
                new string[]{ string.Empty, string.Empty, string.Empty, "                         ```...--:/++ooosssyyyyyyyyyy`" },
                new string[]{ string.Empty, string.Empty, string.Empty, "                                       ```...--::/+oo`" }

            };

            return m_list;
        }
    }
}
