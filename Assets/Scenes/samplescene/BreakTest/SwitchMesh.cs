using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchMesh : MonoBehaviour
{

    public GameObject otherMesh;

    // Start is called before the first frame update
    void Start()
    {
        otherMesh.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        foreach (ContactPoint contact in collision.contacts)
        {
            Debug.DrawRay(contact.point, contact.normal, Color.white);
        }
        if (collision.relativeVelocity.magnitude > 2)
        {
            otherMesh.SetActive(true);
            otherMesh.transform.SetParent(null);
            Destroy(gameObject);
        }
    }
}
