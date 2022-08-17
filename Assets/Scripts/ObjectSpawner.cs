using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    [Header("Timer Shit")]
    public float maxTime = 1;
    private float timer = 0;
    [Header("References")]
    public GameObject pipe;

    private void Update()
    {
        if(timer > maxTime)
        {
            GameObject newPipe = Instantiate(pipe);
            newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-2, 2), 0);
            Destroy(newPipe, 15);

            timer = 0;
        }

        timer += Time.deltaTime;
    }

    private void Start()
    {
        GameObject newPipe = Instantiate(pipe);
        newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-2, 2), 0);
        Destroy(newPipe, 15);
    }
}
