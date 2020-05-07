using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public float gotSphereDestroyDelay;
    private bool hitBySphere;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Cuerpo") && !hitBySphere)
        {
            hitBySphere = true;
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        hitBySphere = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
