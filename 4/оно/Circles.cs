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
        public static List<Brush> Color;
        public static List<Brush> LineColor;
        public List<KeyValuePair<int,int> > lines;

        public Dictionary<int, List<KeyValuePair<int,int>>> g;
        public List<KeyValuePair<Point, Point>> Lines;
        public int n;
        public void BFS(int v, Graphics DrawGraphics, Color Background, ListBox myListBox)
        {
            bool []used = new bool[Areas.Count];
            Queue<int> q = new Queue<int>();
            used[v] = true;
            q.Enqueue(v);
            Color[v] = Brushes.Red;
            
            Draw(DrawGraphics, Background, myListBox);
            Thread.Sleep(2000);
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

                        used[element.Key] = true;
                        Color[element.Key] = Brushes.Red;
                        LineColor[element.Value] = Brushes.YellowGreen;
                        Draw(DrawGraphics, Background, myListBox);
                        Thread.Sleep(2000);
                        q.Enqueue(element.Key);
                    }
                }
            }

        }
        public Circles(string path)
        {
            using (StreamReader input = new StreamReader(path))
            {
                var XY = input.ReadLine().Split(new char[] { ':',' ' },StringSplitOptions.RemoveEmptyEntries) ;
                Areas = new List<Rectangle>();
                Color = new List<Brush>();
                for (int i = 0; i < XY.Length; i+=2)
                {
                    Color.Add(Brushes.Blue);
                    Areas.Add(new Rectangle(new Point(int.Parse(XY[i]) ,int.Parse(XY[i+1])), new Size(25, 25)));
                   
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
           
            
            int y=30;
            Areas =  new List<Rectangle>();
            Color = new List<Brush>();
            for (int i = 0; i <n; i++)
            {
                Color.Add(Brushes.Blue);
                Areas.Add(new Rectangle(new Point(0, y), new Size(25, 25)));
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
