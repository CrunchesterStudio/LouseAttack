using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManagerInfo : MonoBehaviour
{
    //Paneles
    public GameObject mejExpansion;
    public GameObject mejGeneracion;
    public GameObject mejCombate;
    public GameObject mejTemporal;
    public GameObject mejPago;

    //Mejoras de Expansi�n
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

    //Mejoras Generaci�n
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
        //Mejoras de Expansi�n
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

        //Mejoras Generaci�n
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


    public void OnMouseOverInfo()
    {
        //Mejoras de Expansi�n
        if (mejExpansion.active == true)
        {
            InfoPMadre.SetActive(true);
            InfoCabezaN.SetActive(true);
            InfoClaseInfantil.SetActive(true);
            InfoPatioEscuela.SetActive(true);
            InfoEscuela.SetActive(true);
            InfoCPerros.SetActive(true);
            InfoHostal.SetActive(true);
            InfoJetpack.SetActive(true);
        }

        //Mejoras de Combate
        if (mejCombate.active == true)
        {
            InfoPiojoMazao.SetActive(true);
            InfoCazaTitanes.SetActive(true);
            InfoPiojoCanon.SetActive(true);
            InfoPiojoMan.SetActive(true);
            InfoJefeEquipo.SetActive(true);
            InfoLiderM.SetActive(true);
            InfoPEstratega.SetActive(true);
            InfoPKasparov.SetActive(true);
        }

        //Mejoras Generaci�n
        if (mejGeneracion.active == true)
        {
            InfoEnfermera.SetActive(true);
            InfoPPagado.SetActive(true);
            InfoPCafeina.SetActive(true);
            InfoPSpeed.SetActive(true);
            InfoPMellizos.SetActive(true);
            InfoPQuinti.SetActive(true);
            InfoPDeca.SetActive(true);
            InfoPHecta.SetActive(true);
        }

        //Mejoras de Pago
        if (mejPago.active == true)
            InfoMejoraPago.SetActive(true);

        //Mejoras Temporales
        if (mejTemporal.active == true)
        {
            InfoClonaP.SetActive(true);
            InfoMultiC.SetActive(true);
        }
    }

    public void OnMouseExitInfo()
    {
        //Mejoras de Expansi�n
        if (mejExpansion.active == true)
        {
            InfoPMadre.SetActive(false);
            InfoCabezaN.SetActive(false);
            InfoClaseInfantil.SetActive(false);
            InfoPatioEscuela.SetActive(false);
            InfoEscuela.SetActive(false);
            InfoCPerros.SetActive(false);
            InfoHostal.SetActive(false);
            InfoJetpack.SetActive(false);
        }

        //Mejoras de Combate
        if (mejCombate.active == true)
        {
            InfoPiojoMazao.SetActive(false);
            InfoCazaTitanes.SetActive(false);
            InfoPiojoCanon.SetActive(false);
            InfoPiojoMan.SetActive(false);
            InfoJefeEquipo.SetActive(false);
            InfoLiderM.SetActive(false);
            InfoPEstratega.SetActive(false);
            InfoPKasparov.SetActive(false);
        }

        //Mejoras Generaci�n
        if (mejGeneracion.active == true)
        {
            InfoEnfermera.SetActive(false);
            InfoPPagado.SetActive(false);
            InfoPCafeina.SetActive(false);
            InfoPSpeed.SetActive(false);
            InfoPMellizos.SetActive(false);
            InfoPQuinti.SetActive(false);
            InfoPDeca.SetActive(false);
            InfoPHecta.SetActive(false);
        }

        //Mejoras de Pago
        if (mejPago.active == true)
            InfoMejoraPago.SetActive(false);

        //Mejoras Temporales
        if (mejTemporal.active == true)
        {
            InfoClonaP.SetActive(false);
            InfoMultiC.SetActive(false);
        }
    }

}