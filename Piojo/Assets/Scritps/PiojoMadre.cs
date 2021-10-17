using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PiojoMadre : MonoBehaviour
{
    public Text contador;
    public Text costeActual;
    public PiojoButtonHandler piojosGen;
    private int numPiojos;
    private int contPiojoMadre;
    private int coste = 25;

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
            costeActual.text = coste.ToString();
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
