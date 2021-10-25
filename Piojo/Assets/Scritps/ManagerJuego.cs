using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManagerJuego : MonoBehaviour
{
    //Contador Principal
    public Text contador;

    //Botón Piojos
    public int numPiojos = 0;

    //Botón Enemigos
    public LifeBar barraVida;
    public Text vidaEnemigo;
    public List<Enemigo> listaEnemigos;
    public Text nombreEnemigo;

    //Piojo Madre
    public Text costeActualPMadre;
    private int costePMadre = 200;
    public Text cantidadPmadre;
    private int contPiojoMadre = 0;

    //Cabeza Niño
    public Text costeActualCabezaN;
    private int costeCabezaN = 1500;
    public Text cantidadCabezaN;
    private int contCabezaN = 0;

    //Clase Infantil
    public Text costeActualClaseInfantil;
    private int costeClaseInfantil = 11000;
    public Text cantidadClaseInfantil;
    private int contClaseInfantil = 0;

    //Patio Escuela
    public Text costeActualPatioEscuela;
    private int costePatioEscuela = 80000;
    public Text cantidadPatioEscuela;
    private int contPatioEscuela = 0;

    //Escuela
    public Text costeActualEscuela;
    private int costeEscuela = 600000;
    public Text cantidadEscuela;
    private int contEscuela = 0;

    //Cabalgadores de Perros
    public Text costeActualCPerros;
    private int costeCPerros = 4500000;
    public Text cantidadCPerros;
    private int contCPerros = 0;

    //Hostal
    public Text costeActualHostal;
    private int costeHostal = 34000000;
    public Text cantidadHostal;
    private int contHostal = 0;

    //Jetpack
    public Text costeActualJetPack;
    private int costeJetpack = 250000000;
    public Text cantidadJetpack;
    private int contJetpack = 0;

    //Piojo Mazao
    public Text costeActualPMazao;
    private int costePMazao = 1000;
    public Text cantidadPiojoMazao;
    private int contPiojoMazao = 0;

    //Caza Titanes
    public Text costeActualCazaTitanes;
    private int costeCTitanes = 6500;
    public Text cantidadCazaTitanes;
    private int contCazaTitanes = 0;

    //Piojo Cañón
    public Text costeActualPCanon;
    private int costePCanon = 50000;
    public Text cantidadPCanon;
    private int contPCanon = 0;

    //Piojo Man
    public Text costeActualPMan;
    private int costePMan = 500000;
    public Text cantidadPiojoMan;
    private int contPiojoMan = 0;

    //Jefe de Equipo
    public Text costeActualJefe;
    private int costeJefe = 5000;
    public Text cantidadJefe;
    private int contJefe = 0;

    //Líder Motivador
    public Text costeActualLiderM;
    private int costeLiderM = 35000;
    public Text cantidadLiderM;
    private int contLiderM = 0;

    //Piojo Estratega
    public Text costeActualPEstratega;
    private int costePEstratega = 250000;
    public Text cantidadPEstratega;
    private int contPEstratega = 0;

    //Piojo Kasparov
    public Text costeActualPKasparov;
    private int costePKasparov = 3000000;
    public Text cantidadPKasparov;
    private int contPKasparov = 0;

    //Tienda
    public GameObject tienda;

    //Mejora 1
    public Text costeMejora1;
    public Text cantMejora1;
    private int cantidadMejora1 = 0;



    // Start is called before the first frame update
    void Start()
    {
        //Botón Enemigo
        listaEnemigos = new List<Enemigo>();
        inicializarEnemigos();
        nombreEnemigo.text = listaEnemigos[0].tipo.ToString();

        //Piojo Madre
        costeActualPMadre.text = costePMadre.ToString();
        costeActualPMadre.color = Color.red;
        cantidadPmadre.text = "x" + contPiojoMadre.ToString();

        //Cabeza Niño
        costeActualCabezaN.text = costeCabezaN.ToString();
        costeActualCabezaN.color = Color.red;
        cantidadCabezaN.text = "x" + contCabezaN.ToString();

        //Clase Infantil
        costeActualClaseInfantil.text = costeClaseInfantil.ToString();
        costeActualClaseInfantil.color = Color.red;
        cantidadClaseInfantil.text = "x" + contClaseInfantil.ToString();

        //Patio Escuela
        costeActualPatioEscuela.text = costePatioEscuela.ToString();
        costeActualPatioEscuela.color = Color.red;
        cantidadPatioEscuela.text = "x" + contPatioEscuela.ToString();

        //Escuela
        costeActualEscuela.text = costeEscuela.ToString();
        costeActualEscuela.color = Color.red;
        cantidadEscuela.text = "x" + contEscuela.ToString();

        //Cabalgadores de Perros
        costeActualCPerros.text = costeCPerros.ToString();
        costeActualCPerros.color = Color.red;
        cantidadCPerros.text = "x" + contCPerros.ToString();

        //Hostal
        costeActualHostal.text = costeHostal.ToString();
        costeActualHostal.color = Color.red;
        cantidadHostal.text = "x" + contHostal.ToString();

        //Jetpack
        costeActualJetPack.text = costeJetpack.ToString();
        costeActualJetPack.color = Color.red;
        cantidadJetpack.text = "x" + contJetpack.ToString();

        //Piojo Mazao
        costeActualPMazao.text = costePMazao.ToString();
        costeActualPMazao.color = Color.red;
        cantidadPiojoMazao.text = "x" + contPiojoMazao.ToString();

        //Caza Titanes
        costeActualCazaTitanes.text = costeCTitanes.ToString();
        costeActualCazaTitanes.color = Color.red;
        cantidadCazaTitanes.text = "x" + contCazaTitanes.ToString();

        //Piojo Cañón
        costeActualPCanon.text = costePCanon.ToString();
        costeActualPCanon.color = Color.red;
        cantidadPCanon.text = "x" + contPCanon.ToString();

        //Piojo Man
        costeActualPMan.text = costePMan.ToString();
        costeActualPMan.color = Color.red;
        cantidadPiojoMan.text = "x" + contPiojoMan.ToString();



        //Jefe Equipo
        costeActualJefe.text = costeJefe.ToString();
        costeActualJefe.color = Color.red;
        cantidadJefe.text = "x" + contJefe.ToString();

        //Líder Motivador
        costeActualLiderM.text = costeLiderM.ToString();
        costeActualLiderM.color = Color.red;
        cantidadLiderM.text = "x" + contLiderM.ToString();

        //Piojo Estratega
        costeActualPEstratega.text = costePEstratega.ToString();
        costeActualPEstratega.color = Color.red;
        cantidadPEstratega.text = "x" + contPEstratega.ToString();

        //Piojo Kasparov
        costeActualPKasparov.text = costePKasparov.ToString();
        costeActualPKasparov.color = Color.red;
        cantidadPKasparov.text = "x" + contPKasparov.ToString();

    }

    // Update is called once per frame
    void Update()
    {
        //Piojo Madre
        if (getPiojos() >= costePMadre)
            costeActualPMadre.color = Color.green;
        else
            costeActualPMadre.color = Color.red;

        //Cabeza Niño && listaEnemigos[0].tipo != tipoEnemigo.Pulga
        if (getPiojos() >= costeCabezaN)
            costeActualCabezaN.color = Color.green;
        else
            costeActualCabezaN.color = Color.red;

        //Clase Infantil
        if (getPiojos() >= costeClaseInfantil)
            costeActualClaseInfantil.color = Color.green;
        else
            costeActualClaseInfantil.color = Color.red;

        //Patio Escuela
        if (getPiojos() >= costePatioEscuela)
            costeActualPatioEscuela.color = Color.green;
        else
            costeActualPatioEscuela.color = Color.red;

        //Escuela
        if (getPiojos() >= costeEscuela)
            costeActualEscuela.color = Color.green;
        else
            costeActualEscuela.color = Color.red;

        //Cabalgadores de Perros
        if (getPiojos() >= costeCPerros)
            costeActualCPerros.color = Color.green;
        else
            costeActualCPerros.color = Color.red;

        //Hostal
        if (getPiojos() >= costeHostal)
            costeActualHostal.color = Color.green;
        else
            costeActualHostal.color = Color.red;

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

        //Jefe Equipo
        if (getPiojos() >= costeJefe)
            costeActualJefe.color = Color.green;
        else
            costeActualJefe.color = Color.red;

        //Lider Motivador
        if (getPiojos() >= costeLiderM)
            costeActualLiderM.color = Color.green;
        else
            costeActualLiderM.color = Color.red;

        //Piojo Estratega
        if (getPiojos() >= costePEstratega)
            costeActualPEstratega.color = Color.green;
        else
            costeActualPEstratega.color = Color.red;

        //Piojo Kasparov
        if (getPiojos() >= costePKasparov)
            costeActualPKasparov.color = Color.green;
        else
            costeActualPKasparov.color = Color.red;
    }

    //Botón Piojo
    public int getPiojos() { return numPiojos; }
    public void setPiojos(int newP) { numPiojos = newP; }
    public void GeneradorPiojos()
    {
        numPiojos++;
        contador.text = numPiojos.ToString();
        /*
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
        */
    }

    //Mejoras de Combate
    private int checkMejoras()
    {
        int cont1 = contPiojoMan, cont2 = contPCanon, cont3 = contCazaTitanes, cont4 = contPiojoMazao;
        Dictionary<string, int> dic = new Dictionary<string, int>();
        int aux = getPiojos();

        while (dic.Count != 4)
        {
            dic.Clear();
            if (cont1 == 0 || aux / (cont1 * 1000) >= 1)
            {
                dic.Add("PiojoMan", cont1);
            }
            else if (cont1 != 0)
                cont1--;

            if (cont2 == 0 || aux / (cont2 * 100) >= 1)
            {
                dic.Add("PiojoCanon", cont2);
            }
            else if (cont2 != 0)
                cont2--;

            if (cont3 == 0 || aux / (cont3 * 50) >= 1)
            {
                dic.Add("CazaTitanes", cont3);
            }
            else if (cont3 != 0)
                cont3--;

            if (cont4 == 0 || aux / (cont4 * 10) >= 1)
            {
                dic.Add("PiojoMazao", cont4);
            }
            else if (cont4 != 0)
                cont4--;
        }
        return Mathf.Max(dic["PiojoMan"] * 20, dic["PiojoCanon"] * 15, dic["CazaTitanes"] * 10, dic["PiojoMazao"] * 5);
    }

    //Botón Enemigos
    public void DestructorPiojos()
    {

        numPiojos = getPiojos();
        if (numPiojos > 0)
        {
            int aux = checkMejoras();
            if (aux == 0 || aux > numPiojos)
            {
                numPiojos--;
                setPiojos(numPiojos);
                contador.text = numPiojos.ToString();
                listaEnemigos[0].SetVidaActual(listaEnemigos[0].GetVidaActual() - 1);
                barraVida.setVida(listaEnemigos[0].GetVidaActual());
                vidaEnemigo.text = listaEnemigos[0].GetVidaActual().ToString() + "/" + listaEnemigos[0].GetVidaMax().ToString();
                if (listaEnemigos[0].GetVidaActual() <= 0)
                {
                    listaEnemigos.RemoveAt(0);
                    nombreEnemigo.text = listaEnemigos[0].tipo.ToString();
                    barraVida.setVidaMaxima(listaEnemigos[0].GetVidaMax());
                    barraVida.setVida(listaEnemigos[0].GetVidaActual());
                    vidaEnemigo.text = listaEnemigos[0].GetVidaActual().ToString() + "/" + listaEnemigos[0].GetVidaMax().ToString();
                }

            }
            else
            {
                numPiojos = numPiojos - aux;
                setPiojos(numPiojos);
                contador.text = numPiojos.ToString();
                listaEnemigos[0].SetVidaActual(listaEnemigos[0].GetVidaActual() - contPiojoMazao * 5);
                barraVida.setVida(listaEnemigos[0].GetVidaActual());
                vidaEnemigo.text = listaEnemigos[0].GetVidaActual().ToString() + "/" + listaEnemigos[0].GetVidaMax().ToString();
                if (listaEnemigos[0].GetVidaActual() <= 0)
                {
                    listaEnemigos.RemoveAt(0);
                    nombreEnemigo.text = listaEnemigos[0].tipo.ToString();
                    barraVida.setVidaMaxima(listaEnemigos[0].GetVidaMax());
                    barraVida.setVida(listaEnemigos[0].GetVidaActual());
                    vidaEnemigo.text = listaEnemigos[0].GetVidaActual().ToString() + "/" + listaEnemigos[0].GetVidaMax().ToString();
                }

            }

        }
    }

    //Piojo Madre
    public void añadePiojoMadre()
    {
        if (getPiojos() >= costePMadre)
        {
            contPiojoMadre++;
            cantidadPmadre.text = "x" + contPiojoMadre.ToString();
            numPiojos = getPiojos();
            numPiojos -= costePMadre;
            setPiojos(numPiojos);
            contador.text = numPiojos.ToString();
            costePMadre = Mathf.RoundToInt(costePMadre * 1.5f);
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

    //Cabeza Niño
    public void añadeCabezaN()
    {
        if (getPiojos() >= costeCabezaN)
        {
            contCabezaN++;
            cantidadCabezaN.text = "x" + contCabezaN.ToString();
            numPiojos = getPiojos();
            numPiojos -= costeCabezaN;
            setPiojos(numPiojos);
            contador.text = numPiojos.ToString();
            costeCabezaN = Mathf.RoundToInt(costeCabezaN * 1.5f);
            costeActualCabezaN.text = costeCabezaN.ToString();
            StartCoroutine(Gen5Piojos());
        }
    }
    IEnumerator Gen5Piojos()
    {
        while (true)
        {
            numPiojos = getPiojos();
            numPiojos = numPiojos + (contCabezaN * 5);
            setPiojos(numPiojos);
            contador.text = numPiojos.ToString();
            yield return new WaitForSeconds(1);
        }

    }

    //Clase Infantil
    public void añadeClaseInfantil()
    {
        if (getPiojos() >= costeClaseInfantil)
        {
            contClaseInfantil++;
            cantidadClaseInfantil.text = "x" + contClaseInfantil.ToString();
            numPiojos = getPiojos();
            numPiojos -= costeClaseInfantil;
            setPiojos(numPiojos);
            contador.text = numPiojos.ToString();
            costeClaseInfantil = Mathf.RoundToInt(costeClaseInfantil * 1.5f);
            costeActualClaseInfantil.text = costeClaseInfantil.ToString();
            StartCoroutine(Gen10Piojos());
        }
    }
    IEnumerator Gen10Piojos()
    {
        while (true)
        {
            numPiojos = getPiojos();
            numPiojos = numPiojos + (contClaseInfantil * 10);
            setPiojos(numPiojos);
            contador.text = numPiojos.ToString();
            yield return new WaitForSeconds(1);
        }

    }

    //Patio Escuela
    public void añadePatioEscuela()
    {
        if (getPiojos() >= costePatioEscuela)
        {
            contPatioEscuela++;
            cantidadPatioEscuela.text = "x" + contPatioEscuela.ToString();
            numPiojos = getPiojos();
            numPiojos -= costePatioEscuela;
            setPiojos(numPiojos);
            contador.text = numPiojos.ToString();
            costePatioEscuela = Mathf.RoundToInt(costePatioEscuela * 1.5f);
            costeActualPatioEscuela.text = costePatioEscuela.ToString();
            StartCoroutine(Gen20PiojoSeg());
        }
    }
    IEnumerator Gen20PiojoSeg()
    {
        while (true)
        {
            numPiojos = getPiojos();
            numPiojos = numPiojos + (contPatioEscuela * 20);
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
            cantidadEscuela.text = "x" + contEscuela.ToString();
            numPiojos = getPiojos();
            numPiojos -= costeEscuela;
            setPiojos(numPiojos);
            contador.text = numPiojos.ToString();
            costeEscuela = Mathf.RoundToInt(costeEscuela * 1.5f);
            costeActualEscuela.text = costeEscuela.ToString();
            StartCoroutine(Gen50PiojoSeg());
        }
    }
    IEnumerator Gen50PiojoSeg()
    {
        while (true)
        {
            numPiojos = getPiojos();
            numPiojos = numPiojos + (contEscuela * 50);
            setPiojos(numPiojos);
            contador.text = numPiojos.ToString();
            yield return new WaitForSeconds(1);
        }
    }

    //Cabalgadores de Perros
    public void añadeCPerros()
    {
        if (getPiojos() >= costeCPerros)
        {
            contCPerros++;
            cantidadCPerros.text = "x" + contCPerros.ToString();
            numPiojos = getPiojos();
            numPiojos -= costeCPerros;
            setPiojos(numPiojos);
            contador.text = numPiojos.ToString();
            costeCPerros = Mathf.RoundToInt(costeCPerros * 1.5f);
            costeActualCPerros.text = costeCPerros.ToString();
            StartCoroutine(Gen100PiojoSeg());
        }
    }
    IEnumerator Gen100PiojoSeg()
    {
        while (true)
        {
            numPiojos = getPiojos();
            numPiojos = numPiojos + (contCPerros * 100);
            setPiojos(numPiojos);
            contador.text = numPiojos.ToString();
            yield return new WaitForSeconds(1);
        }
    }

    //Hostal
    public void añadeHostal()
    {
        if (getPiojos() >= costeHostal)
        {
            contHostal++;
            cantidadHostal.text = "x" + contHostal.ToString();
            numPiojos = getPiojos();
            numPiojos -= costeHostal;
            setPiojos(numPiojos);
            contador.text = numPiojos.ToString();
            costeHostal = Mathf.RoundToInt(costeHostal * 1.5f);
            costeActualHostal.text = costeHostal.ToString();
            StartCoroutine(Gen500PiojoSeg());
        }
    }
    IEnumerator Gen500PiojoSeg()
    {
        while (true)
        {
            numPiojos = getPiojos();
            numPiojos = numPiojos + (contHostal * 500);
            setPiojos(numPiojos);
            contador.text = numPiojos.ToString();
            yield return new WaitForSeconds(1);
        }
    }

    //Jetpack
    public void añadeJetpack()
    {
        if (getPiojos() >= costeJetpack)
        {
            contJetpack++;
            cantidadJetpack.text = "x" + contJetpack.ToString();
            numPiojos = getPiojos();
            numPiojos -= costeJetpack;
            setPiojos(numPiojos);
            contador.text = numPiojos.ToString();
            costeJetpack = Mathf.RoundToInt(costeJetpack * 1.5f);
            costeActualJetPack.text = costeJetpack.ToString();
            StartCoroutine(Gen1000Piojos());
        }
    }
    IEnumerator Gen1000Piojos()
    {
        while (true)
        {
            numPiojos = getPiojos();
            numPiojos = numPiojos + (contJetpack * 1000);
            setPiojos(numPiojos);
            contador.text = numPiojos.ToString();
            yield return new WaitForSeconds(1);
        }

    }

    //Piojo Mazao
    public void añadePiojoMazao()
    {
        if (getPiojos() >= costePMazao)
        {
            contPiojoMazao++;
            cantidadPiojoMazao.text = "x" + contPiojoMazao.ToString();
            numPiojos = getPiojos();
            numPiojos -= costePMazao;
            setPiojos(numPiojos);
            contador.text = numPiojos.ToString();
            costePMazao = Mathf.RoundToInt(costePMazao * 1.5f);
            costeActualPMazao.text = costePMazao.ToString();
        }
    }

    //Caza Titanes
    public void añadeCazaTitanes()
    {
        if (getPiojos() >= costeCTitanes)
        {
            contCazaTitanes++;
            cantidadCazaTitanes.text = "x" + contCazaTitanes.ToString();
            numPiojos = getPiojos();
            numPiojos -= costeCTitanes;
            setPiojos(numPiojos);
            contador.text = numPiojos.ToString();
            costeCTitanes = Mathf.RoundToInt(costeCTitanes * 1.5f);
            costeActualCazaTitanes.text = costeCTitanes.ToString();
        }
    }

    //Piojo Cañón
    public void añadePiojoCanon()
    {
        if (getPiojos() >= costePCanon)
        {
            contPCanon++;
            cantidadPCanon.text = "x" + contPCanon.ToString();
            numPiojos = getPiojos();
            numPiojos -= costePCanon;
            setPiojos(numPiojos);
            contador.text = numPiojos.ToString();
            costePCanon = Mathf.RoundToInt(costePCanon * 1.5f);
            costeActualPCanon.text = costePCanon.ToString();
        }
    }

    //Piojo Man
    public void añadePiojoMan()
    {
        if (getPiojos() >= costePMan)
        {
            contPiojoMan++;
            cantidadPiojoMan.text = "x" + contPiojoMan.ToString();
            numPiojos = getPiojos();
            numPiojos -= costePMan;
            setPiojos(numPiojos);
            contador.text = numPiojos.ToString();
            costePMan = Mathf.RoundToInt(costePMan * 1.5f);
            costeActualPMan.text = costePMan.ToString();
        }
    }

    //Jefe de Equipo
    public void añadeJefe()
    {
        if (getPiojos() >= costeJefe)
        {
            contJefe++;
            cantidadJefe.text = "x" + contJefe.ToString();
            numPiojos = getPiojos();
            numPiojos -= costeJefe;
            setPiojos(numPiojos);
            contador.text = numPiojos.ToString();
            costeJefe = Mathf.RoundToInt(costeJefe * 1.5f);
            costeActualJefe.text = costeJefe.ToString();
        }
    }


    //Lider Motivador
    public void añadeLiderM()
    {
        if (getPiojos() >= costeLiderM)
        {
            contLiderM++;
            cantidadLiderM.text = "x" + contLiderM.ToString();
            numPiojos = getPiojos();
            numPiojos -= costeLiderM;
            setPiojos(numPiojos);
            contador.text = numPiojos.ToString();
            costeLiderM = Mathf.RoundToInt(costeLiderM * 1.5f);
            costeActualLiderM.text = costeLiderM.ToString();
        }
    }

    //Piojo Estratega
    public void añadePEstratega()
    {
        if (getPiojos() >= costePEstratega)
        {
            contPEstratega++;
            cantidadPEstratega.text = "x" + contPEstratega.ToString();
            numPiojos = getPiojos();
            numPiojos -= costePEstratega;
            setPiojos(numPiojos);
            contador.text = numPiojos.ToString();
            costePEstratega = Mathf.RoundToInt(costePEstratega * 1.5f);
            costeActualPEstratega.text = costePEstratega.ToString();
        }
    }

    //Piojo Kasparov
    public void añadePKasparov()
    {
        if (getPiojos() >= costePKasparov)
        {
            contPKasparov++;
            cantidadPKasparov.text = "x" + contPKasparov.ToString();
            numPiojos = getPiojos();
            numPiojos -= costePKasparov;
            setPiojos(numPiojos);
            contador.text = numPiojos.ToString();
            costePKasparov = Mathf.RoundToInt(costePKasparov * 1.5f);
            costeActualPKasparov.text = costePKasparov.ToString();
        }
    }






    //Enemigos
    private void inicializarEnemigos()
    {
        Enemigo e1 = new Enemigo(100, tipoEnemigo.Pulga);
        Enemigo e2 = new Enemigo(200, tipoEnemigo.Salamandra);
        Enemigo e3 = new Enemigo(500, tipoEnemigo.HumanoConRepelente);
        listaEnemigos.Add(e1);
        listaEnemigos.Add(e2);
        listaEnemigos.Add(e3);
        barraVida.setVidaMaxima(listaEnemigos[0].GetVidaMax());
        vidaEnemigo.text = listaEnemigos[0].GetVidaActual().ToString() + "/" + listaEnemigos[0].GetVidaMax().ToString();
    }

    //Tienda
    public void muestraTienda()
    {
        tienda.SetActive(true);
    }

    public void ocultaTienda()
    {
        tienda.SetActive(false);
    }


    //Mejora1
    public void añadeMejora1()
    {
        //Condición




        cantidadMejora1++;
        cantMejora1.text = "x" + cantidadMejora1.ToString();
    }


}
