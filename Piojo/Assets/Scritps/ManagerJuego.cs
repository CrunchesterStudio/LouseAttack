using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Newtonsoft.Json;
using System.Runtime.InteropServices;
using System.IO;
using System.Globalization;
public class ManagerJuego : MonoBehaviour
{
    private Animation tutorial;
    public Animator animator;
    public GameObject panel;
    public Button intro;
    public Image titulo;

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
    private int costeClaseInfantil = 5000;
    public Text cantidadClaseInfantil;
    private int contClaseInfantil = 0;

    //Patio Escuela
    public Text costeActualPatioEscuela;
    private int costePatioEscuela = 10000;
    public Text cantidadPatioEscuela;
    private int contPatioEscuela = 0;

    //Escuela
    public Text costeActualEscuela;
    private int costeEscuela = 20000;
    public Text cantidadEscuela;
    private int contEscuela = 0;

    //Cabalgadores de Perros
    public Text costeActualCPerros;
    private int costeCPerros = 40000;
    public Text cantidadCPerros;
    private int contCPerros = 0;

    //Hostal
    public Text costeActualHostal;
    private int costeHostal = 200000;
    public Text cantidadHostal;
    private int contHostal = 0;

    //Jetpack
    public Text costeActualJetPack;
    private int costeJetpack = 400000;
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
    private int costeClonaP = 0;
    private bool activeClonaP = false;

    //Multi Clic
    public Text costeActualMultiC;
    private int costeMultiC = 0;
    private bool activeMultiC = false;

    //Texto Barreras
    public GameObject ayudaBarreras;

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

    //Candados bloqueados AntiBarrera
    public Button CandadoCasco;
    public Button CandadoChaleco;
    public Button CandadoMascara;
    public Button CandadoPulsera;

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
    public Button btnGen;

    //Partida cargada por primera vez
    private bool cargado = false;

    //Idioma y formato
    CultureInfo c = new CultureInfo("es-ES");

    //Vida
    int vidaBase = 1000;
    int factor = 2;

    //Enemigos
    public Sprite[] spritesEnem;
    public Image BtnEnemigo;
    public AudioClip[] soundEnem;

