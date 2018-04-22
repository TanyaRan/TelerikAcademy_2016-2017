using System;
using System.Collections.Generic;

namespace Point3DTasks
{
    public class Point3DStartup
    {
        public static void Main()
        {
            Point3D pOne = new Point3D(1, 20, 30);
            Point3D pTwo = new Point3D(3, -4, -5);
            Point3D pThree = new Point3D(7, -8, 10);
            Console.WriteLine("Points :\npOne {0}pTwo {1}pThree {2}", pOne.ToString(), pTwo.ToString(), pThree.ToString());

            double dist = Distance3D.CalculateDistance(pOne, pThree);
            Console.WriteLine("Distance pOne-pThree is : {0:F2}", dist);
            Console.WriteLine();

            Path firstPath = new Path();
            firstPath.AddPoint(pTwo);
            firstPath.AddPoint(pOne);
            firstPath.AddPoint(pThree);

            PathStorage.SavePath(firstPath);
            List<Path> pathList = PathStorage.LoadPath();
            foreach (var path in pathList)
            {
                Console.WriteLine("-----Path Start-------");
                foreach (var pointers in path.pathPointsList)
                {
                    Console.WriteLine(pointers);
                }

                Console.WriteLine("-----Path End-------");
            }
        }
    }
}
