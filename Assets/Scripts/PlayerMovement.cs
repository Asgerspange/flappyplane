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
