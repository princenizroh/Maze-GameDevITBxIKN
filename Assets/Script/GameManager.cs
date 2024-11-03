using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using UnityEngine;
using UnityEngine.EventSystems;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public GameObject Arena;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CreateArena(2));
    }

    public IEnumerator CreateArena(int arenaSum)
    {
        yield return new WaitForSeconds(1);
        for (int i = 0; i < arenaSum; i++)
        {
            GameObject ArenaClone = Instantiate(Arena, new Vector3(i, Arena.transform.position.y, i), Arena.transform.rotation);
        }
    }
}
