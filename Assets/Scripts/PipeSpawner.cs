using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject pipe;
    public float spawnRate = 2;
    public float heightOffset = 10;
    private float timer = 0;
    void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate){
            timer = timer + Time.deltaTime;
        }
        else{
        spawnPipe();
        timer = 0;
        }
    }
void spawnPipe()
{
    //Gap between pipes was too small
    float gapSize = 3f; 
    //Getting bounds
    float screenTop = Camera.main.orthographicSize - 1; 
    float screenBottom = -Camera.main.orthographicSize + 1; 
// Making sure top & bottom pipes have enough space in between and not too far to be in the bound
    float randomY = Random.Range(screenBottom + gapSize / 2, screenTop - gapSize / 2);
    GameObject newPipe = Instantiate(pipe, new Vector3(transform.position.x, randomY, 0), Quaternion.identity);
    Transform topPipe = newPipe.transform.Find("TopPipe");
    Transform bottomPipe = newPipe.transform.Find("BottomPipe");

    if (topPipe != null && bottomPipe != null)
    {
        topPipe.position = new Vector3(topPipe.position.x, randomY + gapSize / 2, topPipe.position.z);
        bottomPipe.position = new Vector3(bottomPipe.position.x, randomY - gapSize / 2, bottomPipe.position.z);
    }
}


}
