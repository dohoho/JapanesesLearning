using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JapaneseLearning
{
    public partial class Form1 : Form
    {
        
        private Dictionary<int, string> dicHiragana = new Dictionary<int, string>();
        private Dictionary<int, string> dicKatakana = new Dictionary<int, string>();
        private Random rd = new Random();
        public Form1()
        {
            InitializeComponent();
            for(int i = 1; i <= hiragana.Length; i++)
            {
                dicHiragana.Add(i, hiragana[i - 1]);
            }
            for(int j = 1; j <= katakana.Length; j++)
            {
                dicKatakana.Add(j, katakana[j - 1]);
            }
        }
        int i = 0;
        private void btnNext_Click(object sender, EventArgs e)
        {
            
            if (chkSenquence.Checked)
            {
                lbHiragana.Text = dicHiragana[i+1];
                lbRomajiKatakana.Text = lbRomaijHiragana.Text = romaji[i];
                lbKatakana.Text = dicKatakana[i + 1];
                previous = i;
                i++;
            }
            else
            {
                int a = rd.Next(0, 103);
                previous = a;
                lbHiragana.Text = dicHiragana[a+1];
                lbKatakana.Text = dicKatakana[a + 1];
                lbRomajiKatakana.Text = lbRomaijHiragana.Text = romaji[a];
            }
            ShowHideRomajiHiragana();
        }
        int previous = 0;
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            previous = previous == 0 ? 103 : previous;
            lbHiragana.Text = dicHiragana[previous + 1];
            lbRomaijHiragana.Text = romaji[previous];
            previous--;
            ShowHideRomajiHiragana();
        }
        private void chkShowRomaji_CheckedChanged(object sender, EventArgs e)
        {
            ShowHideRomajiHiragana();
        }

        private void ShowHideRomajiHiragana()
        {
            if (chkShowRomaji.Checked)
            {
                lbRomaijHiragana.Show();
            }
            else
            {
                lbRomaijHiragana.Hide();
            }
        }
        private string[] katakana = {"ア","イ","ウ","エ","オ",
                                    "カ","キ","ク","ケ","コ",
                                    "サ","シ","ス","セ","ソ",
                                    "タ","チ","ツ","テ","ト",
                                    "ナ","ニ","ヌ","ネ","ノ",
                                    "ハ","ヒ","フ","ヘ","ホ",
                                    "マ","ミ","ム","メ","モ",
                                    "ヤ","ユ","ヨ",
                                    "ラ","リ","ル","レ","ロ",
                                    "ワ","ヲ","ン",
                                    "ガ","ギ","グ","ゲ","ゴ",
                                    "ザ","ジ","ズ","ゼ","ゾ",
                                    "ダ","ヂ","ヅ","デ","ド",
                                    "バ","ビ","ブ","ベ","ボ",
                                    "パ","ピ","プ","ペ","ポ"
                                    };
        private string[] hiragana =    {"あ","い","う","え","お",
                                        "か","き","く","け","こ",
                                        "さ","し","す","せ","そ",
                                        "た","ち","つ","て","と",
                                        "な","に","ぬ","ね","の",
                                        "は","ひ","ふ","へ","ほ",
                                        "ま","み","む","め","も",
                                        "や","ゆ","よ",
                                        "ら","り","る","れ","ろ",
                                        "わ","を","ん",
                                       "が","ぎ","ぐ","げ","ご",
                                        "ざ","じ","ず","ぜ","ぞ",
                                        "だ","ぢ","ふ","で","ど",
                                        "ば","び","ぶ","べ","ぼ",
                                        "ぱ","ぴ","ぷ","ぺ","ぽ",
                                        "きゃ","きゅ","きょ",
                                        "しゃ","しゅ","しょ",
                                        "ちゃ","ちゅ","ちょ",
                                        "にゃ","にゅ","にょ",
                                        "ひゃ","ひゅ","ひょ",
                                        "みゃ","みゅ","みょ",
                                        "りゃ","りゅ","りょ",
                                        "ぎゃ","ぎゅ","ぎょ",
                                        "じゃ","じゅ","じょ",
                                        "びゃ","びゅ","びょ",
                                        "ぴゃ","ぴゅ","ぴょ"
                                       };
        private string[] romaji = { "a","i","u","e","o",
                                      "ka","ki","ku","ke","ko",
                                      "sa","shi","su","se","so",
                                      "ta","chi","tsu","te","to",
                                      "na","ni","nu","ne","no",
                                      "ha","hi","fu","he","ho",
                                      "ma","mi","mu","me","mo",
                                      "ya","yu","yo",
                                      "ra","ri","ru","re","ro",
                                      "wa","wo","n",
                                      "ga","gi","gu","ge","go",
                                       "za","zi","zu","ze","zo",
                                       "da","di","du","de","do",
                                        "ba","bi","bu","be","bo",
                                        "pa","pi","pu","pe","po",
                                        "kya","kyu","kyo",
                                        "sha","shu","sho",
                                        "cha","chu","cho",
                                        "nya","nyu","nyo",
                                        "hya","hyu","hyo",
                                        "mya","myu","myo",
                                        "rya","ryu","ryo",
                                        "gya","gyu","gyo","jya",
                                        "jyu","jyo","bya","byu",
                                        "byo","pya","pyu","pyo"
                                  };

        

        
    }
}
