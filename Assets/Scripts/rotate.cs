using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            GetComponent<Transform> ().eulerAngles = new Vector3 (-50, 189, -10);
        if (Input.GetKeyUp(KeyCode.Space))
            GetComponent<Transform> ().eulerAngles = new Vector3 (-95, 189, -10);
        
    }       
}
