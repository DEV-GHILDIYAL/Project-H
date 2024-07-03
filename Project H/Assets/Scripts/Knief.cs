using UnityEngine;

public class Knief : MonoBehaviour
{
    public float damageAmount = 10f;
    public float range = 3f;
    public Transform interactSource;
    public LayerMask targetLayer;

    public int damage = 20;

    

    public void Attack()
    {
        // Shoot a ray from the camera's position in the direction it's facing
        Ray ray = new Ray(interactSource.position, interactSource.forward);
        RaycastHit hit;

        // Check if the ray hits any object on the specified layer
        if (Physics.Raycast(ray, out hit, range, targetLayer))
        {
            if(hit.collider.gameObject.tag == "CursedChicken" || hit.collider.gameObject.tag == "NormalChicken")
            {
                hit.collider.gameObject.GetComponent<Chicken>().TakeDamage(damage);
            }
        }
    }
}
