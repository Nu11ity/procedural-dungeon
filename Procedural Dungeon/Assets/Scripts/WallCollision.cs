using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallCollision : MonoBehaviour
{
    private void Start()
    {
        Collider[] colliders = Physics.OverlapSphere(transform.position, .01f);

        foreach (Collider collider in colliders)
        {
            if (collider.tag == "Wall")
            {
                gameObject.SetActive(false);
                //Destroy(gameObject);
                return;
            }
        }

        GetComponent<Collider>().enabled = true;
    }
}
