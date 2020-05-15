using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Valve.VR.InteractionSystem.Hand.CustomStart() == true){
            transform.position += Time.deltaTime * new Vector3(0, 0, 4);
        }

        
    }
}
