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

    //Piojo Madre
    public Text costeActualPMadre;
    private int costePMadre = 10;
    public Text cantidadPmadre;
    private int contPiojoMadre = 0;

    //Cabeza Niño
    public Text costeActualCabezaN;
    private int costeCabezaN = 10;
    public Text cantidadCabezaN;
    private int contCabezaN = 0;

    //Clase Infantil
    public Text costeActualClaseInfantil;
    private int costeClaseInfantil = 10;
    public Text cantidadClaseInfantil;
    private int contClaseInfantil = 0;

    //Patio Escuela
    public Text costeActualPatioEscuela;
    private int costePatioEscuela = 10;
    public Text cantidadPatioEscuela;
    private int contPatioEscuela = 0;

    //Escuela
    public Text costeActualEscuela;
    private int costeEscuela = 10;
    public Text cantidadEscuela;
    private int contEscuela = 0;

    //Hostal
    public Text costeActualCPerros;
    private int costeCPerros = 10;
    public Text cantidadCPerros;
    private int contCPerros = 0;

    //Hostal
    public Text costeActualHostal;
    private int costeHostal = 20;
    public Text cantidadHostal;
    private int contHostal = 0;

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

    //Piojo Cañón
    public Text costeActualPCanon;
    private int costePCanon = 10;
    public Text cantidadPCanon;
    private int contPCanon = 0;

    //Piojo Man
    public Text costeActualPMan;
    private int costePMan = 10;
    public Text cantidadPiojoMan;
    private int contPiojoMan = 0;

    //Tienda
    public GameObject tienda;

    public Text costeMejora1;
    public Text cantMejora1;
    private int cantidadMejora1 = 0;



    // Start is called before the first frame update
    void Start()
    {
        //Botón Enemigo
        listaEnemigos = new List<Enemigo>();
        inicializarEnemigos();

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

    private (Dictionary<string, int>, int) checkMejoras()
    {
        Dictionary<string, int> dic = new Dictionary<string, int>();
        int aux = getPiojos();
        while (true)
        {
            if (contPiojoMan * 20 / aux >= 1)
            {
                dic.Add("PiojoMan", contPiojoMan);
                return (dic, 20);
            }
            else
                contPiojoMan--;
            if (contPiojoMan == 0 && contPCanon * 15 / aux >= 1)
            {
                dic.Add("PiojoCanon", contPCanon);
                return (dic, 15);
            }
            else
                contPCanon--;
            if (contPCanon == 0 && contCazaTitanes * 10 / aux >= 1)
            {
                dic.Add("CazaTitanes", contCazaTitanes);
                return (dic, 10);
            }
            else
                contCazaTitanes--;
            if (contCazaTitanes == 0 && contPiojoMazao * 5 / aux >= 1)
            {
                dic.Add("PiojoMazao", contPiojoMazao);
                return (dic, 5);
            }
            else
                contPiojoMazao--;
            if (contPiojoMazao == 0)
            {
                dic.Add("SinMejoras", 0);
                return (dic, 0);
            }
        }
    }


    //Botón Enemigos
    public void DestructorPiojos()
    {
        int aux, cont;
        Dictionary<string, int> dic;
        (dic, aux) = checkMejoras();
        numPiojos = getPiojos();
        if (numPiojos > 0)
        {
            if (dic.ContainsKey("SinMejoras"))
            {
                dic.Clear();
                numPiojos--;
                setPiojos(numPiojos);
                contador.text = numPiojos.ToString();
                listaEnemigos[0].SetVidaActual(listaEnemigos[0].GetVidaActual() - 1);
                barraVida.setVida(listaEnemigos[0].GetVidaActual());
                vidaEnemigo.text = listaEnemigos[0].GetVidaActual().ToString() + "/" + listaEnemigos[0].GetVidaMax().ToString();
                if (listaEnemigos[0].GetVidaActual() <= 0)
                {
                    listaEnemigos.RemoveAt(0);
                    barraVida.setVidaMaxima(listaEnemigos[0].GetVidaMax());
                    barraVida.setVida(listaEnemigos[0].GetVidaActual());
                    vidaEnemigo.text = listaEnemigos[0].GetVidaActual().ToString() + "/" + listaEnemigos[0].GetVidaMax().ToString();
                }

            }
            else
            {
                numPiojos = numPiojos - (contPiojoMazao * 5);
                setPiojos(numPiojos);
                contador.text = numPiojos.ToString();
                listaEnemigos[0].SetVidaActual(listaEnemigos[0].GetVidaActual() - contPiojoMazao * 5);
                barraVida.setVida(listaEnemigos[0].GetVidaActual());
                vidaEnemigo.text = listaEnemigos[0].GetVidaActual().ToString() + "/" + listaEnemigos[0].GetVidaMax().ToString();
                if (listaEnemigos[0].GetVidaActual() <= 0)
                {
                    listaEnemigos.RemoveAt(0);
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
            costeCabezaN = Mathf.RoundToInt(costeCabezaN * 1.2f);
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
            costeClaseInfantil = Mathf.RoundToInt(costeClaseInfantil * 1.2f);
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
            costePatioEscuela = Mathf.RoundToInt(costePatioEscuela * 1.2f);
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
            costeEscuela = Mathf.RoundToInt(costeEscuela * 1.2f);
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
            costeCPerros = Mathf.RoundToInt(costeCPerros * 1.2f);
            costeActualCPerros.text = costeCPerros.ToString();
            StartCoroutine(Gen75PiojoSeg());
        }
    }
    IEnumerator Gen75PiojoSeg()
    {
        while (true)
        {
            numPiojos = getPiojos();
            numPiojos = numPiojos + (contCPerros * 75);
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
            costeHostal = Mathf.RoundToInt(costeHostal * 1.2f);
            costeActualHostal.text = costeHostal.ToString();
            StartCoroutine(Gen100PiojoSeg());
        }
    }
    IEnumerator Gen100PiojoSeg()
    {
        while (true)
        {
            numPiojos = getPiojos();
            numPiojos = numPiojos + (contHostal * 100);
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
            costeJetpack = Mathf.RoundToInt(costeJetpack * 1.2f);
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
            cantidadCazaTitanes.text = "x" + contCazaTitanes.ToString();
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
            cantidadPCanon.text = "x" + contPCanon.ToString();
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
            cantidadPiojoMan.text = "x" + contPiojoMan.ToString();
            numPiojos = getPiojos();
            numPiojos -= costePMan;
            setPiojos(numPiojos);
            contador.text = numPiojos.ToString();
            costePMan = Mathf.RoundToInt(costePMan * 1.2f);
            costeActualPMan.text = costePMan.ToString();
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
