using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum tipoEnemigo
{
    Pulga,
    Salamandra,
    HumanoQueSeDucha,
    HumanoConRepelente
}
public class Enemigo
{
    private int vidaMax;
    private int vidaActual;
    public tipoEnemigo tipo;

    public Enemigo(int vidaMax, tipoEnemigo tipo)
    {
        this.vidaMax = vidaMax;
        this.tipo = tipo;
        this.vidaActual = this.vidaMax;
    }

    public int GetVidaMax()
    {
        return this.vidaMax;
    }

    public void SetVidaMax(int nuevaVida)
    {
        this.vidaMax = nuevaVida;
    }

    public int GetVidaActual()
    {
        return this.vidaActual;
    }

    public void SetVidaActual(int nuevaVida)
    {
        this.vidaActual = nuevaVida;
    }

}

