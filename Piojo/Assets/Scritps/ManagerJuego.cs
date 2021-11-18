using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Newtonsoft.Json;
using System.Runtime.InteropServices;
using System.IO;
public class ManagerJuego : MonoBehaviour
{
    private Animation tutorial;
    public Animator animator;
    public GameObject panel;
    public Button intro;

    private int mejoraActiva = 0;

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

    //Enfermera Piojo
    public Text costeActualEnfermera;
    private int costeEnfermera = 200;
    public Text cantidadEnfermera;
    private int contEnfermera = 0;

    //Piojo Bien Pagado
    public Text costeActualPPagado;
    private int costePPagado = 5000;
    public Text cantidadPPagado;
    private int contPPagado = 0;

    //Piojo Cafeína
    public Text costeActualPCafeina;
    private int costePCafeina = 85000;
    public Text cantidadPCafeina;
    private int contPCafeina = 0;

    //Piojo SpeedRunner
    public Text costeActualPSpeed;
    private int costePSpeed = 2000000;
    public Text cantidadPSpeed;
    private int contPSpeed = 0;

    //Piojos Mellizos 
    public Text costeActualPMellizos;
    private int costePMellizos = 20;
    public Text cantidadPMellizos;
    private int contPMellizos = 0;

    //Piojos Quintillizos 
    public Text costeActualPQuinti;
    private int costePQuinti = 500;
    public Text cantidadPQuinti;
    private int contPQuinti = 0;

    //Piojos Decallizos 
    public Text costeActualPDeca;
    private int costePDeca = 12000;
    public Text cantidadPDeca;
    private int contPDeca = 0;

    //Piojos Hectallizos 
    public Text costeActualPHecta;
    private int costePHecta = 450000;
    public Text cantidadPHecta;
    private int contPHecta = 0;

    //Mejoras
    public GameObject mejExpansion;
    public GameObject mejGeneracion;
    public GameObject mejCombate;
    public GameObject mejAntibarrera;
    public GameObject mejPago;

    //Tienda
    public GameObject tienda;

    //Casco
    public Text costeActualCasco;
    private int costeCasco = 5;
    public Text cantidadCasco;
    private int contCasco = 0;

    //Chaleco
    public Text costeActualChaleco;
    private int costeChaleco = 5;
    public Text cantidadChaleco;
    private int contChaleco = 0;

    //Máscara
    public Text costeActualMascara;
    private int costeMascara = 5;
    public Text cantidadMascara;
    private int contMascara = 0;

    //Pulsera
    public Text costeActualPulsera;
    private int costePulsera = 5;
    public Text cantidadPulsera;
    private int contPulsera = 0;

    //ClonaPiojos
    public Text costeActualClonaP;
    private int costeClonaP = 2;
    private bool activeClonaP = false;

    //Multi Clic
    public Text costeActualMultiC;
    private int costeMultiC = 5;
    private bool activeMultiC = false;

    //Suma y Resta Piojos
    public Text sumaPiojos;
    public Text restaPiojos;

    //Texto guardado
    public Text textoGuardado;

    //Contador de enemigos derrotados
    private int enemDerrotados = 0;

    //Candados bloqueados Expansion
    public Button MejExp3Candado;
    public Button MejExp4Candado;
    public Button MejExp5Candado;
    public Button MejExp6Candado;
    public Button MejExp7Candado;
    public Button MejExp8Candado;

    //Candados bloqueados Generacion
    public Button MejGen3Candado;
    public Button MejGen4Candado;
    public Button MejGen5Candado;
    public Button MejGen6Candado;
    public Button MejGen7Candado;
    public Button MejGen8Candado;

    //Candados bloqueados Combate
    public Button MejComb3Candado;
    public Button MejComb4Candado;
    public Button MejComb5Candado;
    public Button MejComb6Candado;
    public Button MejComb7Candado;
    public Button MejComb8Candado;

    //Bloqueos de los enemigos
    public Button casco;
    public Button chaleco;
    public Button mascara;
    public Button pulsera;

    //Botones de la interfaz
    public Button btnTienda;
    public Button btnAjustes;
    public Button btnGuardar;
    public Button btnCargar;
    public Button btnInfo;
    public Button btnSalir;

    //Partida cargada por primera vez
    private bool cargado = false;

