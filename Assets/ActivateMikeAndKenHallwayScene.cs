using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ActivateMikeAndKenHallwayScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SceneManager.LoadScene("NadaHallwayMike&Ken", LoadSceneMode.Single);
    }

    
}
