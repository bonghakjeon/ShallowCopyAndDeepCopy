using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShallowCopyAndDeepCopy
{
    // TODO : 깊은 복사 VS 얕은 복사 구현 (2024.02.22 jbh)
    // 참고 URL - https://cwkcw.tistory.com/389
    class cCopySample : ICloneable
    {
        public int iCopy;      // 값
        public char charCopy;  // 값 
        public int[] arrCopy  = new int[5];     // 참조 
        public cField clsCopy = new cField();   // 참조

        /// <summary>
        /// 얕은 복사(ShallowCopy)
        /// </summary>
        public object ShallowCopy()
        {
            return this.MemberwiseClone();
        }

        /// <summary>
        /// 깊은 복사(Deep Copy)
        /// </summary>
        public object Clone()
        {
            cCopySample copy = this.MemberwiseClone() as cCopySample;

            // Array
            copy.arrCopy = new int[5];
            for (int i = 0; i < 5; i++)
            {
                copy.arrCopy[i] = this.arrCopy[i];
            }

            // Class (새로운 객체 생성)
            copy.clsCopy = new cField();
            copy.clsCopy.iValue = this.clsCopy.iValue;

            return copy;
        }
    }
}
