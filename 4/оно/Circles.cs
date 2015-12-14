using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.IO;
namespace оно
{
   
    class Circles
    {
        
        public  List<Rectangle> Areas;
        public List<KeyValuePair<int, int>>  copplines;
        public static List<Brush> Color;
        public static List<Brush> LineColor;
        public List<KeyValuePair<int,int> > lines;
        public List<int> timeAreas;
        public List<int> p;
        int time1;
        int timealgo;
        public Dictionary<int, List<KeyValuePair<int,int>>> g;
        public List<KeyValuePair<Point, Point>> Lines;
        public int n;
        public static int Compare1(KeyValuePair<int, int> a, KeyValuePair<int, int> b)
        {
            if (a.Value > b.Value)
            {
                return 1;
            }
            else
            {
                if (a.Value == b.Value)
                {
                    if (a.Key > b.Key)
                    {
                        return 1;
                    }
                   
                    if (a.Key == b.Key)
                        return 0;
                    return -1;
                }
                return -1;
            }
            
        }
        public void SortLines()
        {
            copplines.Sort(Compare1);
        }
        public  void BFS(int v, Graphics DrawGraphics, Color Background, ListBox myListBox, int time)
        {
            time1 = 0;
            for (int i = 0; i < Areas.Count; i++)
                p[i] = -1;
            bool []used = new bool[Areas.Count];
            Queue<int> q = new Queue<int>();
            used[v] = true;
            q.Enqueue(v);
            Color[v] = Brushes.Red;
            timeAreas[v] = time;
            Draw(DrawGraphics, Background, myListBox);
            Thread.Sleep(time);
            while (q.Count != 0)
            {
                int to = q.Dequeue();
             
                foreach (var element in g[to])
                {
                    if (!used[element.Key])
                    {
                        for (int j = 0; j < lines.Count; j++)
                        {
                            if (lines[j].Value == lines[element.Value].Value && lines[j].Key == lines[element.Value].Key || lines[j].Key == lines[element.Value].Value && lines[j].Value == lines[element.Value].Key)
                            { 
                                LineColor[j] = Brushes.YellowGreen;
                                
                            }
                        }
                        time++;
                        timeAreas[element.Key] = time;
                        used[element.Key] = true;
                        Color[element.Key] = Brushes.Red;
                        LineColor[element.Value] = Brushes.YellowGreen;
                        Draw(DrawGraphics, Background, myListBox);
                        p[element.Key] = to;
                        Thread.Sleep(time);
                        q.Enqueue(element.Key);
                    }
                }
            }

        }
        public void DFS(int v, Graphics DrawGraphics, Color Background, ListBox myListBox, ref int time,bool []used,int time1)
        {
            foreach (var element in g[v])
            {
                if (!used[element.Key])
                {
                    for (int j = 0; j < lines.Count; j++)
                    {
                        if (lines[j].Value == lines[element.Value].Value && lines[j].Key == lines[element.Value].Key || lines[j].Key == lines[element.Value].Value && lines[j].Value == lines[element.Value].Key)
                        {
                            LineColor[j] = Brushes.YellowGreen;

                        }
                    }
                    time++;
                    timeAreas[element.Key] = time;
                    used[element.Key] = true;
                    Color[element.Key] = Brushes.Red;
                    LineColor[element.Value] = Brushes.YellowGreen;
                    Draw(DrawGraphics, Background, myListBox);
                    p[element.Key] = v;
                    Thread.Sleep(time1);
                    DFS(element.Key, DrawGraphics, Background, myListBox, ref time, used,time1);

                }
            }
        }
    
        public void PreDFS(int v, Graphics DrawGraphics, Color Background, ListBox myListBox, int time1)
        {
           int time = 0;
            for (int i = 0; i < Areas.Count; i++)
                p[i] = -1;
            bool[] used = new bool[Areas.Count];
            used[v] = true;
            Color[v] = Brushes.Red;
            timeAreas[v] = time;
            Draw(DrawGraphics, Background, myListBox);
            Thread.Sleep(time);
            DFS(v,DrawGraphics,Background,myListBox,ref time,used,time1);
            

        }
        public Circles(string path)
        {
            using (StreamReader input = new StreamReader(path))
            {
                copplines = new List<KeyValuePair<int, int>>();
                var XY = input.ReadLine().Split(new char[] { ':',' ' },StringSplitOptions.RemoveEmptyEntries) ;
                Areas = new List<Rectangle>();
                Color = new List<Brush>();
                timeAreas = new List<int>();
                p = new List<int>();
                for (int i = 0; i < XY.Length; i+=2)
                {
                    p.Add(-1);
                    Color.Add(Brushes.Blue);
                    Areas.Add(new Rectangle(new Point(int.Parse(XY[i]) ,int.Parse(XY[i+1])), new Size(25, 25)));
                    timeAreas.Add(-1);
                }
                var linesinput = input.ReadLine().Split(new char[] { '.' ,' ' }, StringSplitOptions.RemoveEmptyEntries);
                Lines = new List<KeyValuePair<Point, Point>>();
                lines = new List<KeyValuePair<int, int>>();
                LineColor = new List<Brush>();
                for (int i = 0; i < linesinput.Length; i += 2)
                {
                    lines.Add(new KeyValuePair<int, int>(int.Parse(linesinput[i]), int.Parse(linesinput[i+1])));
                    LineColor.Add(Brushes.Black);
                    
                }
                n = Areas.Count;
                g = new Dictionary<int, List<KeyValuePair<int, int>>>(n);
                
            }
        }
        public Circles(TextBox a)
        {
            
              n = int.Parse(a.Text);
            p = new List<int>();
            copplines = new List<KeyValuePair<int, int>>();
            int y=30;
            Areas =  new List<Rectangle>();
            timeAreas = new List<int>();
            Color = new List<Brush>();
            for (int i = 0; i <n; i++)
            {
                p.Add(-1);
                Color.Add(Brushes.Blue);
                Areas.Add(new Rectangle(new Point(0, y), new Size(25, 25)));
                timeAreas.Add(-1);
                y += 40;               
            }
            Lines = new List<KeyValuePair<Point, Point>>();
            lines = new List<KeyValuePair<int, int>>();
            LineColor = new List<Brush>();
            g = new Dictionary<int, List<KeyValuePair<int,int>>>(n);
            
        }
        public void Add(Point click)
        {
            n++;
            Color.Add(Brushes.Blue);
            Areas.Add(new Rectangle(click, new Size(25, 25)));
            timeAreas.Add(-1);
            p.Add(-1);

        }

        public void Draw(Graphics DrawGraphics, Color BackGroundColor,ListBox list)
        {
            list.Items.Clear();
            if(lines.Count!=0)
                list.Items.Add(lines.Count);
            foreach (var temp in lines)
            {
                list.Items.Add(temp);
            }
            DrawGraphics.Clear(BackGroundColor);
            for (int i = 0; i < Areas.Count; i++)
            {
                DrawGraphics.FillEllipse(Color[i], Areas[i]);
                DrawGraphics.DrawString(i.ToString(),new Font(FontFamily.GenericSansSerif,10),Brushes.White,new Point(Areas[i].X+3,Areas[i].Y+3));
                
            }
         
            for (int i = 0; i < lines.Count; i++)
            {
                
              
                var pen = new Pen(LineColor[i], 2);
           
                var element = lines[i];
              
             
              
                    DrawGraphics.DrawLine(pen, new Point(Areas[element.Key].Location.X+3, Areas[element.Key].Location.Y+3 ),
                                new Point(Areas[element.Value].Location.X+3, Areas[element.Value].Location.Y +3));
                
            }
           
        }

      
    }
}
