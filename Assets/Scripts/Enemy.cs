
using UnityEngine;

public class Enemy : MonoBehaviour
{
    
    public float horizontalBound = 10f;
    public float verticalBound = 10f;
    public float elapsedTime = 0f;
    [Tooltip("of the circle on which the Enemey moves")]
    public float radius = 4f; [SerializeField]
    private Vector2 startingPosition;
    
     // Start is called before the first frame update
    void Start()
    {
        Transform transform = gameObject.GetComponent<Transform>();
        transform.position = new Vector2( 
            Random.Range(-horizontalBound, horizontalBound),
             Random.Range(-verticalBound, verticalBound));
        startingPosition = transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        elapsedTime = elapsedTime + Time.deltaTime;
        transform.position = startingPosition + new Vector2(radius * Mathf.Sin( elapsedTime), radius*Mathf.Cos(elapsedTime));
    }
}
