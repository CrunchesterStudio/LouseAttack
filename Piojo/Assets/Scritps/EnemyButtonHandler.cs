using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyButtonHandler : MonoBehaviour
{
    public Text contador;
    public PiojoButtonHandler piojosGen;
    private int numPiojos;

    public void DestructorPiojos()
    {
        numPiojos = piojosGen.getPiojos();
        if (numPiojos > 0)
        {
            numPiojos--;
            piojosGen.setPiojos(numPiojos);
            contador.text = numPiojos.ToString();
        }
    }
}
