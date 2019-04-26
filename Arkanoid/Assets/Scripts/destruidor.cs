using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destruidor : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject collider = collision.collider.gameObject;
        GameObject.Destroy(collider);
    }
    private void OnTriggerExit2D(Collider2D collider)
    {
        GameObject.Destroy(collider.gameObject);
    }
}
