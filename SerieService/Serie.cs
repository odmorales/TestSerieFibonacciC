namespace SerieService
{
    public class Serie
    {
        public int[] getSerie(int numero)
        {
            int a = 0, b, tmp;
            int[] serie = new int[numero];

            b = 1;

            serie[0] = 0;
            for (int i = 1; i < numero; i++)
            {
                tmp = a + b;
                a = b;
                b = tmp;

                serie[i] = a;
            }

            return serie;
        }
    }
}