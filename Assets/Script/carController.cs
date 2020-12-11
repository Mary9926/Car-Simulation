using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carController : MonoBehaviour
{

    [SerializeField]
    private Animator _animator;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            _animator.SetTrigger("speedUp");
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            _animator.SetTrigger("slowDown");
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            _animator.SetTrigger("coffeeBreak");
        }
        if (Input.GetKeyDown(KeyCode.O))
        {
            _animator.SetTrigger("oil");
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            _animator.SetTrigger("engine");
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            _animator.SetTrigger("disaster");
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            _animator.SetTrigger("fuel");
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            _animator.SetTrigger("phoneCall");
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            _animator.SetTrigger("radio");
        }
        if (Input.GetKeyDown(KeyCode.M))
        {
            _animator.SetTrigger("music");
        }
    }
}






