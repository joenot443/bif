using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {
	public int zone;
	public float difficulty;
	public long score;
	public Rigidbody2D baseObstacle;
	
	public enum OBJECT_TYPE {
		ANVIL = 0,
		BIRD,
		PLANE,
		SQUIRREL,
		CLOUD
	};
	
	private float obstacleTimer;
	
	// Use this for initialization
	void Start () {
		obstacleTimer = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
		float timeDiff = Time.time - obstacleTimer;
		if(timeDiff > difficulty){
			SpawnObstacle(OBJECT_TYPE.ANVIL);
			obstacleTimer = Time.time;
		}
	}
	
	void SpawnObstacle (OBJECT_TYPE obstacleId) {
		float x = Random.Range(-2,2); // Window.getsize()
		float y = -5.0f;		
		Rigidbody2D obs = Instantiate(baseObstacle,new Vector3(x,y,0),this.transform.rotation) as Rigidbody2D;

		BaseObstacle gc = obs.GetComponent<BaseObstacle>();
		
		gc.speed = 15.0f;	
//		obs.speed = 15;
	}
}