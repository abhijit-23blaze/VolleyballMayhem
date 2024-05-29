using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnerscript : MonoBehaviour
{
    public GameObject cubeprefab;
    void Update()
    {

        int k = 0;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (k < 4)
            {
                Instantiate(cubeprefab, transform.position, Quaternion.identity);
                k++;
            }
            
        }
    }
}
