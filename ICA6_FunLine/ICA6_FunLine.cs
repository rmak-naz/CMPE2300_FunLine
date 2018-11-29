using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GDIDrawer;

namespace ICA6_FunLine
{
    public partial class ICA6_FunLine : Form
    {
        private CDrawer _canvas = new CDrawer();
        private Random rnd = new Random();
        private List<FunLine> lineList;

        public ICA6_FunLine()
        {
            InitializeComponent();
            _canvas.ContinuousUpdate = false;
        }

        private void B_Populate_Click(object sender, EventArgs e)
        {
            const int lineCount = 40;
            const int minLength = 25;
            const int maxLength = 401;
            const int minWidth = 1;
            const int maxWidth = 11;

            lineList = new List<FunLine>();

            for (int count = 0; count < lineCount; ++count)
            {
                FunLine newLine = new FunLine(rnd.Next(minLength, maxLength), rnd.Next(minWidth, maxWidth));
                lineList.Add(newLine);
            }

            RenderLines();
            B_LenAsc.Enabled = true;
            B_LenDesc.Enabled = true;
            B_Width.Enabled = true;
            B_WidthHeight.Enabled = true;
            B_RemStub.Enabled = true;
            B_RemLong.Enabled = true;
            TrB_Length.Enabled = true;
            TrackMinMax();
        }

        private void B_LenAsc_Click(object sender, EventArgs e)
        {
            lineList.Sort();
            RenderLines();
        }

        private void B_LenDesc_Click(object sender, EventArgs e)
        {
            lineList.Sort(FunLine.DecComp);
            RenderLines();
        }

        private void B_Width_Click(object sender, EventArgs e)
        {
            lineList.Sort((lineA, lineB) => lineA._width - lineB._width);
            RenderLines();
        }

        private void B_WidthHeight_Click(object sender, EventArgs e)
        {
            lineList.Sort(FunLine.WidthThenHeightComp);
            RenderLines();
        }

        private void B_RemStub_Click(object sender, EventArgs e)
        {
            lineList.RemoveAll(new Predicate<FunLine>(ShorterThan));
            RenderLines();
            TrackMinMax();
        }

        private void B_RemLong_Click(object sender, EventArgs e)
        {
            const int maxLength = 325;

            lineList.RemoveAll(line => line._length > maxLength);
            RenderLines();
            TrackMinMax();
        }

        private void RenderLines()
        {
            _canvas.Clear();
            lineList.ForEach(line => line.Render(_canvas,new Point(100+lineList.IndexOf(line) * 15, 100)));
            _canvas.Render();
        }

        private bool ShorterThan(FunLine line)
        {
            const int minLength = 75;

            return line._length < minLength;
        }

        private void TrB_Length_Scroll(object sender, EventArgs e)
        {
            lineList.ForEach(line => line._flag = false);
            lineList.FindAll(line => Math.Abs(line._length - TrB_Length.Value) <= 10).ForEach(line => line._flag = true);
            
            TrackMinMax();

            RenderLines();
        }

        private void TrackMinMax()
        {
            TrB_Length.Minimum = lineList.Min(line => line._length);
            TrB_Length.Maximum = lineList.Max(line => line._length);
            LB_MinMax.Text = "Min: " + TrB_Length.Minimum + "; Max: " + TrB_Length.Maximum + "; Value: " + TrB_Length.Value;
        }
    }
}
