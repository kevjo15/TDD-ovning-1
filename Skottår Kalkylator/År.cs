namespace Skottår_Kalkylator
{
    public class År
    {
        public static bool ÄrSkottår(int år)
        {
            // Alla år delbara med 400 är skottår
            if (år % 400 == 0)
            {
                return true;
            }
            // Alla år delbara med 100 men inte med 400 är inte skottår
            else if (år % 100 == 0 && år % 400 != 0)
            {
                return false;
            }
            // Alla år delbara med 4 men inte delbara med 100 är skottår
            else if (år % 4 == 0 && år % 100 != 0)
            {
                return true;
            }
            // Alla övriga år är inte skottår
            else
            {
                return false;
            }
        }
        public static bool ÄrSkottårOneLiner(int år)
        {
            return (år % 400 == 0) || (år % 100 != 0 && år % 4 == 0);
        }
        public static bool ÄrSkottår3Lines(int år)
        {
            if (år % 400 == 0)
                return true;

            if (år % 100 == 0 && år % 400 != 0)
                return false;

            return år % 4 == 0 && år % 100 != 0;
        }
        public static int GetDagNummer(DateTime datum)
        {
            return datum.DayOfYear;
        }

    }
}