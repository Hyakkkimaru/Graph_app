using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace GraphApp
{
    public class Vertex
    {
        public int Id { get; set; }
        public PointF Position { get; set; } // Add Position property

        public Vertex(int id, PointF location)
        {
            Id = id;
            Position = location;
        }
    }

    // Edge class
    public class Edge
    {
        public Vertex StartVertex { get; set; }
        public Vertex EndVertex { get; set; }
        public int Weight { get; set; }

        public Edge(Vertex startVertex, Vertex endVertex, int weight)
        {
            StartVertex = startVertex;
            EndVertex = endVertex;
            Weight = weight;
        }
    }

    public partial class MainForm : Form
    {
        private List<Vertex> vertices = new List<Vertex>();
        private List<Edge> edges = new List<Edge>();
        private int selectedVertexIndex = -1;
        private int selectedEdgeIndex = -1;
        private bool isDragging = false;
        private PointF dragStartPoint;
        private Vertex draggedVertex;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            DrawGraph(e.Graphics);
        }

        private void DrawGraph(Graphics g)
        {
            foreach (Edge edge in edges)
            {
                g.DrawLine(Pens.Black, edge.StartVertex.Position, edge.EndVertex.Position);
                // Add edge weight text
                PointF textPosition = new PointF((edge.StartVertex.Position.X + edge.EndVertex.Position.X) / 2, (edge.StartVertex.Position.Y + edge.EndVertex.Position.Y) / 2);
                g.DrawString(edge.Weight.ToString(), Font, Brushes.Black, textPosition);
            }
            foreach (Vertex vertex in vertices)
            {
                g.FillEllipse(Brushes.LightBlue, new RectangleF(vertex.Position.X - 10, vertex.Position.Y - 10, 20, 20));
                g.DrawString(vertex.Id.ToString(), Font, Brushes.Black, vertex.Position);
            }
        }

        private void AddVertexButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(VertexTextBox.Text, out int id))
            {
                Vertex newVertex = new Vertex(id, new PointF(ClientSize.Width / 2, ClientSize.Height / 2)); // Pass required arguments
                vertices.Add(newVertex);
                Invalidate();
            }
        }

        private void AddEdgeButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(StartVertexTextBox.Text, out int startId) && int.TryParse(EndVertexTextBox.Text, out int endId) && int.TryParse(WeightTextBox.Text, out int weight))
            {
                Vertex startVertex = vertices.Find(v => v.Id == startId);
                Vertex endVertex = vertices.Find(v => v.Id == endId);
                if (startVertex != null && endVertex != null)
                {
                    Edge newEdge = new Edge(startVertex, endVertex, weight); // Pass required arguments
                    edges.Add(newEdge);
                    Invalidate();
                }
            }
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                foreach (Vertex vertex in vertices)
                {
                    if (Math.Abs(vertex.Position.X - e.X) < 10 && Math.Abs(vertex.Position.Y - e.Y) < 10)
                    {
                        selectedVertexIndex = vertices.IndexOf(vertex);
                        isDragging = true;
                        dragStartPoint = new PointF(e.X, e.Y);
                        draggedVertex = vertex;
                        break;
                    }
                }
            }
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                draggedVertex.Position = new PointF(e.X, e.Y);
                Invalidate();
            }
        }

        private void MainForm_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }
    }
}