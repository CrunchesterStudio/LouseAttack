using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManosMagicas : MonoBehaviour
{
    public Text contador;
    public PiojoButtonHandler piojosGen;
    private int numPiojos;
    public int contManosMagicas;
    private int coste = 5000;

    public void añadeManosMagicas()
    {
        if (piojosGen.getPiojos() >= coste)
        {
            contManosMagicas++;
            numPiojos = piojosGen.getPiojos();
            numPiojos -= coste;
            piojosGen.setPiojos(numPiojos);
            contador.text = numPiojos.ToString();
            coste = Mathf.RoundToInt(coste * 1.2f);    
        }
    }
}
