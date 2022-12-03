using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int monsterNum = 10;
    public GameObject s1monster;
    // Start is called before the first frame update
    public GameObject rangeObject;
    BoxCollider rangeCollider;
    public int max = 0;

    public GameObject food;
    private void Awake()
    {
        rangeCollider = rangeObject.GetComponent<BoxCollider>();
    }

    Vector3 Return_RandomPosition()
    {
        Vector3 originPosition = rangeObject.transform.position;
        // 콜라이더의 사이즈를 가져오는 bound.size 사용
        float range_X = rangeCollider.bounds.size.x;
        float range_Z = rangeCollider.bounds.size.z;

        range_X = Random.Range((range_X / 2) * -1, range_X / 2);
        range_Z = Random.Range((range_Z / 2) * -1, range_Z / 2);
        Vector3 RandomPostion = new Vector3(range_X, 5.0f, range_Z);

        Vector3 respawnPosition = originPosition + RandomPostion;
        return respawnPosition;
    }

    void Start()
    {
        StartCoroutine(RandomRespawn_Coroutine());
    }

    // Update is called once per frame
    void Update()
    {
        Monster();
    }

    void Monster()
    {
        if(monsterNum == 0)
        {
            Debug.Log("다주금");
            food.SetActive(true);
        }
    }

    IEnumerator RandomRespawn_Coroutine()
    {
        while (max < 10)
        {
            yield return new WaitForSeconds(1f);

            // 생성 위치 부분에 위에서 만든 함수 Return_RandomPosition() 함수 대입
            GameObject Monster = Instantiate(s1monster, Return_RandomPosition(), Quaternion.identity);
            max++;
        }
    }
}
