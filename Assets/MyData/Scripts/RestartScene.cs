using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartScene : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    KeyCode restartButton;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(restartButton))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

    }
  

}
