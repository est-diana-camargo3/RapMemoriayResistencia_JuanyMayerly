using UnityEngine;

public class PhoneBoothInteraction : MonoBehaviour
{
    [Header("Panel de informacion")]
    public GameObject infoPanel;

    [Header("Audio Narracion")]
    public AudioSource narracionAudio;

    private bool yaSeReprodujo = false;

    private void Start()
    {
        infoPanel.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            infoPanel.SetActive(true);

            if (!yaSeReprodujo && narracionAudio != null)
            {
                narracionAudio.Play();
                yaSeReprodujo = true;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            infoPanel.SetActive(false);
        }
    }
}