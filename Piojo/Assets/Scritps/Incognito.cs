using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Incognito : MonoBehaviour
{
    public GameObject modoIncognito;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(muestraPanel());
    }

    IEnumerator muestraPanel()
    {
        modoIncognito.SetActive(true);
        yield return new WaitForSeconds(5);
        modoIncognito.SetActive(false);
    }

}
