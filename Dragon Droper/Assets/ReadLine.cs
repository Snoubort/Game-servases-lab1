using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadLine : MonoBehaviour
{
    public int n = -1;
    public GameObject PrefCub;
    public GameObject self;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(n >=0){
            for (int i = 0; i<n; i++){
                Instantiate(PrefCub, self.transform.position, self.transform.rotation);
            }
            n = -1;
        }
        
    }
}
