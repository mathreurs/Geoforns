using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PosGuerraFriaManager : MonoBehaviour
{
    public GameObject slide1,slide2,slide3,slide4,slide5,atualSlide,proxSlide, slideFinal;

    public float certo, errado;

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
            proxSlide = slide5;
        }

        if (slide5.activeInHierarchy)
        {
            atualSlide = slide5;
            proxSlide = slideFinal;
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

}