    // Start is called before the first frame update
    void Start()
    {
        //Botón Enemigo
        listaEnemigos = new List<Enemigo>();
        inicializarEnemigos();
        nombreEnemigo.text = listaEnemigos[0].tipo.ToString();
        inicializarBarreras(listaEnemigos[0]);

        //Piojo Madre
        costeActualPMadre.text = FormatoNum(costePMadre);
        costeActualPMadre.color = Color.red;
        cantidadPmadre.text = "x" + FormatoNum(contPiojoMadre);

        //Cabeza Niño
        costeActualCabezaN.text = FormatoNum(costeCabezaN);
        costeActualCabezaN.color = Color.red;
        cantidadCabezaN.text = "x" + FormatoNum(contCabezaN);

        //Clase Infantil
        costeActualClaseInfantil.text = FormatoNum(costeClaseInfantil);
        costeActualClaseInfantil.color = Color.red;
        cantidadClaseInfantil.text = "x" + FormatoNum(contClaseInfantil);

        //Patio Escuela
        costeActualPatioEscuela.text = FormatoNum(costePatioEscuela);
        costeActualPatioEscuela.color = Color.red;
        cantidadPatioEscuela.text = "x" + FormatoNum(contPatioEscuela);

        //Escuela
        costeActualEscuela.text = FormatoNum(costeEscuela);
        costeActualEscuela.color = Color.red;
        cantidadEscuela.text = "x" + FormatoNum(contEscuela);

        //Cabalgadores de Perros
        costeActualCPerros.text = FormatoNum(costeCPerros);
        costeActualCPerros.color = Color.red;
        cantidadCPerros.text = "x" + FormatoNum(contCPerros);

        //Hostal
        costeActualHostal.text = FormatoNum(costeHostal);
        costeActualHostal.color = Color.red;
        cantidadHostal.text = "x" + FormatoNum(contHostal);

        //Jetpack
        costeActualJetPack.text = FormatoNum(costeJetpack);
        costeActualJetPack.color = Color.red;
        cantidadJetpack.text = "x" + FormatoNum(contJetpack);

        //Piojo Mazao
        costeActualPMazao.text = FormatoNum(costePMazao);
        costeActualPMazao.color = Color.red;
        cantidadPiojoMazao.text = "x" + FormatoNum(contPiojoMazao);

        //Caza Titanes
        costeActualCazaTitanes.text = FormatoNum(costeCTitanes);
        costeActualCazaTitanes.color = Color.red;
        cantidadCazaTitanes.text = "x" + FormatoNum(contCazaTitanes);

        //Piojo Cañón
        costeActualPCanon.text = FormatoNum(costePCanon);
        costeActualPCanon.color = Color.red;
        cantidadPCanon.text = "x" + FormatoNum(contPCanon);

        //Piojo Man
        costeActualPMan.text = FormatoNum(costePMan);
        costeActualPMan.color = Color.red;
        cantidadPiojoMan.text = "x" + FormatoNum(contPiojoMan);

        //Jefe Equipo
        costeActualJefe.text = FormatoNum(costeJefe);
        costeActualJefe.color = Color.red;
        cantidadJefe.text = "x" + FormatoNum(contJefe);

        //Líder Motivador
        costeActualLiderM.text = FormatoNum(costeLiderM);
        costeActualLiderM.color = Color.red;
        cantidadLiderM.text = "x" + FormatoNum(contLiderM);

        //Piojo Estratega
        costeActualPEstratega.text = FormatoNum(costePEstratega);
        costeActualPEstratega.color = Color.red;
        cantidadPEstratega.text = "x" + FormatoNum(contPEstratega);

        //Piojo Kasparov
        costeActualPKasparov.text = FormatoNum(costePKasparov);
        costeActualPKasparov.color = Color.red;
        cantidadPKasparov.text = "x" + FormatoNum(contPKasparov);

        //Enfermera Piojo
        costeActualEnfermera.text = FormatoNum(costeEnfermera);
        costeActualEnfermera.color = Color.red;
        cantidadEnfermera.text = "x" + FormatoNum(contEnfermera);

        //Piojo Bien Pagado
        costeActualPPagado.text = FormatoNum(costePPagado);
        costeActualPPagado.color = Color.red;
        cantidadPPagado.text = "x" + FormatoNum(contPPagado);

        //Piojo Cafeina
        costeActualPCafeina.text = FormatoNum(costePCafeina);
        costeActualPCafeina.color = Color.red;
        cantidadPCafeina.text = "x" + FormatoNum(contPCafeina);

        //Piojo Speedrunner
        costeActualPSpeed.text = FormatoNum(costePSpeed);
        costeActualPSpeed.color = Color.red;
        cantidadPSpeed.text = "x" + FormatoNum(contPSpeed);

        //Piojos Mellizos
        costeActualPMellizos.text = FormatoNum(costePMellizos);
        costeActualPMellizos.color = Color.red;
        cantidadPMellizos.text = "x" + FormatoNum(contPMellizos);

        //Piojo Quintillizos
        costeActualPQuinti.text = FormatoNum(costePQuinti);
        costeActualPQuinti.color = Color.red;
        cantidadPQuinti.text = "x" + FormatoNum(contPQuinti);

        //Piojo Decallizos
        costeActualPDeca.text = FormatoNum(costePDeca);
        costeActualPDeca.color = Color.red;
        cantidadPDeca.text = "x" + FormatoNum(contPDeca);

        //Piojo Hectallizos
        costeActualPHecta.text = FormatoNum(costePHecta);
        costeActualPHecta.color = Color.red;
        cantidadPHecta.text = "x" + FormatoNum(contPHecta);

        //Casco
        costeActualCasco.text = FormatoNum(costeCasco);
        costeActualCasco.color = Color.red;
        cantidadCasco.text = "x" + FormatoNum(contCasco);

        //Chaleco
        costeActualChaleco.text = FormatoNum(costeChaleco);
        costeActualChaleco.color = Color.red;
        cantidadChaleco.text = "x" + FormatoNum(contChaleco);

        //Mascara
        costeActualMascara.text = FormatoNum(costeMascara);
        costeActualMascara.color = Color.red;
        cantidadMascara.text = "x" + FormatoNum(contMascara);

        //Pulsera
        costeActualPulsera.text = FormatoNum(costePulsera);
        costeActualPulsera.color = Color.red;
        cantidadPulsera.text = "x" + FormatoNum(contPulsera);

        //Clona Piojos
        costeActualClonaP.text = "5€";
        costeActualClonaP.color = Color.green;

        //Multi Clic
        costeActualMultiC.text = "5€";
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
            btnGuardar.gameObject.SetActive(false);
            btnCargar.gameObject.SetActive(false);
            btnAjustes.gameObject.SetActive(true);
            btnSalir.gameObject.SetActive(true);
            titulo.gameObject.SetActive(false);
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

        if (casco.gameObject.activeSelf)
            CandadoCasco.gameObject.SetActive(false);

        if (chaleco.gameObject.activeSelf)
            CandadoChaleco.gameObject.SetActive(false);

        if (mascara.gameObject.activeSelf)
            CandadoMascara.gameObject.SetActive(false);

        if (pulsera.gameObject.activeSelf)
            CandadoPulsera.gameObject.SetActive(false);

    }

    //Botón Piojo
    public int getPiojos() { return numPiojos; }
    public void setPiojos(int newP) { numPiojos = newP; }

    //Mejoras de Generacion
    private int checkGeneracion()
    {
        return 1 + (contPMellizos * 2 + contPQuinti * 10 + contPDeca * 50 + contPHecta * 100);
    }

    private void checkMejorasPago(int aux)
    {
        if (activeClonaP && activeMultiC)
        {
            if (getPiojos() == 0)
            {
                numPiojos++;
                StartCoroutine(Sumador("+1"));
            }

            else if (aux == 0)
            {
                numPiojos = (numPiojos + 2) * 2;
                StartCoroutine(Sumador("+" + FormatoNum((numPiojos + 2) * 2)));
            }

            else
            {
                numPiojos = numPiojos + (2 * aux) + (aux * 20);
                StartCoroutine(Sumador("+" + FormatoNum((2 * aux) + (aux * 20))));
            }
        }

        if (activeClonaP && !activeMultiC)
        {
            if (aux == 0)
            {
                numPiojos += 2;
                StartCoroutine(Sumador("+2"));
            }
            else
            {
                numPiojos += (2 * aux);
                StartCoroutine(Sumador("+" + FormatoNum(2 * aux)));
            }
        }

        if (activeMultiC && !activeClonaP)
        {
            if (getPiojos() == 0)
            {
                numPiojos++;
                StartCoroutine(Sumador("+1"));
            }
            else if (aux == 0)
            {
                numPiojos *= 2;
                StartCoroutine(Sumador("+" + FormatoNum(numPiojos *= 2)));
            }
            else
            {
                numPiojos += (aux * 20);
                StartCoroutine(Sumador("+" + FormatoNum(aux * 20)));
            }
        }

        if (!activeClonaP && !activeMultiC)
        {
            if (aux == 0)
            {
                numPiojos++;
                StartCoroutine(Sumador("+1"));
            }
            else
            {
                numPiojos += aux;
                StartCoroutine(Sumador("+" + FormatoNum(aux)));
            }
        }
    }

