using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class For : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for (var i = 0; i < 3; i++)
        {
            print(i);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
//var i = 0 - saya� olarak kullan�lacak bir de�i�ken bildirmek

//i < 3 - bu ko�ul her yinelemeden �nce kontrol edilir. Ko�ul do�ruysa, d�ng� yeniden yinelenir. Ko�ul yanl�� ise d�ng� sonland�r�l�r

//i++ - i = i + 1 ile ayn� �eydir; sadece i'ye 1 ekleriz

//print i - d�ng�n�n g�vdesi

//1.Saya� de�i�keni olu�turma
//var i = 0;
//2. 0 < 3 - do�rudur, yani d�ng� g�vdesi y�r�t�l�r
//3. print(i)
//4. i++
//5. D�ng�n�n ba��na d�n�yoruz. 1 < 3 - do�rudur, yani d�ng� g�vdesi y�r�t�l�r
//6. print(i)
//7. i++
//8. Bir kez daha d�ng�n�n ba��na d�n�yoruz. 2 < 3 - do�rudur, yani d�ng� g�vdesi y�r�t�l�r
//9. print(i)
//10. i++
//11. D�ng�n�n ba��na d�n�yoruz. 3 < 3 - yanl��t�r, yani d�ng� bozulur
// ... y�r�tme burada durur, ��nk� i == 3