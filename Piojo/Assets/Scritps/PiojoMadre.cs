using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PiojoMadre : MonoBehaviour
{
    public Text contador;
    public PiojoButtonHandler piojosGen;
    private int numPiojos;
    private int contPiojoMadre;
    private int coste = 250;

    public void añadePiojoMadre()
    {
        if (piojosGen.getPiojos() >= coste)
        {
            contPiojoMadre++;
            numPiojos = piojosGen.getPiojos();
            numPiojos -= coste;
            piojosGen.setPiojos(numPiojos);
            contador.text = numPiojos.ToString();
            coste = Mathf.RoundToInt(coste * 1.2f);
            StartCoroutine(Gen1PiojoSeg());
        }
    }


    IEnumerator Gen1PiojoSeg()
    {
        while (true)
        {
            numPiojos = piojosGen.getPiojos();
            numPiojos = numPiojos + contPiojoMadre;
            piojosGen.setPiojos(numPiojos);
            contador.text = numPiojos.ToString();
            yield return new WaitForSeconds(1);
        }
    }
}
