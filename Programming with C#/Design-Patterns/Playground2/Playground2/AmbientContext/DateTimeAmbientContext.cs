using System;

namespace Playground2.AmbientContext
{
    //https://www.google.ru/search?newwindow=1&ei=s_eGWvinM836kwXt_afYDg&q=ambient+context+c%23+datetime&oq=Ambient+Context+C%23+datet&gs_l=psy-ab.1.0.33i21k1.2259917.2262792.0.2263467.6.6.0.0.0.0.277.849.0j4j1.5.0....0...1c.1.64.psy-ab..1.5.847...0i22i30k1j33i160k1.0.yp2PXRw3zB8

    public class DateTimeAmbientContext
    {
        private static DateTime instance;

        private DateTimeAmbientContext()
        {
        }

        public static DateTime Instance
        {
            get
            {
                if (instance != null)
                {
                    instance = new DateTime();
                }

                return instance;
            }
        }

        public static DateTime Now
        {
            get
            {
                return DateTime.Now;
            }
        }
    }
}
