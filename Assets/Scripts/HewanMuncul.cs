using UnityEngine;

public class HewanMuncul : MonoBehaviour
{
    #region Variables
    public float jedaWaktu = 0.8f;

    public GameObject[] hewan;

    float timer;
    #endregion

    #region Builtin Methods
    void Update()
    {
        timer += Time.deltaTime;
        if(timer > jedaWaktu)
        {
            int acak = Random.Range(0, hewan.Length);
            Instantiate(hewan[acak], transform.position, transform.rotation);
            timer = 0;
        }
    }
    #endregion
}
