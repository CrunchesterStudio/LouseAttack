using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManagerInfo : MonoBehaviour
{
    //Mejoras de Expansión
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

    public GameObject InfoJefeEquipo;
    public GameObject InfoLiderM;
    public GameObject InfoPEstratega;
    public GameObject InfoPKasparov;

    //Mejoras Generación
    public GameObject InfoEnfermera;
    public GameObject InfoPPagado;
    public GameObject InfoPCafeina;
    public GameObject InfoPSpeed;
    public GameObject InfoPMellizos;
    public GameObject InfoPQuinti;
    public GameObject InfoPDeca;
    public GameObject InfoPHecta;

    //Mejoras de Pago
    public GameObject InfoMejoraPago;

    //Mejoras Temporales
    public GameObject InfoClonaP;
    public GameObject InfoMultiC;

    // Start is called before the first frame update
    void Start()
    {
        //Mejoras de Expansión
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
        InfoJefeEquipo.SetActive(false);
        InfoLiderM.SetActive(false);
        InfoPEstratega.SetActive(false);
        InfoPKasparov.SetActive(false);

        //Mejoras Generación
        InfoEnfermera.SetActive(false);
        InfoPPagado.SetActive(false);
        InfoPCafeina.SetActive(false);
        InfoPSpeed.SetActive(false);
        InfoPMellizos.SetActive(false);
        InfoPQuinti.SetActive(false);
        InfoPDeca.SetActive(false);
        InfoPHecta.SetActive(false);

        //Mejoras de Pago
        InfoMejoraPago.SetActive(false);

        //Mejoras Temporales
        InfoClonaP.SetActive(false);
        InfoMultiC.SetActive(false);
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

    //Jefe Equipo
    public void OnMouseOverJefe() { InfoJefeEquipo.SetActive(true); }
    public void OnMouseExitJefe() { InfoJefeEquipo.SetActive(false); }

    //Lider Motivador
    public void OnMouseOverLiderM() { InfoLiderM.SetActive(true); }
    public void OnMouseExitLiderM() { InfoLiderM.SetActive(false); }

    //Piojo Estratega
    public void OnMouseOverPEstratega() { InfoPEstratega.SetActive(true); }
    public void OnMouseExitPEstratega() { InfoPEstratega.SetActive(false); }

    //Piojo Kasparov
    public void OnMouseOverPKasparov() { InfoPKasparov.SetActive(true); }
    public void OnMouseExitPKasparov() { InfoPKasparov.SetActive(false); }

    //Enfermera Piojo
    public void OnMouseOverEnfermera() { InfoEnfermera.SetActive(true); }
    public void OnMouseExitEnfermera() { InfoEnfermera.SetActive(false); }

    //Piojo Bien Pagado
    public void OnMouseOverPPagado() { InfoPPagado.SetActive(true); }
    public void OnMouseExitPPagado() { InfoPPagado.SetActive(false); }

    //Piojo Cafeina
    public void OnMouseOverPCafeina() { InfoPCafeina.SetActive(true); }
    public void OnMouseExitPCafeina() { InfoPCafeina.SetActive(false); }

    //Piojo Speedrunner
    public void OnMouseOverPSpeed() { InfoPSpeed.SetActive(true); }
    public void OnMouseExitPSpeed() { InfoPSpeed.SetActive(false); }

    //Piojos Mellizos
    public void OnMouseOverPMellizos() { InfoPMellizos.SetActive(true); }
    public void OnMouseExitPMellizos() { InfoPMellizos.SetActive(false); }

    //Piojos Quintillizos 
    public void OnMouseOverPQuinti() { InfoPQuinti.SetActive(true); }
    public void OnMouseExitPQuinti() { InfoPQuinti.SetActive(false); }

    //Piojos Decallizos
    public void OnMouseOverPDeca() { InfoPDeca.SetActive(true); }
    public void OnMouseExitPDeca() { InfoPDeca.SetActive(false); }

    //Piojos Hectallizos
    public void OnMouseOverPHecta() { InfoPHecta.SetActive(true); }
    public void OnMouseExitPHecta() { InfoPHecta.SetActive(false); }


    //Mejora Pago 1
    public void OnMouseOverMejoraPago() { InfoMejoraPago.SetActive(true); }
    public void OnMouseExitMejoraPago() { InfoMejoraPago.SetActive(false); }

    //Clona Piojos
    public void OnMouseOverClonaP() { InfoClonaP.SetActive(true); }
    public void OnMouseExitClonaP() { InfoClonaP.SetActive(false); }

    //Multi Clic
    public void OnMouseOverMultiC() { InfoMultiC.SetActive(true); }
    public void OnMouseExitMultiC() { InfoMultiC.SetActive(false); }



}
