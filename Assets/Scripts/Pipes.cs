using UnityEngine;

public class Pipes : MonoBehaviour
{
    [SerializeField] private float _speed = 0.65f;
    
    // Fix: Added this variable so Spawner.cs can access it
    public float gap; 

    private void Update()
    {
        transform.position += Vector3.left * _speed * Time.deltaTime;
    }
}