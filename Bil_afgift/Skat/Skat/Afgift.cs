using System;

namespace Skat
{
    public class Afgift
    {
        public Afgift()
        {

        }

        /// <summary>
        /// Udregner afgiften på bilen ud fra dens pris
        /// </summary>
        /// <param name="pris">prisen på bilen</param>
        /// <returns>den afgiften på bilen, konverteret til hel tal</returns>
        public static int BilAfgift(int pris)
        {
            //Exception TooLow = new ArgumentOutOfRangeException("Prisen er ikke gyldig, siden den er 0 eller negativ");

            // check om prisen er 0 eller under 0, hvis ja, kast Exception
            // efter denne metode har kastet en exception, stopper den med at køre resten
            if (pris < 0)
            {
                throw new ArgumentOutOfRangeException($"!!!!! Prisen ({pris}) er ikke gyldig, siden den er 0 eller negativ !!!!!"); ;
            }

            // hvis prisen er mindre end, eller er lige præcis 200.000
            if (pris <= 200000)
            {
                double temp = pris * 0.85;
                return (Convert.ToInt32(temp));
            }
            else // hvis prisen er højere end 200.000 // hvis prisen var under 0, ville vi aldrig haft nået her til
            {
                double temp = (pris * 1.5) - 130000;
                return (Convert.ToInt32(temp));
            }
        }

        /// <summary>
        /// udregner prisen på Elbilen ud fra dens pris
        /// </summary>
        /// <param name="pris">prisen på elbilen</param>
        /// <returns>afgiften på elbilen, konverteret til hel tal</returns>
        public static int ElBilAfgift(int pris)
        {
            //Exception TooLow = new ArgumentOutOfRangeException("Prisen er ikke gyldig, siden den er 0 eller negativ");

            // check om prisen er 0 eller under 0, hvis ja, kast Exception
            // efter denne metode har kastet en exception, stopper den med at køre resten
            if (pris < 0)
            {
                throw new ArgumentOutOfRangeException($"!!!!! Prisen ({pris}) er ikke gyldig, siden den er 0 eller negativ !!!!!"); ;
            }

            // hvis prisen er mindre end, eller er lige præcis 200.000
            if (pris <= 200000)
            {
                double temp = (pris * 0.85) * 0.20;
                return (Convert.ToInt32(temp));
            }
            else // hvis prisen er højere end 200.000 // hvis prisen var under 0, ville vi aldrig haft nået her til
            {
                double temp = ((pris * 1.5) - 130000) * 0.20;
                return (Convert.ToInt32(temp));
            }
        }
    }
}
