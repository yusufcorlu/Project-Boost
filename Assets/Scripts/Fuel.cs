using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fuel : MonoBehaviour
{
    Renderer fuelRenderer;

    [SerializeField] float rotateSpeed = .3f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotateSpeed, rotateSpeed, rotateSpeed);
    }

    private void OnTriggerEnter(Collider other) 
    {
        GetComponent<Renderer>().enabled = false;
        Debug.Log("You picked up fuel");
    }
}