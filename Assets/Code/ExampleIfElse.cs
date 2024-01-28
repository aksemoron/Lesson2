using System;
using UnityEngine;

namespace Code
{
    public sealed class ExampleIfElse : MonoBehaviour
    {
        public int A;
        public int B;

        private void OnValidate()
        {
            Second();
        }

        private void First()
        {
            if (A > B)
            {
                Debug.LogError("A more B");
            }
        }
        
        private void Second()
        {
            // > =
            if (A >= B)
            {
                Debug.LogError("A more B");
            }
            else
            {
                Debug.LogError("B more A");
            }
        }
        
        private void Third()
        {
            if (A > B)
            {
                Debug.LogError("A more B");
            }
            else if (A < B)
            {
                Debug.LogError("B more A");
            }
            else
            {
                Debug.LogError("A equal B");
            }
        }
        
        private void Fourth(bool isCharacter, bool isDead)
        {
            if (isCharacter && !isDead)
            {
                Debug.LogError("Character is alive");
            }
        }
        
        private void Fifth()
        {
            int max = A > B ? A : B;
        }

        public int C;
        private void Sixth()
        {
            int max = A > B ? A > C ? A : C : B > C ? B : C;
            int maxTwo = 0;
            if (A > B)
            {
                if (A > C)
                {
                    maxTwo = A;
                }
                else
                {
                    maxTwo = C;
                }
            }
            else if (B > C)
            {
                maxTwo = B;
            }
            else
            {
                maxTwo = C;
            }

            Debug.LogError(max);
            Debug.LogError(maxTwo);
        }
    }
}