    // Start is called before the first frame update
    void Start()
    {
        //Botón Enemigo
        listaEnemigos = new List<Enemigo>();
        inicializarEnemigos();
        nombreEnemigo.text = listaEnemigos[0].tipo.ToString();
        inicializarBarreras(listaEnemigos[0]);

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

        //Casco
        costeActualCasco.text = costeCasco.ToString();
        costeActualCasco.color = Color.red;
        cantidadCasco.text = "x" + contCasco.ToString();

        //Chaleco
        costeActualChaleco.text = costeChaleco.ToString();
        costeActualChaleco.color = Color.red;
        cantidadChaleco.text = "x" + contChaleco.ToString();

        //Mascara
        costeActualMascara.text = costeMascara.ToString();
        costeActualMascara.color = Color.red;
        cantidadMascara.text = "x" + contMascara.ToString();

        //Pulsera
        costeActualPulsera.text = costePulsera.ToString();
        costeActualPulsera.color = Color.red;
        cantidadPulsera.text = "x" + contPulsera.ToString();


        //Clona Piojos
        costeActualClonaP.text = costeClonaP.ToString() + "€";
        costeActualClonaP.color = Color.green;

        //Multi Clic
        costeActualMultiC.text = costeMultiC.ToString() + "€";
        costeActualMultiC.color = Color.green;

        //Suma y Resta Piojos
        sumaPiojos.text = "";
        restaPiojos.text = "";

        //Mejoras
        mejExpansion.SetActive(false);
        mejGeneracion.SetActive(false);
        mejCombate.SetActive(false);
        mejAntibarrera.SetActive(false);
        mejPago.SetActive(false);



        animator.Play("Tutorial");

    }

