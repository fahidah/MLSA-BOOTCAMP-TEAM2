using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstructorController : MonoBehaviour
{
    private Animator instructorAnimation;
    // Start is called before the first frame update
    void Start()
    {
        instructorAnimation = GetComponent<Animator>();
    }

    // Update is called once per frame
    public void Bow()
    {
        instructorAnimation.SetTrigger("bowTrigger");
    }
}
