using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    public GameObject canvas;
    // Start is called before the first frame update
    // Update is called once per frame

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Ball")
        {
            StartCoroutine(SetActive());
            SceneManager.LoadScene("Congrats");

            
        }
    }

    private IEnumerator SetActive()
    {
        canvas.SetActive(true);
        yield return new WaitForSeconds(2);
    }
    private void CallArena()
    {
        StartCoroutine(GameManager.instance.CreateArena(2));
    }
}
