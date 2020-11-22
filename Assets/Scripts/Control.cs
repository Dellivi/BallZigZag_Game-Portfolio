using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Scene {
    public class Control : MonoBehaviour
    {

        [SerializeField] private GameObject startBlock;
        [SerializeField] private GameObject mainBlock;
        [SerializeField] private GameObject endBlock;

        [SerializeField] private GameObject krystal;

        private int completeLevels = 0;


        void Start()
        {
            StartCoroutine(GenerateLevel());
        }  

        // Рандомная генерация уровня/блоков
        private IEnumerator GenerateLevel()
        {
            Vector3 size = new Vector3(1, 2, 1);
            Vector3 position = new Vector3(2, 0, -3);

            //Создание стартового блока 3х3
            GameObject newBlock = Instantiate(startBlock);
            newBlock.transform.position = new Vector3(0, 0.5f, 0);
            newBlock.transform.localScale = new Vector3(5, 1, 5);

            //Создание стартового блока
            newBlock = Instantiate(mainBlock);
            newBlock.transform.position = position;
        
        
            //Сколько блоков нужно создать. Возрастает по мере прохождения уровней.
            int count = completeLevels + 100;

            // Генерация основных блоков
            for (int i = 0; i < count; i++)
            {

                int rand = Random.Range(0, 2);
                int left = -1;

                if (rand == 0) { position.x += size.x; }
                else { position.z += size.z * left; }

                newBlock = Instantiate(mainBlock);

                newBlock.transform.position = position;
                newBlock.transform.localScale = size;

                //Создание кристаллов над блоками с шансом в 20%
                float chance = Random.Range(0f, 1f);

                if (chance <= 0.2f)
                {
                    Instantiate(krystal, new Vector3(newBlock.transform.position.x, 1f, newBlock.transform.position.z), Quaternion.identity);
                }

                yield return new WaitForEndOfFrame();
            }

            yield return new WaitForEndOfFrame();
        }


        public void CompleteLevel()
        {
            this.completeLevels += 1;
        }

    }
}

