using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystAnalys_lr1
{
    public class Vertex
    {
        public int x, y;
        public Vertex()
        { }
        public Vertex(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }

    public class Edge
    {
        public int v1, v2;
        public int Weight;
        public Edge()
        { }
        public Edge(int v1, int v2, int Weight)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.Weight = Weight;
        }
    }