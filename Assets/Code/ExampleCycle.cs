using System;
using UnityEngine;

namespace Code
{
    public sealed class ExampleCycle : MonoBehaviour
    {
        private void OnValidate()
        {
            ExampleFor();
        }

        private void First()
        {
            Debug.LogError("Mom");
            Debug.LogError("Mom");
            Debug.LogError("Mom");
            Debug.LogError("Mom");
            Debug.LogError("Mom");
            Debug.LogError("Mom");
            Debug.LogError("Mom");
            Debug.LogError("Mom");
            Debug.LogError("Mom");
            Debug.LogError("Mom");
        }

        private int ExampleRecursion(int n)
        {
            return ExampleRecursion(n - 1) + ExampleRecursion(n - 2);
        }

        private int ExampleFor(int n)
        {
            int a0 = 0;
            int a1 = 1;
            int temp = 0;
            for (int i = 0; i <= n; i++)
            {
                temp = a0 + a1;
                a0 = a1;
                a1 = temp;
            }

            return temp;
        }
        
        private void ExampleFor()
        {
            for (int i = 10; i > 0; i--)
            {
                Debug.LogError("Mom");
                Debug.LogError($"{i}");
            }
        }
        
        private void ExampleDoWhile(int n)
        {
            int count = 0;
            do
            {
                count++;
                n /= 10;
            } while (n != 0);

            Debug.LogError(count);
        }

        private void ExampleWhile(int n)
        {
            int count = 0;
            while (n != 0)
            {
                count++;
                n /= 10;
            } 
            Debug.LogError(count);
        }

        private void ExampleForeach()
        {
            string str = "Roman";
            foreach (char i in str)
            {
                if (i == 'm')
                {
                    break;
                    //continue;
                    //return;
                }
                Debug.LogError(i);
            }
            Debug.LogError("ExampleForeach");
        }

        private void NameMethod(Character character)
        {
            bool isDead = false;
            do
            {
                character.Damage(100);
                isDead = character.IsDead;
            } while (!isDead);
        }
    }
}
