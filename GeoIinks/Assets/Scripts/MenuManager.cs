using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject painelMenu, painelConteudo, fadeIN,fadeOUT;
    [SerializeField] private string nomeDoLevelDeJogo;
    public void Play()
    {
        
        StartCoroutine(trocaPainel());
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void PreGuerraFria()
    {
        SceneManager.LoadScene(1);
    }

    IEnumerator trocaPainel()
    {
        fadeIN.SetActive(false);
        fadeOUT.SetActive(true);
        yield return new WaitForSeconds(1);
        painelMenu.SetActive(false);
        yield return new WaitForSeconds(1);
        painelConteudo.SetActive(true);
        fadeOUT.SetActive(false);
        fadeIN.SetActive(true);
    }


}
