using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RotatePlayer : MonoBehaviour
{

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StopAllCoroutines();
            StartCoroutine(RotateTheBird());
        }
    }

    IEnumerator RotateTheBird()
    {
        //Make bird look up
        Vector3 newRotation = new Vector3(-55, 189, 0);
        transform.eulerAngles = newRotation;
        yield return new WaitForSeconds(0.2f);
        //Make bird look forward
        Vector3 new1Rotation = new Vector3(-95, 189, 0);
        transform.eulerAngles = new1Rotation;
        yield return new WaitForSeconds(0.3f);
        //MAke bird look down
        Vector3 new2Rotation = new Vector3(-135, 189, 0);
        transform.eulerAngles = new2Rotation;
        yield return null;
    }

}
