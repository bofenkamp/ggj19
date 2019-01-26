using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodFinder : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(CanSeeFood());
    }

    public bool CanSeeFood ()
    {
        Transform food = this.transform;
        Transform grandma = GameObject.FindGameObjectWithTag("Eyes").transform;
        return !Physics.Linecast(food.position, grandma.position);
    }
}
