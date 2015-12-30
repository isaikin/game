using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace оно
{

    public partial class Form1 : Form
    {
     
          
        Circles myCircles;
        bool FirstTimeCLicked;
        bool check;
        bool checkDFS;
        int time;
        Point FirstClick;
        Point Addclick;
        int Pointer;
        bool isStarted;
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            FirstTimeCLicked = false;
            check = false;
            listBox1.Enabled = false;
            listBox1.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            myCircles.Draw(this.CreateGraphics(),this.BackColor,listBox1);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if(isStarted)
                myCircles.Draw(e.Graphics, this.BackColor, listBox1);
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)      
        {
            if (checkDFS)
            {
                for (int i = 0; i < myCircles.n; i++)
                {
                    if (myCircles.Areas[i].IntersectsWith(new Rectangle(new Point(e.X, e.Y), new Size(2, 2))))
                    {

                        FirstClick = new Point(e.X, e.Y);
                        if (myCircles.timeAreas[i] == time)
                        {
                            for (int j = 0; j < myCircles.lines.Count; j++)
                            {

                                if (myCircles.lines[j].Key == i && myCircles.lines[j].Value == myCircles.p[i] ||
                                    myCircles.lines[j].Value == i && myCircles.lines[j].Key == myCircles.p[i])
                                    Circles.LineColor[j] = Brushes.YellowGreen;

                            }

                            time++;
                            Circles.Color[i] = Brushes.Red;
                            myCircles.Draw(this.CreateGraphics(), this.BackColor, listBox1);
                            if (time >= myCircles.Areas.Count)
                            {
                                checkDFS = false;
                                сбросToolStripMenuItem_Click(sender, e);
                                MessageBox.Show("Finish");


                            }
                        }
                    
                    else
                    {
                        MessageBox.Show("Game Over");
                        сбросToolStripMenuItem_Click(sender, e);
                        checkDFS = false;
                        return;
                    }
                         }
                }
            }
            else
            {
                if (check)
                {

                    for (int i = 0; i < myCircles.n; i++)
                    {
                        if (myCircles.Areas[i].IntersectsWith(new Rectangle(new Point(e.X, e.Y), new Size(2, 2))))
                        {

                            FirstClick = new Point(e.X, e.Y);
                            if (myCircles.timeAreas[i] == time)
                            {
                                for (int j = 0; j < myCircles.lines.Count; j++)
                                {

                                    if (myCircles.lines[j].Key == i && myCircles.lines[j].Value == myCircles.p[i] ||
                                        myCircles.lines[j].Value == i && myCircles.lines[j].Key == myCircles.p[i])
                                        Circles.LineColor[j] = Brushes.YellowGreen;

                                }

                                time++;
                                Circles.Color[i] = Brushes.Red;
                                myCircles.Draw(this.CreateGraphics(), this.BackColor, listBox1);
                                if (time >= myCircles.Areas.Count)
                                {
                                    check = false;
                                    сбросToolStripMenuItem_Click(sender, e);
                                    MessageBox.Show("Finish");


                                }


                            }
                            else
                            {
                                MessageBox.Show("Game Over");
                                сбросToolStripMenuItem_Click(sender, e);
                                check = false;
                                return;
                            }

                            myCircles.Draw(this.CreateGraphics(), this.BackColor, listBox1);
                            return;
                        }
                    }
                    myCircles.Draw(this.CreateGraphics(), this.BackColor, listBox1);


                    Pointer = -1;
                }
                else
                {

                    if (myCircles == null)
                    {
                        MessageBox.Show("Создейте вершины");
                        return;
                    }
                    if (!FirstTimeCLicked)
                    {
                        for (int i = 0; i < myCircles.n; i++)
                        {
                            if (myCircles.Areas[i].IntersectsWith(new Rectangle(new Point(e.X, e.Y), new Size(2, 2))))
                            {
                                FirstTimeCLicked = true;
                                FirstClick = new Point(e.X, e.Y);
                                Pointer = i;
                                Circles.Color[i] = Brushes.Black;
                                myCircles.Draw(this.CreateGraphics(), this.BackColor, listBox1);
                                return;
                            }
                        }
                        myCircles.Draw(this.CreateGraphics(), this.BackColor, listBox1);

                        FirstTimeCLicked = false;
                        Pointer = -1;
                    }
                    else
                    {
                        var temp1 = new Rectangle(listBox1.Location, listBox1.Size);
                        if (temp1.IntersectsWith(new Rectangle(e.Location, new Size(2, 2))))
                            return;
                        for (int i = 0; i < myCircles.n; i++)
                        {
                            if (myCircles.Areas[i].IntersectsWith(new Rectangle(new Point(e.X, e.Y), new Size(2, 2))))
                            {
                                if (Pointer == i)
                                {
                                    Circles.Color[Pointer] = Brushes.Blue;
                                    myCircles.Draw(this.CreateGraphics(), this.BackColor, listBox1);
                                    Pointer = -1;

                                    return;
                                }

                                FirstTimeCLicked = false;
                                if (Pointer != -1)
                                {
                                    Circles.Color[Pointer] = Brushes.Blue;
                                    var temp = new KeyValuePair<int, int>(Pointer, i);
                                    bool flag = true;
                                    foreach (var t in myCircles.lines)
                                    {
                                        if (temp.Key == t.Key && t.Value == temp.Value)
                                        {
                                            flag = false;
                                        }

                                    }
                                    if (flag)
                                    {

                                        myCircles.lines.Add(temp);

                                        myCircles.lines.Add(new KeyValuePair<int, int>(i, Pointer));
                                        Circles.LineColor.Add(Brushes.Black);
                                        Circles.LineColor.Add(Brushes.Black);

                                        myCircles.Draw(this.CreateGraphics(), this.BackColor, listBox1);
                                    }
                                }

                                Pointer = -1;
                                return;

                            }
                        }
                        if (Pointer != -1)
                        {
                            var tempRectangle = myCircles.Areas[Pointer];
                            tempRectangle.X = e.X;
                            tempRectangle.Y = e.Y;
                            myCircles.Areas.RemoveAt(Pointer);
                            Circles.Color[Pointer] = Brushes.Blue;
                            myCircles.Areas.Insert(Pointer, tempRectangle);
                            myCircles.Draw(this.CreateGraphics(), this.BackColor, listBox1);
                            FirstTimeCLicked = false;
                        }
                        Pointer = -1;
                        Addclick = new Point(-1, -1);
                        return;

                    }
                }

            }
        }
      
        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                myCircles = new Circles(textBox1);
                button1.Enabled = false;
                this.button1.Hide();
                this.textBox1.Hide();
                this.textBox1.Enabled = false;
                isStarted = true;
                myCircles.Draw(this.CreateGraphics(), this.BackColor, listBox1);
            }
            catch (FormatException r)
            {
                MessageBox.Show(r.Message);
            }
            
        }

       
       

        private void новыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.CreateGraphics().Clear(this.BackColor);
            button1.Enabled = true;
            this.button1.Show();
            this.textBox1.Show();
            this.textBox1.Text = "";
            this.textBox1.Enabled = true;
        }

     
        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            for (int i = 0; i < myCircles.n; i++)
            {
                if (!myCircles.Areas[i].IntersectsWith(new Rectangle(new Point(e.X, e.Y), new Size(5, 5))))
                {
                    myCircles.Add(new Point(e.X, e.Y));
                    myCircles.Draw(this.CreateGraphics(), this.BackColor, listBox1);
                    Addclick = new Point(-1, -1);
                    return;
                }

            }
          
            
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button==MouseButtons.Right && !check)
            {
                for (int i = 0; i < myCircles.Areas.Count; i++)
                {
                    if (myCircles.Areas[i].IntersectsWith(new Rectangle(new Point(e.X, e.Y), new Size(3, 3))))
                    {
                        myCircles.Areas.RemoveAt(i);
                        myCircles.timeAreas.RemoveAt(i);
                        Circles.Color.RemoveAt(i);
                        for (int j = 0; j < myCircles.lines.Count; j++)
                        {
                            if (myCircles.lines[j].Key == i || myCircles.lines[j].Value == i)
                            {
                                myCircles.lines.RemoveAt(j);
                                Circles.LineColor.RemoveAt(j);
                                j = -1;
                            }
                        }
                        for (int j = 0; j < myCircles.lines.Count; j++)
                        {
                            if (myCircles.lines[j].Key > i )
                            {
                                var temp = new KeyValuePair<int, int>(myCircles.lines[j].Key-1, myCircles.lines[j].Value);
                                myCircles.lines.RemoveAt(j);
                                myCircles.lines.Insert(j,temp);
                               

                            }
                            if (myCircles.lines[j].Value > i)
                            {
                                var temp = new KeyValuePair<int, int>(myCircles.lines[j].Key , myCircles.lines[j].Value-1);
                                myCircles.lines.RemoveAt(j);
                                myCircles.lines.Insert(j, temp);


                            }
                        }
                        myCircles.Draw(this.CreateGraphics(), this.BackColor, listBox1);
                        
                        myCircles.n--;
                        return;
                    }
                }
            }

        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Control a = new Control();
            System.Windows.Forms.Help.ShowHelp(a, " readme.txt");
            
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {

            string path = "" ;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                        saveFileDialog1.DefaultExt="txt";
                    
                    path = saveFileDialog1.FileName;
                    {
                       
                        
                        using (StreamWriter a = new StreamWriter(path,false))
                        {
                            foreach (var element in myCircles.Areas)
                                a.Write("{0}:{1} ",element.X,element.Y);
                            a.WriteLine();
                            
                            foreach (var element in myCircles.lines)
                            {
                                a.Write("{0}.{1} ", element.Key, element.Value);
                            }

                                
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void всавитьГрафToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string path = "";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    
                     path =openFileDialog1.FileName;
                    myCircles = new Circles(path);
                    button1.Enabled = false;
                    this.button1.Hide();
                    this.textBox1.Hide();
                    this.textBox1.Enabled = false;
                    myCircles.Draw(this.CreateGraphics(), this.BackColor, listBox1);
                    isStarted = true;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void визуализацияDfsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool r = false;
            for (int i = 0; i < Circles.Color.Count; i++)
            {
                if (Circles.Color[i] == Brushes.Black)
                {
                    Pointer = i;
                    r = true;
                    break;
                }

            }

            if (!r)
            {

                MessageBox.Show("Выделите вершину начала");
                return;
            }
            myCircles.copplines = myCircles.lines;
            myCircles.SortLines();
            myCircles.g.Clear();
            myCircles.lines.OrderBy(S => S.Key);
            for (int i = 0; i < myCircles.Areas.Count; i++)
            {
                List<KeyValuePair<int, int>> temp = new List<KeyValuePair<int, int>>();
                for (int j = 0; j < myCircles.lines.Count; j++)
                {
                    if (myCircles.lines[j].Key == i)
                    {
                        temp.Add(new KeyValuePair<int, int>(myCircles.lines[j].Value, j));

                    }
                }
                myCircles.g.Add(i, temp);
               
            }
            myCircles.PreDFS(Pointer, this.CreateGraphics(), this.BackColor, listBox1, 2000);
            MessageBox.Show("Finish");
            Pointer = -1;
        }

        private void визуализацияBfsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            bool r = false;
            for (int i = 0; i < Circles.Color.Count; i++)
            {
                if (Circles.Color[i] == Brushes.Black)
                {
                    Pointer = i;
                    r = true;
                    break;
                }

            }

            if (!r)
            {

                MessageBox.Show("Выделите вершину начала");
                return;
            }
            myCircles.copplines = myCircles.lines;
            myCircles.SortLines();
            myCircles.g.Clear();
            myCircles.lines.OrderBy(S => S.Key);
            for (int i = 0; i < myCircles.Areas.Count; i++)
            {
                List<KeyValuePair<int, int>> temp = new List<KeyValuePair<int, int>>();
                for (int j = 0; j < myCircles.lines.Count; j++)
                {
                    if (myCircles.lines[j].Key == i)
                    {
                        temp.Add(new KeyValuePair<int, int>(myCircles.lines[j].Value, j));

                    }
                }
                myCircles.g.Add(i, temp);
            }
           
            myCircles.BFS(Pointer, this.CreateGraphics(), this.BackColor, listBox1,2000);
            MessageBox.Show("Finish");
            Pointer = -1;
        }

        private void сбросToolStripMenuItem_Click(object sender, EventArgs e)
        {
            check = false;
            checkDFS = false;
            for (int i = 0; i < Circles.Color.Count; i++)
            {
                myCircles.timeAreas[i] = -1;
                Circles.Color[i] = Brushes.Blue;
            }
            for (int i = 0; i < Circles.LineColor.Count; i++)
            {

                Circles.LineColor[i] = Brushes.Black;
            }
            myCircles.Draw(this.CreateGraphics(), this.BackColor, listBox1);
        }

        private void проверкаBfsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myCircles.copplines = myCircles.lines;
            myCircles.SortLines();
            myCircles.g.Clear();
            time = 1;
            for (int i = 0; i < myCircles.Areas.Count; i++)
            {
                List<KeyValuePair<int, int>> temp = new List<KeyValuePair<int, int>>();
                for (int j = 0; j < myCircles.lines.Count; j++)
                {
                    if (myCircles.lines[j].Key == i)
                    {
                        temp.Add(new KeyValuePair<int, int>(myCircles.lines[j].Value, j));

                    }
                }
                myCircles.g.Add(i, temp);
            }
            Random ran = new Random();
            int v = ran.Next(0, myCircles.Areas.Count);
            myCircles.BFS(v, this.CreateGraphics(), this.BackColor, listBox1, 0);
            for (int i = 0; i < Circles.Color.Count; i++)
            {
                Circles.Color[i] = Brushes.Blue;
            }
            for (int i = 0; i < Circles.LineColor.Count; i++)
            {

                Circles.LineColor[i] = Brushes.Black;
            }
            check = true;
            time = 1;
            Circles.Color[v] = Brushes.Red;
            myCircles.Draw(this.CreateGraphics(), this.BackColor, listBox1);


        }

        private void проверкаDfsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myCircles.copplines = myCircles.lines;
            myCircles.SortLines();
            myCircles.g.Clear();
            time = 1;
            for (int i = 0; i < myCircles.Areas.Count; i++)
            {
                List<KeyValuePair<int, int>> temp = new List<KeyValuePair<int, int>>();
                for (int j = 0; j < myCircles.lines.Count; j++)
                {
                    if (myCircles.lines[j].Key == i)
                    {
                        temp.Add(new KeyValuePair<int, int>(myCircles.lines[j].Value, j));

                    }
                }
                myCircles.g.Add(i, temp);
            }
            Random ran = new Random();
            int v = ran.Next(0, myCircles.Areas.Count);
            myCircles.PreDFS(v, this.CreateGraphics(), this.BackColor, listBox1,0);
            for (int i = 0; i < Circles.Color.Count; i++)
            {
                Circles.Color[i] = Brushes.Blue;
            }
            for (int i = 0; i < Circles.LineColor.Count; i++)
            {

                Circles.LineColor[i] = Brushes.Black;
            }
            checkDFS = true;
            time = 1;
            Circles.Color[v] = Brushes.Red;
            myCircles.Draw(this.CreateGraphics(), this.BackColor, listBox1);

        }
    }
}
