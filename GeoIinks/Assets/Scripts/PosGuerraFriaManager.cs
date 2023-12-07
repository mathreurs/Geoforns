using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PosGuerraFriaManager : MonoBehaviour
{
    public GameObject slide1,slide2,slide3,slide4,atualSlide,proxSlide, slideFinal;

    public float certo, errado;
    public TMP_Text textoFinal;

    public Image acertos;

    public void Update()
    {
        if(slide1.activeInHierarchy)
        {
            atualSlide = slide1;
            proxSlide = slide2;
        }

        if(slide2.activeInHierarchy)
        {
            atualSlide = slide2;
            proxSlide = slide3;
        }

        if (slide3.activeInHierarchy)
        {
            atualSlide = slide3;
            proxSlide = slide4;
        }

        if (slide4.activeInHierarchy) 
        {
            atualSlide = slide4;
            proxSlide = slideFinal;
        }

        if (certo == 1)
        {
            acertos.fillAmount = 0.25f;
            textoFinal.text = "25% de acerto, precisa estudar mais";
        }
        if (certo == 2)
        {
            acertos.fillAmount = 0.50f;
            textoFinal.text = "50% de acerto, está quase";
        }
        if (certo == 3)
        {
            acertos.fillAmount = 0.75f;
            textoFinal.text = "75% de acerto, um bom resultado";
        }
        if (certo == 4)
        {
            acertos.fillAmount = 1f;
            textoFinal.text = "100% de acerto!, parabens!!";
        }
    }

    public void correto()
    {
        atualSlide.SetActive(false);
        proxSlide.SetActive(true);
        certo++;
    }

    public void erro()
    {
        atualSlide.SetActive(false);
        proxSlide.SetActive(true);  
        errado++;
    }

    public void voltarMenu()
    {
        SceneManager.LoadScene(0);
    }

}
