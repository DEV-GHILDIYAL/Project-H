using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [Header("Knief")]
    public bool isKniefPicked;
    public GameObject knief;
    public GameObject kniefButton;

    [Header("Interact Button")]
    public GameObject EButton;
    public GameObject GButton;

    [Header("Chicken Info")]
    public TextMeshProUGUI numberOfNormalChickenText;
    public int noOfNormalChicken;
    public TextMeshProUGUI numberOfCursedChickenText;
    public int noOfCursedChicken;

    public GameObject deadCursedChicken;
    public GameObject deadNormalChicken;

    [Header("Scripts")]
    public PickUpAndDrop pickUpAndDrop;

    private void Awake()
    {
        isKniefPicked = false;
        knief.SetActive(false);
        kniefButton.SetActive(false);

        GButton.SetActive(false);
    }
    public void Update()
    {
        if (isKniefPicked)
        {
            kniefButton.SetActive(true);
            knief.SetActive(true);
        }
        if (pickUpAndDrop.isPicked)
        {
            GButton.SetActive(true);
        }
        else
        {
            GButton.SetActive(false);
        }
    }
}
