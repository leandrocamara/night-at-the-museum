using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class ControlVideoPlayer : MonoBehaviour
{
    private Text label;
    private VideoPlayer videoPlayer;
    public GameObject video;

    private void Start()
    {
        label = gameObject.GetComponentInChildren<Text>();
        videoPlayer = video.GetComponentInChildren<VideoPlayer>();
    }

    /**
     * Inicia/pausa o vídeo informado.
     *
     * @param GameObject video
     */
    public void PlayVideo()
    {
        if (videoPlayer.isPlaying)
        {
            videoPlayer.Pause();
            label.text = "PLAY";
        }
        else
        {
            videoPlayer.Play();
            label.text = "PAUSE";
        }
    }
}
