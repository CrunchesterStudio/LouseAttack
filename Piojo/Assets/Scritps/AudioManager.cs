using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{

    public AudioSource source { get { return GetComponent<AudioSource>(); } }
    public Button btn { get { return GetComponent<Button>(); } }
    public AudioClip clip;
    public bool esMejora = false;
    // Start is called before the first frame update
    void Start()
    {


            gameObject.AddComponent<AudioSource>();
        if (clip != null&&!esMejora)
        {
            btn.onClick.AddListener(PlaySound);
        }

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void PlaySound()
    {
        source.PlayOneShot(clip);
    }

   


}

