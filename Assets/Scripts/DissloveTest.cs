using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DissloveTest : MonoBehaviour
{
        
    public Material material;                       //���׸����� �޾ƿ´�.
    public float amount = -1;                       //������ ���� �޾ƿ´�.
    public bool bDisslove;                          //���� �÷��� 

    private void Start()
    {
        amount = -1;
        material.SetFloat("_Amount", amount);
    }

    void Update()
    {
        if(bDisslove)
        {
            amount += Time.deltaTime;
            material.SetFloat("_Amount", amount);
        }       
    }
}
