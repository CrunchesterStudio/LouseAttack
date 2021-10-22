using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManagerJuego : MonoBehaviour
{
    //Contador Principal
    public Text contador;

    //Bot�n Piojos
    public int numPiojos = 0;

    //Bot�n Enemigos
    public LifeBar barraVida;
    public int maxVida = 100;
    public int vidaActual = 100;

    //Enfermera
    public Text costeActualEnfermera;
    private int costeEnfermera = 10;
    public Text cantidadEnfermera;
    private int contEnfermeras = 0;

    //Piojo Madre
    public Text costeActualPMadre;
    private int costePMadre = 25;
    public Text cantidadPmadre;
    private int contPiojoMadre = 0;

    //Escuela
    public Text costeActualEscuela;
    private int costeEscuela = 10;
    public Text cantidadEscuela;
    private int contEscuela = 0;

    //Hostal
    public Text costeActualHostal;
    private int costeHostal = 20;
    public Text cantidadHostal;
    private int contHostal = 0;

    //Manos M�gicas
    public Text costeActualManosM;
    private int costeManos = 50;
    public Text cantidadManosM;
    private int contManosMagicas = 0;

    //Jetpack
    public Text costeActualJetPack;
    private int costeJetpack = 10;
    public Text cantidadJetpack;
    private int contJetpack = 0;

    //Piojo Mazao
    public Text costeActualPMazao;
    private int costePMazao = 10;
    public Text cantidadPiojoMazao;
    private int contPiojoMazao = 0;

    //Caza Titanes
    public Text costeActualCazaTitanes;
    private int costeCTitanes = 10;
    public Text cantidadCazaTitanes;
    private int contCazaTitanes = 0;

    //Piojo Ca��n
    public Text costeActualPCanon;
    private int costePCanon = 10;
    public Text cantidadPCanon;
    private int contPCanon = 0;

    //Piojo Man
    public Text costeActualPMan;
    private int costePMan = 10;
    public Text cantidadPiojoMan;
    private int contPiojoMan = 0;


    // Start is called before the first frame update
    void Start()
    {
        //Bot�n Enemigo
        vidaActual = maxVida;
        barraVida.setVidaMaxima(maxVida);

        //Enfermera
        costeActualEnfermera.text = costeEnfermera.ToString();
        costeActualEnfermera.color = Color.red;
        cantidadEnfermera.text = contEnfermeras.ToString();

        //Piojo Madre
        costeActualPMadre.text = costePMadre.ToString();
        costeActualPMadre.color = Color.red;
        cantidadPmadre.text = contPiojoMadre.ToString();

        //Escuela
        costeActualEscuela.text = costeEscuela.ToString();
        costeActualEscuela.color = Color.red;
        cantidadEscuela.text = contEscuela.ToString();

        //Hostal
        costeActualHostal.text = costeHostal.ToString();
        costeActualHostal.color = Color.red;
        cantidadHostal.text = contHostal.ToString();

        //Manos M�gicas
        costeActualManosM.text = costeManos.ToString();
        costeActualManosM.color = Color.red;
        cantidadManosM.text = contManosMagicas.ToString();

        //Jetpack
        costeActualJetPack.text = costeJetpack.ToString();
        costeActualJetPack.color = Color.red;
        cantidadJetpack.text = contJetpack.ToString();

        //Piojo Mazao
        costeActualPMazao.text = costePMazao.ToString();
        costeActualPMazao.color = Color.red;
        cantidadPiojoMazao.text = contPiojoMazao.ToString();

        //Caza Titanes
        costeActualCazaTitanes.text = costeCTitanes.ToString();
        costeActualCazaTitanes.color = Color.red;
        cantidadCazaTitanes.text = contCazaTitanes.ToString();

        //Piojo Ca��n
        costeActualPCanon.text = costePCanon.ToString();
        costeActualPCanon.color = Color.red;
        cantidadPCanon.text = contPCanon.ToString();

        //Piojo Man
        costeActualPMan.text = costePMan.ToString();
        costeActualPMan.color = Color.red;
        cantidadPiojoMan.text = contPiojoMan.ToString();

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

        //Manos M�gicas
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

        //Piojo Ca��n
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

    //Bot�n Piojo
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

    //Bot�n Enemigos
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
    public void a�adeEnfermera()
    {
        if (getPiojos() >= costeEnfermera)
        {
            contEnfermeras++;
            cantidadEnfermera.text = contEnfermeras.ToString();
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
    public void a�adePiojoMadre()
    {
        if (getPiojos() >= costePMadre)
        {
            contPiojoMadre++;
            cantidadPmadre.text = contPiojoMadre.ToString();
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
    public void a�adeEscuela()
    {
        if (getPiojos() >= costeEscuela)
        {
            contEscuela++;
            cantidadEscuela.text = contEscuela.ToString();
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
    public void a�adeHotel()
    {
        if (getPiojos() >= costeHostal)
        {
            contHostal++;
            cantidadHostal.text = contHostal.ToString();
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

    //Manos M�gicas
    public void a�adeManosMagicas()
    {
        if (getPiojos() >= costeManos)
        {
            contManosMagicas++;
            cantidadManosM.text = contManosMagicas.ToString();
            numPiojos = getPiojos();
            numPiojos -= costeManos;
            setPiojos(numPiojos);
            contador.text = numPiojos.ToString();
            costeManos = Mathf.RoundToInt(costeManos * 1.2f);
            costeActualManosM.text = costeManos.ToString();
        }
    }

    //Jetpack
    public void a�adeJetpack()
    {
        if (getPiojos() >= costeJetpack)
        {
            contJetpack++;
            cantidadJetpack.text = contJetpack.ToString();
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
    public void a�adePiojoMazao()
    {
        if (getPiojos() >= costePMazao)
        {
            contPiojoMazao++;
            cantidadPiojoMazao.text = contPiojoMazao.ToString();
            numPiojos = getPiojos();
            numPiojos -= costePMazao;
            setPiojos(numPiojos);
            contador.text = numPiojos.ToString();
            costePMazao = Mathf.RoundToInt(costePMazao * 1.2f);
            costeActualPMazao.text = costePMazao.ToString();
        }
    }

    //Caza Titanes
    public void a�adeCazaTitanes()
    {
        if (getPiojos() >= costeCTitanes)
        {
            contCazaTitanes++;
            cantidadCazaTitanes.text = contCazaTitanes.ToString();
            numPiojos = getPiojos();
            numPiojos -= costeCTitanes;
            setPiojos(numPiojos);
            contador.text = numPiojos.ToString();
            costeCTitanes = Mathf.RoundToInt(costeCTitanes * 1.2f);
            costeActualCazaTitanes.text = costeCTitanes.ToString();
        }
    }

    //Piojo Ca��n
    public void a�adePiojoCanon()
    {
        if (getPiojos() >= costePCanon)
        {
            contPCanon++;
            cantidadPCanon.text = contPCanon.ToString();
            numPiojos = getPiojos();
            numPiojos -= costePCanon;
            setPiojos(numPiojos);
            contador.text = numPiojos.ToString();
            costePCanon = Mathf.RoundToInt(costePCanon * 1.2f);
            costeActualPCanon.text = costePCanon.ToString();
        }
    }

    //Piojo Man
    public void a�adePiojoMan()
    {
        if (getPiojos() >= costePMan)
        {
            contPiojoMan++;
            cantidadPiojoMan.text = contPiojoMan.ToString();
            numPiojos = getPiojos();
            numPiojos -= costePMan;
            setPiojos(numPiojos);
            contador.text = numPiojos.ToString();
            costePMan = Mathf.RoundToInt(costePMan * 1.2f);
            costeActualPMan.text = costePMan.ToString();
        }
    }


}
