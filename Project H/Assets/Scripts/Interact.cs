using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Interact : MonoBehaviour
{
    public Transform interactSource;

    public float interactDistance = 3f;
    public LayerMask interactLayer;

    public Image interactIcon;

    public bool isInteracting;
    RaycastHit hit;

    [Header("Scripts")]
    public Machine machine;
    public GameManager gameManager;
    public PickUpAndDrop pickUpAndDrop;
    public PoisionBox poisionBox;

    private void Start()
    {
        if(interactIcon != null)
        {
            interactIcon.enabled = false;
        }
    }

    private void Update()
    {
        Ray ray = new Ray(interactSource.position, interactSource.forward);
        Debug.DrawRay(interactSource.position, interactSource.forward);

        if(Physics.Raycast(ray, out hit, interactDistance, interactLayer))
        {
            if(isInteracting == false)
            {
                if (interactIcon != null)
                {
                    interactIcon.enabled = true;
                    isInteracting = true;
                }
            }
        }
        else
        {
            interactIcon.enabled = false;
            isInteracting= false;
        }
    }

    public void DoInteract()
    {
        if (isInteracting)
        {
            GameObject hitObj = hit.collider.gameObject;
            hit.collider.TryGetComponent(out Interactable interactable);

            if(hitObj.tag == "knief")
            {
                if (!gameManager.isKniefPicked)
                {
                    gameManager.isKniefPicked = true;
                    Destroy(hit.collider.gameObject);
                }
            }
            else if (interactable.canPick == false)
            {
                interactable.Interact();
                if (hitObj.tag == "Machine")
                {
                    machine.interactWithMachine();
                }
                else if(hitObj.tag == "PoisionBox")
                {
                    poisionBox.activateBox();
                }
            }
            else
            {
                if (pickUpAndDrop.isPicked == false)
                    pickUpAndDrop.Pick(hit.collider.gameObject);
            }
        }
        else
        {
            Debug.Log("Iski bhen ki maze maze");
        }
    }
}
