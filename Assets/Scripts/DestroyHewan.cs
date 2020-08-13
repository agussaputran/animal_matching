using UnityEngine;
using UnityEngine.SceneManagement;

public class DestroyHewan : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other) 
    {
        Destroy(other.gameObject);
        SceneManager.LoadScene(2);
    }
}
