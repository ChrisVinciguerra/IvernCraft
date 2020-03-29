using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrowTree : MonoBehaviour
{
    private Animator anim;
    public BoxCollider2D colide;
    public Transform playertrans;
    public Animator ianim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        

        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);

            


            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);

            if (hit.collider == colide)
            {
                if (mousePos.x < playertrans.position.x)
                {
                    ianim.SetTrigger("growleft");
                }
                else
                {
                    ianim.SetTrigger("growright");
                }

                Debug.Log("Tree was clicked!" + mousePos.x + playertrans.position.x);

                anim.SetTrigger("makeGrow");
            }
        }

    }
}
