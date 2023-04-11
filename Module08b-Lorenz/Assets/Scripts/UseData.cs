using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class UseData : MonoBehaviour
{/**
  * Tutorial link
  * https://github.com/tikonen/blog/tree/master/csvreader
  * */

    List<Dictionary<string, object>> data;

    //public GameObject myCube;//prefab

    int rowCount; //variable 
    private float startDelay = 2.0f;
    private float timeInterval = 1.0f;
    public object tempObj;
    public float tempFloat;

    void Awake()
    {

        data = CSVReader.Read("testh2o"); //udata is the name of the csv file 

        for (var i = 0; i < data.Count; i++)
        {
            //name, age, speed, description, is the headers of the database
            print("xh2o " + data[i]["xh2o"] + " ");

        }
        rowCount = 0;

    }//end Awake()

    // Use this for initialization
    void Start()
    {

        InvokeRepeating("SpawnObject", startDelay, timeInterval);


    }//end Start()

    // Update is called once per frame
   
     
    void SpawnObject()
    {
        tempObj = (data[rowCount]["xh2o"]);
        tempFloat = System.Convert.ToSingle(tempObj);
        tempFloat = (tempFloat - 2300.0f) * 5.0f;

        rowCount++;

        transform.localScale = new Vector3 (tempFloat, tempFloat, tempFloat);

        Debug.Log("The tempFloat is " + tempFloat);
        Debug.Log("Count " + rowCount);

    }



    // Update is called once per frame
    void Update()
    {
        /* for (var i = 0; i < data.Count; i++)
         {
             object xco2 = data[i]["xco2"];//get age data
             gameObject.transform.localScale = new Vector3((float)xco2, (float)xco2, (float)xco2);
         }
         //As long as cube count is not zero, instantiate prefab
         //while (cubeCount > 0)
         // {
         //    Instantiate(myCube);
         //    cubeCount--;
         //    Debug.Log("cubeCount" + cubeCount);
         // }
        */

    }//end Update()


}


