using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kodlar : MonoBehaviour
{
    public GameObject Panel;
    public void Start()
    {
        Panel.gameObject.SetActive(true);
    }
    public void CikisButon()
    {
        Application.Quit();
    }
    public void Basla()
    {
        Panel.gameObject.SetActive(false);
    }
}
