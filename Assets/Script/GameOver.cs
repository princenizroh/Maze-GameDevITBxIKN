using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameOver : MonoBehaviour
{
    public GameObject button;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Ball")
        {      
            StartCoroutine(SetActive()); 
        }
    }

    public void Repeat()
    {
        SceneManager.LoadScene("Maze");
    }
    private IEnumerator SetActive()
    {
        button.SetActive(true);
        yield return new WaitForSeconds(2);
    }
}
