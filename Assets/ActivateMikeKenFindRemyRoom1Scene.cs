using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ActivateMikeKenFindRemyRoom1Scene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SceneManager.LoadScene("Mike&KenFindRemyInRoom1Scene", LoadSceneMode.Single);
    }
}
