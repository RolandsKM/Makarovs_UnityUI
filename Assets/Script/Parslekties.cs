using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Parslekties : MonoBehaviour {

    public void uzSakumu()
    {
        SceneManager.LoadScene("Start", LoadSceneMode.Single);

    }
    public void Atpakal()
    {
        Application.Quit();
    }
    public void uzUI()
    {
        SceneManager.LoadScene("Charecter", LoadSceneMode.Single);

    }
}
