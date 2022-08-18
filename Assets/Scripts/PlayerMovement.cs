using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    [Header("GameObjects")]
    public GameObject GameOver;

    [Header("Rigidbody")]
    public Rigidbody rb;
    RigidbodyConstraints rbConstraints;

    [Header("Audio")]
    public AudioSource audioSource;
    public AudioClip wingAudio;
    public AudioClip deathAudio;

    [Header("Movement")]
    [SerializeField] float jumpHeight = 10;
    

    // Start is called before the first frame update, unity bitch ass monke 
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        jumpHeight = 7;
    }

    // Update is called once per frame, stfu unity piece of shit
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = Vector3.up * jumpHeight;
            audioSource.PlayOneShot(wingAudio);
        }
      
        if(Input.GetKey(KeyCode.I) && Input.GetKey(KeyCode.T) && Input.GetKey(KeyCode.Space))
        {
            GetComponent<BoxCollider>().enabled = false;
            rbConstraints = rb.constraints;
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            GetComponent<BoxCollider>().enabled = true;
            rb.constraints = rbConstraints;
        }

        if (Input.GetKeyDown(KeyCode.Z) && GetComponent<BoxCollider>().enabled == false)
        {
            rb.constraints = rb.constraints == rbConstraints ? RigidbodyConstraints.FreezeAll : rbConstraints;
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("pipe"))
        {
            Time.timeScale = 0;
            audioSource.PlayOneShot(deathAudio);
            GameOver.SetActive(true);

        }
    }
 

}
