using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManagerInfo : MonoBehaviour
{
    //Mejoras de Generación
    public GameObject InfoEnfermera;
    public GameObject InfoPMadre;
    public GameObject InfoEscuela;
    public GameObject InfoHostal;
    public GameObject InfoManosMagicas;
    public GameObject InfoJetpack;

    //Mejoras de Combate
    public GameObject InfoPiojoMazao;
    public GameObject InfoCazaTitanes;
    public GameObject InfoPiojoCanon;
    public GameObject InfoPiojoMan;

    //Mejoras de Pago
    public GameObject InfoMejora1;

    // Start is called before the first frame update
    void Start()
    {
        //Mejoras de Generación
        InfoEnfermera.SetActive(false);
        InfoPMadre.SetActive(false);
        InfoEscuela.SetActive(false);
        InfoHostal.SetActive(false);
        InfoManosMagicas.SetActive(false);
        InfoJetpack.SetActive(false);

        //Mejoras de Combate
        InfoPiojoMazao.SetActive(false);
        InfoCazaTitanes.SetActive(false);
        InfoPiojoCanon.SetActive(false);
        InfoPiojoMan.SetActive(false);

        //Mejoras de Pago
        InfoMejora1.SetActive(false);
}

    //Enfermera
    public void OnMouseOverEnfermera(){InfoEnfermera.SetActive(true);}
    public void OnMouseExitEnfermera(){InfoEnfermera.SetActive(false);}

    //Piojo Madre
    public void OnMouseOverPiojoMadre() { InfoPMadre.SetActive(true); }
    public void OnMouseExitPiojoMadre() { InfoPMadre.SetActive(false); }

    //Escuela
    public void OnMouseOverEscuela() { InfoEscuela.SetActive(true); }
    public void OnMouseExitEscuela() { InfoEscuela.SetActive(false); }

    //Hostal
    public void OnMouseOverHostal() { InfoHostal.SetActive(true); }
    public void OnMouseExitHostal() { InfoHostal.SetActive(false); }

    //Manos Mágicas
    public void OnMouseOverManosM() { InfoManosMagicas.SetActive(true); }
    public void OnMouseExitManosM() { InfoManosMagicas.SetActive(false); }

    //Jetpack
    public void OnMouseOverJetpack() { InfoJetpack.SetActive(true); }
    public void OnMouseExitJetpack() { InfoJetpack.SetActive(false); }

    //PiojoMazao
    public void OnMouseOverPMazao() { InfoPiojoMazao.SetActive(true); }
    public void OnMouseExitPMazao() { InfoPiojoMazao.SetActive(false); }

    //CazaTitanes
    public void OnMouseOverCazaTitanes() { InfoCazaTitanes.SetActive(true); }
    public void OnMouseExitCazaTitanes() { InfoCazaTitanes.SetActive(false); }

    //PiojoCanon
    public void OnMouseOverPCanon() { InfoPiojoCanon.SetActive(true); }
    public void OnMouseExitPCanon() { InfoPiojoCanon.SetActive(false); }

    //PiojoMan
    public void OnMouseOverPiojoMan() { InfoPiojoMan.SetActive(true); }
    public void OnMouseExitPiojoMan() { InfoPiojoMan.SetActive(false); }

    //Mejora 1
    public void OnMouseOverMejora1() { InfoMejora1.SetActive(true); }
    public void OnMouseExitMejora1() { InfoMejora1.SetActive(false); }



}
