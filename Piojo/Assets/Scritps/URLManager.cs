using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class URLManager : MonoBehaviour
{
    public void openTwitter()
    {
        Application.OpenURL("https://twitter.com/crunchesterST");
    }
    public void openInstagram()
    {
        Application.OpenURL("https://www.instagram.com/crunchesterstudio/");
    }
    public void openYoutube()
    {
        Application.OpenURL("https://www.youtube.com/channel/UC2mgQN5akJJlqqFHGw_2U2A");
    }
    public void openTikTok()
    {
        Application.OpenURL("https://www.tiktok.com/@crunchesterstudio");
    }
    public void openPortfolio()
    {
        Application.OpenURL("https://crunchesterstudio.github.io/Portfolio/");
    }
    public void openTeam()
    {
        Application.OpenURL("https://crunchesterstudio.github.io/Portfolio/#team");
    }
}
