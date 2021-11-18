using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Newtonsoft.Json;
public enum tipoEnemigo
{
    Pulga,
    Garrapata,
    Mosca,
    Salamandra,
    PerroSucio,
    HumanoQueSeDucha,
    HumanoConRepelente,
    LocaDeLosGatos
}

public enum barreras
{
    Casco,
    Chaleco,
    Mascara,
    Pulsera,
    SinProtecciones
}

public class Enemigo
{
    [JsonProperty]
    private int vidaMax;
    [JsonProperty]
    private int vidaActual;
    public tipoEnemigo tipo;

    public barreras barrier;

    public Enemigo(int vidaMax, tipoEnemigo tipo, barreras barrier)
    {
        this.vidaMax = vidaMax;
        this.tipo = tipo;
        this.vidaActual = this.vidaMax;
        this.barrier = barrier;
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

