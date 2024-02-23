using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShallowCopyAndDeepCopy
{
    // TODO : 깊은 복사 VS 얕은 복사 구현 (2024.02.22 jbh)
    // 참고 URL - https://cwkcw.tistory.com/389
    // 참고 2 URL - https://m.blog.naver.com/adonise007/220578209008

    // 깊은복사 VS 얕은복사 관련 디자인 패턴  
    // "GoF의 Design Pattern - 17. Prototype"
    // 유튜브 참고 URL - https://youtu.be/UPv8u9ndqAs?si=uoB7arIdDd4EGhuJ

    class cCopySample : ICloneable
    {
        public int iCopy;      // 값
        public char charCopy;  // 값 
        public int[] arrCopy  = new int[5];     // cCopySample 클래스 객체가 가진 참조 타입 멤버 arrCopy(int형 배열)
        public cField clsCopy = new cField();   // cCopySample 클래스 객체가 가진 참조 타입 멤버 clsCopy (cField 클래스 객체)

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

            // Array (새로운 배열 생성해서 값 복사 진행)
            copy.arrCopy = new int[5];
            for (int i = 0; i < 5; i++)
            {
                copy.arrCopy[i] = this.arrCopy[i];
            }

            // Class (새로운 객체 생성해서 값 복사 진행)
            copy.clsCopy = new cField();
            copy.clsCopy.iValue = this.clsCopy.iValue;

            return copy;
        }
    }
}
