using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Parslekties : MonoBehaviour {

    public void uzSakumu()
    {
        SceneManager.LoadScene("Charecter", LoadSceneMode.Single);

    }
    public void Atpakal()
    {
        Application.Quit();
    }
    public void uzUI()
    {
        SceneManager.LoadScene("Makarovs_UnityUI", LoadSceneMode.Single);

    }
}
