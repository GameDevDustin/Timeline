using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class PauseTimeline : MonoBehaviour
{
    private PlayableDirector _director;

    // Start is called before the first frame update
    void Start()
    {
        _director = GetComponent<PlayableDirector>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            PlayTime();
        }
    }

    public void PauseTime()
    {
        _director.Pause();
    }

    public void PlayTime()
    {
        _director.Play();
    }
}
