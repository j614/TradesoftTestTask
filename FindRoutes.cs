using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace TradesoftTestTask
{
    class FindRoutes
    {
        static string newstart = "";
        static Regex pattern = new Regex("[:;,./\t\r -]");
        protected internal bool chek = false;
        int count = 1;


        public Analog[] Analogs { get; set; }
        public  int RecursionDepth;
        public PathForm pF;



        void print(List<string> str)
        {
            count++;
            pF.richTextBox1.Text += "Путь "+count+": ";
            foreach (string s in str) {
                pF.richTextBox1.Text += " " + s+"=>";
                }
            pF.richTextBox1.Text = pF.richTextBox1.Text.Remove(pF.richTextBox1.Text.Length - 2);
            pF.richTextBox1.Text += "\n";
        }
        public void RecursivePathfinding(string startArt, string startManuf, string endArt,string endManuf, int index=1, List<string> path=null,List<string> previousPath=null)
        {
            try
            {
                if (path == null)
                {
                    path = new List<String>();
                    previousPath = new List<String>();
                }
                index++;
                if (index >= RecursionDepth)
                {
                    if (!chek)
                    {
                        MessageBox.Show("Искомый товар "+endArt+"/"+endManuf+" не найден за "+ RecursionDepth.ToString()+" шагов");
                        return;
                    }
                    else return;
                }
                var analogs = Analogs.Where(a => pattern.Replace(a.articleOne, "") == pattern.Replace(startArt, "") && a.manufacturerOne.Equals(startManuf, StringComparison.OrdinalIgnoreCase));
                previousPath.Add(startArt+"/"+startManuf);
                foreach (Analog analog in analogs.ToArray())
                {
                    if ((Analogs.Where(a => pattern.Replace(a.articleOne, "") == pattern.Replace(analog.articleTwo, "")).FirstOrDefault() == null) && !newstart.Equals(endArt+"/"+endManuf, StringComparison.OrdinalIgnoreCase))
                    {
                        previousPath.Remove(analog.articleOne + "/" + analog.manufacturerOne);
                        path.Remove(analog.articleOne + "/" + analog.manufacturerOne);
                        path = previousPath;
                        continue;
                    }
                    else
                    {
                        if (!path.Contains(startArt + "/" + startManuf))
                        {
                            if (analog.confidence == 0)
                            {
                                path.Add(startArt + "/" + startManuf);
                                continue;
                            }
                            else
                                path.Add(startArt + "/" + startManuf);
                          
                        }
                    }

                    if (pattern.Replace(analog.articleTwo, "").Equals(pattern.Replace(endArt, ""), StringComparison.OrdinalIgnoreCase) && pattern.Replace(analog.manufacturerTwo, "").Equals(pattern.Replace(endManuf, ""), StringComparison.OrdinalIgnoreCase))
                    {
                        path.Add(analog.articleTwo + "/" + analog.manufacturerTwo);
                        chek = true;
                        print(path);
                        path.Remove(analog.articleTwo + "/" + analog.manufacturerTwo);
                        path = previousPath;
                        continue;

                    }
                    RecursivePathfinding(analog.articleTwo,analog.manufacturerTwo, endArt,endManuf, index, path, previousPath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Ошибка поиска", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
