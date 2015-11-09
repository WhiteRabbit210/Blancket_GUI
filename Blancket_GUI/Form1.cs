using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UsefulControl;
using Triangulator;
using PointFormat;
using FileManager;
using MatrixVector;

namespace Blancket_GUI
{
    public partial class Form1 : Form
    {
        //cTrianglePointManager SampleTriangleManager = new cTrianglePointManager("sample.mes");

        public Form1()
        {
            InitializeComponent();
            UsefulControl.UsefulControl.SetNumericUDAndTrackBar(nudWeight, tbWeight, 0, 100, 100, 10);
            UsefulControl.DragAndDrop.SetDragDrop(lvMain);
            lvMain.DragDrop += LvMain_DragDrop;
            tbWeight.ValueChanged += TbWeight_ValueChanged;
        }

        private void TbWeight_ValueChanged(object sender, EventArgs e)
        {
            if (lvMain.SelectedItems.Count == 0)
                return;

            foreach (ListViewItem item in lvMain.SelectedItems)
                item.SubItems[1].Text = tbWeight.Value.ToString();
        }

        private void LvMain_DragDrop(object sender, DragEventArgs e)
        {
            lvMain.Items.Clear();
            foreach (string FileName in UsefulControl.DragAndDrop.GetFileNameDragDrop(e))
            {
                ListViewItem Item = new ListViewItem(System.IO.Path.GetFileName(FileName));
                Item.SubItems.Add("10");
                string MesFileName = System.IO.Path.ChangeExtension(FileName, "mes");

                if (new System.IO.FileInfo(MesFileName).Exists)
                    Item.SubItems.Add("○");
                else
                    Item.SubItems.Add("×");

                Item.SubItems.Add(System.IO.Path.GetDirectoryName(FileName));

                lvMain.Items.Add(Item);
            }

            lvMain.Refresh();


        }

