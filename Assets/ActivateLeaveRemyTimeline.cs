using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class ActivateLeaveRemyTimeline : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] PlayableDirector timeline;

    void Start()
    {
        timeline = GetComponent<PlayableDirector>();
    }

    public void PlayTimeline()
    {
        timeline.Play();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
