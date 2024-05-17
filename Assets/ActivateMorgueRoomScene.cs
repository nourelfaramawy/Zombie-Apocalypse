using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ActivateMorgueRoomScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SceneManager.LoadScene("NourRoom2morgue", LoadSceneMode.Single);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
