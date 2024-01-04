using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallonController : MonoBehaviour
{
    public float upSpeed;
    int score = 0;
    AudioSource audioSource;
    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        transform.Translate(0, upSpeed, 0);
    }

    private void OnMouseDown()
    {
        score++;
        audioSource.Play();
        ResetPosition();
        
    }

    void ResetPosition()
    {
        float randomX = Random.Range(-2.5f, 2.5f);
        transform.position = new Vector2 (randomX, -5f);


    }


}
