using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    //Contador Principal
    public Text contador;

    //Botón Piojos
    public int numPiojos = 0;

    //Botón Enemigos
    public LifeBar barraVida;
    public int maxVida = 100;
    public int vidaActual = 100;

    //Enfermera
    public Text costeActualEnfermera;
    private int contEnfermeras = 0;
    private int costeEnfermera = 10;

    //Piojo Madre
    public Text costeActualPMadre;
    private int contPiojoMadre = 0;
    private int costePMadre = 25;

    //Escuela
    public Text costeActualEscuela;
    private int contEscuela = 0;
    private int costeEscuela = 10;

    //Hostal
    public Text costeActualHostal;
    private int contHostal = 0;
    private int costeHostal = 20;

    //Manos Mágicas
    public Text costeActualManosM;
    private int contManosMagicas = 0;
    private int costeManos = 50;

    //Jetpack
    public Text costeActualJetPack;
    private int contJetpack = 0;
    private int costeJetpack = 10;

    //Piojo Mazao
    public Text costeActualPMazao;
    private int contPiojoMazao = 0;
    private int costePMazao = 10;

    //Caza Titanes
    public Text costeActualCazaTitanes;
    private int contCazaTitanes = 0;
    private int costeCTitanes = 10;

    //Piojo Cañón
    public Text costeActualPCanon;
    private int contPCanon = 0;
    private int costePCanon = 10;

    //Piojo Man
    public Text costeActualPMan;
    private int contPiojoMan = 0;
    private int costePMan = 10;


    // Start is called before the first frame update
    void Start()
    {
        //Botón Enemigo
        vidaActual = maxVida;
        barraVida.setVidaMaxima(maxVida);

        //Enfermera
        costeActualEnfermera.text = costeEnfermera.ToString();
        costeActualEnfermera.color = Color.red;

        //Piojo Madre
        costeActualPMadre.text = costePMadre.ToString();
        costeActualPMadre.color = Color.red;

        //Escuela
        costeActualEscuela.text = costeEscuela.ToString();
        costeActualEscuela.color = Color.red;

        //Hostal
        costeActualHostal.text = costeHostal.ToString();
        costeActualHostal.color = Color.red;

        //Manos Mágicas
        costeActualManosM.text = costeManos.ToString();
        costeActualManosM.color = Color.red;

        //Jetpack
        costeActualJetPack.text = costeJetpack.ToString();
        costeActualJetPack.color = Color.red;

        //Piojo Mazao
        costeActualPMazao.text = costePMazao.ToString();
        costeActualPMazao.color = Color.red;

        //Caza Titanes
        costeActualCazaTitanes.text = costeCTitanes.ToString();
        costeActualCazaTitanes.color = Color.red;

        //Piojo Cañón
        costeActualPCanon.text = costePCanon.ToString();
        costeActualPCanon.color = Color.red;

        //Piojo Man
        costeActualPMan.text = costePMan.ToString();
        costeActualPMan.color = Color.red;

    }

    // Update is called once per frame
    void Update()
    {
        //Enfermera
        if (getPiojos() >= costeEnfermera)
            costeActualEnfermera.color = Color.green;
        else
            costeActualEnfermera.color = Color.red;

        //Piojo Madre
        if (getPiojos() >= costePMadre)
            costeActualPMadre.color = Color.green;
        else
            costeActualPMadre.color = Color.red;

        //Escuela
        if (getPiojos() >= costeEscuela)
            costeActualEscuela.color = Color.green;
        else
            costeActualEscuela.color = Color.red;

        //Hostal
        if (getPiojos() >= costeHostal)
            costeActualHostal.color = Color.green;
        else
            costeActualHostal.color = Color.red;

        //Manos Mágicas
        if (getPiojos() >= costeManos)
            costeActualManosM.color = Color.green;
        else
            costeActualManosM.color = Color.red;

        //Jetpack
        if (getPiojos() >= costeJetpack)
            costeActualJetPack.color = Color.green;
        else
            costeActualJetPack.color = Color.red;

        //Piojo Mazao
        if (getPiojos() >= costePMazao)
            costeActualPMazao.color = Color.green;
        else
            costeActualPMazao.color = Color.red;

        //Caza Titanes
        if (getPiojos() >= costeCTitanes)
            costeActualCazaTitanes.color = Color.green;
        else
            costeActualCazaTitanes.color = Color.red;

        //Piojo Cañón
        if (getPiojos() >= costePCanon)
            costeActualPCanon.color = Color.green;
        else
            costeActualPCanon.color = Color.red;

        //Piojo Man
        if (getPiojos() >= costePMan)
            costeActualPMan.color = Color.green;
        else
            costeActualPMan.color = Color.red;
    }

    //Botón Piojo
    public int getPiojos() { return numPiojos; }
    public void setPiojos(int newP) { numPiojos = newP; }

    public void GeneradorPiojos()
    {
        if (contManosMagicas == 0)
        {
            numPiojos++;
            contador.text = numPiojos.ToString();
        }
        else
        {
            numPiojos = numPiojos + (contManosMagicas * 100);
            contador.text = numPiojos.ToString();
        }

    }

    //Botón Enemigos
    public void DestructorPiojos()
    {
        numPiojos = getPiojos();
        if (numPiojos > 0)
        {
            if (contPiojoMazao == 0 || numPiojos < contPiojoMazao * 5)
            {
                numPiojos--;
                setPiojos(numPiojos);
                contador.text = numPiojos.ToString();
                vidaActual--;
                barraVida.setVida(vidaActual);
            }
            else
            {
                numPiojos = numPiojos - (contPiojoMazao * 5);
                setPiojos(numPiojos);
                contador.text = numPiojos.ToString();
                vidaActual -= contPiojoMazao * 5;
                barraVida.setVida(vidaActual);
            }

        }
    }

    //Enfermera
    public void añadeEnfermera()
    {
        if (getPiojos() >= costeEnfermera)
        {
            contEnfermeras++;
            numPiojos = getPiojos();
            numPiojos -= costeEnfermera;
            setPiojos(numPiojos);
            contador.text = numPiojos.ToString();
            costeEnfermera = Mathf.RoundToInt(costeEnfermera * 1.2f);
            costeActualEnfermera.text = costeEnfermera.ToString();
            StartCoroutine(Gen20Piojos());
        }
    }
    IEnumerator Gen20Piojos()
    {
        yield return new WaitForSeconds(20);
        while (true)
        {
            numPiojos = getPiojos();
            numPiojos = numPiojos + (contEnfermeras * 20);
            setPiojos(numPiojos);
            contador.text = numPiojos.ToString();
            yield return new WaitForSeconds(20);
        }

    }

    //Piojo Madre
    public void añadePiojoMadre()
    {
        if (getPiojos() >= costePMadre)
        {
            contPiojoMadre++;
            numPiojos = getPiojos();
            numPiojos -= costePMadre;
            setPiojos(numPiojos);
            contador.text = numPiojos.ToString();
            costePMadre = Mathf.RoundToInt(costePMadre * 1.2f);
            costeActualPMadre.text = costePMadre.ToString();
            StartCoroutine(Gen1PiojoSeg());
        }
    }
    IEnumerator Gen1PiojoSeg()
    {
        while (true)
        {
            numPiojos = getPiojos();
            numPiojos = numPiojos + contPiojoMadre;
            setPiojos(numPiojos);
            contador.text = numPiojos.ToString();
            yield return new WaitForSeconds(1);
        }
    }

    //Escuela
    public void añadeEscuela()
    {
        if (getPiojos() >= costeEscuela)
        {
            contEscuela++;
            numPiojos = getPiojos();
            numPiojos -= costeEscuela;
            setPiojos(numPiojos);
            contador.text = numPiojos.ToString();
            costeEscuela = Mathf.RoundToInt(costeEscuela * 1.2f);
            costeActualEscuela.text = costeEscuela.ToString();
            StartCoroutine(Gen5PiojoSeg());
        }
    }
    IEnumerator Gen5PiojoSeg()
    {
        yield return new WaitForSeconds(5);
        while (true)
        {
            numPiojos = getPiojos();
            numPiojos = numPiojos + (contEscuela * 5);
            setPiojos(numPiojos);
            contador.text = numPiojos.ToString();
            yield return new WaitForSeconds(5);
        }
    }

    //Hostal
    public void añadeHotel()
    {
        if (getPiojos() >= costeHostal)
        {
            contHostal++;
            numPiojos = getPiojos();
            numPiojos -= costeHostal;
            setPiojos(numPiojos);
            contador.text = numPiojos.ToString();
            costeHostal = Mathf.RoundToInt(costeHostal * 1.2f);
            costeActualHostal.text = costeHostal.ToString();
            StartCoroutine(Gen100PiojoSeg());
        }
    }
    IEnumerator Gen100PiojoSeg()
    {
        yield return new WaitForSeconds(25);
        while (true)
        {
            numPiojos = getPiojos();
            numPiojos = numPiojos + (contHostal * 100);
            setPiojos(numPiojos);
            contador.text = numPiojos.ToString();
            yield return new WaitForSeconds(25);
        }
    }

    //Manos Mágicas
    public void añadeManosMagicas()
    {
        if (getPiojos() >= costeManos)
        {
            contManosMagicas++;
            numPiojos = getPiojos();
            numPiojos -= costeManos;
            setPiojos(numPiojos);
            contador.text = numPiojos.ToString();
            costeManos = Mathf.RoundToInt(costeManos * 1.2f);
            costeActualManosM.text = costeManos.ToString();
        }
    }

    //Jetpack
    public void añadeJetpack()
    {
        if (getPiojos() >= costeJetpack)
        {
            contJetpack++;
            numPiojos = getPiojos();
            numPiojos -= costeJetpack;
            setPiojos(numPiojos);
            contador.text = numPiojos.ToString();
            costeJetpack = Mathf.RoundToInt(costeJetpack * 1.2f);
            costeActualJetPack.text = costeJetpack.ToString();
            StartCoroutine(Gen1000Piojos());
        }
    }
    IEnumerator Gen1000Piojos()
    {
        yield return new WaitForSeconds(20);
        while (true)
        {
            numPiojos = getPiojos();
            numPiojos = numPiojos + (contJetpack * 1000);
            setPiojos(numPiojos);
            contador.text = numPiojos.ToString();
            yield return new WaitForSeconds(20);
        }

    }

    //Piojo Mazao
    public void añadePiojoMazao()
    {
        if (getPiojos() >= costePMazao)
        {
            contPiojoMazao++;
            numPiojos = getPiojos();
            numPiojos -= costePMazao;
            setPiojos(numPiojos);
            contador.text = numPiojos.ToString();
            costePMazao = Mathf.RoundToInt(costePMazao * 1.2f);
            costeActualPMazao.text = costePMazao.ToString();
        }
    }

    //Caza Titanes
    public void añadeCazaTitanes()
    {
        if (getPiojos() >= costeCTitanes)
        {
            contCazaTitanes++;
            numPiojos = getPiojos();
            numPiojos -= costeCTitanes;
            setPiojos(numPiojos);
            contador.text = numPiojos.ToString();
            costeCTitanes = Mathf.RoundToInt(costeCTitanes * 1.2f);
            costeActualCazaTitanes.text = costeCTitanes.ToString();
        }
    }

    //Piojo Cañón
    public void añadePiojoCanon()
    {
        if (getPiojos() >= costePCanon)
        {
            contPCanon++;
            numPiojos = getPiojos();
            numPiojos -= costePCanon;
            setPiojos(numPiojos);
            contador.text = numPiojos.ToString();
            costePCanon = Mathf.RoundToInt(costePCanon * 1.2f);
            costeActualPCanon.text = costePCanon.ToString();
        }
    }

    //Piojo Man
    public void añadePiojoMan()
    {
        if (getPiojos() >= costePMan)
        {
            contPiojoMan++;
            numPiojos = getPiojos();
            numPiojos -= costePMan;
            setPiojos(numPiojos);
            contador.text = numPiojos.ToString();
            costePMan = Mathf.RoundToInt(costePMan * 1.2f);
            costeActualPMan.text = costePMan.ToString();
        }
    }
}
