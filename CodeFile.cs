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


        //заполняет матрицу смежности
        public void fillAdjacencyMatrix(int numberV, List<Edge> E, int[,] matrix)
        {
            for (int i = 0; i < numberV; i++)
                for (int j = 0; j < numberV; j++)
                    matrix[i, j] = 0;
            for (int i = 0; i < E.Count; i++)
            {
                matrix[E[i].v1, E[i].v2] = E[i].Weight;
                matrix[E[i].v2, E[i].v1] = E[i].Weight;
            }
        }

        //заполняет матрицу инцидентности
        public void fillIncidenceMatrix(int numberV, List<Edge> E, int[,] matrix)
        {
            for (int i = 0; i < numberV; i++)
                for (int j = 0; j < E.Count; j++)
                    matrix[i, j] = 0;
            for (int i = 0; i < E.Count; i++)
            {
                matrix[E[i].v1, i] = 1;
                matrix[E[i].v2, i] = 1;
            }
        }

        
    }
}