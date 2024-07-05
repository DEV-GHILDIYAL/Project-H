using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class VersionManager : MonoBehaviour
{
    public TextMeshProUGUI version;

    private void Start()
    {
        version.text = "version: " + Application.version.ToString();
    }
}