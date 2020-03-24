using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class replay : MonoBehaviour
{
    //On mouse click, reload the scene
    void OnMouseDown()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
