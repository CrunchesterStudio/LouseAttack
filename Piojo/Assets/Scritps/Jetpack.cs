using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Jetpack : MonoBehaviour
{
    public Text contador;
    public Text costeActual;
    public PiojoButtonHandler piojosGen;
    private int numPiojos;
    private int contJetpack;
    private int coste = 10;

    private void Start()
    {
        costeActual.text = coste.ToString();
        costeActual.color = Color.red;
    }

    private void Update()
    {
        if (piojosGen.getPiojos() >= coste)
        {
            costeActual.color = Color.green;
        }
        else
        {
            costeActual.color = Color.red;
        }
    }

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
            costeActual.text = coste.ToString();
            StartCoroutine(Gen1000Piojos());
        }
    }


    IEnumerator Gen1000Piojos()
    {
        yield return new WaitForSeconds(20);
        while (true)
        {
            numPiojos = piojosGen.getPiojos();
            numPiojos = numPiojos + (contJetpack * 1000);
            piojosGen.setPiojos(numPiojos);
            contador.text = numPiojos.ToString();
            yield return new WaitForSeconds(20);
        }

    }
}
