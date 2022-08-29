using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coins : MonoBehaviour
{
    public int rotatespeed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, rotatespeed, 0, Space.World);
        

    }
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
}
