using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Escuela : MonoBehaviour
{
    public Text contador;
    public PiojoButtonHandler piojosGen;
    private int numPiojos;
    private int contEscuela;
    private int coste = 100;

    public void añadeEscuela()
    {
        if (piojosGen.getPiojos() >= coste)
        {
            contEscuela++;
            numPiojos = piojosGen.getPiojos();
            numPiojos -= coste;
            piojosGen.setPiojos(numPiojos);
            contador.text = numPiojos.ToString();
            coste = Mathf.RoundToInt(coste * 1.2f);
            StartCoroutine(Gen5PiojoSeg());
        }
    }


    IEnumerator Gen5PiojoSeg()
    {
        while (true)
        {
            numPiojos = piojosGen.getPiojos();
            numPiojos = numPiojos + (contEscuela*5);
            piojosGen.setPiojos(numPiojos);
            contador.text = numPiojos.ToString();
            yield return new WaitForSeconds(5);
        }
    }
}
