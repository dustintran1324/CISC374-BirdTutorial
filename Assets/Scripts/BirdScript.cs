using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapStrength;
    public LogicScript logic;
    public bool birdIsAlive = true;
    private AudioSource audioSource;
    public AudioClip flapSound;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameObject.name = "Kween Henlizabeth";
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive) //You can't play anymore after the bird is dead so score doesn't go up when you
        {
            myRigidbody.linearVelocity = Vector2.up * flapStrength;
            audioSource.PlayOneShot(flapSound);
        }
        OnTouchingBound();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdIsAlive = false;
    }
    //Kill Birdy when it touches bounds
    public void OnTouchingBound(){
        float screenTop = Camera.main.orthographicSize - 1; 
        float screenBottom = -Camera.main.orthographicSize + 1; 
        if (transform.position.y > screenTop || transform.position.y < screenBottom){
            logic.gameOver();
            birdIsAlive = false;
        }
    }
}
