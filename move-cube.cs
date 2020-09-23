using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

  public GameObject[] point;
  public float Speed;
  private int CurrentPosition;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        transform.position=Vector3.MoveTowards(transform.position, point[CurrentPosition].transform.position, Speed *Time.deltaTime);
    }
}