    private void inicializarBarreras(Enemigo enemigo)
    {
        switch (enemigo.barrier.ToString())
        {
            case "Casco":
                casco.gameObject.SetActive(true);
                break;
            case "Chaleco":
                chaleco.gameObject.SetActive(true);
                break;
            case "Mascara":
                mascara.gameObject.SetActive(true);
                break;
            case "Pulsera":
                pulsera.gameObject.SetActive(true);
                break;
            case "SinProtecciones":
                casco.gameObject.SetActive(false);
                chaleco.gameObject.SetActive(false);
                mascara.gameObject.SetActive(false);
                pulsera.gameObject.SetActive(false);
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (animator.GetCurrentAnimatorStateInfo(0).normalizedTime > 1)
        {
            intro.gameObject.SetActive(false);
            btnTienda.gameObject.SetActive(true);
            btnGuardar.gameObject.SetActive(true);
            btnCargar.gameObject.SetActive(true);
            btnAjustes.gameObject.SetActive(true);
            btnSalir.gameObject.SetActive(true);

            if (!cargado)
            {
                textoGuardado.gameObject.SetActive(true);
                cargarPartida();
                StartCoroutine(guardadoAutomatico());
                cargado = true;
            }
        }

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
        if (getPiojos() >= costeClaseInfantil && enemDerrotados > 0)
            costeActualClaseInfantil.color = Color.green;
        else
            costeActualClaseInfantil.color = Color.red;

        //Patio Escuela
        if (getPiojos() >= costePatioEscuela && enemDerrotados > 0)
            costeActualPatioEscuela.color = Color.green;
        else
            costeActualPatioEscuela.color = Color.red;

        //Escuela
        if (getPiojos() >= costeEscuela && enemDerrotados > 1)
            costeActualEscuela.color = Color.green;
        else
            costeActualEscuela.color = Color.red;

        //Cabalgadores de Perros
        if (getPiojos() >= costeCPerros && enemDerrotados > 1)
            costeActualCPerros.color = Color.green;
        else
            costeActualCPerros.color = Color.red;

        //Hostal
        if (getPiojos() >= costeHostal && enemDerrotados > 2)
            costeActualHostal.color = Color.green;
        else
            costeActualHostal.color = Color.red;

        //Jetpack
        if (getPiojos() >= costeJetpack && enemDerrotados > 2)
            costeActualJetPack.color = Color.green;
        else
            costeActualJetPack.color = Color.red;

        //Piojo Mazao
        if (getPiojos() >= costePMazao)
            costeActualPMazao.color = Color.green;
        else
            costeActualPMazao.color = Color.red;

        //Caza Titanes
        if (getPiojos() >= costeCTitanes && enemDerrotados > 0)
            costeActualCazaTitanes.color = Color.green;
        else
            costeActualCazaTitanes.color = Color.red;

        //Piojo Cañón
        if (getPiojos() >= costePCanon && enemDerrotados > 1)
            costeActualPCanon.color = Color.green;
        else
            costeActualPCanon.color = Color.red;

        //Piojo Man
        if (getPiojos() >= costePMan && enemDerrotados > 2)
            costeActualPMan.color = Color.green;
        else
            costeActualPMan.color = Color.red;

        //Jefe Equipo
        if (getPiojos() >= costeJefe)
            costeActualJefe.color = Color.green;
        else
            costeActualJefe.color = Color.red;

        //Lider Motivador
        if (getPiojos() >= costeLiderM && enemDerrotados > 0)
            costeActualLiderM.color = Color.green;
        else
            costeActualLiderM.color = Color.red;

        //Piojo Estratega
        if (getPiojos() >= costePEstratega && enemDerrotados > 1)
            costeActualPEstratega.color = Color.green;
        else
            costeActualPEstratega.color = Color.red;

        //Piojo Kasparov
        if (getPiojos() >= costePKasparov && enemDerrotados > 2)
            costeActualPKasparov.color = Color.green;
        else
            costeActualPKasparov.color = Color.red;

        //Enfermera Piojo 
        if (getPiojos() >= costeEnfermera)
            costeActualEnfermera.color = Color.green;
        else
            costeActualEnfermera.color = Color.red;

        //Piojo Bien Pagado
        if (getPiojos() >= costePPagado && enemDerrotados > 0)
            costeActualPPagado.color = Color.green;
        else
            costeActualPPagado.color = Color.red;

        //Piojo Cafeina
        if (getPiojos() >= costePCafeina && enemDerrotados > 1)
            costeActualPCafeina.color = Color.green;
        else
            costeActualPCafeina.color = Color.red;

        //Piojo Speedrunner
        if (getPiojos() >= costePSpeed && enemDerrotados > 2)
            costeActualPSpeed.color = Color.green;
        else
            costeActualPSpeed.color = Color.red;

        //Piojos Mellizos
        if (getPiojos() >= costePMellizos)
            costeActualPMellizos.color = Color.green;
        else
            costeActualPMellizos.color = Color.red;

        //Piojos Quintillizos
        if (getPiojos() >= costePQuinti && enemDerrotados > 0)
            costeActualPQuinti.color = Color.green;
        else
            costeActualPQuinti.color = Color.red;

        //Piojos Decallizos
        if (getPiojos() >= costePDeca && enemDerrotados > 1)
            costeActualPDeca.color = Color.green;
        else
            costeActualPDeca.color = Color.red;

        //Piojos Hectallizos
        if (getPiojos() >= costePHecta && enemDerrotados > 2)
            costeActualPHecta.color = Color.green;
        else
            costeActualPHecta.color = Color.red;

        //Casco
        if (getPiojos() >= costeCasco)
            costeActualCasco.color = Color.green;
        else
            costeActualCasco.color = Color.red;

        //Chaleco
        if (getPiojos() >= costeChaleco)
            costeActualChaleco.color = Color.green;
        else
            costeActualChaleco.color = Color.red;

        //Mascara
        if (getPiojos() >= costeMascara)
            costeActualMascara.color = Color.green;
        else
            costeActualMascara.color = Color.red;

        //Pulsera
        if (getPiojos() >= costePulsera)
            costeActualPulsera.color = Color.green;
        else
            costeActualPulsera.color = Color.red;


        if (enemDerrotados > 0)
        {
            MejExp3Candado.gameObject.SetActive(false);
            MejExp4Candado.gameObject.SetActive(false);
            MejGen3Candado.gameObject.SetActive(false);
            MejGen4Candado.gameObject.SetActive(false);
            MejComb3Candado.gameObject.SetActive(false);
            MejComb4Candado.gameObject.SetActive(false);
        }
        if (enemDerrotados > 1)
        {
            MejExp5Candado.gameObject.SetActive(false);
            MejExp6Candado.gameObject.SetActive(false);
            MejGen5Candado.gameObject.SetActive(false);
            MejGen6Candado.gameObject.SetActive(false);
            MejComb5Candado.gameObject.SetActive(false);
            MejComb6Candado.gameObject.SetActive(false);
        }
        if (enemDerrotados > 2)
        {
            MejExp7Candado.gameObject.SetActive(false);
            MejExp8Candado.gameObject.SetActive(false);
            MejGen7Candado.gameObject.SetActive(false);
            MejGen8Candado.gameObject.SetActive(false);
            MejComb7Candado.gameObject.SetActive(false);
            MejComb8Candado.gameObject.SetActive(false);
        }
    }

    //Botón Piojo
    public int getPiojos() { return numPiojos; }
    public void setPiojos(int newP) { numPiojos = newP; }

    //Mejoras de Generacion
    private int checkGeneracion()
    {
        return 1 + (contPMellizos * 2 + contPQuinti * 10 + contPDeca * 50 + contPHecta * 100);
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
        if (getPiojos() >= costeClaseInfantil && enemDerrotados > 0)
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
        if (getPiojos() >= costePatioEscuela && enemDerrotados > 0)
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
        if (getPiojos() >= costeEscuela && enemDerrotados > 1)
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
        if (getPiojos() >= costeCPerros && enemDerrotados > 1)
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
        if (getPiojos() >= costeHostal && enemDerrotados > 2)
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
        if (getPiojos() >= costeJetpack && enemDerrotados > 2)
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
        if (getPiojos() >= costeCTitanes && enemDerrotados > 0)
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
        if (getPiojos() >= costePCanon && enemDerrotados > 1)
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
        if (getPiojos() >= costePMan && enemDerrotados > 2)
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
        if (getPiojos() >= costeLiderM && enemDerrotados > 0)
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
        if (getPiojos() >= costePEstratega && enemDerrotados > 1)
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
        if (getPiojos() >= costePKasparov && enemDerrotados > 2)
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
        if (getPiojos() >= costePPagado && enemDerrotados > 0)
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
        if (getPiojos() >= costePCafeina && enemDerrotados > 1)
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
        if (getPiojos() >= costePSpeed && enemDerrotados > 2)
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
        if (getPiojos() >= costePQuinti && enemDerrotados > 0)
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
        if (getPiojos() >= costePDeca && enemDerrotados > 1)
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
        if (getPiojos() >= costePHecta && enemDerrotados > 2)
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
        Enemigo e1 = new Enemigo(5, tipoEnemigo.Pulga, barreras.SinProtecciones);
        Enemigo e2 = new Enemigo(5, tipoEnemigo.Salamandra, barreras.Casco);
        Enemigo e3 = new Enemigo(5, tipoEnemigo.HumanoConRepelente, barreras.Chaleco);
        listaEnemigos.Add(e1);
        listaEnemigos.Add(e2);
        listaEnemigos.Add(e3);
        barraVida.setVidaMaxima(listaEnemigos[0].GetVidaMax());
        vidaEnemigo.text = listaEnemigos[0].GetVidaActual().ToString() + "/" + listaEnemigos[0].GetVidaMax().ToString();
    }

    private void recuperaVida()
    {
        Random.InitState((int)Time.realtimeSinceStartup);
        int num = Random.Range(0, 10);
        if (listaEnemigos[0].GetVidaActual() <= listaEnemigos[0].GetVidaMax() / 2 && num > 8)
        {
            barraVida.setVidaMaxima(listaEnemigos[0].GetVidaMax());
            listaEnemigos[0].SetVidaActual(listaEnemigos[0].GetVidaMax());
            vidaEnemigo.text = listaEnemigos[0].GetVidaActual().ToString() + "/" + listaEnemigos[0].GetVidaMax().ToString();
        }
    }

    //Tienda
    public void muestraTienda()
    {
        if (tienda.active == false)
        {
            tienda.SetActive(true);
            btnInfo.gameObject.SetActive(true);
            switch (mejoraActiva)
            {
                case 0:
                    mejExpansion.SetActive(true);
                    break;
                case 1:
                    mejGeneracion.SetActive(true);
                    break;
                case 2:
                    mejCombate.SetActive(true);
                    break;
                case 3:
                    mejAntibarrera.SetActive(true);
                    break;
                case 4:
                    mejPago.SetActive(true);
                    break;
            }
        }
        else
        {
            tienda.SetActive(false);
            mejPago.SetActive(false);
            mejExpansion.SetActive(false);
            mejGeneracion.SetActive(false);
            mejCombate.SetActive(false);
            mejAntibarrera.SetActive(false);
            btnInfo.gameObject.SetActive(false);
        }
    }

    //Mejoras
    public void muestraPago()
    {
        if (mejPago.active == false)
        {
            mejoraActiva = 4;
            mejPago.SetActive(true);
            mejExpansion.SetActive(false);
            mejGeneracion.SetActive(false);
            mejCombate.SetActive(false);
            mejAntibarrera.SetActive(false);
        }
    }

    public void muestraExpansion()
    {
        if (mejExpansion.active == false)
        {
            mejoraActiva = 0;
            mejExpansion.SetActive(true);
            mejGeneracion.SetActive(false);
            mejCombate.SetActive(false);
            mejAntibarrera.SetActive(false);
            mejPago.SetActive(false);
        }
    }

    public void muestraGeneracion()
    {
        if (mejGeneracion.active == false)
        {
            mejoraActiva = 1;
            mejExpansion.SetActive(false);
            mejGeneracion.SetActive(true);
            mejCombate.SetActive(false);
            mejAntibarrera.SetActive(false);
            mejPago.SetActive(false);
        }
    }

    public void muestraCombate()
    {
        if (mejCombate.active == false)
        {
            mejoraActiva = 2;
            mejExpansion.SetActive(false);
            mejGeneracion.SetActive(false);
            mejAntibarrera.SetActive(false);
            mejCombate.SetActive(true);
            mejPago.SetActive(false);
        }
    }

    public void muestraAntibarrera()
    {
        if (mejAntibarrera.active == false)
        {
            mejoraActiva = 3;
            mejExpansion.SetActive(false);
            mejGeneracion.SetActive(false);
            mejCombate.SetActive(false);
            mejAntibarrera.SetActive(true);
            mejPago.SetActive(false);
        }
    }

    //Casco
    public void añadeCasco()
    {
        if (getPiojos() >= costeCasco)
        {
            casco.gameObject.SetActive(false);
            contCasco++;
            cantidadCasco.text = "x" + contCasco.ToString();
            numPiojos = getPiojos();
            numPiojos -= costeCasco;
            setPiojos(numPiojos);
            contador.text = numPiojos.ToString();
            costeCasco = Mathf.RoundToInt(costeCasco * 1.5f);
            costeActualCasco.text = costeCasco.ToString();
        }
    }

    //Chaleco
    public void añadeChaleco()
    {
        if (getPiojos() >= costeChaleco)
        {
            chaleco.gameObject.SetActive(false);
            contChaleco++;
            cantidadChaleco.text = "x" + contChaleco.ToString();
            numPiojos = getPiojos();
            numPiojos -= costeChaleco;
            setPiojos(numPiojos);
            contador.text = numPiojos.ToString();
            costeChaleco = Mathf.RoundToInt(costeChaleco * 1.5f);
            costeActualChaleco.text = costeChaleco.ToString();
        }
    }

    //Mascara
    public void añadeMascara()
    {
        if (getPiojos() >= costeMascara)
        {
            mascara.gameObject.SetActive(false);
            contMascara++;
            cantidadMascara.text = "x" + contMascara.ToString();
            numPiojos = getPiojos();
            numPiojos -= costeMascara;
            setPiojos(numPiojos);
            contador.text = numPiojos.ToString();
            costeMascara = Mathf.RoundToInt(costeMascara * 1.5f);
            costeActualMascara.text = costeMascara.ToString();
        }
    }

    //Pulsera
    public void añadePulsera()
    {
        if (getPiojos() >= costePulsera)
        {
            pulsera.gameObject.SetActive(false);
            contPulsera++;
            cantidadPulsera.text = "x" + contPulsera.ToString();
            numPiojos = getPiojos();
            numPiojos -= costePulsera;
            setPiojos(numPiojos);
            contador.text = numPiojos.ToString();
            costePulsera = Mathf.RoundToInt(costePulsera * 1.5f);
            costeActualPulsera.text = costePulsera.ToString();
        }
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
        recuperaVida();
        if (listaEnemigos[0].GetVidaActual() <= 0)
        {
            if (listaEnemigos.Count == 1)
            {
                Random.InitState((int)Time.realtimeSinceStartup);
                int r = Random.Range(0, 7);
                int barrier = Random.Range(0, 5);
                Enemigo e = new Enemigo(listaEnemigos[0].GetVidaMax() * 2, (tipoEnemigo)r, (barreras)barrier);
                inicializarBarreras(e);
                listaEnemigos.Add(e);
            }
            listaEnemigos.RemoveAt(0);
            inicializarBarreras(listaEnemigos[0]);
            enemDerrotados++;

            nombreEnemigo.text = listaEnemigos[0].tipo.ToString();
            barraVida.setVidaMaxima(listaEnemigos[0].GetVidaMax());
            barraVida.setVida(listaEnemigos[0].GetVidaActual());
            vidaEnemigo.text = listaEnemigos[0].GetVidaActual().ToString() + "/" + listaEnemigos[0].GetVidaMax().ToString();
        }
    }

    public void saltarIntro()
    {
        animator.gameObject.GetComponent<Animator>().enabled = false;
        Color temp = panel.GetComponent<Image>().color;
        temp.a = 0.0f;
        intro.gameObject.SetActive(false);
        panel.GetComponent<Image>().color = temp;
        panel.gameObject.transform.GetChild(0).gameObject.SetActive(false);
        panel.gameObject.transform.GetChild(1).gameObject.SetActive(false);
        panel.gameObject.transform.GetChild(2).gameObject.SetActive(false);
        panel.gameObject.transform.GetChild(3).gameObject.SetActive(true);
        panel.gameObject.transform.GetChild(4).gameObject.SetActive(true);
        panel.gameObject.transform.GetChild(5).gameObject.SetActive(true);
        panel.gameObject.transform.GetChild(10).gameObject.SetActive(false);
        btnTienda.gameObject.SetActive(true);
        btnGuardar.gameObject.SetActive(true);
        btnCargar.gameObject.SetActive(true);
        btnAjustes.gameObject.SetActive(true);
        btnSalir.gameObject.SetActive(true);

        if (!cargado)
        {
            textoGuardado.gameObject.SetActive(true);
            cargarPartida();
            StartCoroutine(guardadoAutomatico());
            cargado = true;
        }

    }

    //SALVADO DE PARTIDA
    public void guardarPartida()
    {
        Partida p = new Partida();
        p.numPiojos = this.numPiojos;
        p.enemDerrotados = this.enemDerrotados;
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

        string jsonString = JsonConvert.SerializeObject(p, Formatting.Indented);

        GuardarDatos(jsonString);
        StartCoroutine(mostrarGuardado());


    }

    IEnumerator mostrarGuardado()
    {

        textoGuardado.text = "PARTIDA GUARDADA";
        yield return new WaitForSeconds(2);
        textoGuardado.text = "";
    }
    IEnumerator mostrarCarga(string s)
    {
        if (s != null)
        {
            textoGuardado.text = "PARTIDA CARGADA";
            yield return new WaitForSeconds(2);
            textoGuardado.text = "";
        }
        else
        {
            textoGuardado.text = "NO HAY SALVADOS";
            yield return new WaitForSeconds(2);
            textoGuardado.text = "";
        }

    }

    IEnumerator guardadoAutomatico()
    {
        yield return new WaitForSeconds(60);
        guardarPartida();
        StartCoroutine(guardadoAutomatico());
    }

    //CARGA DE PARTIDA
    public void cargarPartida()
    {
        string datosPartida = CargarDatos();
        if (datosPartida != null)
        {
            Partida p = new Partida();
            p = JsonConvert.DeserializeObject<Partida>(datosPartida);

            this.numPiojos = p.numPiojos;
            this.enemDerrotados = p.enemDerrotados;
            this.listaEnemigos = p.listaEnemigos;
            this.costePMadre = p.costePMadre;
            this.contPiojoMadre = p.contPiojoMadre;
            this.costeCabezaN = p.costeCabezaN;
            this.contCabezaN = p.contCabezaN;
            this.costeClaseInfantil = p.costeClaseInfantil;
            this.contClaseInfantil = p.contClaseInfantil;
            this.costePatioEscuela = p.costePatioEscuela;
            this.contPatioEscuela = p.contPatioEscuela;
            this.costeEscuela = p.costeEscuela;
            this.contEscuela = p.contEscuela;
            this.costeCPerros = p.costeCPerros;
            this.contCPerros = p.contCPerros;
            this.costeHostal = p.costeHostal;
            this.contHostal = p.contHostal;
            this.costeJetpack = p.costeJetpack;
            this.contJetpack = p.contJetpack;

            this.costePMazao = p.costePMazao;
            this.contPiojoMazao = p.contPiojoMazao;
            this.costeCTitanes = p.costeCTitanes;
            this.contCazaTitanes = p.contCazaTitanes;
            this.costePCanon = p.costePCanon;
            this.contPCanon = p.contPCanon;
            this.costePMan = p.costePMan;
            this.contPiojoMan = p.contPiojoMan;
            this.costeJefe = p.costeJefe;
            this.contJefe = p.contJefe;
            this.costeLiderM = p.costeLiderM;
            this.contLiderM = p.contLiderM;
            this.costePEstratega = p.costePEstratega;
            this.contPEstratega = p.contPEstratega;
            this.costePKasparov = p.costePKasparov;
            this.contPKasparov = p.contPKasparov;
            this.costeEnfermera = p.costeEnfermera;
            this.contEnfermera = p.contEnfermera;
            this.costePPagado = p.costePPagado;
            this.contPPagado = p.contPPagado;
            this.costePCafeina = p.costePCafeina;
            this.contPCafeina = p.contPCafeina;
            this.costePSpeed = p.costePSpeed;
            this.contPSpeed = p.contPSpeed;
            this.costePMellizos = p.costePMellizos;
            this.contPMellizos = p.contPMellizos;
            this.costePQuinti = p.costePQuinti;
            this.contPQuinti = p.contPQuinti;
            this.costePDeca = p.costePDeca;
            this.contPDeca = p.contPDeca;
            this.costePHecta = p.costePHecta;
            this.contPHecta = p.contPHecta;
            this.costeClonaP = p.costeClonaP;
            this.activeClonaP = p.activeClonaP;
            this.costeMultiC = p.costeMultiC;
            this.activeMultiC = p.activeMultiC;
            this.barraVida.setVidaMaxima(listaEnemigos[0].GetVidaMax());
            this.barraVida.setVida(listaEnemigos[0].GetVidaActual());

            actualizarTextos();
            retomarCorutinas();
        }

        StartCoroutine(mostrarCarga(datosPartida));
    }


    private void actualizarTextos()
    {
        this.contador.text = this.numPiojos.ToString();
        this.vidaEnemigo.text = this.listaEnemigos[0].GetVidaActual().ToString();
        this.costeActualPMadre.text = this.costePMadre.ToString();
        this.cantidadPmadre.text = "x" + this.contPiojoMadre.ToString();
        this.costeActualCabezaN.text = this.costeCabezaN.ToString();
        this.cantidadCabezaN.text = "x" + this.contCabezaN.ToString();
        this.costeActualClaseInfantil.text = this.costeClaseInfantil.ToString();
        this.cantidadClaseInfantil.text = "x" + this.contClaseInfantil.ToString();
        this.costeActualPatioEscuela.text = this.costePatioEscuela.ToString();
        this.cantidadPatioEscuela.text = "x" + this.contPatioEscuela.ToString();
        this.costeActualEscuela.text = this.costeEscuela.ToString();
        this.cantidadEscuela.text = "x" + this.contEscuela.ToString();
        this.costeActualCPerros.text = this.costeCPerros.ToString();
        this.cantidadCPerros.text = "x" + this.contCPerros.ToString();
        this.costeActualHostal.text = this.costeHostal.ToString();
        this.cantidadHostal.text = "x" + this.contHostal.ToString();
        this.costeActualJetPack.text = this.costeJetpack.ToString();
        this.cantidadJetpack.text = "x" + this.contJetpack.ToString();

        this.costeActualPMazao.text = this.costePMazao.ToString();
        this.cantidadPiojoMazao.text = "x" + this.contPiojoMazao.ToString();
        this.costeActualCazaTitanes.text = this.costeCTitanes.ToString();
        this.cantidadCazaTitanes.text = "x" + this.contCazaTitanes.ToString();
        this.costeActualPCanon.text = this.costePCanon.ToString();
        this.cantidadPCanon.text = "x" + this.contPCanon.ToString();
        this.costeActualPMan.text = this.costePMan.ToString();
        this.cantidadPiojoMan.text = "x" + this.contPiojoMan.ToString();
        this.costeActualJefe.text = this.costeJefe.ToString();
        this.cantidadJefe.text = "x" + this.contJefe.ToString();
        this.costeActualLiderM.text = this.costeLiderM.ToString();
        this.cantidadLiderM.text = "x" + this.contLiderM.ToString();
        this.costeActualPEstratega.text = this.costePEstratega.ToString();
        this.cantidadPEstratega.text = "x" + this.contPEstratega.ToString();
        this.costeActualPKasparov.text = this.costePKasparov.ToString();
        this.cantidadPKasparov.text = "x" + this.contPKasparov.ToString();
        this.costeActualEnfermera.text = this.costeEnfermera.ToString();
        this.cantidadEnfermera.text = "x" + this.contEnfermera.ToString();
        this.costeActualPPagado.text = this.costePPagado.ToString();
        this.cantidadPPagado.text = "x" + this.contPPagado.ToString();
        this.costeActualPCafeina.text = this.costePCafeina.ToString();
        this.cantidadPCafeina.text = "x" + this.contPCafeina.ToString();
        this.costeActualPSpeed.text = this.costePSpeed.ToString();
        this.cantidadPSpeed.text = "x" + this.contPSpeed.ToString();
        this.costeActualPMellizos.text = this.costePMellizos.ToString();
        this.cantidadPMellizos.text = "x" + this.contPMellizos.ToString();
        this.costeActualPQuinti.text = this.costePQuinti.ToString();
        this.cantidadPQuinti.text = "x" + this.contPQuinti.ToString();
        this.costeActualPDeca.text = this.costePDeca.ToString();
        this.cantidadPDeca.text = "x" + this.contPDeca.ToString();
        this.costeActualPHecta.text = this.costePHecta.ToString();
        this.cantidadPHecta.text = "x" + this.contPHecta.ToString();

        this.cantidadCasco.text = "x" + this.contCasco.ToString();
        this.costeActualClonaP.text = this.costeClonaP.ToString();
        this.costeActualMultiC.text = this.costeMultiC.ToString();

        this.nombreEnemigo.text = this.listaEnemigos[0].tipo.ToString();
        this.vidaEnemigo.text = this.listaEnemigos[0].GetVidaActual().ToString() + "/" + this.listaEnemigos[0].GetVidaMax().ToString();
    }


    public void retomarCorutinas()
    {
        for (int i = 0; i < contPiojoMadre; i++)
        {
            StartCoroutine(Gen1PiojoSeg());
        }
        for (int i = 0; i < contCabezaN; i++)
        {
            StartCoroutine(Gen5Piojos());
        }
        for (int i = 0; i < contClaseInfantil; i++)
        {
            StartCoroutine(Gen10Piojos());
        }
        for (int i = 0; i < contPatioEscuela; i++)
        {
            StartCoroutine(Gen20PiojoSeg());
        }
        for (int i = 0; i < contEscuela; i++)
        {
            StartCoroutine(Gen50PiojoSeg());
        }
        for (int i = 0; i < contCPerros; i++)
        {
            StartCoroutine(Gen100PiojoSeg());
        }
        for (int i = 0; i < contHostal; i++)
        {
            StartCoroutine(Gen500PiojoSeg());
        }
        for (int i = 0; i < contJetpack; i++)
        {
            StartCoroutine(Gen1000Piojos());
        }
        for (int i = 0; i < contJefe; i++)
        {
            StartCoroutine(attack1s());
        }
        for (int i = 0; i < contLiderM; i++)
        {
            StartCoroutine(attack10s());
        }
        for (int i = 0; i < contPEstratega; i++)
        {
            StartCoroutine(attack50s());
        }
        for (int i = 0; i < contPKasparov; i++)
        {
            StartCoroutine(attack100s());
        }
        for (int i = 0; i < contEnfermera; i++)
        {
            StartCoroutine(click20s());
        }
        for (int i = 0; i < contPPagado; i++)
        {
            StartCoroutine(click10s());
        }
        for (int i = 0; i < contPCafeina; i++)
        {
            StartCoroutine(click5s());
        }
        for (int i = 0; i < contPSpeed; i++)
        {
            StartCoroutine(click2s());
        }
    }



    [DllImport("__Internal")]
    private static extern void GuardarDatos(string d);

    [DllImport("__Internal")]
    private static extern string CargarDatos();
}