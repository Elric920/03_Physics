/***
 * Title：
 * Description:
 * Author：IMDT_Elric
 * Date:
 * Version:
 */
 
using UnityEngine;

public class MoveManager : MonoBehaviour
{
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(10, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
