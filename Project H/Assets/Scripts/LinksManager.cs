using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinksManager : MonoBehaviour
{
    public void feedbackForm()
    {
        Application.OpenURL("https://forms.gle/HfsDhqS7tWxHeYme9");
    }

    public void BuyMeACoffee()
    {
        Application.OpenURL("http://buymeacoffee.com/aixer");
    }
}
