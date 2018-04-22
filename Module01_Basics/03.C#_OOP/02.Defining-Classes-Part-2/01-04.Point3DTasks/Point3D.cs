using System.Text;

namespace Point3DTasks
{
    public struct Point3D
    {
        private static readonly Point3D pointO
            = new Point3D(0, 0, 0);

        public Point3D(int pointX, int pointY, int pointZ)
            : this()
        {
            this.PointX = pointX;
            this.PointY = pointY;
            this.PointZ = pointZ;
        }

        public int PointX { get; set; }

        public int PointY { get; set; }

        public int PointZ { get; set; }

        public static Point3D PointO
        {
            get
            {
                return pointO;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendFormat("Coord X:{0}, ", this.PointX.ToString());
            result.AppendFormat("Coord Y:{0}, ", this.PointY.ToString());
            result.AppendFormat("Coord Z:{0}\n", this.PointZ.ToString());

            return result.ToString();
        }
    }
}
