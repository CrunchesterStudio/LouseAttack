using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeBar : MonoBehaviour
{
    public Slider lifebar;

    public void setVida(int vida)
    {
        lifebar.value = vida;
    }

    public void setVidaMaxima(int vida)
    {
        lifebar.value = vida;
        lifebar.maxValue = vida;
    }

}
