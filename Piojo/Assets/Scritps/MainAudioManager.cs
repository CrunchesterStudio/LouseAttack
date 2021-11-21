using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainAudioManager : MonoBehaviour
{
    public static MainAudioManager inst;
    public Sprite[] sprites;
    public Image image;
    public bool muted=false;
    private void Awake()
    {
            if (inst == null)
            {
                inst = this;
            }
            else
            {
            Destroy(this);
            }
    }
    // Start is called before the first frame update
    void Start()
    {
        if (AudioListener.volume==0)
        {
            muted = true;
            AudioListener.volume = 0;
            if(image!=null)
                image.sprite = sprites[1];

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Mute()
    {
        if (!muted)
        {
            
            AudioListener.volume = 0;
            if (image != null)
                image.sprite = sprites[1];
            muted = true;
        }
        else if (muted)
        {
            AudioListener.volume = 1;
            if (image != null)
                image.sprite = sprites[0];
            muted = false;
        }

    }

}
