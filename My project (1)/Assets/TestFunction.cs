using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestFunction : MonoBehaviour
{
    public int finalDamage;
    public MeshRenderer meshRenderer;
    public Color[] colors;


    //EVENT FUNCTIONS
    // Start is called before the first frame update
    void Start()
    {
        finalDamage = AttackPlayer();

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnDisable()
    {
        meshRenderer.material.color = Color.red;
    }

    private void OnEnable()
    {
        //meshrenderer = component meshrenderer
        //material = sub component on mesh renderer
        //color = under material that changes color

        //colors = variable array of colors
        //[] = int value
        //random range between 0 - colors.length 

        meshRenderer.material.color = colors[Random.Range(0, colors.Length)];

        //for (int i = 0; i < colors.Length; i++)

    }

    private void OnMouseEnter()
    {
        //meshrenderer = component meshrenderer
        //material = sub component on mesh renderer
        //color = under material that changes color

        //colors = variable array of colors
        //[] = int value
        //random range between 0 - colors.length 

        //meshRenderer.material.color = colors[Random.Range(0, colors.Length)];

       // for (int i = 0; i < colors.Length; i++)
    }

    private void OnMouseExit()
    {
        //ChangeColor();
    }

    private void OnMouseDown()
    {
        Invoke(nameof(ChangeColor), 5.5f););
    }

    private void OnMouseUp()
    {
        //ChangeColor();
    }

    private void OnMouseDrag()
    {
        //ChangeColor();
    }

    public void ChangeColor()
    {
        meshRenderer.material.color = colors[Random.Range(0, colors.Length)];
    }




    public int AttackPlayer()
    {
        int damage = 10;
        return damage;
    }
}
        
    
