using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hide : MonoBehaviour
{
    public GameObject HidePosition;
    public GameObject Player;
    public float HideSpeed;
    bool Saklanmak;
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            Saklanmak = true;
        }
        if (Saklanmak == true)
        {
            Player.transform.position = Vector3.MoveTowards(Player.transform.position, HidePosition.transform.position, HideSpeed*Time.deltaTime);
        }
    }
}
