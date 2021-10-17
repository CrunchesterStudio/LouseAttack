using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hotel1Estrella : MonoBehaviour
{
    public Text contador;
    public PiojoButtonHandler piojosGen;
    private int numPiojos;
    private int contHotel;
    private int coste = 2000;

    public void añadeHotel()
    {
        if (piojosGen.getPiojos() >= coste)
        {
            contHotel++;
            numPiojos = piojosGen.getPiojos();
            numPiojos -= coste;
            piojosGen.setPiojos(numPiojos);
            contador.text = numPiojos.ToString();
            coste = Mathf.RoundToInt(coste * 1.2f);
            StartCoroutine(Gen100PiojoSeg());
        }
    }


    IEnumerator Gen100PiojoSeg()
    {
        while (true)
        {
            numPiojos = piojosGen.getPiojos();
            numPiojos = numPiojos + (contHotel * 100);
            piojosGen.setPiojos(numPiojos);
            contador.text = numPiojos.ToString();
            yield return new WaitForSeconds(5);
        }
    }
}