    public void GeneradorPiojos()
    {
        int aux = checkGeneracion();
        checkMejorasPago(aux);
        contador.text = FormatoNum(numPiojos);
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
                    contador.text = FormatoNum(numPiojos);
                    codigoVida();
                }
                else
                {
                    numPiojos = (numPiojos - aux);
                    setPiojos(numPiojos);
                    StartCoroutine(Restador("-" + FormatoNum(aux)));
                    contador.text = FormatoNum(numPiojos);
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
            cantidadPmadre.text = "x" + FormatoNum(contPiojoMadre);
            numPiojos = getPiojos();
            numPiojos -= costePMadre;
            setPiojos(numPiojos);
            contador.text = FormatoNum(numPiojos);
            costePMadre = Mathf.RoundToInt(costePMadre * 1.5f);
            costeActualPMadre.text = FormatoNum(costePMadre);
            StartCoroutine(Gen1PiojoSeg());
            AudioManager audioManager = mejExpansion.gameObject.transform.GetChild(0).GetComponent<AudioManager>();
            audioManager.PlaySound();
        }
    }
    IEnumerator Gen1PiojoSeg()
    {
        while (true)
        {
            numPiojos = getPiojos();
            numPiojos = numPiojos + contPiojoMadre;
            setPiojos(numPiojos);
            contador.text = FormatoNum(numPiojos);
            yield return new WaitForSeconds(1);
        }
    }

    //Cabeza Niño
    public void añadeCabezaN()
    {
        if (getPiojos() >= costeCabezaN)
        {
            contCabezaN++;
            cantidadCabezaN.text = "x" + FormatoNum(contCabezaN);
            numPiojos = getPiojos();
            numPiojos -= costeCabezaN;
            setPiojos(numPiojos);
            contador.text = FormatoNum(numPiojos);
            costeCabezaN = Mathf.RoundToInt(costeCabezaN * 1.5f);
            costeActualCabezaN.text = FormatoNum(costeCabezaN);
            StartCoroutine(Gen5Piojos());
            AudioManager audioManager = mejExpansion.gameObject.transform.GetChild(1).GetComponent<AudioManager>();
            audioManager.PlaySound();
        }
    }
    IEnumerator Gen5Piojos()
    {
        while (true)
        {
            numPiojos = getPiojos();
            numPiojos = numPiojos + (contCabezaN * 5);
            setPiojos(numPiojos);
            contador.text = FormatoNum(numPiojos);
            yield return new WaitForSeconds(1);
        }

    }

    //Clase Infantil
    public void añadeClaseInfantil()
    {
        if (getPiojos() >= costeClaseInfantil && enemDerrotados > 0)
        {
            contClaseInfantil++;
            cantidadClaseInfantil.text = "x" + FormatoNum(contClaseInfantil);
            numPiojos = getPiojos();
            numPiojos -= costeClaseInfantil;
            setPiojos(numPiojos);
            contador.text = FormatoNum(numPiojos);
            costeClaseInfantil = Mathf.RoundToInt(costeClaseInfantil * 1.5f);
            costeActualClaseInfantil.text = FormatoNum(costeClaseInfantil);
            StartCoroutine(Gen10Piojos());
            AudioManager audioManager = mejExpansion.gameObject.transform.GetChild(2).GetComponent<AudioManager>();
            audioManager.PlaySound();
        }
    }
    IEnumerator Gen10Piojos()
    {
        while (true)
        {
            numPiojos = getPiojos();
            numPiojos = numPiojos + (contClaseInfantil * 10);
            setPiojos(numPiojos);
            contador.text = FormatoNum(numPiojos);
            yield return new WaitForSeconds(1);
        }

    }

    //Patio Escuela
    public void añadePatioEscuela()
    {
        if (getPiojos() >= costePatioEscuela && enemDerrotados > 0)
        {
            contPatioEscuela++;
            cantidadPatioEscuela.text = "x" + FormatoNum(contPatioEscuela);
            numPiojos = getPiojos();
            numPiojos -= costePatioEscuela;
            setPiojos(numPiojos);
            contador.text = FormatoNum(numPiojos);
            costePatioEscuela = Mathf.RoundToInt(costePatioEscuela * 1.5f);
            costeActualPatioEscuela.text = FormatoNum(costePatioEscuela);
            StartCoroutine(Gen20PiojoSeg());
            AudioManager audioManager = mejExpansion.gameObject.transform.GetChild(3).GetComponent<AudioManager>();
            audioManager.PlaySound();
        }
    }
    IEnumerator Gen20PiojoSeg()
    {
        while (true)
        {
            numPiojos = getPiojos();
            numPiojos = numPiojos + (contPatioEscuela * 20);
            setPiojos(numPiojos);
            contador.text = FormatoNum(numPiojos);
            yield return new WaitForSeconds(1);
        }
    }

    //Escuela
    public void añadeEscuela()
    {
        if (getPiojos() >= costeEscuela && enemDerrotados > 1)
        {
            contEscuela++;
            cantidadEscuela.text = "x" + FormatoNum(contEscuela);
            numPiojos = getPiojos();
            numPiojos -= costeEscuela;
            setPiojos(numPiojos);
            contador.text = FormatoNum(numPiojos);
            costeEscuela = Mathf.RoundToInt(costeEscuela * 1.5f);
            costeActualEscuela.text = FormatoNum(costeEscuela);
            StartCoroutine(Gen50PiojoSeg());
            AudioManager audioManager = mejExpansion.gameObject.transform.GetChild(4).GetComponent<AudioManager>();
            audioManager.PlaySound();
        }
    }
    IEnumerator Gen50PiojoSeg()
    {
        while (true)
        {
            numPiojos = getPiojos();
            numPiojos = numPiojos + (contEscuela * 50);
            setPiojos(numPiojos);
            contador.text = FormatoNum(numPiojos);
            yield return new WaitForSeconds(1);
        }
    }

    //Cabalgadores de Perros
    public void añadeCPerros()
    {
        if (getPiojos() >= costeCPerros && enemDerrotados > 1)
        {
            contCPerros++;
            cantidadCPerros.text = "x" + FormatoNum(contCPerros);
            numPiojos = getPiojos();
            numPiojos -= costeCPerros;
            setPiojos(numPiojos);
            contador.text = FormatoNum(numPiojos);
            costeCPerros = Mathf.RoundToInt(costeCPerros * 1.5f);
            costeActualCPerros.text = FormatoNum(costeCPerros);
            StartCoroutine(Gen100PiojoSeg());
            AudioManager audioManager = mejExpansion.gameObject.transform.GetChild(5).GetComponent<AudioManager>();
            audioManager.PlaySound();
        }
    }
    IEnumerator Gen100PiojoSeg()
    {
        while (true)
        {
            numPiojos = getPiojos();
            numPiojos = numPiojos + (contCPerros * 100);
            setPiojos(numPiojos);
            contador.text = FormatoNum(numPiojos);
            yield return new WaitForSeconds(1);
        }
    }

    //Hostal
    public void añadeHostal()
    {
        if (getPiojos() >= costeHostal && enemDerrotados > 2)
        {
            contHostal++;
            cantidadHostal.text = "x" + FormatoNum(contHostal);
            numPiojos = getPiojos();
            numPiojos -= costeHostal;
            setPiojos(numPiojos);
            contador.text = FormatoNum(numPiojos);
            costeHostal = Mathf.RoundToInt(costeHostal * 1.5f);
            costeActualHostal.text = FormatoNum(costeHostal);
            StartCoroutine(Gen500PiojoSeg());
            AudioManager audioManager = mejExpansion.gameObject.transform.GetChild(6).GetComponent<AudioManager>();
            audioManager.PlaySound();
        }
    }
    IEnumerator Gen500PiojoSeg()
    {
        while (true)
        {
            numPiojos = getPiojos();
            numPiojos = numPiojos + (contHostal * 500);
            setPiojos(numPiojos);
            contador.text = FormatoNum(numPiojos);
            yield return new WaitForSeconds(1);
        }
    }

    //Jetpack
    public void añadeJetpack()
    {
        if (getPiojos() >= costeJetpack && enemDerrotados > 2)
        {
            contJetpack++;
            cantidadJetpack.text = "x" + FormatoNum(contJetpack);
            numPiojos = getPiojos();
            numPiojos -= costeJetpack;
            setPiojos(numPiojos);
            contador.text = FormatoNum(numPiojos);
            costeJetpack = Mathf.RoundToInt(costeJetpack * 1.5f);
            costeActualJetPack.text = FormatoNum(costeJetpack);
            StartCoroutine(Gen1000Piojos());
            AudioManager audioManager = mejExpansion.gameObject.transform.GetChild(7).GetComponent<AudioManager>();
            audioManager.PlaySound();
        }
    }
    IEnumerator Gen1000Piojos()
    {
        while (true)
        {
            numPiojos = getPiojos();
            numPiojos = numPiojos + (contJetpack * 1000);
            setPiojos(numPiojos);
            contador.text = FormatoNum(numPiojos);
            yield return new WaitForSeconds(1);
        }
    }

    //Piojo Mazao
    public void añadePiojoMazao()
    {
        if (getPiojos() >= costePMazao)
        {
            contPiojoMazao++;
            cantidadPiojoMazao.text = "x" + FormatoNum(contPiojoMazao);
            numPiojos = getPiojos();
            numPiojos -= costePMazao;
            setPiojos(numPiojos);
            contador.text = FormatoNum(numPiojos);
            costePMazao = Mathf.RoundToInt(costePMazao * 1.5f);
            costeActualPMazao.text = FormatoNum(costePMazao);
            AudioManager audioManager = mejCombate.gameObject.transform.GetChild(0).GetComponent<AudioManager>();
            audioManager.PlaySound();
        }
    }

    //Caza Titanes
    public void añadeCazaTitanes()
    {
        if (getPiojos() >= costeCTitanes && enemDerrotados > 0)
        {
            contCazaTitanes++;
            cantidadCazaTitanes.text = "x" + FormatoNum(contCazaTitanes);
            numPiojos = getPiojos();
            numPiojos -= costeCTitanes;
            setPiojos(numPiojos);
            contador.text = FormatoNum(numPiojos);
            costeCTitanes = Mathf.RoundToInt(costeCTitanes * 1.5f);
            costeActualCazaTitanes.text = FormatoNum(costeCTitanes);
            AudioManager audioManager = mejCombate.gameObject.transform.GetChild(1).GetComponent<AudioManager>();
            audioManager.PlaySound();
        }
    }

    //Piojo Cañón
    public void añadePiojoCanon()
    {
        if (getPiojos() >= costePCanon && enemDerrotados > 1)
        {
            contPCanon++;
            cantidadPCanon.text = "x" + FormatoNum(contPCanon);
            numPiojos = getPiojos();
            numPiojos -= costePCanon;
            setPiojos(numPiojos);
            contador.text = FormatoNum(numPiojos);
            costePCanon = Mathf.RoundToInt(costePCanon * 1.5f);
            costeActualPCanon.text = FormatoNum(costePCanon);
            AudioManager audioManager = mejCombate.gameObject.transform.GetChild(2).GetComponent<AudioManager>();
            audioManager.PlaySound();
        }
    }

    //Piojo Man
    public void añadePiojoMan()
    {
        if (getPiojos() >= costePMan && enemDerrotados > 2)
        {
            contPiojoMan++;
            cantidadPiojoMan.text = "x" + FormatoNum(contPiojoMan);
            numPiojos = getPiojos();
            numPiojos -= costePMan;
            setPiojos(numPiojos);
            contador.text = FormatoNum(numPiojos);
            costePMan = Mathf.RoundToInt(costePMan * 1.5f);
            costeActualPMan.text = FormatoNum(costePMan);
            AudioManager audioManager = mejCombate.gameObject.transform.GetChild(3).GetComponent<AudioManager>();
            audioManager.PlaySound();
        }
    }

    //Jefe de Equipo
    public void añadeJefe()
    {
        if (getPiojos() >= costeJefe)
        {
            contJefe++;
            cantidadJefe.text = "x" + FormatoNum(contJefe);
            numPiojos = getPiojos();
            numPiojos -= costeJefe;
            setPiojos(numPiojos);
            contador.text = FormatoNum(numPiojos);
            costeJefe = Mathf.RoundToInt(costeJefe * 1.5f);
            costeActualJefe.text = FormatoNum(costeJefe);
            StartCoroutine(attack1s());
            AudioManager audioManager = mejCombate.gameObject.transform.GetChild(4).GetComponent<AudioManager>();
            audioManager.PlaySound();
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
                contador.text = FormatoNum(numPiojos);
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
            cantidadLiderM.text = "x" + FormatoNum(contLiderM);
            numPiojos = getPiojos();
            numPiojos -= costeLiderM;
            setPiojos(numPiojos);
            contador.text = FormatoNum(numPiojos);
            costeLiderM = Mathf.RoundToInt(costeLiderM * 1.5f);
            costeActualLiderM.text = FormatoNum(costeLiderM);
            StartCoroutine(attack10s());
            AudioManager audioManager = mejCombate.gameObject.transform.GetChild(5).GetComponent<AudioManager>();
            audioManager.PlaySound();
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
                contador.text = FormatoNum(numPiojos);
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
            cantidadPEstratega.text = "x" + FormatoNum(contPEstratega);
            numPiojos = getPiojos();
            numPiojos -= costePEstratega;
            setPiojos(numPiojos);
            contador.text = FormatoNum(numPiojos);
            costePEstratega = Mathf.RoundToInt(costePEstratega * 1.5f);
            costeActualPEstratega.text = FormatoNum(costePEstratega);
            StartCoroutine(attack50s());
            AudioManager audioManager = mejCombate.gameObject.transform.GetChild(6).GetComponent<AudioManager>();
            audioManager.PlaySound();
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
                contador.text = FormatoNum(numPiojos);
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
            cantidadPKasparov.text = "x" + FormatoNum(contPKasparov);
            numPiojos = getPiojos();
            numPiojos -= costePKasparov;
            setPiojos(numPiojos);
            contador.text = FormatoNum(numPiojos);
            costePKasparov = Mathf.RoundToInt(costePKasparov * 1.5f);
            costeActualPKasparov.text = FormatoNum(costePKasparov);
            StartCoroutine(attack100s());
            AudioManager audioManager = mejCombate.gameObject.transform.GetChild(7).GetComponent<AudioManager>();
            audioManager.PlaySound();
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
                contador.text = FormatoNum(numPiojos);
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
            cantidadEnfermera.text = "x" + FormatoNum(contEnfermera);
            numPiojos = getPiojos();
            numPiojos -= costeEnfermera;
            setPiojos(numPiojos);
            contador.text = FormatoNum(numPiojos);
            costeEnfermera = Mathf.RoundToInt(costeEnfermera * 1.5f);
            costeActualEnfermera.text = FormatoNum(costeEnfermera);
            StartCoroutine(click20s());
            AudioManager audioManager = mejGeneracion.gameObject.transform.GetChild(0).GetComponent<AudioManager>();
            audioManager.PlaySound();
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
            cantidadPPagado.text = "x" + FormatoNum(contPPagado);
            numPiojos = getPiojos();
            numPiojos -= costePPagado;
            setPiojos(numPiojos);
            contador.text = FormatoNum(numPiojos);
            costePPagado = Mathf.RoundToInt(costePPagado * 1.5f);
            costeActualPPagado.text = FormatoNum(costePPagado);
            StartCoroutine(click10s());
            AudioManager audioManager = mejGeneracion.gameObject.transform.GetChild(1).GetComponent<AudioManager>();
            audioManager.PlaySound();
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
            cantidadPCafeina.text = "x" + FormatoNum(contPCafeina);
            numPiojos = getPiojos();
            numPiojos -= costePCafeina;
            setPiojos(numPiojos);
            contador.text = FormatoNum(numPiojos);
            costePCafeina = Mathf.RoundToInt(costePCafeina * 1.5f);
            costeActualPCafeina.text = FormatoNum(costePCafeina);
            StartCoroutine(click5s());
            AudioManager audioManager = mejGeneracion.gameObject.transform.GetChild(2).GetComponent<AudioManager>();
            audioManager.PlaySound();
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
            cantidadPSpeed.text = "x" + FormatoNum(contPSpeed);
            numPiojos = getPiojos();
            numPiojos -= costePSpeed;
            setPiojos(numPiojos);
            contador.text = FormatoNum(numPiojos);
            costePSpeed = Mathf.RoundToInt(costePSpeed * 1.5f);
            costeActualPSpeed.text = FormatoNum(costePSpeed);
            StartCoroutine(click2s());
            AudioManager audioManager = mejGeneracion.gameObject.transform.GetChild(3).GetComponent<AudioManager>();
            audioManager.PlaySound();
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
            cantidadPMellizos.text = "x" + FormatoNum(contPMellizos);
            numPiojos = getPiojos();
            numPiojos -= costePMellizos;
            setPiojos(numPiojos);
            contador.text = FormatoNum(numPiojos);
            costePMellizos = Mathf.RoundToInt(costePMellizos * 1.5f);
            costeActualPMellizos.text = FormatoNum(costePMellizos);
            AudioManager audioManager = mejGeneracion.gameObject.transform.GetChild(4).GetComponent<AudioManager>();
            audioManager.PlaySound();
        }
    }

    //Piojos Quintillizos 
    public void añadePQuinti()
    {
        if (getPiojos() >= costePQuinti && enemDerrotados > 0)
        {
            contPQuinti++;
            cantidadPQuinti.text = "x" + FormatoNum(contPQuinti);
            numPiojos = getPiojos();
            numPiojos -= costePQuinti;
            setPiojos(numPiojos);
            contador.text = FormatoNum(numPiojos);
            costePQuinti = Mathf.RoundToInt(costePQuinti * 1.5f);
            costeActualPQuinti.text = FormatoNum(costePQuinti);
            AudioManager audioManager = mejGeneracion.gameObject.transform.GetChild(5).GetComponent<AudioManager>();
            audioManager.PlaySound();
        }
    }

    //Piojos Decallizos 
    public void añadePDeca()
    {
        if (getPiojos() >= costePDeca && enemDerrotados > 1)
        {
            contPDeca++;
            cantidadPDeca.text = "x" + FormatoNum(contPDeca);
            numPiojos = getPiojos();
            numPiojos -= costePDeca;
            setPiojos(numPiojos);
            contador.text = FormatoNum(numPiojos);
            costePDeca = Mathf.RoundToInt(costePDeca * 1.5f);
            costeActualPDeca.text = FormatoNum(costePDeca);
            AudioManager audioManager = mejGeneracion.gameObject.transform.GetChild(6).GetComponent<AudioManager>();
            audioManager.PlaySound();
        }
    }

    //Piojos Hectallizos 
    public void añadePHecta()
    {
        if (getPiojos() >= costePHecta && enemDerrotados > 2)
        {
            contPHecta++;
            cantidadPHecta.text = "x" + FormatoNum(contPHecta);
            numPiojos = getPiojos();
            numPiojos -= costePHecta;
            setPiojos(numPiojos);
            contador.text = FormatoNum(numPiojos);
            costePHecta = Mathf.RoundToInt(costePHecta * 1.5f);
            costeActualPHecta.text = FormatoNum(costePHecta);
            AudioManager audioManager = mejGeneracion.gameObject.transform.GetChild(7).GetComponent<AudioManager>();
            audioManager.PlaySound();
        }
    }

    public void muestraAyuda()
    {
        StartCoroutine(ayuda());
    }

    IEnumerator ayuda()
    {
        ayudaBarreras.SetActive(true);
        yield return new WaitForSeconds(3);
        ayudaBarreras.SetActive(false);
        StopCoroutine(ayuda());
    }

    //Enemigos
    private void inicializarEnemigos()
    {

        Random.InitState((int)Time.realtimeSinceStartup);
        int num = Random.Range(0, 7);
        Enemigo e1 = new Enemigo(vidaBase, (tipoEnemigo)num, barreras.SinProtecciones, num, num);
        num = Random.Range(0, 7);
        Enemigo e2 = new Enemigo((vidaBase * (enemDerrotados + 1) + e1.GetVidaMax() * factor), (tipoEnemigo)num, barreras.Casco, num, num);
        num = Random.Range(0, 7);
        Enemigo e3 = new Enemigo((vidaBase * (enemDerrotados + 1) + e2.GetVidaMax() * factor), (tipoEnemigo)num, barreras.Chaleco, num, num);
        listaEnemigos.Add(e1);
        listaEnemigos.Add(e2);
        listaEnemigos.Add(e3);
        barraVida.setVidaMaxima(listaEnemigos[0].GetVidaMax());
        barraVida.setVida(listaEnemigos[0].GetVidaActual());
        BtnEnemigo.sprite = spritesEnem[listaEnemigos[0].imagen];
        vidaEnemigo.text = FormatoNum(listaEnemigos[0].GetVidaActual()) + "/" + FormatoNum(listaEnemigos[0].GetVidaMax());
    }

    private void recuperaVida()
    {
        Random.InitState((int)Time.realtimeSinceStartup);
        int num = Random.Range(0, 10);
        if (listaEnemigos[0].GetVidaActual() <= listaEnemigos[0].GetVidaMax() / 2 && num > 8)
        {
            barraVida.setVidaMaxima(listaEnemigos[0].GetVidaMax());
            listaEnemigos[0].SetVidaActual(listaEnemigos[0].GetVidaActual() + listaEnemigos[0].GetVidaMax() / 10);
            barraVida.setVida(listaEnemigos[0].GetVidaActual());
            vidaEnemigo.text = FormatoNum(listaEnemigos[0].GetVidaActual()) + "/" + FormatoNum(listaEnemigos[0].GetVidaMax());
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
            CandadoCasco.gameObject.SetActive(true);
            contCasco++;
            cantidadCasco.text = "x" + FormatoNum(contCasco);
            numPiojos = getPiojos();
            numPiojos -= costeCasco;
            setPiojos(numPiojos);
            contador.text = FormatoNum(numPiojos);
            costeCasco = Mathf.RoundToInt(costeCasco * 1.5f);
            costeActualCasco.text = FormatoNum(costeCasco);
            AudioManager audioManager = mejAntibarrera.gameObject.transform.GetChild(0).GetComponent<AudioManager>();
            audioManager.PlaySound();
        }
    }

    //Chaleco
    public void añadeChaleco()
    {
        if (getPiojos() >= costeChaleco)
        {
            chaleco.gameObject.SetActive(false);
            CandadoChaleco.gameObject.SetActive(true);
            contChaleco++;
            cantidadChaleco.text = "x" + FormatoNum(contChaleco);
            numPiojos = getPiojos();
            numPiojos -= costeChaleco;
            setPiojos(numPiojos);
            contador.text = FormatoNum(numPiojos);
            costeChaleco = Mathf.RoundToInt(costeChaleco * 1.5f);
            costeActualChaleco.text = FormatoNum(costeChaleco);
            AudioManager audioManager = mejAntibarrera.gameObject.transform.GetChild(1).GetComponent<AudioManager>();
            audioManager.PlaySound();
        }
    }

    //Mascara
    public void añadeMascara()
    {
        if (getPiojos() >= costeMascara)
        {
            mascara.gameObject.SetActive(false);
            CandadoMascara.gameObject.SetActive(true);
            contMascara++;
            cantidadMascara.text = "x" + FormatoNum(contMascara);
            numPiojos = getPiojos();
            numPiojos -= costeMascara;
            setPiojos(numPiojos);
            contador.text = FormatoNum(numPiojos);
            costeMascara = Mathf.RoundToInt(costeMascara * 1.5f);
            costeActualMascara.text = FormatoNum(costeMascara);
            AudioManager audioManager = mejAntibarrera.gameObject.transform.GetChild(2).GetComponent<AudioManager>();
            audioManager.PlaySound();
        }
    }

    //Pulsera
    public void añadePulsera()
    {
        if (getPiojos() >= costePulsera)
        {
            pulsera.gameObject.SetActive(false);
            CandadoPulsera.gameObject.SetActive(true);
            contPulsera++;
            cantidadPulsera.text = "x" + FormatoNum(contPulsera);
            numPiojos = getPiojos();
            numPiojos -= costePulsera;
            setPiojos(numPiojos);
            contador.text = FormatoNum(numPiojos);
            costePulsera = Mathf.RoundToInt(costePulsera * 1.5f);
            costeActualPulsera.text = FormatoNum(costePulsera);
            AudioManager audioManager = mejAntibarrera.gameObject.transform.GetChild(3).GetComponent<AudioManager>();
            audioManager.PlaySound();
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
            contador.text = FormatoNum(numPiojos);
            StartCoroutine(active30s());
            AudioManager audioManager = mejPago.gameObject.transform.GetChild(0).GetComponent<AudioManager>();
            audioManager.PlaySound();
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
            contador.text = FormatoNum(numPiojos);
            StartCoroutine(clicx2());
            AudioManager audioManager = mejPago.gameObject.transform.GetChild(1).GetComponent<AudioManager>();
            audioManager.PlaySound();
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
        vidaEnemigo.text = FormatoNum(listaEnemigos[0].GetVidaActual()) + "/" + FormatoNum(listaEnemigos[0].GetVidaMax());
        recuperaVida();
        if (listaEnemigos[0].GetVidaActual() <= 0)
        {
            if (listaEnemigos.Count == 1)
            {
                Random.InitState((int)Time.realtimeSinceStartup);
                int r = Random.Range(0, 7);
                int barrier = Random.Range(0, 5);
                Enemigo e = new Enemigo((listaEnemigos[0].GetVidaMax() + vidaBase * (enemDerrotados + 1)) * factor, (tipoEnemigo)r, (barreras)barrier, r, r);
                inicializarBarreras(e);
                listaEnemigos.Add(e);
            }
            listaEnemigos.RemoveAt(0);
            inicializarBarreras(listaEnemigos[0]);
            enemDerrotados++;

            nombreEnemigo.text = listaEnemigos[0].tipo.ToString();
            barraVida.setVidaMaxima(listaEnemigos[0].GetVidaMax());
            barraVida.setVida(listaEnemigos[0].GetVidaActual());
            BtnEnemigo.sprite = spritesEnem[listaEnemigos[0].imagen];
            gameObject.AddComponent<AudioSource>();
            GetComponent<AudioSource>().PlayOneShot(soundEnem[listaEnemigos[0].sonido]);
            vidaEnemigo.text = FormatoNum(listaEnemigos[0].GetVidaActual()) + "/" + FormatoNum(listaEnemigos[0].GetVidaMax());
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
        panel.gameObject.transform.GetChild(6).gameObject.SetActive(true);
        panel.gameObject.transform.GetChild(7).gameObject.SetActive(true);
        panel.gameObject.transform.GetChild(8).gameObject.SetActive(true);
        panel.gameObject.transform.GetChild(9).gameObject.SetActive(true);
        panel.gameObject.transform.GetChild(10).gameObject.SetActive(true);
        btnTienda.gameObject.SetActive(true);
        btnGuardar.gameObject.SetActive(false);
        btnCargar.gameObject.SetActive(false);
        btnAjustes.gameObject.SetActive(true);
        btnSalir.gameObject.SetActive(true);
        btnGen.gameObject.SetActive(true);
        titulo.gameObject.SetActive(false);

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
            textoGuardado.text = "";
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
        this.vidaEnemigo.text = FormatoNum(this.listaEnemigos[0].GetVidaActual());
        this.costeActualPMadre.text = FormatoNum(this.costePMadre);
        this.cantidadPmadre.text = "x" + FormatoNum(this.contPiojoMadre);
        this.costeActualCabezaN.text = FormatoNum(this.costeCabezaN);
        this.cantidadCabezaN.text = "x" + FormatoNum(this.contCabezaN);
        this.costeActualClaseInfantil.text = FormatoNum(this.costeClaseInfantil);
        this.cantidadClaseInfantil.text = "x" + FormatoNum(this.contClaseInfantil);
        this.costeActualPatioEscuela.text = FormatoNum(this.costePatioEscuela);
        this.cantidadPatioEscuela.text = "x" + FormatoNum(this.contPatioEscuela);
        this.costeActualEscuela.text = FormatoNum(this.costeEscuela);
        this.cantidadEscuela.text = "x" + FormatoNum(this.contEscuela);
        this.costeActualCPerros.text = FormatoNum(this.costeCPerros);
        this.cantidadCPerros.text = "x" + FormatoNum(this.contCPerros);
        this.costeActualHostal.text = FormatoNum(this.costeHostal);
        this.cantidadHostal.text = "x" + FormatoNum(this.contHostal);
        this.costeActualJetPack.text = FormatoNum(this.costeJetpack);
        this.cantidadJetpack.text = "x" + FormatoNum(this.contJetpack);

        this.costeActualPMazao.text = FormatoNum(this.costePMazao);
        this.cantidadPiojoMazao.text = "x" + FormatoNum(this.contPiojoMazao);
        this.costeActualCazaTitanes.text = FormatoNum(this.costeCTitanes);
        this.cantidadCazaTitanes.text = "x" + FormatoNum(this.contCazaTitanes);
        this.costeActualPCanon.text = FormatoNum(this.costePCanon);
        this.cantidadPCanon.text = "x" + FormatoNum(this.contPCanon);
        this.costeActualPMan.text = FormatoNum(this.costePMan);
        this.cantidadPiojoMan.text = "x" + FormatoNum(this.contPiojoMan);
        this.costeActualJefe.text = FormatoNum(this.costeJefe);
        this.cantidadJefe.text = "x" + FormatoNum(this.contJefe);
        this.costeActualLiderM.text = FormatoNum(this.costeLiderM);
        this.cantidadLiderM.text = "x" + FormatoNum(this.contLiderM);
        this.costeActualPEstratega.text = FormatoNum(this.costePEstratega);
        this.cantidadPEstratega.text = "x" + FormatoNum(this.contPEstratega);
        this.costeActualPKasparov.text = FormatoNum(this.costePKasparov);
        this.cantidadPKasparov.text = "x" + FormatoNum(this.contPKasparov);
        this.costeActualEnfermera.text = FormatoNum(this.costeEnfermera);
        this.cantidadEnfermera.text = "x" + FormatoNum(this.contEnfermera);
        this.costeActualPPagado.text = FormatoNum(this.costePPagado);
        this.cantidadPPagado.text = "x" + FormatoNum(this.contPPagado);
        this.costeActualPCafeina.text = FormatoNum(this.costePCafeina);
        this.cantidadPCafeina.text = "x" + FormatoNum(this.contPCafeina);
        this.costeActualPSpeed.text = FormatoNum(this.costePSpeed);
        this.cantidadPSpeed.text = "x" + FormatoNum(this.contPSpeed);
        this.costeActualPMellizos.text = FormatoNum(this.costePMellizos);
        this.cantidadPMellizos.text = "x" + FormatoNum(this.contPMellizos);
        this.costeActualPQuinti.text = FormatoNum(this.costePQuinti);
        this.cantidadPQuinti.text = "x" + FormatoNum(this.contPQuinti);
        this.costeActualPDeca.text = FormatoNum(this.costePDeca);
        this.cantidadPDeca.text = "x" + FormatoNum(this.contPDeca);
        this.costeActualPHecta.text = FormatoNum(this.costePHecta);
        this.cantidadPHecta.text = "x" + FormatoNum(this.contPHecta);

        this.cantidadCasco.text = "x" + FormatoNum(this.contCasco);
        this.costeActualClonaP.text = FormatoNum(this.costeClonaP);
        this.costeActualMultiC.text = FormatoNum(this.costeMultiC);

        this.nombreEnemigo.text = this.listaEnemigos[0].tipo.ToString();
        this.vidaEnemigo.text = FormatoNum(this.listaEnemigos[0].GetVidaActual()) + "/" + FormatoNum(this.listaEnemigos[0].GetVidaMax());
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

    private string FormatoNum(int num)
    {
        string s = "";
        if (num >= 1000000)
        {
            double d = num / 1000000.0;
            s = d.ToString("0.0", c) + " M";
            return s;
        }
        if (num >= 10000)
        {
            float f = num / 1000;
            s = f.ToString("0", c) + " K";
            return s;
        }
        else
        {
            if (num == 0)
            {
                s = "0";
            }
            else
            {
                s = num.ToString("##,#", c);
            }

            return s;
        }

    }

    [DllImport("__Internal")]
    private static extern void GuardarDatos(string d);

    [DllImport("__Internal")]
    private static extern string CargarDatos();

}