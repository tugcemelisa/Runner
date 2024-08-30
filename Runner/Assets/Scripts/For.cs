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
//var i = 0 - sayaç olarak kullanýlacak bir deðiþken bildirmek

//i < 3 - bu koþul her yinelemeden önce kontrol edilir. Koþul doðruysa, döngü yeniden yinelenir. Koþul yanlýþ ise döngü sonlandýrýlýr

//i++ - i = i + 1 ile ayný þeydir; sadece i'ye 1 ekleriz

//print i - döngünün gövdesi

//1.Sayaç deðiþkeni oluþturma
//var i = 0;
//2. 0 < 3 - doðrudur, yani döngü gövdesi yürütülür
//3. print(i)
//4. i++
//5. Döngünün baþýna dönüyoruz. 1 < 3 - doðrudur, yani döngü gövdesi yürütülür
//6. print(i)
//7. i++
//8. Bir kez daha döngünün baþýna dönüyoruz. 2 < 3 - doðrudur, yani döngü gövdesi yürütülür
//9. print(i)
//10. i++
//11. Döngünün baþýna dönüyoruz. 3 < 3 - yanlýþtýr, yani döngü bozulur
// ... yürütme burada durur, çünkü i == 3