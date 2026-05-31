using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalRecorrido : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene("04_Final");
        }
    }
}