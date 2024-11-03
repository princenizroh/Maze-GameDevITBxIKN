using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    [SerializeField]AudioSource sfx;
    [SerializeField]GameObject video;

    [SerializeField]TMP_Text count;
    private int countSkillIssue;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        count.text = countSkillIssue.ToString();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ball")
            countSkillIssue += 1;
            StartCoroutine(Active());
    }

    private IEnumerator Active()
    {
        sfx.Play();
        video.SetActive(true);
        yield return new WaitForSeconds(4);
        video.SetActive(false);
    }
}
