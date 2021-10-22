using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManagerInfo : MonoBehaviour
{
    //Mensaje
    public GameObject DescpEnfermera;

    // Start is called before the first frame update
    void Start()
    {
        DescpEnfermera.SetActive(false);
    }

    public void OnMouseOver()
    {
        DescpEnfermera.SetActive(true);
    }
    public void OnMouseExit()
    {
        DescpEnfermera.SetActive(false);
    }

}