        private void btnSaveImage_Click(object sender, EventArgs e)
        {
            if (pbxAfter.Image == null)
                return;

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PNGファイル(*.png)|*.png";
            if (sfd.ShowDialog() != DialogResult.OK)
                return;

            new Bitmap(pbxAfter.Image).Save(sfd.FileName);
            MessageBox.Show("ファイルを保存しました", "保存完了(｀・ω・´)", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnMakeAverageFace_Click(object sender, EventArgs e)
        {
            List<string> FileList = new List<string>();
            List<string> MesFileList = new List<string>();
            foreach (ListViewItem item in lvMain.Items)
                if (item.SubItems[2].Text == "×")
                    continue;
                else
                {
                    FileList.Add(item.SubItems[3].Text + "\\" + item.Text);
                    MesFileList.Add(System.IO.Path.ChangeExtension(item.SubItems[3].Text + "\\" + item.Text, "mes"));
                }

            pbMain.Maximum = FileList.Count + 1;
            pbMain.Value = 1;
            pbMain.Refresh();
            Application.DoEvents();

            cTrianglePointManager AverageTriangleManager;
            {
                List<ColumnVector> XYVectorList;
                var MesMatrix = MesFileManager.GetMatrixFromMesFile(MesFileList);
                {
                    ColumnVector AverageVector;
                    ColumnVector SumVector = new ColumnVector(MesMatrix.RowSize);
                    double Count = 0;
                    for (int i = 0; i < MesMatrix.ColSize; i++)
                    {
                        SumVector += MesMatrix.ColumnVector[i] * double.Parse(lvMain.Items[i].SubItems[1].Text);
                        Count += double.Parse(lvMain.Items[i].SubItems[1].Text);
                    }
                    AverageVector = SumVector / Count;
                    XYVectorList = FileManager.MesFileManager.GetXYVector(AverageVector);
                }
                {
                    int MaxPointNumber = 83;
                    DoublePoint[] PointList = new DoublePoint[MaxPointNumber];
                    for (int i = 0; i < MaxPointNumber; i++)
                        PointList[i] = new DoublePoint(XYVectorList[i]);

                    AverageTriangleManager = new cTrianglePointManager(PointList);
                    //AverageTriangleManager.SetTriangle(SampleTriangleManager.TriangleList);
                }
            }

            List<Bitmap> MorphedBitmapList = new List<Bitmap>();
            List<double> WeightList = new List<double>();
            //for (int i = 0; i < FileList.Count; i++)
            Parallel.For(0, FileList.Count, i =>
            {
                {
                    pbMain.Value++;
                    pbMain.Refresh();
                    Application.DoEvents();
                    cTrianglePointManager BeforeTriangleManager;
                    {
                        if (lvMain.Items[i].SubItems[1].Text == "×" || lvMain.Items[i].SubItems[1].Text == "0")
                        { }
                        else
                        {
                            string MesFileName = MesFileList[i];

                            var MesVector = FileManager.MesFileManager.GetVectoreFromMesFile(MesFileName);
                            var XYVector = MesFileManager.GetXYVector(MesVector);
                            int MaxPointNumber = 83;
                            DoublePoint[] PointList = new DoublePoint[MaxPointNumber];
                            for (int j = 0; j < MaxPointNumber; j++)
                            {
                                PointList[j] = new DoublePoint(XYVector[j]);
                            }

                            BeforeTriangleManager = new cTrianglePointManager(PointList);

                            WeightList.Add(double.Parse(lvMain.Items[i].SubItems[1].Text));
                            TriangleMorph Morph = new TriangleMorph(BeforeTriangleManager, AverageTriangleManager, AverageTriangleManager.TriangleList);

                            Bitmap bmp = null;
                            string Extension = System.IO.Path.GetExtension(FileList[i]).ToLower().TrimStart('.');
                            if (Extension == "bmp" || Extension == "png")
                                bmp = Morph.GetMorphBitmapParallel2(new FastDraw.BitmapWrapper(FileList[i]));
                            else if (Extension == "ppm")
                                bmp = Morph.GetMorphBitmapParallel2(FastDraw.PPMtoBitmap.GetPPMtoBitmap(FileList[i]));
                            MorphedBitmapList.Add(bmp);
                            if (bmp != null)
                                bmp.Save(i.ToString() + ".png");
                        }
                    }
                }
            });

            var AfterBitmap = FastDraw.CreateAverageBitmap.GetAverageBitmap(MorphedBitmapList, new Vector(WeightList.ToArray()));
            AfterBitmap.Save(DateTime.Now.ToString("yyyy年MM月dd日 HH時mm分ss秒") + ".bmp");
            pbxAfter.Image = AfterBitmap;
        }

        private void tbWeight_Scroll(object sender, EventArgs e)
        {

        }

        private void lvMain_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (!e.IsSelected)
                return;

            tbWeight.Value = int.Parse(e.Item.SubItems[1].Text);

            DrawImage(e.Item);
        }

        protected void DrawImage(ListViewItem Item)
        {
            var MesVector = FileManager.MesFileManager.GetVectoreFromMesFile(System.IO.Path.ChangeExtension(Item.SubItems[3].Text + "\\" + Item.SubItems[0].Text, "mes"));
            var XYVector = MesFileManager.GetXYVector(MesVector);
            int MaxPointNumber = 83;
            DoublePoint[] PointList = new DoublePoint[MaxPointNumber];
            for (int j = 0; j < PointList.Length; j++)
                PointList[j] = new DoublePoint(XYVector[j]);

            var BeforeTriangleManager = new cTrianglePointManager(PointList);
            var bmp = new FastDraw.BitmapWrapper(Item.SubItems[3].Text + "\\" + Item.SubItems[0].Text);

            if (tsmiDrawMesh.Checked)
                pbxMain.Image = BeforeTriangleManager.bmpDrawLine(bmp);
            else
                pbxMain.Image = bmp;
        }

        private void tsmiDrawMesh_Click(object sender, EventArgs e)
        {
            tsmiDrawMesh.Checked = !tsmiDrawMesh.Checked;
            if (lvMain.SelectedItems.Count == 0)
                return;

            ListViewItem Item = lvMain.SelectedItems[0];
            DrawImage(Item);
        }
    }
}
