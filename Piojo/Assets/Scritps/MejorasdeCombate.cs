using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MejorasdeCombate : MonoBehaviour
{
    public Text contador;
    public Text costeActual;
    public PiojoButtonHandler piojosGen;
    public int contPiojoMazao;
    private int numPiojos;
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
    public void añadePiojoMazao()
    {
        if (piojosGen.getPiojos() >= coste)
        {
            contPiojoMazao++;
            numPiojos = piojosGen.getPiojos();
            numPiojos -= coste;
            piojosGen.setPiojos(numPiojos);
            contador.text = numPiojos.ToString();
            coste = Mathf.RoundToInt(coste * 1.2f);
            costeActual.text = coste.ToString();
        }
    }


   
}
