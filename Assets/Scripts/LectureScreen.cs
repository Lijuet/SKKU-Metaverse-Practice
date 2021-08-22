using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LectureScreen : MonoBehaviour
{
    string test_info;
    public string nextSceneName = "LectureScreenScene";

    // Start is called before the first frame update
    void Start()
    {
        // Load Student Information
        test_info = "I am student";
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)){
            LoadNextScene();
        }
    }

    public void LoadNextScene(){
      // 비동기적으로 Scene을 불러오기 위해 Coroutine을 사용한다.
      StartCoroutine(LoadMyAsyncScene());
    }

    IEnumerator LoadMyAsyncScene()
    {    
    // AsyncOperation을 통해 Scene Load 정도를 알 수 있다.
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(nextSceneName);

        // Scene을 불러오는 것이 완료되면, AsyncOperation은 isDone 상태가 된다.
        while (!asyncLoad.isDone)
        {
            yield return null;
        }
    }
}
