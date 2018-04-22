using System.Collections.Generic;

namespace Point3DTasks
{
    public class Path
    {
        public readonly List<Point3D> pathPointsList = new List<Point3D>();

        public void AddPoint(Point3D point)
        {
            this.pathPointsList.Add(point);
        }

        public void ClearPath()
        {
            this.pathPointsList.Clear();
        }
    }
}
