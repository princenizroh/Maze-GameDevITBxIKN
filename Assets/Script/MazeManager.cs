using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeManager : MonoBehaviour
{
    [SerializeField]
    Transform mazeTransform;
    [SerializeField]
    float speedRotation;
    Vector3 nowRotation = new Vector3(-5,-30,0);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            nowRotation += new Vector3(1,0,0) * speedRotation * Time.deltaTime; 
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            nowRotation += new Vector3(-1,0,0) * speedRotation * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            nowRotation += new Vector3(0,0,1) * speedRotation * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            nowRotation += new Vector3(0,0,-1) * speedRotation * Time.deltaTime;   
        }

        nowRotation.x = Mathf.Clamp(nowRotation.x, -20, 20);
        nowRotation.z = Mathf.Clamp(nowRotation.z, -20, 20);

        mazeTransform.rotation = Quaternion.Euler(nowRotation);
    }
}
