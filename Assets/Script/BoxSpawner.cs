using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxSpawner : MonoBehaviour
{
    public GameObject box_prefab;


    public void SpawnBox()
    {
        GameObject box2_obj = Instantiate(box_prefab);

        Vector3 temp = transform.position;
        temp.z = 0f;

        box2_obj.transform.position = temp;
    }


}
