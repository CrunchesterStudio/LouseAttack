using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyButtonHandler : MonoBehaviour
{
    public Text contador;
    public PiojoButtonHandler piojosGen;
    public LifeBar barraVida;
    private int numPiojos;
    public int maxVida = 100;
    public int vidaActual = 100;

    private void Start()
    {
        vidaActual = maxVida;
        barraVida.setVidaMaxima(maxVida);
    }

    public void DestructorPiojos()
    {
        numPiojos = piojosGen.getPiojos();
        if (numPiojos > 0)
        {
            numPiojos--;
            piojosGen.setPiojos(numPiojos);
            contador.text = numPiojos.ToString();
            vidaActual--;
            barraVida.setVida(vidaActual);
        }
    }
}
