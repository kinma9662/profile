using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public void mode() { SceneManager.LoadScene(0); } //StartGame scene
    public void mode1() { SceneManager.LoadScene(1); } //Each scene corresponds to each level
    public void mode2() { SceneManager.LoadScene(2); }
    public void mode3() { SceneManager.LoadScene(3); }
    public void mode4() { SceneManager.LoadScene(4); }
}
