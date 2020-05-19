using System;
using System.Collections.Generic;
using System.Text;

namespace LV6
{
    enum Gume 
    {
        zimske,
        ljetne
    
    }

    class Auto : WeatherObserver
    {
        double snagaMotora, gorivo;
        string gume;

        public Auto(double snaga, double gorivo,string gume)
        {
            this.snagaMotora = snaga;
            this.gorivo = gorivo;
            this.gume = gume;
        }

        public void Update(int temp)
        {
            if (temp <= 5)
            {
                gume=Gume.zimske.ToString();
                
            }else if (temp > 5)
            {
                gume=Gume.ljetne.ToString();
            }
        }

        public override string ToString()
        {
            return this.snagaMotora+", "+this.gorivo+", "+this.gume;
        }
    }
}

