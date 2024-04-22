using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomIdleAnimation : MonoBehaviour
{

    private Animator myAnimator;


    private void Awake()
    {
        myAnimator = GetComponent<Animator>();
    }

    // Start is called before the first frame update
    void Start()
    {
        if(!myAnimator) { return; }
        
        AnimatorStateInfo state = myAnimator.GetCurrentAnimatorStateInfo(0);
        myAnimator.Play(state.fullPathHash, -1, Random.Range(0.0f, 1.0f)); 
        // all this code is to make my torch animations go at different times to give it more of a game feel
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
