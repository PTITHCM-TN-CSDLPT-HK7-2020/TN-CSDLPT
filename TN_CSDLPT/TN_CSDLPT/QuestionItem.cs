using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TN_CSDLPT
{
    public partial class QuestionItem : UserControl
    {
        public QuestionItem()
        {
            InitializeComponent();
        }

        private int idBaiThi;
        private int idde;
        private int cauSo;
        private int cauBD;
        private string ndCauHoi;
        private string cauA;
        private string cauB;
        private string cauC;
        private string cauD;
        private string daChon = "";
        private string dapAn = "";

        [Category("Custom Props")]
        public int IDBaiThi
        {
            get { return idBaiThi; }
            set { idBaiThi = value; }
        }

        [Category("Custom Props")]
        public int IDDe
        {
            get { return idde; }
            set { idde = value; }
        }

        [Category("Custom Props")]
        public int CauBaiThi
        {
            get { return cauSo; }
            set
            {
                cauSo = value;
                lb_IndexQuestion.Text = "Câu " + cauSo + ": ";
            }
        }


        [Category("Custom Props")]
        public int CauBoDe
        {
            get { return cauBD; }
            set
            {
                cauBD = value;
            }
        }

        //câu hỏi
        [Category("Custom Props")]
        public string NDCauHoi
        {
            get { return ndCauHoi; }
            set
            {
                ndCauHoi = value;
                lb_ContentQuestion.Text = ndCauHoi;
            }
        }

        //câu A
        [Category("Custom Props")]
        public string CauA
        {
            get { return cauA; }
            set
            {
                cauA = value;
                rBtn_AnswerA.Text = cauA;
            }
        }
        //câu B
        [Category("Custom Props")]
        public string CauB
        {
            get { return cauB; }
            set
            {
                cauB = value;
                rBtn_AnswerB.Text = cauB;
            }
        }
        //câu C
        [Category("Custom Props")]
        public string CauC
        {
            get { return cauC; }
            set
            {
                cauC = value;
                rBtn_AnswerC.Text = cauC;
            }
        }
        //câu D
        [Category("Custom Props")]
        public string CauD
        {
            get { return cauD; }
            set
            {
                cauD = value;
                rBtn_AnswerD.Text = cauD;
            }
        }

        //câu đã chọn
        [Category("Custom Props")]
        public string CauDaChon
        {
            get { return daChon; }
            set { daChon = value; }
        }

        //câu đáp án
        [Category("Custom Props")]
        public string CauDapAn
        {
            get { return dapAn; }
            set { dapAn = value; }
        }

        private void rBtn_AnswerA_CheckedChanged(object sender, EventArgs e)
        {
            daChon = "A";
            var principalForm = Application.OpenForms.OfType<fmDoExam>().Single();
            principalForm.capNhapDaChon(cauSo, "A");
        }

        private void rBtn_AnswerB_CheckedChanged(object sender, EventArgs e)
        {
            daChon = "B";
            var principalForm = Application.OpenForms.OfType<fmDoExam>().Single();
            principalForm.capNhapDaChon(cauSo, "B");
        }

        private void rBtn_AnswerC_CheckedChanged(object sender, EventArgs e)
        {
            daChon = "C";
            var principalForm = Application.OpenForms.OfType<fmDoExam>().Single();
            principalForm.capNhapDaChon(cauSo, "C");          
        }

        private void rBtn_AnswerD_CheckedChanged(object sender, EventArgs e)
        {
            daChon = "D";
            var principalForm = Application.OpenForms.OfType<fmDoExam>().Single();
            principalForm.capNhapDaChon(cauSo, "D");
        }
    }
}
