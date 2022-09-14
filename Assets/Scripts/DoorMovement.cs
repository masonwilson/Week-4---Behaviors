using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorMovement : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    [SerializeField] Vector3 moveDirection;
    [SerializeField] float totalMoveDistance;

    Vector3 startingLocation;

    // Start is called before the first frame update
    void Start()
    {
        startingLocation = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        /*
        float distanceTraveled = GetDistanceTraveled();
        // endingLocation = gameObject.transform.position;
        if (distanceTraveled <= totalMoveDistance)
        {
            gameObject.transform.Translate(moveDirection * moveSpeed);

        }
        */
    }
    
    void OnTriggerEnter(Collider other)
    {   
        // i want this to happed only for person (doors are colliding with each other 

        float distanceTraveled = GetDistanceTraveled();
        MoveSide(distanceTraveled, totalMoveDistance);
    }

    void MoveSide(float distanceTraveled, float totalMoveDistance)
    {
        if (distanceTraveled <= totalMoveDistance)
        {
            gameObject.transform.Translate(moveDirection * moveSpeed);

        }
    }
    

    float GetDistanceTraveled()
    {
        return Vector3.Distance(gameObject.transform.position, startingLocation);
    }


}
