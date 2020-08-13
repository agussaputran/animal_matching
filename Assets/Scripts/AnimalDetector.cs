using UnityEngine;
using UnityEngine.UI;

public class AnimalDetector : MonoBehaviour
{
    public string nameTag;
    public Text scoreText;
    public AudioClip trueAudio;
    public AudioClip falseAudio;

    private AudioSource TrueMediaPlayer;
    private AudioSource FalseMediaPlayer;

    void Start()
    {
        TrueMediaPlayer = gameObject.AddComponent<AudioSource>();
        TrueMediaPlayer.clip = trueAudio;

        FalseMediaPlayer = gameObject.AddComponent<AudioSource>();
        FalseMediaPlayer.clip = falseAudio;
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == nameTag)
        {
            Data.score += 25;
            scoreText.text = Data.score.ToString();
            Destroy(other.gameObject);
            TrueMediaPlayer.Play();
        }
        else
        {
            Data.score -= 5;
            scoreText.text = Data.score.ToString();
            Destroy(other.gameObject);
            FalseMediaPlayer.Play();
        }
    }
}
