using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BallonController : MonoBehaviour
{
    public float upSpeed;
    int score = 0;
    AudioSource audioSource;
    public TextMeshProUGUI scoreText;
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
        scoreText.text = score.ToString();  
        audioSource.Play();
        ResetPosition();
        
    }

    void ResetPosition()
    {
        float randomX = Random.Range(-2.5f, 2.5f);
        transform.position = new Vector2 (randomX, -5f);


    }


}
