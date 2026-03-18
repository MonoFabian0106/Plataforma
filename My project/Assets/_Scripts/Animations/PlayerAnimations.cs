using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimations : MonoBehaviour
{
    private Animator _animator;
    private NewInput _newInput;

    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponent<Animator>();
        _newInput = GetComponent<NewInput>();
    }

    // Update is called once per frame
    void Update()
    {
        MovmentAnim();
    }

    public void MovmentAnim()
    {
        if (_newInput.inputX > 0 || _newInput.inputX < 0)
        {
            _animator.SetBool("walk", true);
        }
        else if (_newInput.inputX == 0)
        {
            _animator.SetBool("walk", false);
        }
    }
}
