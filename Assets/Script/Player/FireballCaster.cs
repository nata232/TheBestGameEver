using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballCaster : MonoBehaviour
{
    public Fireball fireballPrefab;
<<<<<<< Updated upstream
    public Transform firenallSourceTransform;
=======
    public Transform fireballSourceTransform;
>>>>>>> Stashed changes


    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
<<<<<<< Updated upstream
            Instantiate(fireballPrefab, firenallSourceTransform.position, firenallSourceTransform.rotation);
=======
            Instantiate(fireballPrefab,fireballSourceTransform.position, fireballSourceTransform.rotation);
>>>>>>> Stashed changes
        }
        
    }
}
