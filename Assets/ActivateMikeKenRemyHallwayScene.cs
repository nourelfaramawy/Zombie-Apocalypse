using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ActivateMikeKenRemyHallwayScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SceneManager.LoadScene("NadaHallwayMike&Ken&RemyScene", LoadSceneMode.Single);
    }
}
