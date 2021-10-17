using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PiojoButtonHandler : MonoBehaviour
{
    public int numPiojos = 0;
    public Text contador;
    public ManosMagicas manosMagicas;

    public void GeneradorPiojos()
    {
        if (manosMagicas.contManosMagicas == 0)
        {
            numPiojos++;
            contador.text = numPiojos.ToString();
        }
        else
        {
            numPiojos = numPiojos + (manosMagicas.contManosMagicas * 100);
            contador.text = numPiojos.ToString();
        }

    }

    public int getPiojos()
    {
        return numPiojos;
    }

    public void setPiojos(int newP)
    {
        numPiojos = newP;
    }
}
