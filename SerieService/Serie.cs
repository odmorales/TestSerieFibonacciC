namespace SerieService
{
    public class Serie
    {
        public int[] GetSerie(int numero)
        {
            int a = 0, b, tmp;
            int[] serie = new int[numero];

            if(numero > 0) { serie[0] = 0; } else { return new int[] { 0 }; }
            
            b = 1;

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