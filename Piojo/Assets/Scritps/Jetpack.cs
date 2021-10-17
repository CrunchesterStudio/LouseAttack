using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Jetpack : MonoBehaviour
{
    public Text contador;
    public PiojoButtonHandler piojosGen;
    private int numPiojos;
    private int contJetpack;
    private int coste = 10000;

    public void añadeJetpack()
    {
        if (piojosGen.getPiojos() >= coste)
        {
            contJetpack++;
            numPiojos = piojosGen.getPiojos();
            numPiojos -= coste;
            piojosGen.setPiojos(numPiojos);
            contador.text = numPiojos.ToString();
            coste = Mathf.RoundToInt(coste * 1.2f);
            StartCoroutine(Gen1000Piojos());
        }
    }


    IEnumerator Gen1000Piojos()
    {
        while (true)
        {
            numPiojos = piojosGen.getPiojos();
            numPiojos = numPiojos + (contJetpack * 1000);
            piojosGen.setPiojos(numPiojos);
            contador.text = numPiojos.ToString();
            yield return new WaitForSeconds(2);
        }

    }
}
