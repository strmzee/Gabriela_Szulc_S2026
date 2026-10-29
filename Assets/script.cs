using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script : MonoBehaviour
{

    public List<GameObject> obiekty = new List<GameObject>();
    
    public Gradient gr;

    public int divide;

    public float angle = 15;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    void SortObj()
    {
        foreach (GameObject go in obiekty)
        {
            if (go.GetComponent<SpriteRenderer>() != null)
            {
                Sprite(go.GetComponent<SpriteRenderer>());
            }
            else if (go.GetComponent<MeshRenderer>() != null)
            {
                Cube(go.transform);
            }
        }
    }

    void Sprite(SpriteRenderer sprite)
    {
        sprite.color = gr.Evaluate(sprite.gameObject.transform.position.y / divide);
    }

    void Cube(Transform tran)
    {
        tran.Rotate(angle, 0, 0);
        tran.position = new Vector3(tran.position.x, tran.position.y +1 *Time.deltaTime, tran.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        SortObj();
    }
}
