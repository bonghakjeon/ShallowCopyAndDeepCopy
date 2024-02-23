using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShallowCopyAndDeepCopy
{
    // TODO : 깊은 복사 VS 얕은 복사 구현 (2024.02.22 jbh)
    // 참고 URL - https://cwkcw.tistory.com/389
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        cCopySample cOrg;

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 원본 데이터 이벤트 메서드 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOrigin_Click(object sender, EventArgs e)
        {
            cOrg = new cCopySample();
            cOrg.iCopy = int.Parse(tboxInt.Text);
            cOrg.charCopy = char.Parse(tboxChar.Text);
            cOrg.arrCopy  = new int[] { int.Parse(tboxIntArray.Text), 0, 0, 0, 0 };
            cOrg.clsCopy.iValue = int.Parse(tboxClassNumber.Text);

            lblOriginData.Text = $"{cOrg.iCopy}, {cOrg.charCopy}, [{String.Join(",", cOrg.arrCopy)}], {cOrg.clsCopy.iValue}";
        }

        /// <summary>
        /// 깊은 복사 + 얕은 복사 이벤트 메서드 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (rdoEqual.Checked)
            {
                gbox.Text = "a = b";
                fEqual();
            }
            else if (rdoShallowCopy.Checked)
            {
                gbox.Text = "Shallow Copy";
                fShallowCopy();
            }
            else if (rdoDeepCopy.Checked)
            {
                gbox.Text = "Deep Copy";
                fDeepCopy();
            }
        }

        private void fEqual()
        {
            cCopySample cOrgRef = cOrg;   // cOrg를 cOrgRef에 참조(연결)해 준다.
            fCopy(cOrgRef);
        }

        private void fShallowCopy()
        {
            cCopySample cShallow = (cCopySample)cOrg.ShallowCopy();   // 얕은 복사 진행 (복사본 객체 cShallow 생성)
            fCopy(cShallow);
        }

        private void fDeepCopy()
        {
            cCopySample cDeep = (cCopySample)cOrg.Clone();   // 깊은 복사 진행 
            fCopy(cDeep);
        }

        private void fCopy(cCopySample cData)
        {
            cData.iCopy = int.Parse(tboxInt.Text);
            cData.charCopy = char.Parse(tboxChar.Text);
            cData.arrCopy[0] = int.Parse(tboxIntArray.Text);
            cData.clsCopy.iValue = int.Parse(tboxClassNumber.Text);

            lblCopyData.Text = $"{cData.iCopy}, {cData.charCopy}, [{String.Join(",", cData.arrCopy)}], {cData.clsCopy.iValue}";

            // 변경 후 Org Data
            lblOrgData.Text = $"{cOrg.iCopy}, {cOrg.charCopy}, [{String.Join(",", cOrg.arrCopy)}], {cOrg.clsCopy.iValue}";
        }
    }
}