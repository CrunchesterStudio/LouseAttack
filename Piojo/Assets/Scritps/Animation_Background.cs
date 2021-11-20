using System.Collections;

using System.Collections.Generic;

using UnityEngine;

using UnityEngine.UI;

public class Animation_Background : MonoBehaviour
{

    public Sprite[] frames;

    public int fps = 10;
    public Image imagen;


    void Update()

    {

        imagen.sprite = frames[(int)(Time.time * fps) % frames.Length];


    }

}

