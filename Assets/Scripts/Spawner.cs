using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private float _maxTime = 1.5f;
    [SerializeField] private float _heightRange = 0.45f;
    [SerializeField] private GameObject _pipe;

    // Fix 1: Changed 'timer' to '_timer' so it matches the code in Update()
    private float _timer; 

    private void Start()
    {
        SpawnPipe();
    }

    private void Update()
    {
        if (_timer > _maxTime)
        {
            // Fix 2: Added the missing semicolon here
            SpawnPipe(); 
            _timer = 0;
        }

        _timer += Time.deltaTime;
    }

    private void SpawnPipe()
    {
        Vector3 spawnPos = transform.position + new Vector3(0, Random.Range(-_heightRange, _heightRange));
        
        // Fix 3: Fixed typo 'Quanternion' -> 'Quaternion'
        GameObject pipe = Instantiate(_pipe, spawnPos, Quaternion.identity);

        Destroy(pipe, 10f);
    }
}