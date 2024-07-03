using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ButtonName : MonoBehaviour
{
    private void Start()
    {
        TextMeshProUGUI text = GetComponentInChildren<TextMeshProUGUI>();
        text.text = gameObject.name;
    }
}
