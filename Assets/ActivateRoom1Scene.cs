using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;

public class ActivateChooseFollowScreamTimeline : MonoBehaviour
{
    void Start()
    {
        SceneManager.LoadScene("Room1", LoadSceneMode.Single);
    }


}
