using UnityEngine;

public class PickUpAndDrop : MonoBehaviour
{
    public bool isPicked;
    public Transform DropPoint;

    public GameObject objPicked;
    public GameManager gameManager;

    private void Start()
    {
        isPicked = false;
    }

    public void Drop()
    {
        if (objPicked != null && isPicked)
        {
            objPicked.SetActive(true);
            objPicked.transform.position = DropPoint.position;
            objPicked = null;
            isPicked = false;
        }
    }

    public void Pick(GameObject obj)
    {
        if (!isPicked && objPicked == null)
        {
            isPicked = true;
            objPicked = obj;
            objPicked.SetActive(false); // Deactivate the object
        }
    }
}
