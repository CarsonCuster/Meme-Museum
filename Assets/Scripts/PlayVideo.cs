using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayVideo : MonoBehaviour
{
    public GameObject screen;
    // Start is called before the first frame update
    void Start()
    {
        var videoPlayer = screen.GetComponent<UnityEngine.Video.VideoPlayer>();
            videoPlayer.Pause();
    }

    // Update is called once per frame
    void OnCollisionEnter()
    {
        var videoPlayer = screen.GetComponent<UnityEngine.Video.VideoPlayer>();
        if(videoPlayer.isPaused)
        {
            videoPlayer.Play();
        }
        else
        {
            videoPlayer.Pause();
        }
    }
}
