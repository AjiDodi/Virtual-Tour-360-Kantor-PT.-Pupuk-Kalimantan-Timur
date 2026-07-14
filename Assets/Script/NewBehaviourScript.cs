using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    public Camera camera;
    //GameObject petunjuk;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray,out hit,100))
            {
                if (hit.collider.tag == "petunjuk"){
                    Debug.Log("berhasil pindah");
                    SceneManager.LoadScene("Scene1");       //hit.collider.gameObject now refers to the 
                                                            //cube under the mouse cursor if present
                }
                if (hit.collider.tag == "petunjuk2")
                {
                    Debug.Log("berhasil pindah");
                    SceneManager.LoadScene("Scene2");       //hit.collider.gameObject now refers to the 
                                                            //cube under the mouse cursor if present
                }
                if (hit.collider.tag == "petunjuk3")
                {
                    Debug.Log("berhasil pindah");
                    SceneManager.LoadScene("Scene3");

                }
                if (hit.collider.tag == "petunjuk4")
                {
                    Debug.Log("berhasil pindah");
                    SceneManager.LoadScene("Scene4");

                }
                if (hit.collider.tag == "petunjuk5")
                {
                    Debug.Log("berhasil pindah");
                    SceneManager.LoadScene("Scene5");

                }
                if (hit.collider.tag == "petunjuk5(5)")
                {
                    Debug.Log("berhasil pindah");
                    SceneManager.LoadScene("Scene5(5)");

                }
                if (hit.collider.tag == "petunjuk5(6)")
                {
                    Debug.Log("berhasil pindah");
                    SceneManager.LoadScene("Scene5(6)");

                }
                if (hit.collider.tag == "petunjuk5(7)")
                {
                    Debug.Log("berhasil pindah");
                    SceneManager.LoadScene("Scene5(7)");

                }
                if (hit.collider.tag == "petunjuk6")
                {
                    Debug.Log("berhasil pindah");
                    SceneManager.LoadScene("Scene6");

                }
                if (hit.collider.tag == "petunjuk7")
                {
                    Debug.Log("berhasil pindah");
                    SceneManager.LoadScene("Scene7");

                }
                if (hit.collider.tag == "petunjuk8")
                {
                    Debug.Log("berhasil pindah");
                    SceneManager.LoadScene("Scene8");

                }
                if (hit.collider.tag == "petunjuk9")
                {
                    Debug.Log("berhasil pindah");
                    SceneManager.LoadScene("Scene9");

                }
                if (hit.collider.tag == "petunjuk10")
                {
                    Debug.Log("berhasil pindah");
                    SceneManager.LoadScene("Scene10");

                }
                if (hit.collider.tag == "petunjuk11")
                {
                    Debug.Log("berhasil pindah");
                    SceneManager.LoadScene("Scene11");

                }
                if (hit.collider.tag == "petunjuk12")
                {
                    Debug.Log("berhasil pindah");
                    SceneManager.LoadScene("Scene12");

                }
                if (hit.collider.tag == "petunjuk13")
                {
                    Debug.Log("berhasil pindah");
                    SceneManager.LoadScene("Scene13");

                }
                if (hit.collider.tag == "petunjuk14")
                {
                    Debug.Log("berhasil pindah");
                    SceneManager.LoadScene("Scene14");

                }
                if (hit.collider.tag == "petunjuk15")
                {
                    Debug.Log("berhasil pindah");
                    SceneManager.LoadScene("Scene15");

                }
                if (hit.collider.tag == "petunjuk16")
                {
                    Debug.Log("berhasil pindah");
                    SceneManager.LoadScene("Scene16");

                }
                if (hit.collider.tag == "petunjuk17")
                {
                    Debug.Log("berhasil pindah");
                    SceneManager.LoadScene("Scene17");

                }
                if (hit.collider.tag == "petunjuk18")
                {
                    Debug.Log("berhasil pindah");
                    SceneManager.LoadScene("Scene18");

                }
                if (hit.collider.tag == "petunjuk19")
                {
                    Debug.Log("berhasil pindah");
                    SceneManager.LoadScene("Scene19");

                }
                if (hit.collider.tag == "petunjuk20")
                {
                    Debug.Log("berhasil pindah");
                    SceneManager.LoadScene("Scene20");

                }
                if (hit.collider.tag == "petunjuk21")
                {
                    Debug.Log("berhasil pindah");
                    SceneManager.LoadScene("Scene21");

                }
                if (hit.collider.tag == "petunjuk22")
                {
                    Debug.Log("berhasil pindah");
                    SceneManager.LoadScene("Scene22");

                }
                if (hit.collider.tag == "petunjuk23")
                {
                    Debug.Log("berhasil pindah");
                    SceneManager.LoadScene("Scene23");

                }
                if (hit.collider.tag == "petunjuk24")
                {
                    Debug.Log("berhasil pindah");
                    SceneManager.LoadScene("Scene24");

                }
                if (hit.collider.tag == "petunjuk25")
                {
                    Debug.Log("berhasil pindah");
                    SceneManager.LoadScene("Scene25");

                }
                if (hit.collider.tag == "petunjuk26")
                {
                    Debug.Log("berhasil pindah");
                    SceneManager.LoadScene("Scene26");

                }
                if (hit.collider.tag == "petunjuk27")
                {
                    Debug.Log("berhasil pindah");
                    SceneManager.LoadScene("Scene27");

                }
                if (hit.collider.tag == "petunjuk28")
                {
                    Debug.Log("berhasil pindah");
                    SceneManager.LoadScene("Scene28");

                }
                if (hit.collider.tag == "petunjuk29")
                {
                    Debug.Log("berhasil pindah");
                    SceneManager.LoadScene("Scene29");

                }
                if (hit.collider.tag == "petunjuk30")
                {
                    Debug.Log("berhasil pindah");
                    SceneManager.LoadScene("Scene30");

                }
                if (hit.collider.tag == "petunjuk31")
                {
                    Debug.Log("berhasil pindah");
                    SceneManager.LoadScene("Scene31");

                }
                if (hit.collider.tag == "petunjuk32")
                {
                    Debug.Log("berhasil pindah");
                    SceneManager.LoadScene("Scene32");

                }
                if (hit.collider.tag == "petunjuk33")
                {
                    Debug.Log("berhasil pindah");
                    SceneManager.LoadScene("Scene33");

                }
                if (hit.collider.tag == "petunjuk34")
                {
                    Debug.Log("berhasil pindah");
                    SceneManager.LoadScene("Scene34");

                }
                if (hit.collider.tag == "petunjuk34(1)")
                {
                    Debug.Log("berhasil pindah");
                    SceneManager.LoadScene("Scene34(1)");

                }
                if (hit.collider.tag == "petunjuk35")
                {
                    Debug.Log("berhasil pindah");
                    SceneManager.LoadScene("Scene35");

                }
                if (hit.collider.tag == "petunjuk36")
                {
                    Debug.Log("berhasil pindah");
                    SceneManager.LoadScene("Scene36");

                }
                if (hit.collider.tag == "petunjuk36(1)")
                {
                    Debug.Log("berhasil pindah");
                    SceneManager.LoadScene("Scene36(1)");

                }
                if (hit.collider.tag == "petunjuk36(2)")
                {
                    Debug.Log("berhasil pindah");
                    SceneManager.LoadScene("Scene36(2)");

                }
                if (hit.collider.tag == "petunjuk37")
                {
                    Debug.Log("berhasil pindah");
                    SceneManager.LoadScene("Scene37");

                }
                if (hit.collider.tag == "petunjuk37(1)")
                {
                    Debug.Log("berhasil pindah");
                    SceneManager.LoadScene("Scene37(1)");

                }
                if (hit.collider.tag == "petunjuk37(2)")
                {
                    Debug.Log("berhasil pindah");
                    SceneManager.LoadScene("Scene37(2)");

                }
                if (hit.collider.tag == "petunjuk38")
                {
                    Debug.Log("berhasil pindah");
                    SceneManager.LoadScene("Scene38");

                }
                if (hit.collider.tag == "petunjuk38(1)")
                {
                    Debug.Log("berhasil pindah");
                    SceneManager.LoadScene("Scene38(1)");

                }
                if (hit.collider.tag == "petunjuk38(2)")
                {
                    Debug.Log("berhasil pindah");
                    SceneManager.LoadScene("Scene38(2)");

                }
                if (hit.collider.tag == "petunjuk39")
                {
                    Debug.Log("berhasil pindah");
                    SceneManager.LoadScene("Scene39");

                }
                if (hit.collider.tag == "petunjuk40")
                {
                    Debug.Log("berhasil pindah");
                    SceneManager.LoadScene("Scene40");

                }
                if (hit.collider.tag == "petunjuk41")
                {
                    Debug.Log("berhasil pindah");
                    SceneManager.LoadScene("Scene41");

                }
                if (hit.collider.tag == "petunjuk42")
                {
                    Debug.Log("berhasil pindah");
                    SceneManager.LoadScene("Scene42");

                }
                if (hit.collider.tag == "petunjuk43")
                {
                    Debug.Log("berhasil pindah");
                    SceneManager.LoadScene("Scene43");

                }
                if (hit.collider.tag == "petunjuk44")
                {
                    Debug.Log("berhasil pindah");
                    SceneManager.LoadScene("Scene44");

                }
            }

            
        }
    } 

    public void CurrentClickedGameObject(GameObject gameObject)
    {
        if (gameObject.tag == "petunjuk")
        {
            Debug.Log("berhasil pindah");
        }
    }
}
