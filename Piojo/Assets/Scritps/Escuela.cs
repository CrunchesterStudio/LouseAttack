using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Escuela : MonoBehaviour
{
    public Text contador;
    public Text costeActual;
    public PiojoButtonHandler piojosGen;
    private int numPiojos;
    private int contEscuela;
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
            costeActual.text = coste.ToString();
            StartCoroutine(Gen5PiojoSeg());
        }
    }


    IEnumerator Gen5PiojoSeg()
    {
        yield return new WaitForSeconds(5);
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
