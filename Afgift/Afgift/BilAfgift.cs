using System;

namespace Afgift
{
    public static class BilAfgift
    {
        public const string CarPrice_WhenPriceIsLessThanNull =
            "Det er ikke muligt at beregne prisen for BilAfgiften, da værdien er mindre end nul";

        /// <summary>
        /// Metoden ovenfor beregner afgiften af en person bil.´Ved hjælp af parameterværdi "int pris",
        // hvor bliver der udregnet via de formler som bliver tilbudt:
        // hvis prisen er mindre eller lig med 200000: pris * 0.85
        // hvis prisen er størrre end 200000: (pris * 1.50) - 130000
        /// </summary>
        /// <param name="pris"></param>
        /// <returns></returns>
        public static int AfgiftTilBil (int pris)
        {
            double result = 0;

            if (pris >= 0)
            {
                if (pris <= 200000)
                {
                    result = pris * 0.85;
                }

                if (pris > 200000)
                {
                    result = pris * 1.5 - 130000;
                }
                return Convert.ToInt32(result);
            }

            throw new System.ArgumentOutOfRangeException("pris", pris, 
                CarPrice_WhenPriceIsLessThanNull);
        }

        /// <summary>
        // Metoden ovenfor beregner afgiften af en person Elbil. Ved hjælp af parameterværdi "int pris",
        // hvor bliver der udregnet via de formler som bliver tilbudt:
        // Hvis prisen er mindre eller lig med 200000: pris * 0.20
        // Hvis prisen er størrre end 200000: (pris * 0.20) - 130000
        /// </summary>
        /// <param name="pris"></param> 
        /// <returns></returns>
        public static int AfgiftTilElbil(int pris)
        {
            double result = 0;

            if (pris >= 0)
            {
                if (pris <= 200000)
                {
                    result = pris * 0.20;
                }

                if (pris > 200000)
                {
                    result = pris * 0.20 - 130000;
                }

                return Convert.ToInt32(result);
            }

            throw new System.ArgumentOutOfRangeException("pris", pris,
                CarPrice_WhenPriceIsLessThanNull);
        }
    }
}
