using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManagerInfo : MonoBehaviour
{
    //Mejoras de Generación
    public GameObject InfoPMadre;
    public GameObject InfoCabezaN;
    public GameObject InfoClaseInfantil;
    public GameObject InfoPatioEscuela;
    public GameObject InfoEscuela;
    public GameObject InfoCPerros;
    public GameObject InfoHostal;
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
        InfoPMadre.SetActive(false);
        InfoCabezaN.SetActive(false);
        InfoClaseInfantil.SetActive(false);
        InfoPatioEscuela.SetActive(false);
        InfoEscuela.SetActive(false);
        InfoCPerros.SetActive(false);
        InfoHostal.SetActive(false);
        InfoJetpack.SetActive(false);

        //Mejoras de Combate
        InfoPiojoMazao.SetActive(false);
        InfoCazaTitanes.SetActive(false);
        InfoPiojoCanon.SetActive(false);
        InfoPiojoMan.SetActive(false);

        //Mejoras de Pago
        InfoMejora1.SetActive(false);
}

    //Piojo Madre
    public void OnMouseOverPiojoMadre() { InfoPMadre.SetActive(true); }
    public void OnMouseExitPiojoMadre() { InfoPMadre.SetActive(false); }

    //Cabeza Niño
    public void OnMouseOverCabezaN() { InfoCabezaN.SetActive(true); }
    public void OnMouseExitCabezaN() { InfoCabezaN.SetActive(false); }

    //Clase Infantil
    public void OnMouseOverClaseInfantil() { InfoClaseInfantil.SetActive(true); }
    public void OnMouseExitClaseInfantil() { InfoClaseInfantil.SetActive(false); }

    //Escuela
    public void OnMouseOverPatioEscuela() { InfoPatioEscuela.SetActive(true); }
    public void OnMouseExitPatioEscuela() { InfoPatioEscuela.SetActive(false); }

    //Escuela
    public void OnMouseOverEscuela() { InfoEscuela.SetActive(true); }
    public void OnMouseExitEscuela() { InfoEscuela.SetActive(false); }

    //Cabalgadores de Perros
    public void OnMouseOverCPerros() { InfoCPerros.SetActive(true); }
    public void OnMouseExitCPerros() { InfoCPerros.SetActive(false); }

    //Hostal
    public void OnMouseOverHostal() { InfoHostal.SetActive(true); }
    public void OnMouseExitHostal() { InfoHostal.SetActive(false); }

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
