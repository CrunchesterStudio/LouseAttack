using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Security.AccessControl;
using Newtonsoft.Json;
using UnityEngine;
using System.Runtime.InteropServices;
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

    //Manos Mágicas
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
        //PlayerSettings.WebGL.memorySize = 1024;

        //Botón Enemigo
        listaEnemigos = new List<Enemigo>();
        inicializarEnemigos();

        //Enfermera
        costeActualEnfermera.text = costeEnfermera.ToString();
        costeActualEnfermera.color = Color.red;
        cantidadEnfermera.text = "x" + contEnfermeras.ToString();

        //Piojo Madre
        costeActualPMadre.text = costePMadre.ToString();
        costeActualPMadre.color = Color.red;
        cantidadPmadre.text = "x" + contPiojoMadre.ToString();

        //Escuela
        costeActualEscuela.text = costeEscuela.ToString();
        costeActualEscuela.color = Color.red;
        cantidadEscuela.text = "x" + contEscuela.ToString();

        //Hostal
        costeActualHostal.text = costeHostal.ToString();
        costeActualHostal.color = Color.red;
        cantidadHostal.text = "x" + contHostal.ToString();

        //Manos Mágicas
        costeActualManosM.text = costeManos.ToString();
        costeActualManosM.color = Color.red;
        cantidadManosM.text = "x" + contManosMagicas.ToString();

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
        //Enfermera
        if (getPiojos() >= costeEnfermera)
            costeActualEnfermera.color = Color.green;
        else
            costeActualEnfermera.color = Color.red;

        //Piojo Madre
        if (getPiojos() >= costePMadre && listaEnemigos[0].tipo != tipoEnemigo.Pulga)
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

    //Enfermera
    public void añadeEnfermera()
    {
        if (getPiojos() >= costeEnfermera)
        {
            contEnfermeras++;
            cantidadEnfermera.text = "x" + contEnfermeras.ToString();
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
        if (getPiojos() >= costePMadre && listaEnemigos[0].tipo != tipoEnemigo.Pulga)
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
            cantidadManosM.text = "x" + contManosMagicas.ToString();
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

    //SALVADO DE PARTIDA
    public void guardarPartida()
    {
         Partida p=new Partida();
         p.numPiojos=this.numPiojos;
         p.listaEnemigos = this.listaEnemigos;
         p.costeEnfermera =this.costeEnfermera;
         p.contEnfermeras=this.contEnfermeras;
         p.costePMadre=this.costePMadre;
         p.contPiojoMadre=this.contPiojoMadre;
         p.costeEscuela=this.costeEscuela;
         p.contEscuela=this.contEscuela;
         p.costeHostal =this.costeHostal;
         p.contHostal=this.contHostal;
         p.costeManos=this.costeManos;
         p.contManosMagicas=this.contManosMagicas;
         p.costeJetpack=this.costeJetpack;
         p.contJetpack=this.contJetpack;

         p.costePMazao=this.costePMazao;
         p.contPiojoMazao=this.contPiojoMazao;
         p.costeCTitanes= this.costeCTitanes;
         p.contCazaTitanes=this.contCazaTitanes;
         p.costePCanon= this.costePCanon;
         p.contPCanon=this.contPCanon;
         p.costePMan=this.costePMan;
         p.contPiojoMan=this.contPiojoMan;
        try
        {
            string jsonString = JsonConvert.SerializeObject(p, Formatting.Indented);
            
            GuardarDatos(jsonString);
            //StreamWriter s = new StreamWriter(Application.persistentDataPath + "/data.json");
            //s.Write(jsonString);
            //s.Close();
        }
        catch(IOException e)
        {

        }
        
         
    }
    //CARGA DE PARTIDA
    public void cargarPartida()
    {
        string datosPartida = "";
        try
        {
            //StreamReader r = new StreamReader(Application.persistentDataPath + "/data.json");
            //datosPartida = r.ReadToEnd();
            //r.Close();
            datosPartida=CargarDatos(datosPartida);
        }
        catch(IOException e)
        {

        }

        Partida p = new Partida();
        p = JsonConvert.DeserializeObject<Partida>(datosPartida);

        this.numPiojos = p.numPiojos;
        this.listaEnemigos = p.listaEnemigos;
        this.costeEnfermera = p.costeEnfermera;
        this.contEnfermeras = p.contEnfermeras;
        this.costePMadre = p.costePMadre;
        this.contPiojoMadre = p.contPiojoMadre;
        this.costeEscuela = p.costeEscuela;
        this.contEscuela = p.contEscuela;
        this.costeHostal = p.costeHostal;
        this.contHostal = p.contHostal;
        this.costeManos = p.costeManos;
        this.contManosMagicas = p.contManosMagicas;
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
        this.barraVida.setVida(listaEnemigos[0].GetVidaActual());
        this.barraVida.setVidaMaxima(listaEnemigos[0].GetVidaMax());
        actualizarTextos();

    }

    private void actualizarTextos()
    {
        this.contador.text=this.numPiojos.ToString();
        this.vidaEnemigo.text=this.listaEnemigos[0].GetVidaActual().ToString();
        this.costeActualEnfermera.text=this.costeEnfermera.ToString();
        this.cantidadEnfermera.text=this.contEnfermeras.ToString();
        this.costeActualPMadre.text=this.costePMadre.ToString();
        this.cantidadPmadre.text=this.contPiojoMadre.ToString();
        this.costeActualEscuela.text=this.costeEscuela.ToString();
        this.cantidadEscuela.text=this.contEscuela.ToString();
        this.costeActualHostal.text=this.costeHostal.ToString();
        this.cantidadHostal.text=this.contHostal.ToString();
        this.costeActualManosM.text=this.costeManos.ToString();
        this.cantidadManosM.text=this.contManosMagicas.ToString();
        this.costeActualJetPack.text=this.costeJetpack.ToString();
        this.cantidadJetpack.text=this.contJetpack.ToString();
        this.costeActualPMazao.text=this.costePMazao.ToString();
        this.cantidadPiojoMazao.text=this.contPiojoMazao.ToString();
        this.costeActualCazaTitanes.text=this.costeCTitanes.ToString();
        this.cantidadCazaTitanes.text=this.contCazaTitanes.ToString();
        this.costeActualPCanon.text=this.costePCanon.ToString();
        this.cantidadPCanon.text=this.contPCanon.ToString();
        this.costeActualPMan.text=this.costePMan.ToString();
        this.cantidadPiojoMan.text=this.contPiojoMan.ToString();
        this.vidaEnemigo.text = this.listaEnemigos[0].GetVidaActual().ToString() + "/" + this.listaEnemigos[0].GetVidaMax().ToString();
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
    
    [DllImport("__Internal")]
    private static extern void GuardarDatos(string d);
    
    [DllImport("__Internal")]
    private static extern string CargarDatos(string d);
}
