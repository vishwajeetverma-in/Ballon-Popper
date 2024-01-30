using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using System;

public class BallonController : MonoBehaviour
{
    public float upSpeed;
    private AudioSource audioSource;
    public TextMeshProUGUI scoreText;

    //[SerializeField] ScoreManager scoreManager;

    public event Action MouseClickEvent; 

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if(transform.position.y > 6f)
        {
            //SceneManager.LoadScene("Level1");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    private void FixedUpdate()
    {
        transform.Translate(0, upSpeed, 0);
    }

    private void OnMouseDown()
    {
        //scoreManager.AddScore();

        MouseClickEvent.Invoke();

        audioSource.Play();
        ResetPosition(); 
    }

    void ResetPosition()
    {
        float randomX = UnityEngine.Random.Range(-2.8f, 2.59f);
        transform.position = new Vector2 (randomX, -5.6f);
    }
}
