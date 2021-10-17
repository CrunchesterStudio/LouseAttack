using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enfermera : MonoBehaviour
{
    public Text contador;
    public PiojoButtonHandler piojosGen;
    private int numPiojos;
    private int contEnfermeras;
    private int coste = 100;

    public void añadeEnfermera()
    {
        if (piojosGen.getPiojos()>=coste)
        {
            contEnfermeras++;
            numPiojos = piojosGen.getPiojos();
            numPiojos -= coste;
            piojosGen.setPiojos(numPiojos);
            contador.text = numPiojos.ToString();
            coste = Mathf.RoundToInt(coste * 1.2f);
            StartCoroutine(Gen20Piojos());
        }
    }


    IEnumerator Gen20Piojos()
    {
        while (true)
        {
            numPiojos = piojosGen.getPiojos();
            numPiojos = numPiojos + (contEnfermeras * 20);
            piojosGen.setPiojos(numPiojos);
            contador.text = numPiojos.ToString();
            yield return new WaitForSeconds(20);
        }

    }


}
