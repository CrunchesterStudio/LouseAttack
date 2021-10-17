using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManosMagicas : MonoBehaviour
{
    public Text contador;
    public Text costeActual;
    public PiojoButtonHandler piojosGen;
    private int numPiojos;
    public int contManosMagicas;
    private int coste = 50;

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
            costeActual.text = coste.ToString();
        }
    }
}
