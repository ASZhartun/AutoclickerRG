using System;
using System.Windows.Forms;

namespace AutoclickerRG
{
    public class Validator
    {
        public Validator() { }

        public int[] validateCoord(string[] coords)
        {
            if (HasAllInts(coords))
            {
                int[] trueCoords = ParseCoordsToInts(coords);
                NormalizeCoords(trueCoords);
                if (FirstPointLessThanSecond(trueCoords))
                {
                    return trueCoords;
                }
            }
            return new int[] { 0, 0, Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height };
        }

        private void NormalizeCoords(int[] trueCoords)
        {
            trueCoords[2] = trueCoords[2] > Screen.PrimaryScreen.Bounds.Width ? Screen.PrimaryScreen.Bounds.Width : trueCoords[2];
            trueCoords[3] = trueCoords[3] > Screen.PrimaryScreen.Bounds.Height ? Screen.PrimaryScreen.Bounds.Height : trueCoords[3];
        }

        private bool FirstPointLessThanSecond(int[] trueCoords)
        {
            return trueCoords[0] < trueCoords[2] && trueCoords[1] < trueCoords[3];
        }

        private int[] ParseCoordsToInts(string[] coords)
        {
            int[] trueCoords = new int[coords.Length];
            for (int i = 0; i < coords.Length; i++)
            {
                Int32.TryParse(coords[i], out trueCoords[i]);
            }
            return trueCoords;
        }

        private bool HasAllInts(string[] coords)
        {
            for (int i = 0; i < coords.Length; i++)
            {
                int temp = 0;
                if (!Int32.TryParse(coords[i], out temp))
                {
                    return false;
                }
            }
            return true;
        }

        public int validateCPS(string cps)
        {
            int result = 0;
            Int32.TryParse(cps, out result);
            return result;
        }
    }
}