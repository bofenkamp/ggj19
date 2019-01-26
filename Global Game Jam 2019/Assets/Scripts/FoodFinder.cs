using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodFinder : MonoBehaviour
{
    [SerializeField]
    private float fieldOfView;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CanSeeFood();
    }

    public bool CanSeeFood ()
    {
        Transform food = this.transform;
        Transform grandma = GameObject.FindGameObjectWithTag("Eyes").transform;
        Transform gaze = grandma.GetChild(0);
        if (Physics.Linecast(food.position, grandma.position)) //is there an object blocking grandma's view?
            return false;
        else
        {
            Vector3 gazeDir = gaze.position - grandma.position;
            Vector3 foodDir = food.position - grandma.position;
            float angle = Vector3.Angle(gazeDir, foodDir);
            return angle <= fieldOfView;
        }
    }
}
