using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddCollider : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other) {
        Debug.Log("Произошло столкновение с " + other.gameObject.name);
        other.gameObject.GetComponent<Renderer>().material.SetColor("_Color", Color.green); 
    }

    private void OnTriggerExit(Collider other) {
        Debug.Log("Завершили столкновение с " + other.gameObject.name);
        other.gameObject.GetComponent<Renderer>().material.SetColor("_Color", Color.red);
    }
}
