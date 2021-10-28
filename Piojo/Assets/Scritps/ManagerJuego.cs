using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Newtonsoft.Json;
using System.Runtime.InteropServices;
using System.IO;
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
    private int costePMazao = 10;
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
    private int costeJefe = 10;
    public Text cantidadJefe;
    private int contJefe = 0;

    //Líder Motivador
    public Text costeActualLiderM;
    private int costeLiderM = 10;
    public Text cantidadLiderM;
    private int contLiderM = 0;

    //Piojo Estratega
    public Text costeActualPEstratega;
    private int costePEstratega = 10;
    public Text cantidadPEstratega;
    private int contPEstratega = 0;

    //Piojo Kasparov
    public Text costeActualPKasparov;
    private int costePKasparov = 10;
    public Text cantidadPKasparov;
    private int contPKasparov = 0;

    //Enfermera Piojo
    public Text costeActualEnfermera;
    private int costeEnfermera = 10;
    public Text cantidadEnfermera;
    private int contEnfermera = 0;

    //Piojo Bien Pagado
    public Text costeActualPPagado;
    private int costePPagado = 10;
    public Text cantidadPPagado;
    private int contPPagado = 0;

    //Piojo Cafeína
    public Text costeActualPCafeina;
    private int costePCafeina = 10;
    public Text cantidadPCafeina;
    private int contPCafeina = 0;

    //Piojo SpeedRunner
    public Text costeActualPSpeed;
    private int costePSpeed = 10;
    public Text cantidadPSpeed;
    private int contPSpeed = 0;

    //Piojos Mellizos 
    public Text costeActualPMellizos;
    private int costePMellizos = 10;
    public Text cantidadPMellizos;
    private int contPMellizos = 0;

    //Piojos Quintillizos 
    public Text costeActualPQuinti;
    private int costePQuinti = 10;
    public Text cantidadPQuinti;
    private int contPQuinti = 0;

    //Piojos Decallizos 
    public Text costeActualPDeca;
    private int costePDeca = 10;
    public Text cantidadPDeca;
    private int contPDeca = 0;

    //Piojos Hectallizos 
    public Text costeActualPHecta;
    private int costePHecta = 10;
    public Text cantidadPHecta;
    private int contPHecta = 0;

    //Mejoras
    public GameObject mejExpansion;
    public GameObject mejGeneracion;
    public GameObject mejCombate;
    public GameObject mejTemporal;

    //Tienda
    public GameObject tienda;

    //Mejora Pago
    public Text costeMejoraPago;
    public Text cantMejoraPago;
    private int cantidadMejorPago = 0;

    //ClonaPiojos
    public Text costeActualClonaP;
    private int costeClonaP = 10;
    private bool activeClonaP = false;

    //Multi Clic
    public Text costeActualMultiC;
    private int costeMultiC = 10;
    private bool activeMultiC = false;

    //Suma y Resta Piojos
    public Text sumaPiojos;
    public Text restaPiojos;



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

        //Enfermera Piojo
        costeActualEnfermera.text = costeEnfermera.ToString();
        costeActualEnfermera.color = Color.red;
        cantidadEnfermera.text = "x" + contEnfermera.ToString();

        //Piojo Bien Pagado
        costeActualPPagado.text = costePPagado.ToString();
        costeActualPPagado.color = Color.red;
        cantidadPPagado.text = "x" + contPPagado.ToString();

        //Piojo Cafeina
        costeActualPCafeina.text = costePCafeina.ToString();
        costeActualPCafeina.color = Color.red;
        cantidadPCafeina.text = "x" + contPCafeina.ToString();

        //Piojo Speedrunner
        costeActualPSpeed.text = costePSpeed.ToString();
        costeActualPSpeed.color = Color.red;
        cantidadPSpeed.text = "x" + contPSpeed.ToString();

        //Piojos Mellizos
        costeActualPMellizos.text = costePMellizos.ToString();
        costeActualPMellizos.color = Color.red;
        cantidadPMellizos.text = "x" + contPMellizos.ToString();

        //Piojo Quintillizos
        costeActualPQuinti.text = costePQuinti.ToString();
        costeActualPQuinti.color = Color.red;
        cantidadPQuinti.text = "x" + contPQuinti.ToString();

        //Piojo Decallizos
        costeActualPDeca.text = costePDeca.ToString();
        costeActualPDeca.color = Color.red;
        cantidadPDeca.text = "x" + contPDeca.ToString();

        //Piojo Hectallizos
        costeActualPHecta.text = costePHecta.ToString();
        costeActualPHecta.color = Color.red;
        cantidadPHecta.text = "x" + contPHecta.ToString();

        //Clona Piojos
        costeActualClonaP.text = costeClonaP.ToString();
        costeActualClonaP.color = Color.red;

        //Multi Clic
        costeActualMultiC.text = costeMultiC.ToString();
        costeActualMultiC.color = Color.red;

        //Suma y Resta Piojos
        sumaPiojos.text = "";
        restaPiojos.text = "";

        //Mejoras
        mejExpansion.SetActive(false);
        mejGeneracion.SetActive(false);
        mejCombate.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        //Piojo Madre
        if (getPiojos() >= costePMadre)
            costeActualPMadre.color = Color.green;
        else
            costeActualPMadre.color = Color.red;

        //Cabeza Niño 
        if (getPiojos() >= costeCabezaN)
            costeActualCabezaN.color = Color.green;
        else
            costeActualCabezaN.color = Color.red;

        //Clase Infantil
        if (getPiojos() >= costeClaseInfantil && listaEnemigos[0].tipo != tipoEnemigo.Pulga)
            costeActualClaseInfantil.color = Color.green;
        else
            costeActualClaseInfantil.color = Color.red;

        //Patio Escuela
        if (getPiojos() >= costePatioEscuela && listaEnemigos[0].tipo != tipoEnemigo.Pulga)
            costeActualPatioEscuela.color = Color.green;
        else
            costeActualPatioEscuela.color = Color.red;

        //Escuela
        if (getPiojos() >= costeEscuela && listaEnemigos.Count < 2)
            costeActualEscuela.color = Color.green;
        else
            costeActualEscuela.color = Color.red;

        //Cabalgadores de Perros
        if (getPiojos() >= costeCPerros && listaEnemigos.Count < 2)
            costeActualCPerros.color = Color.green;
        else
            costeActualCPerros.color = Color.red;

        //Hostal
        if (getPiojos() >= costeHostal && listaEnemigos.Count == 0)
            costeActualHostal.color = Color.green;
        else
            costeActualHostal.color = Color.red;

        //Jetpack
        if (getPiojos() >= costeJetpack && listaEnemigos.Count == 0)
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

        //Enfermera Piojo 
        if (getPiojos() >= costeEnfermera)
            costeActualEnfermera.color = Color.green;
        else
            costeActualEnfermera.color = Color.red;

        //Piojo Bien Pagado
        if (getPiojos() >= costePPagado)
            costeActualPPagado.color = Color.green;
        else
            costeActualPPagado.color = Color.red;

        //Piojo Cafeina
        if (getPiojos() >= costePCafeina)
            costeActualPCafeina.color = Color.green;
        else
            costeActualPCafeina.color = Color.red;

        //Piojo Speedrunner
        if (getPiojos() >= costePSpeed)
            costeActualPSpeed.color = Color.green;
        else
            costeActualPSpeed.color = Color.red;

        //Piojos Mellizos
        if (getPiojos() >= costePMellizos)
            costeActualPMellizos.color = Color.green;
        else
            costeActualPMellizos.color = Color.red;

        //Piojos Quintillizos
        if (getPiojos() >= costePQuinti)
            costeActualPQuinti.color = Color.green;
        else
            costeActualPQuinti.color = Color.red;

        //Piojos Decallizos
        if (getPiojos() >= costePDeca)
            costeActualPDeca.color = Color.green;
        else
            costeActualPDeca.color = Color.red;

        //Piojos Hectallizos
        if (getPiojos() >= costePHecta)
            costeActualPHecta.color = Color.green;
        else
            costeActualPHecta.color = Color.red;

        //Clona Piojos
        if (getPiojos() >= costeClonaP)
            costeActualClonaP.color = Color.green;
        else
            costeActualClonaP.color = Color.red;

        //Multi Clic
        if (getPiojos() >= costeMultiC)
            costeActualMultiC.color = Color.green;
        else
            costeActualMultiC.color = Color.red;
    }

    //Botón Piojo
    public int getPiojos() { return numPiojos; }
    public void setPiojos(int newP) { numPiojos = newP; }

    //Mejoras de Generacion
    private int checkGeneracion()
    {
        return contPMellizos * 2 + contPQuinti * 10 + contPDeca * 50 + contPHecta * 100;
    }

    public void GeneradorPiojos()
    {
        int aux = checkGeneracion();
        if (activeClonaP)
        {
            if (aux == 0)
            {
                numPiojos += 2;
                StartCoroutine(Sumador("+2"));
            }

            else
            {
                numPiojos += (2 * aux);
                StartCoroutine(Sumador("+" + (2 * aux).ToString()));
            }

        }
        else if (activeMultiC)
        {
            if (getPiojos() == 0)
            {
                numPiojos++;
                StartCoroutine(Sumador("+1"));
            }
            else if (aux == 0)
            {
                numPiojos *= 2;
                StartCoroutine(Sumador("+" + (numPiojos *= 2).ToString()));
            }
            else
            {
                numPiojos += (aux * 20);
                StartCoroutine(Sumador("+" + (aux * 20).ToString()));
            }
        }
        else
        {
            if (aux == 0)
            {
                numPiojos++;
                StartCoroutine(Sumador("+1"));
            }
            else
            {
                numPiojos += aux;
                StartCoroutine(Sumador("+" + aux.ToString()));
            }
        }
        contador.text = numPiojos.ToString();
    }

    //Mejoras de Combate
    private int checkMejoras()
    {

        return (contPiojoMan * 1000 + contPCanon * 100 + contCazaTitanes * 50 + contPiojoMazao * 10);
    }

    //Botón Enemigos
    public void DestructorPiojos()
    {
        numPiojos = getPiojos();
        if (numPiojos > 0)
        {
            int aux = checkMejoras();
            if (aux == 0)
            {
                numPiojos--;
                setPiojos(numPiojos);
                StartCoroutine(Restador("-1"));
                contador.text = numPiojos.ToString();
                listaEnemigos[0].SetVidaActual(listaEnemigos[0].GetVidaActual() - 1);
                codigoVida();
            }
            else
            {
                if ((numPiojos - aux) <= 0)
                {
                    StartCoroutine(Restador("-" + numPiojos.ToString()));
                    listaEnemigos[0].SetVidaActual(listaEnemigos[0].GetVidaActual() - numPiojos);
                    numPiojos = 0;
                    contador.text = numPiojos.ToString();
                    codigoVida();
                }
                else
                {
                    numPiojos = (numPiojos - aux);
                    setPiojos(numPiojos);
                    StartCoroutine(Restador("-" + aux.ToString()));
                    contador.text = numPiojos.ToString();
                    listaEnemigos[0].SetVidaActual(listaEnemigos[0].GetVidaActual() - aux);
                    codigoVida();
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
        if (getPiojos() >= costeClaseInfantil && listaEnemigos[0].tipo != tipoEnemigo.Pulga)
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
        if (getPiojos() >= costePatioEscuela && listaEnemigos[0].tipo != tipoEnemigo.Pulga)
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
            StartCoroutine(attack1s());
        }
    }
    IEnumerator attack1s()
    {
        while (true)
        {
            if (getPiojos() != 0)
            {
                numPiojos--;
                setPiojos(numPiojos);
                contador.text = numPiojos.ToString();
                listaEnemigos[0].SetVidaActual(listaEnemigos[0].GetVidaActual() - 1);
                codigoVida();
            }
            yield return new WaitForSeconds(1);
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
            StartCoroutine(attack10s());
        }
    }
    IEnumerator attack10s()
    {
        while (true)
        {
            if (getPiojos() >= 100) //Para que te deje maniobrar ahora
            {
                numPiojos -= 10;
                setPiojos(numPiojos);
                contador.text = numPiojos.ToString();
                listaEnemigos[0].SetVidaActual(listaEnemigos[0].GetVidaActual() - 10);
                codigoVida();
            }
            yield return new WaitForSeconds(1);
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
            StartCoroutine(attack50s());
        }
    }
    IEnumerator attack50s()
    {
        while (true)
        {
            if (getPiojos() >= 1000) //Para que te deje maniobrar ahora
            {
                numPiojos -= 50;
                setPiojos(numPiojos);
                contador.text = numPiojos.ToString();
                listaEnemigos[0].SetVidaActual(listaEnemigos[0].GetVidaActual() - 50);
                codigoVida();
            }
            yield return new WaitForSeconds(1);
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
            StartCoroutine(attack100s());
        }
    }
    IEnumerator attack100s()
    {
        while (true)
        {
            if (getPiojos() >= 1000) //Para que te deje maniobrar ahora
            {
                numPiojos -= 100;
                setPiojos(numPiojos);
                contador.text = numPiojos.ToString();
                listaEnemigos[0].SetVidaActual(listaEnemigos[0].GetVidaActual() - 100);
                codigoVida();
            }
            yield return new WaitForSeconds(1);
        }
    }

    //Enfermera Piojo 
    public void añadeEnfermera()
    {
        if (getPiojos() >= costeEnfermera)
        {
            contEnfermera++;
            cantidadEnfermera.text = "x" + contEnfermera.ToString();
            numPiojos = getPiojos();
            numPiojos -= costeEnfermera;
            setPiojos(numPiojos);
            contador.text = numPiojos.ToString();
            costeEnfermera = Mathf.RoundToInt(costeEnfermera * 1.5f);
            costeActualEnfermera.text = costeEnfermera.ToString();
            StartCoroutine(click20s());
        }
    }

    IEnumerator click20s()
    {
        yield return new WaitForSeconds(20);
        while (true)
        {
            GeneradorPiojos();
            yield return new WaitForSeconds(20);
        }
    }

    //Piojo Bien Pagado 
    public void añadePPagado()
    {
        if (getPiojos() >= costePPagado)
        {
            contPPagado++;
            cantidadPPagado.text = "x" + contPPagado.ToString();
            numPiojos = getPiojos();
            numPiojos -= costePPagado;
            setPiojos(numPiojos);
            contador.text = numPiojos.ToString();
            costePPagado = Mathf.RoundToInt(costePPagado * 1.5f);
            costeActualPPagado.text = costePPagado.ToString();
            StartCoroutine(click10s());
        }
    }

    IEnumerator click10s()
    {
        yield return new WaitForSeconds(10);
        while (true)
        {
            GeneradorPiojos();
            yield return new WaitForSeconds(10);
        }
    }

    //Piojo Cafeina
    public void añadePCafeina()
    {
        if (getPiojos() >= costePCafeina)
        {
            contPCafeina++;
            cantidadPCafeina.text = "x" + contPCafeina.ToString();
            numPiojos = getPiojos();
            numPiojos -= costePCafeina;
            setPiojos(numPiojos);
            contador.text = numPiojos.ToString();
            costePCafeina = Mathf.RoundToInt(costePCafeina * 1.5f);
            costeActualPCafeina.text = costePCafeina.ToString();
            StartCoroutine(click5s());
        }
    }

    IEnumerator click5s()
    {
        yield return new WaitForSeconds(5);
        while (true)
        {
            GeneradorPiojos();
            yield return new WaitForSeconds(5);
        }
    }

    //Piojo SpeedRunner 
    public void añadePSpeed()
    {
        if (getPiojos() >= costePSpeed)
        {
            contPSpeed++;
            cantidadPSpeed.text = "x" + contPSpeed.ToString();
            numPiojos = getPiojos();
            numPiojos -= costePSpeed;
            setPiojos(numPiojos);
            contador.text = numPiojos.ToString();
            costePSpeed = Mathf.RoundToInt(costePSpeed * 1.5f);
            costeActualPSpeed.text = costePSpeed.ToString();
            StartCoroutine(click2s());
        }
    }

    IEnumerator click2s()
    {
        yield return new WaitForSeconds(2);
        while (true)
        {
            GeneradorPiojos();
            yield return new WaitForSeconds(2);
        }
    }

    //Piojos Mellizos 
    public void añadePMellizos()
    {
        if (getPiojos() >= costePMellizos)
        {
            contPMellizos++;
            cantidadPMellizos.text = "x" + contPMellizos.ToString();
            numPiojos = getPiojos();
            numPiojos -= costePMellizos;
            setPiojos(numPiojos);
            contador.text = numPiojos.ToString();
            costePMellizos = Mathf.RoundToInt(costePMellizos * 1.5f);
            costeActualPMellizos.text = costePMellizos.ToString();
        }
    }

    //Piojos Quintillizos 
    public void añadePQuinti()
    {
        if (getPiojos() >= costePQuinti)
        {
            contPQuinti++;
            cantidadPQuinti.text = "x" + contPQuinti.ToString();
            numPiojos = getPiojos();
            numPiojos -= costePQuinti;
            setPiojos(numPiojos);
            contador.text = numPiojos.ToString();
            costePQuinti = Mathf.RoundToInt(costePQuinti * 1.5f);
            costeActualPQuinti.text = costePQuinti.ToString();
        }
    }

    //Piojos Decallizos 
    public void añadePDeca()
    {
        if (getPiojos() >= costePDeca)
        {
            contPDeca++;
            cantidadPDeca.text = "x" + contPDeca.ToString();
            numPiojos = getPiojos();
            numPiojos -= costePDeca;
            setPiojos(numPiojos);
            contador.text = numPiojos.ToString();
            costePDeca = Mathf.RoundToInt(costePDeca * 1.5f);
            costeActualPDeca.text = costePDeca.ToString();
        }
    }

    //Piojos Hectallizos 
    public void añadePHecta()
    {
        if (getPiojos() >= costePHecta)
        {
            contPHecta++;
            cantidadPHecta.text = "x" + contPHecta.ToString();
            numPiojos = getPiojos();
            numPiojos -= costePHecta;
            setPiojos(numPiojos);
            contador.text = numPiojos.ToString();
            costePHecta = Mathf.RoundToInt(costePHecta * 1.5f);
            costeActualPHecta.text = costePHecta.ToString();
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
        if (tienda.active == false)
            tienda.SetActive(true);
        else
            tienda.SetActive(false);
    }

    //Mejoras
    public void muestraExpansion()
    {
        if (mejExpansion.active == false)
        {
            mejExpansion.SetActive(true);
            mejGeneracion.SetActive(false);
            mejCombate.SetActive(false);
        }
        else
            mejExpansion.SetActive(false);
    }

    public void muestraGeneracion()
    {
        if (mejGeneracion.active == false)
        {
            mejExpansion.SetActive(false);
            mejGeneracion.SetActive(true);
            mejCombate.SetActive(false);
        }
        else
            mejGeneracion.SetActive(false);
    }

    public void muestraCombate()
    {
        if (mejCombate.active == false)
        {
            mejExpansion.SetActive(false);
            mejGeneracion.SetActive(false);
            mejCombate.SetActive(true);
        }
        else
            mejCombate.SetActive(false);
    }

    //Mejora Pago
    public void añadeMejoraPago()
    {
        cantidadMejorPago++;
        cantMejoraPago.text = "x" + cantidadMejorPago.ToString();
    }

    //Clona Piojo
    public void añadeClonaP()
    {
        if (getPiojos() >= costeClonaP)
        {
            numPiojos = getPiojos();
            numPiojos -= costeClonaP;
            setPiojos(numPiojos);
            contador.text = numPiojos.ToString();
            StartCoroutine(active30s());
        }
    }

    IEnumerator active30s()
    {
        activeClonaP = true;
        yield return new WaitForSeconds(30);
        activeClonaP = false;
        StopCoroutine(active30s());
    }

    //Clona Piojo
    public void añadeMultiC()
    {
        if (getPiojos() >= costeMultiC)
        {
            numPiojos = getPiojos();
            numPiojos -= costeMultiC;
            setPiojos(numPiojos);
            contador.text = numPiojos.ToString();
            StartCoroutine(clicx2());
        }
    }

    IEnumerator clicx2()
    {
        activeMultiC = true;
        yield return new WaitForSeconds(5);
        activeMultiC = false;
        StopCoroutine(clicx2());
    }

    //Sumador y Restador
    IEnumerator Sumador(string s)
    {
        sumaPiojos.text = s;
        yield return new WaitForSeconds(1);
        sumaPiojos.text = "";
        StopCoroutine(Sumador(s));
    }

    IEnumerator Restador(string s)
    {
        restaPiojos.text = s;
        yield return new WaitForSeconds(1);
        restaPiojos.text = "";
        StopCoroutine(Restador(s));
    }

    private void codigoVida()
    {
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

    //SALVADO DE PARTIDA
    public void guardarPartida()
    {
        Partida p = new Partida();
        p.numPiojos = this.numPiojos;
        p.listaEnemigos = this.listaEnemigos;
        p.costePMadre = this.costePMadre;
        p.contPiojoMadre = this.contPiojoMadre;
        p.costeCabezaN = this.costeCabezaN;
        p.contCabezaN = this.contCabezaN;
        p.costeClaseInfantil = this.costeClaseInfantil;
        p.contClaseInfantil = this.contClaseInfantil;
        p.costePatioEscuela = this.costePatioEscuela;
        p.contPatioEscuela = this.contPatioEscuela;
        p.costeEscuela = this.costeEscuela;
        p.contEscuela = this.contEscuela;
        p.costeCPerros = this.costeCPerros;
        p.contCPerros = this.contCPerros;
        p.costeHostal = this.costeHostal;
        p.contHostal = this.contHostal;
        p.costeJetpack = this.costeJetpack;
        p.contJetpack = this.contJetpack;

        p.costePMazao = this.costePMazao;
        p.contPiojoMazao = this.contPiojoMazao;
        p.costeCTitanes = this.costeCTitanes;
        p.contCazaTitanes = this.contCazaTitanes;
        p.costePCanon = this.costePCanon;
        p.contPCanon = this.contPCanon;
        p.costePMan = this.costePMan;
        p.contPiojoMan = this.contPiojoMan;
        p.costeJefe = this.costeJefe;
        p.contJefe = this.contJefe;
        p.costeLiderM = this.costeLiderM;
        p.contLiderM = this.contLiderM;
        p.costePEstratega = this.costePEstratega;
        p.contPEstratega = this.contPEstratega;
        p.costePKasparov = this.costePKasparov;
        p.contPKasparov = this.contPKasparov;
        p.costeEnfermera = this.costeEnfermera;
        p.contEnfermera = this.contEnfermera;
        p.costePPagado = this.costePPagado;
        p.contPPagado = this.contPPagado;
        p.costePCafeina = this.costePCafeina;
        p.contPCafeina = this.contPCafeina;
        p.costePSpeed = this.costePSpeed;
        p.contPSpeed = this.contPSpeed;
        p.costePMellizos = this.costePMellizos;
        p.contPMellizos = this.contPMellizos;
        p.costePQuinti = this.costePQuinti;
        p.contPQuinti = this.contPQuinti;
        p.costePDeca = this.costePDeca;
        p.contPDeca = this.contPDeca;
        p.costePHecta = this.costePHecta;
        p.contPHecta = this.contPHecta;
        p.costeClonaP = this.costeClonaP;
        p.activeClonaP = this.activeClonaP;
        p.costeMultiC = this.costeMultiC;
        p.activeMultiC = this.activeMultiC;
        //try
        //{
        string jsonString = JsonConvert.SerializeObject(p, Formatting.Indented);

        GuardarDatos(jsonString);
        //    //StreamWriter s = new StreamWriter(Application.persistentDataPath + "/data.json");
        //    //s.Write(jsonString);
        //    //s.Close();
        //}
        //catch (IOException e)
        //{

        //}


    }
    [DllImport("__Internal")]
    private static extern void GuardarDatos(string d);
}