using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{

    public AudioSource source { get { return GetComponent<AudioSource>(); } }
    public Button btn { get { return GetComponent<Button>(); } }
    public AudioClip clip;
    public Text text = null;
    // Start is called before the first frame update
    void Start()
    {
        if (AudioListener.volume == 0)
        {
            if (text != null)
                text.text = "Sonido OFF";
        }
        if (clip != null)
        {
            gameObject.AddComponent<AudioSource>();
            btn.onClick.AddListener(PlaySound);
        }

    }

    // Update is called once per frame
    void Update()
    {

    }

    void PlaySound()
    {
        source.PlayOneShot(clip);
    }

    public void Mute()
    {
        if (AudioListener.volume > 0)
        {
            AudioListener.volume = 0;
            if (text != null)
                text.text = "Sonido OFF";
        }
        else if (AudioListener.volume == 0)
        {
            AudioListener.volume = 1;
            if (text != null)
                text.text = "Sonido ON";
        }

    }


}

