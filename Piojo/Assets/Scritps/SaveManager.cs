using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Newtonsoft.Json;
using System.Runtime.InteropServices;
using System.IO;

public class SaveManager : MonoBehaviour
{
    public static SaveManager inst;
    

    private void Awake()
    {
        if (inst == null)
        {
            inst = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }


    public static void BorrarPartida()
    {
        BorrarDatos();
        ChangeScene.LoadScene("MainMenu");
    }



    [DllImport("__Internal")]
    private static extern string BorrarDatos();
}
