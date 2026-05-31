using UnityEngine;
using UnityEngine.Video;

public class PhoneBoothInteraction : MonoBehaviour
{
    [Header("Panel de informacion")]
    public GameObject infoPanel;

    [Header("Video")]
    public VideoPlayer videoPlayer;

    [Header("Audio Narracion")]
    public AudioSource narracionAudio;

    private bool playerInside = false;

    private void Start()
    {
        infoPanel.SetActive(false);

        if (videoPlayer != null)
        {
            videoPlayer.Stop();
            videoPlayer.loopPointReached += OnVideoEnd;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInside = true;

            infoPanel.SetActive(true);

            if (videoPlayer != null)
            {
                videoPlayer.Play();
            }

            if (narracionAudio != null)
            {
                narracionAudio.Play();
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInside = false;

            infoPanel.SetActive(false);

            if (videoPlayer != null)
            {
                videoPlayer.Stop();
            }

            if (narracionAudio != null)
            {
                narracionAudio.Stop();
            }
        }
    }

    private void OnVideoEnd(VideoPlayer vp)
    {
        // Solo cerrar si el jugador sigue dentro
        if (playerInside)
        {
            infoPanel.SetActive(false);

            if (narracionAudio != null)
            {
                narracionAudio.Stop();
            }
        }
    }
}