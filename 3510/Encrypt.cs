using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace _3510_encryptionTest
{
    class Encrypt
    {
        //받아오는 값
        private string key;
        private string text;

        //암호판
        private char[,] encpan = new char[5,5];
        private string encpanEnter = "";//출력하는 암호판

        //재배치된 문자열
        private char[] textReloc;
        private string textRelocSpace = "";//출력하는 재배치문자열

        int xCnt = 0;

        public Encrypt(){}
        public Encrypt(string key, string text)
        {
            //공백제거해서 저장
            this.key = key.Replace(" ","");
            this.text = text.Replace(" ", "");
        }

        //키 중복제거
        public void deduplication()
        {
            char[] tmpkey = key.ToCharArray();
            for (int i = tmpkey.Length-1; i > 0; i--)
            {
                //0부터 i-1까지에 tmp[i]가 속해있으면 중복이므로 구별하기 위해 '0'넣기
                //(substring의 매개변수는 시작범위만 포함)
                if ((key.Substring(0, i)).Contains(tmpkey[i]))
                {
                    tmpkey[i] = '0';
                }
            }

            key = new string(tmpkey);
            key=key.Replace("0","");
        }

        // 문자열 재배치
        public void textRelocation()
        {
            //z는 q로 취급
            text = text.Replace("z", "q");

            char[] tmptext = text.ToCharArray();
            string tmptext2 = "";

            tmptext2 += tmptext[0];//첫글자 추가
            for (int i = 1; i < tmptext.Length; i++)
            {
                if (tmptext[i] == tmptext[i - 1] && tmptext2.Length % 2 == 1)
                {
                    tmptext2 += "x";//이전꺼와 같으면 x추가
                    xCnt++;
                }
                tmptext2 += tmptext[i];
            }
            if (tmptext2.Length % 2 != 0)
            {
                tmptext2 += "x";//홀수자리면 마지막에 x추가
                xCnt++;
            }

            textReloc = tmptext2.ToCharArray();

            //재배치 출력을 위해 띄어쓰기 넣기
            tmptext=tmptext2.ToCharArray();
            for (int i = 0; i < tmptext.Length; i++)
            {
                //방번호가 홀수-> 뒤에 " "넣기
                if (i % 2 == 1) textRelocSpace += (tmptext[i] + " ");
                else textRelocSpace += tmptext[i];
            }
        }

        //암호판 생성
        public void makeEncpan()
        {
            //키중복제거
            deduplication();
            string tmpenc = key;

            //z는 q로 취급
            tmpenc = tmpenc.Replace("z", "q");

            //a~y까지 중복없는 거 추가(z는 q와 같이 취급해서 포함x)
            for (char i = 'a'; i < 'z'; i++)
            {
                if (!tmpenc.Contains(i))
                {
                    tmpenc += i;
                }
            }

            //tmpenc의 내용을 2차원배열에 넣기
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    encpan[i,j] = tmpenc[i*5+j];
                }
            }

            //암호판 출력을 위해 5개마다 줄바꿈 넣기
            for (int i = 0; i < 5; i++)
            {
                encpanEnter += ("["+tmpenc.Substring(i * 5, 5)+"]");
            }
        }


        //암호화
        public string encryption()
        {
            string encText = "";

            //암호판에서의 문자열들 인덱스 저장(행, 열)
            int[,] index = new int[textReloc.Length, 2];

            for (int i = 0; i < textReloc.Length; i++)
            {
                for (int j = 0; j < 5; j++)//행
                {
                    for (int k = 0; k < 5; k++)//열
                    {
                        if (textReloc[i] == encpan[j, k])
                        {
                            index[i, 0] = j;
                            index[i, 1] = k;
                            break;
                        }
                    }
                }
            }

            for (int i = 0; i < textReloc.Length; i+=2)
            {
                int row = 0, col = 0;

                //같은 열일때 행+1,열그대로
                if (index[i, 1] == index[i + 1, 1])
                {
                    row = index[i, 1];

                    if (index[i, 0] + 1 > 4) col = 0;
                    else col = index[i, 0]+1;
                    encText += encpan[col, row];
                    
                    if (index[i+1, 0] + 1 > 4) col = 0;
                    else col = index[i+1, 0]+1;
                    encText += (encpan[col, row] + " ");
                }
                //같은 행일때 행그대로,열+1
                else if (index[i, 0] == index[i + 1, 0])
                {
                    col = index[i, 0];

                    if (index[i, 1] + 1 > 4) row = 0;
                    else row = index[i, 1] + 1;
                    encText += encpan[col, row];

                    if (index[i + 1, 1] + 1 > 4) row = 0;
                    else row = index[i + 1, 1] + 1;
                    encText += (encpan[col, row] + " ");
                }
                else
                {
                    col = index[i+1, 0];
                    row = index[i, 1];

                    encText += encpan[col, row];

                    col = index[i, 0];
                    row = index[i+1, 1];

                    encText += (encpan[col, row] + " ");
                }
            }

            return encText;
        }

        //복호화
        public string decode(string enc)
        {
            string decText = "";
            enc = enc.Replace(" ", "");
            char[] encT = enc.ToCharArray();//암호문

            //암호판에서의 문자열들 인덱스 저장(행, 열)
            int[,] index = new int[encT.Length, 2];

            for (int i = 0; i < encT.Length; i++)
            {
                for (int j = 0; j < 5; j++)//행
                {
                    for (int k = 0; k < 5; k++)//열
                    {
                        if (encT[i] == encpan[j, k])
                        {
                            index[i, 0] = j;
                            index[i, 1] = k;
                            break;
                        }
                    }
                }
            }

            for (int i = 0; i < encT.Length; i += 2)
            {
                int row = 0, col = 0;

                //같은 열일때 행-1,열그대로
                if (index[i, 1] == index[i + 1, 1])
                {
                    row = index[i, 1];

                    if (index[i, 0] - 1 < 0) col = 4;
                    else col = index[i, 0] - 1;
                    decText += encpan[col, row];

                    if (index[i + 1, 0] - 1 < 0) col = 4;
                    else col = index[i + 1, 0] - 1;
                    decText += (encpan[col, row] + " ");
                }
                //같은 행일때 행그대로,열-1
                else if (index[i, 0] == index[i + 1, 0])
                {
                    col = index[i, 0];

                    if (index[i, 1] - 1 < 0) row = 4;
                    else row = index[i, 1] - 1;
                    decText += encpan[col, row];

                    if (index[i + 1, 1] - 1 < 0) row = 4;
                    else row = index[i + 1, 1] - 1;
                    decText += (encpan[col, row] + " ");
                }
                else
                {
                    col = index[i + 1, 0];
                    row = index[i, 1];

                    decText += encpan[col, row];

                    col = index[i, 0];
                    row = index[i + 1, 1];

                    decText += (encpan[col, row] + " ");
                }
            }

            //공백없애고 x지우기
            decText=decText.Replace(" ","");
            string tmpdec = ""+decText[0];
            for (int i = 1; i < decText.Length; i++)
            {
                if (xCnt > 0 && decText[i]=='x')
                {
                    //마지막글자이고 평문이랑 길이가 똑같거나 엑스 양옆의 내용이 같으면 x빼기
                    if (((i == decText.Length - 1) && (tmpdec.Length == text.Length))||(decText[i - 1].Equals(decText[i + 1])))
                    {
                        Debug.WriteLine(tmpdec.Length + " " + text.Length);
                    
                        xCnt--;
                        continue;
                    }
                }
                tmpdec += decText[i];
            }

            //q를 q와 z라고 출력(읽는 사람의 센스에 따라...)
            tmpdec=tmpdec.Replace("q", "(q/z)");
            
            return tmpdec;
        }

        public string getKey()
        {
            return key;
        }

        public string getText()
        {
            return text;
        }

        public string getEncpanEnter()
        {
            return encpanEnter;
        }

        public string getTextRelocSpace()
        {
            return textRelocSpace;
        }
    }
}
