using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class menuScript : MonoBehaviour
{

    public Text name;
    public Button level1;
    public Button level2;

    public GameObject menuUI;
    public GameObject buttons;
    public GameObject grid;
    public GameObject brick;
    public GameObject gameplay;
    

    // Start is called before the first frame update
    void Start()
    {
        Destroy(name, 3);
        StartCoroutine(setMenu());
       // buttons.SetActive(true);
    }

    IEnumerator setMenu()
    {
        yield return new WaitForSeconds(3);
        buttons.SetActive(true);
    }

    public void Level1()
    {   Debug.Log("Nivel 1");
        menuUI.SetActive(false);
        grid.SetActive(true);
        buttons.SetActive(false);
        gameplay.SetActive(true);
    }

    public void Level2()
    {   
        Debug.Log("Nivel 2");
        menuUI.SetActive(false);
        brick.SetActive(true);
        buttons.SetActive(false);
        gameplay.SetActive(true);
    }

    public void Credits()
    {
        Debug.Log("Creditos");
        menuUI.SetActive(false);
        buttons.SetActive(false);
        
    }
}
