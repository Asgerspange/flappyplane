using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnviromentSpawner : MonoBehaviour
{
    public float maxTime = 10;
    private float timer = 0;
    public GameObject enviroment;

    private void Start()
    {
        GameObject newEnviroment = Instantiate(enviroment);
        newEnviroment.transform.position = transform.position + new Vector3(0, 0, 0);
        Destroy(newEnviroment, 40);
    }

    private void Update()
    {
        if (timer > maxTime)
        {
            GameObject newEnviroment = Instantiate(enviroment);
            newEnviroment.transform.position = transform.position + new Vector3(0, 0, 0);
            Destroy(newEnviroment, 40);

            timer = 0;
        }

        timer += Time.deltaTime;
    }
}
